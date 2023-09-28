import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { ApiResponse } from 'src/app/core/interfaces/apiResponse.interface';
import { AreaRequirements } from 'src/app/core/interfaces/areaRequirements.interface';
import { FilterValue } from 'src/app/core/interfaces/courseArea.filter.interface';
import { CourseArea } from 'src/app/core/interfaces/courseConfiguration.interface';
import { POSTCourseAreaService } from 'src/app/core/services/postcoursearea.service';

@Component({
  selector: 'app-course-area',
  templateUrl: './coursearea.component.html',
  styleUrls: ['./coursearea.component.css'],
})
export class CourseAreaComponent implements OnInit {
  filter: FilterValue = {
    IncludeArchived: false,
    pagesize: 10,
    currentPage: 1,
    SortColumn: '',
    SearchString: '',
    ShortOrder: '',
  };

  totalRecords: number = 0;

  totalPages!: number;

  currentPage: number = 0;

  apiResponse!: ApiResponse;

  courseArea!: CourseArea;

  areaRequirements!: AreaRequirements;

  constructor(private postCourseAreaService: POSTCourseAreaService) {}

  ngOnInit() {
    this.postCourseAreaService
      .ConfigurePostAreas(this.filter)
      .subscribe((response: ApiResponse) => {
        this.apiResponse = response;
        this.courseArea = response.content;
        this.totalRecords = response.content?.totalRecordsCount || 0;
        this.totalPages = Math.ceil(this.totalRecords / this.filter.pagesize);
      });
  }

  getUpdateFilterWithEventForSearching(event: FilterValue) {
    this.filter.SearchString = event.SearchString;
    this.filter.IncludeArchived = event.IncludeArchived;
    this.handleApiResponse('getUpdateFilterWithEventForSearching', 1);
  }

  getUpdateFilterWithEventForShorting(event: FilterValue) {
    this.filter.ShortOrder = event.ShortOrder;
    this.filter.SortColumn = event.SortColumn;
    this.handleApiResponse(
      'getUpdateFilterWithEventForSearching',
      event.currentPage
    );
  }

  private handleApiResponse(flag: string, currentPage: number) {
    this.filter.currentPage = currentPage;
    this.postCourseAreaService
      .ConfigurePostAreas(this.filter)
      .subscribe((response: any) => {
        this.apiResponse = response;
        this.courseArea = response.content;
        this.totalRecords = response.content?.totalRecordsCount || 0;
        this.totalPages = Math.ceil(this.totalRecords / this.filter.pagesize);
      });
  }
}
