import { Component, OnDestroy, OnInit } from '@angular/core';
import { DynamicDialogRef } from 'primeng/dynamicdialog';
import { Subject, takeUntil } from 'rxjs';
import { ApiResponse } from 'src/app/core/interfaces/apiResponse.interface';
import { CloneCourseList } from 'src/app/core/interfaces/common/cloneCourseList.interface';
import { POSTCourseService } from 'src/app/core/services/course.service';
import { NotificationService } from 'src/app/core/services/notification.service';

@Component({
  selector: 'course-choose',
  templateUrl: './chooseCourse.container.html',
  styleUrls: ['./chooseCourse.container.css'],
})
export class ChooseCourseContainer implements OnInit, OnDestroy {
  private destroy$: Subject<void> = new Subject<void>();

  chooseCourseFromValue: string = 'CreateNew';

  cloneCourseList!: CloneCourseList[];

  courseID: number = 0;

  selectedCourse!: CloneCourseList;

  showDropdown: boolean = false;

  cloneCourseValidation: string = '';

  CloneCourseID: number = 0;

  constructor(
    private ref: DynamicDialogRef,
    private courseService: POSTCourseService,
    private notification: NotificationService
  ) {}

  chooseCourseExit_Click = (flag: string) => {
    this.ref.close(flag);
  };
  ngOnInit(): void {}

  cloneCourse = (cloneFromExisting: string) => {
    if (cloneFromExisting == 'CloneFromExisting') {
      this.showDropdown = true;
      this.courseService
        .GetCourseCloneLists()
        .pipe(takeUntil(this.destroy$))
        .subscribe((response: ApiResponse) => {
          this.cloneCourseList = response.content;
        });
    } else {
      this.showDropdown = false;
      this.cloneCourseList = [];
    }
  };

  chooseCourseNext_Click = (flag: string) => {
    if (this.showDropdown) {
      if (this.selectedCourse == null) {
        this.notification.showError(
          'Please select course that to be cloned',
          'Choose Course'
        );
        this.cloneCourseValidation = 'Please select course that to be cloned';
      } else {
        this.CloneCourseID = this.selectedCourse.postCourseId;
        this.courseID = 0;
        this.cloneCourseValidation = '';
      }
    } else {
      this.courseID = 0;
    }

    if (this.cloneCourseValidation == '') {
      this.ref.close({
        courseID: this.courseID,
        flag,
        cloneCourseID: this.CloneCourseID,
      });
    }
  };

  ngOnDestroy() {
    this.destroy$.next();
    this.destroy$.complete();
  }
}
