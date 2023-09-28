import { DepartmentEmployee } from '../common/departmentEmployee.interface';
import { PostoutSideInstructor } from '../common/postoutSideInstructor.interface';
import { RefMiscReferenceDatum } from '../common/refMiscReferenceDatum.interface';

export interface ApplicableAreas {}

export interface POSTAreaListDetail {
  postAreaID: number;
  postCourseID: number;
  postCourseAreaID: number;
  areaNameID: number;
  lstArea: POSTAreaListDetail[];
  credit?: number | null;
  insideInstructorsDetail: string;
  lstInsideInstructors: POSTInstructors[];
  lstAreaInsideInstructors: POSTInstructors[];
  lstAllInsideInstructors: POSTInstructors[];
  outSideInstructorsDetail: string;
  lstOutSideInstructors: PostoutSideInstructor[];
  includeAllInstructors: boolean;
  areaFromEdit: boolean;
}

export interface POSTInstructors {
  departmentEmployeeIDObj: DepartmentEmployee;
  editedName: string;
  editedOn: Date;
  addedName: string;
  addedOn: Date;
  isActive?: boolean | null;
  certificationType: number;
  certifiedExpDate: Date;
  instructorIDNumber?: number | null;
  departmentEmployeeID: number;
  postInstructorID: number;
  recordIdentifyValue: number;
  isRecordDelete: boolean;
  isRecordUpdate: boolean;
  instructorName: string;
  certificationTypeObj: RefMiscReferenceDatum;
  certificationTypeSTR: string;
}
