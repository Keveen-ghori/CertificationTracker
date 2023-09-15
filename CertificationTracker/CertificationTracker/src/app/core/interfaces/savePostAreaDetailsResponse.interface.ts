import { CourseArea } from './courseConfiguration.interface';

export interface SavePostAreaDetailsResponse {
  postArea: CourseArea;
  validationMessage: string;
  selectedArea: number;
}
