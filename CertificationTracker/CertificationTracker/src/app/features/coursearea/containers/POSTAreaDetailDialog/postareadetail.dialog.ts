import { Component, OnInit, Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {
  MAT_DIALOG_DATA,
  MatDialog,
  MatDialogRef,
} from '@angular/material/dialog';
import { ToastrService } from 'ngx-toastr';
import { ApiResponse } from 'src/app/core/interfaces/apiResponse.interface';
import { AreaDetails } from 'src/app/core/interfaces/areaDetails.interface';
import { POSTAreaDetail } from 'src/app/core/interfaces/postareadetail.interface';
import { SavePostAreaDetailsResponse } from 'src/app/core/interfaces/savePostAreaDetailsResponse.interface';
import { POSTCourseAreaService } from 'src/app/core/services/postcoursearea.service';

@Component({
  selector: 'app-course-area-detail',
  templateUrl: './postareadetail.dialog.html',
  styleUrls: ['../requirementspanel/requirementspanel.container.css'],
})
export class POSTAreaDetailDialog implements OnInit {
  postAreaDetail!: AreaDetails;
  postArea!: SavePostAreaDetailsResponse;
  serverError!: string;
  areaDetail: FormGroup = this.fb.group({
    postAreaID: [0],
    area: ['', Validators.required],
    areaDescription: ['', Validators.required],
  });

  constructor(
    private postCourseAreaService: POSTCourseAreaService,
    private toastr: ToastrService,
    public fb: FormBuilder,
    public dialogRef: MatDialogRef<POSTAreaDetailDialog>,
    @Inject(MAT_DIALOG_DATA) public data: number
  ) {}

  ngOnInit(): void {
    this.postCourseAreaService
      .AreaDetails(this.data)
      .subscribe((response: ApiResponse) => {
        if (response.success) {
          this.postAreaDetail = response.content;
          this.areaDetail.controls['postAreaID'].setValue(
            response.content.postAreaID
          );
          this.areaDetail.controls['area'].setValue(response.content.area);
          this.areaDetail.controls['areaDescription'].setValue(
            response.content.areaDescription
          );
        }
      });
  }

  CloseRequirementDetail_Click = () => {
    this.dialogRef.close();
  };

  saveAreaDetail = () => {
    if (!this.areaDetail.invalid) {
      this.postCourseAreaService
        .SaveAreaDetails(this.areaDetail.value)
        .subscribe((response: ApiResponse) => {
          if (response.success == true) {
            this.postArea = response.content;
            if (this.postArea && this.postArea.validationMessage) {
              this.postArea.validationMessage =
                'Area name and Area description already exists, please provide different area name and area description.';
            } else {
              this.dialogRef.close();
              this.toastr.success('Data Saved Successfully.');
            }
          } else {
            this.serverError =
              'Unable to connect to the Server, Try again later!';
          }
        });
    }
  };
}
