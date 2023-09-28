import { Component, OnDestroy, OnInit } from '@angular/core';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { MatTableDataSource } from '@angular/material/table';
import { DialogService, DynamicDialogRef } from 'primeng/dynamicdialog';
import { Subject, takeUntil } from 'rxjs';
import { ApiResponse } from 'src/app/core/interfaces/apiResponse.interface';
import { CourseFilter } from 'src/app/core/interfaces/courseConfiguration/courseFilter.interface';
import { POSTCoursesDetail } from 'src/app/core/interfaces/postcoursesdetail.interface';
import { POSTCourseService } from 'src/app/core/services/course.service';
import { NotificationService } from 'src/app/core/services/notification.service';
import { ChooseCourseContainer } from '../containers/chooseCourseContainer/chooseCourse.container';
import { CourseDetailDialog } from '../containers/courseDetailDialog/courseDetailDialog.container';

@Component({
  selector: 'app-course-configuration',
  templateUrl: './courseconfiguration.component.html',
  styleUrls: ['./courseconfiguration.component.css'],
})
export class CourseConfigurationComponent implements OnInit, OnDestroy {
  private destroy$: Subject<void> = new Subject<void>();

  courseDialog: boolean = false;

  courses!: POSTCoursesDetail[];

  course!: POSTCoursesDetail;

  date: Date | undefined;

  totalRecordsCount: number = 0;

  filter: CourseFilter = {
    includeArchived: false,
    pageSize: 10,
    pageNumber: 1,
    shortColumn: 'courseTitle',
    keyword: '',
    shortOrder: 'asc',
  };

  displayedColumns = [
    'courseTitle',
    'courseHours',
    'courseStartDate',
    'employees',
    'pOSTCourseAreas',
    'instructors',
    'actions',
  ];

  dataSource!: MatTableDataSource<POSTCoursesDetail>;

  ref: DynamicDialogRef | undefined;

  newCourseID!: number;

  constructor(
    private courseService: POSTCourseService,
    private notification: NotificationService,
    public dialogService: DialogService
  ) {}

  ngOnInit(): void {
    this.courseService
      .GetCourseList(this.filter)
      .pipe(takeUntil(this.destroy$))
      .subscribe((response: ApiResponse) => {
        this.courses = response.content;
        this.totalRecordsCount = this.courses[0].totalRecordsCount;
        this.dataSource = new MatTableDataSource(this.courses);
      });
  }

  customSort(event: any) {
    this.filter.shortColumn = event.active;
    this.filter.shortOrder = event.direction;
    this.filteredCourseData();
  }

  paginate = (event: any) => {
    this.filter.pageSize = event.rows;
    this.filter.pageNumber = event.page + 1;
    this.filteredCourseData();
  };

  filterGlobal(event: Event) {
    const inputElement = event.target as HTMLInputElement;
    this.filter.keyword = inputElement.value;
    this.filter.pageNumber = 1;
    this.filteredCourseData();
  }

  includePastCourses(event: MatSlideToggleChange) {
    const isChecked = event.checked;
    this.filter.includeArchived = isChecked;
    this.filter.pageNumber = 1;
    this.filteredCourseData();
  }

  filteredCourseData() {
    this.courseService
      .GetCourseList(this.filter)
      .pipe(takeUntil(this.destroy$))
      .subscribe((response: ApiResponse) => {
        this.courses = response.content;
        this.totalRecordsCount =
          this.courses.length != 0 ? this.courses[0].totalRecordsCount : 0;
        this.dataSource = new MatTableDataSource(this.courses);
      });
  }

  ngOnDestroy() {
    this.destroy$.next();
    this.destroy$.complete();
  }

  AddNewCourse_Click() {
    this.ref = this.dialogService.open(ChooseCourseContainer, {
      header: 'Please Select Course',
      width: '650px',
      contentStyle: { overflow: 'auto' },
      baseZIndex: 10000,
    });

    this.ref.onClose.subscribe((data: any) => {
      if (data.flag === 'CourseDetail') {
        this.ref = this.dialogService.open(CourseDetailDialog, {
          header: 'Course Detail',
          width: '1000px',
          height: '692px',
          contentStyle: { overflow: 'auto' },
          baseZIndex: 10001,
          data: {
            courseID: data.courseID,
            cloneCourseID: data.cloneCourseID,
            flag: data.flag,
          },
        });
      } else {
      }
    });
  }

  IsValidCourseForEditing(postCourseID: number) {}

  ViewCourseDetailInfo(postCourseID: number) {}

  OpenCourseDetailInfo(postCourseID: number) {
    this.ref = this.dialogService.open(CourseDetailDialog, {
      header: 'Course Detail',
      width: '1000px',
      height: '692px',
      contentStyle: { overflow: 'auto' },
      baseZIndex: 10001,
      data: {
        courseID: postCourseID,
        cloneCourseID: 0,
      },
    });

    this.ref.onClose.subscribe((data: any) => {
      debugger;
      this.filteredCourseData();
    });
  }

  DeletePOSTCourseDetail(postCourseID: number) {}
}
