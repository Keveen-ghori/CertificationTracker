export interface CourseForEditingDetails {
  lstStudentName: string[];
  courseName: string;
  message: string;
  isValidForEditing: boolean | null;
  isAllFullEarnedCredits: boolean | null;
  isErrorOccurred: boolean | null;
  pOSTCourseID: number | null;
}
