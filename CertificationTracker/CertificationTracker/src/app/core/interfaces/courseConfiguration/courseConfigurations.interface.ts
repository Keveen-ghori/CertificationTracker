import { DataItemType } from '../common/dataItemType.interface';
import { POSTApplicableAreaDetail } from './postApplicableAreaDetail.interface';

export interface CourseConfigurations {
  postCourseID: number;
  courseTitle: string;
  sponsor: string;
  startDate: Date | null;
  courseStartDateLabel: string;
  endDate: Date | null;
  courseEndDateLabel: string;
  courseFee?: number | null;
  courseFeeLabel: string;
  inSideLocation?: boolean | null;
  courseHours?: number | null;
  attendanceHours?: number | null;
  addressName: string | '';
  street: string | '';
  city: string | '';
  state: string | '';
  zip: string | '';
  locationString: string;
  archivedCourses: boolean;
  instructorCertificationExpiresDate?: Date | null;
  comment: string;
  employeeDetail: string;
  listEmployee: number[];
  listSelectedEmployee: string[];
  lstEmployees: DataItemType[];
  archivedArea: boolean;
  postApplicableAreaDetails: POSTApplicableAreaDetail[];
  chooseCourse: boolean;
  cloneCourseID: number;
  includeArchived: number;
  mainCourseIDOfClone: number;
}
