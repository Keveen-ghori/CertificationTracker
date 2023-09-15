import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { SubPostAreaDetail } from 'src/app/core/interfaces/subPostAreaDetails';

@Component({
  selector: 'app-course-area-showarea',
  templateUrl: './showarea.container.html',
  styleUrls: ['../requirementspanel/requirementspanel.container.css'],
})
export class ShowAreaContainer implements OnInit {
  constructor(
    public dialogRef: MatDialogRef<ShowAreaContainer>,
    @Inject(MAT_DIALOG_DATA) public data: SubPostAreaDetail
  ) {}
  ngOnInit(): void {
  }

  CloseRequirementDetail_Click = () => {
    this.dialogRef.close();
  };
}
