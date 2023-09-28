export interface PostoutSideInstructor {
  postoutSideInstructorId: number;
  instructorName?: string | null;
  instructorIdnumber?: string | null;
  instructorCertificationExpireDate?: Date | null;
  isActive?: boolean | null;
  addedOn?: Date | null;
  addedName?: string | null;
  editedOn?: Date | null;
  editedName?: string | null;
  departmentId?: number | null;
  certificationType?: number | null;
}
