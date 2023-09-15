import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FilterValue } from 'src/app/core/interfaces/courseArea.filter.interface';
import { CourseArea } from 'src/app/core/interfaces/courseConfiguration.interface';
import { POSTAreaDetailDialog } from '../POSTAreaDetailDialog/postareadetail.dialog';
import { MatDialog } from '@angular/material/dialog';
import { DeletePOSTAreaDialog } from '../deletePostArea/deletepostarea.dialog';

@Component({
  selector: 'app-course-area-content',
  templateUrl: './content.coursearea.component.html',
  styleUrls: ['./content.coursearea.component.css'],
})
export class CourseAreaContentComponent implements OnInit {
  filter: FilterValue = {
    IncludeArchived: false,
    pagesize: 10,
    currentPage: 1,
    SortColumn: '',
    SearchString: '',
    ShortOrder: '',
  };

  @Input()
  totalRecords: number = 0;

  @Input()
  totalPages: number = 0;

  @Output()
  currentPage = new EventEmitter<number>();

  @Output()
  filterValue = new EventEmitter<FilterValue>();

  @Input()
  courseArea?: CourseArea;

  constructor(public dialog: MatDialog) {}

  ngOnInit() {}

  filterParameter = (value: any) => {
    this.filter.currentPage = value.currentPage;
    this.filter.ShortOrder = value.ShortOrder;
    this.filter.SortColumn = value.SortColumn;
    this.filter.currentPage = value.CurrentPage;
    this.filterValue.emit(this.filter);
  };

  onPageChange(page: string | number) {
    if (typeof page === 'number') {
      this.filter.currentPage = page;
      this.filterValue.emit(this.filter);
      this.currentPage.emit(this.filter.currentPage);
    } else {
      // Handle ellipsis ('...') or any other non-numeric values as needed
    }
  }

  getRange(): number[] {
    return Array.from({ length: this.totalPages }, (_, index) => index + 1);
  }

  generatePages(): Array<number | string> {
    const pages: Array<number | string> = [];
    const pagesToShow = 1;
    const currentPage = this.filter.currentPage;

    if (this.totalPages <= 10) {
      for (let i = 1; i <= this.totalPages; i++) {
        pages.push(i);
      }
    } else {
      let startPage = Math.max(1, currentPage - pagesToShow);
      let endPage = Math.min(this.totalPages, currentPage + pagesToShow);

      if (currentPage <= pagesToShow) {
        endPage = pagesToShow * 2 + 1;
      } else if (currentPage >= this.totalPages - pagesToShow) {
        startPage = this.totalPages - pagesToShow * 2;
      }

      for (let i = startPage; i <= endPage; i++) {
        if (i === startPage && i > 1) {
          pages.push('...');
        }
        pages.push(i);
        if (i === endPage && i < this.totalPages) {
          pages.push('...');
        }
      }
    }

    return pages;
  }

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

  DeletePOSTAreaDetail = (postCourseAreaID: number) => {
    const dialogRef = this.dialog.open(DeletePOSTAreaDialog, {
      width: '360px',
      height: '260px',
      data: postCourseAreaID,
    });

    dialogRef.afterClosed().subscribe((result: any) => {
      this.filterValue.emit(this.filter);
    });
  };
}
