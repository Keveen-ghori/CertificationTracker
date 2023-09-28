export interface RefMiscReferenceDatum {
  refMiscReferenceDataId: number;
  agencyId?: number | null;
  departmentId?: number | null;
  displayString?: string | null;
  description?: string | null;
  isSystemData?: boolean | null;
  displaySeq?: number | null;
  refCategory?: string | null;
  isActive?: boolean | null;
  addedOn?: Date | null;
  editedOn?: Date | null;
  addedName?: string | null;
  editedName?: string | null;
  dataValue?: string | null;
  isDefaultToCategory?: boolean | null;
  subRefCategory?: string | null;
  refDepartmentOverrideFrom?: number | null;
  rptcode?: string | null;
}
