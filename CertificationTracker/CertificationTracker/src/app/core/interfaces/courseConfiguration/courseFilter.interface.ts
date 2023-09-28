export interface CourseFilter {
  includeArchived: boolean;
  pageNumber: number;
  pageSize: number;
  shortOrder: string;
  shortColumn: string;
  keyword: string;
}
