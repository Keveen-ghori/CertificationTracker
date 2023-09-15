import {
  AfterViewInit,
  Component,
  Inject,
  Input,
  OnInit,
  ViewChild,
} from '@angular/core';
import {
  MAT_DIALOG_DATA,
  MatDialog,
  MatDialogRef,
} from '@angular/material/dialog';
import { MatTabChangeEvent } from '@angular/material/tabs';
import { ApiResponse } from 'src/app/core/interfaces/apiResponse.interface';
import { AreaRequirements } from 'src/app/core/interfaces/areaRequirements.interface';
import { POSTCourseAreaService } from 'src/app/core/services/postcoursearea.service';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { PostcurriculumArea } from 'src/app/core/interfaces/postcurriculumArea.interface';
import { ShowAreaContainer } from '../showArea/showarea.container';
import { POSTAreaDetail } from 'src/app/core/interfaces/postareadetail.interface';
import { SubPostAreaDetail } from 'src/app/core/interfaces/subPostAreaDetails';

@Component({
  selector: 'app-course-area-requirementpanel',
  templateUrl: './requirementspanel.container.html',
  styleUrls: ['./requirementspanel.container.css'],
})
export class RequirementsPanelContainer implements OnInit {
  ControlType!: string;
  areaRequirements: AreaRequirements = {
    postCurriculumAreaList: [],
    totalMandatedHours: '0',
    totalMaximumHours: '0',
    isGeneralAreaList: false,
  };

  subPostAreaDetail: SubPostAreaDetail = {
    postAreaName: '',
    postAreaCredit: 0,
  };

  displayedColumns: string[] = [
    'generalArea',
    'areaDescription',
    'postcurriculumAreaId',
  ];

  dataSource!: MatTableDataSource<PostcurriculumArea>;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    private postCourseAreaService: POSTCourseAreaService,
    public dialog: MatDialog,
    public dialogRef: MatDialogRef<RequirementsPanelContainer>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {}
  ngOnInit() {
    this.ControlType = this.data;
    this.getRequirementData(this.ControlType);
  }

  postArea = (control: MatTabChangeEvent) => {
    const tab = control.index;
    this.ControlType = tab == 1 ? 'GeneralArea' : 'POSTArea';
    this.getRequirementData(this.ControlType);
  };

  getRequirementData = (controlType: string) => {
    this.postCourseAreaService
      .CourseAreaRequirements(controlType)
      .subscribe((response: ApiResponse) => {
        this.areaRequirements.postCurriculumAreaList =
          response.content.postCurriculumAreaList;
        this.areaRequirements.totalMandatedHours =
          response.content.totalMandatedHours;
        this.areaRequirements.totalMaximumHours =
          response.content.totalMaximumHours;
        this.dataSource = new MatTableDataSource(
          this.areaRequirements.postCurriculumAreaList
        );
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
      });
  };

  OpenPOSTAreaDetailFromGeneralArea = (postcurriculumAreaId: number): void => {
    this.areaRequirements.postCurriculumAreaList.filter(
      (x: PostcurriculumArea) => {
        if (x.postcurriculumAreaId == postcurriculumAreaId) {
          const h1 = `${x.generalArea} - ${x.areaDescription}`;
          this.subPostAreaDetail.postAreaName = h1;
          this.subPostAreaDetail.postAreaCredit = x.mandatedHours;
        }
        return this.subPostAreaDetail;
      }
    );
    const dialogRef = this.dialog.open(ShowAreaContainer, {
      width: '560px',
      height: '248.2px',
      data: this.subPostAreaDetail,
    });
  };

  CloseRequirementDetail_Click = () => {
    this.dialogRef.close();
  };
}
