import { POSTAreaDetail } from './postareadetail.interface';
import { POSTCoursesDetail } from './postcoursesdetail.interface';

export interface CourseArea {
  totalRecordsCount: number | 0;
  coursesDetailList: POSTCoursesDetail[];
  areaDetailList: POSTAreaDetail[];
}
