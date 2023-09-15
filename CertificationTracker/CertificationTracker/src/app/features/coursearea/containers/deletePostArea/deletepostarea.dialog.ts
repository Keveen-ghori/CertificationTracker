import { Component, OnInit, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { ToastrService } from 'ngx-toastr';
import { ApiResponse } from 'src/app/core/interfaces/apiResponse.interface';
import { POSTCourseAreaService } from 'src/app/core/services/postcoursearea.service';

@Component({
  selector: 'app-course-area-delete',
  templateUrl: './deletepostarea.dialog.html',
  styleUrls: ['./deletepostarea.container.css'],
})
export class DeletePOSTAreaDialog implements OnInit {
  constructor(
    private toastr: ToastrService,
    private postCourseAreaService: POSTCourseAreaService,
    public dialogRef: MatDialogRef<DeletePOSTAreaDialog>,
    @Inject(MAT_DIALOG_DATA) public data: number
  ) {}
  ngOnInit(): void {}

  DeletePostArea(PostAreaID: number) {
    this.postCourseAreaService
      .DeleteAreaDetails(PostAreaID)
      .subscribe((response: ApiResponse) => {
        if (response.statusCode === 200 && response.content) {
          this.dialogRef.close();
          this.toastr.success('Record Delete Successfully.');
        } else {
          this.toastr.error(
            response.messages?.[0]?.message
              ? response.messages[0].message
              : 'An unknown error occurred.'
          );
        }
      });
  }

  onDismiss(): void {
    this.dialogRef.close();
  }
}
