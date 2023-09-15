import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FilterValue } from 'src/app/core/interfaces/courseArea.filter.interface';
import { MatDialog } from '@angular/material/dialog';
import { RequirementsPanelContainer } from '../requirementspanel/requirementspanel.container';
import { AreaRequirements } from 'src/app/core/interfaces/areaRequirements.interface';
import { POSTCourseAreaService } from 'src/app/core/services/postcoursearea.service';
import { ApiResponse } from 'src/app/core/interfaces/apiResponse.interface';
import { POSTAreaDetailDialog } from '../POSTAreaDetailDialog/postareadetail.dialog';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';

@Component({
  selector: 'app-course-area-header',
  templateUrl: './header.containers.html',
  styleUrls: ['./header.containers.css'],
})
export class AreaHeaderComponent implements OnInit {
  keyword!: string;
  includeArchived!: boolean;
  filter: FilterValue = {
    IncludeArchived: false,
    pagesize: 10,
    currentPage: 1,
    SortColumn: '',
    SearchString: '',
    ShortOrder: '',
  };

  @Output()
  filterValue = new EventEmitter<FilterValue>();

  @Output()
  controlType = new EventEmitter<string>();

  constructor(public dialog: MatDialog) {}

  ngOnInit() {}

  searchString(event: Event) {
    const inputElement = event.target as HTMLInputElement;
    if (inputElement.id === 'IncludeArchived') {
      this.filter.IncludeArchived = inputElement.checked;
    } else {
      this.keyword = inputElement.value || '';
      this.filter.SearchString = this.keyword;
    }

    this.filterValue.emit(this.filter);
  }

  IncludeArchieved(event: MatSlideToggleChange) {
    const isChecked = event.checked;
    this.filter.IncludeArchived = isChecked;
    this.filterValue.emit(this.filter);
  }

  btnRequirements_Click = (): void => {
    const dialogRef = this.dialog.open(RequirementsPanelContainer, {
      width: '660px',
      data: { controlType: 'POSTArea' },
    });
  };

  OpenPOSTAreaDetail(postCourseAreaID: number) {
    const dialogRef = this.dialog.open(POSTAreaDetailDialog, {
      width: '420px',
      height: '325.2px',
      data: postCourseAreaID,
    });

    dialogRef.afterClosed().subscribe((result: any) => {
      this.filterValue.emit(this.filter);
    });
  }
}
