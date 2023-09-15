export interface FilterValue {
  IncludeArchived: boolean;
  pagesize: number;
  currentPage: number | 1;
  SortColumn: string;
  SearchString: string;
  ShortOrder: string;
}
