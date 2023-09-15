using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RefMiscReferenceDatum
{
    public int RefMiscReferenceDataId { get; set; }

    public int? AgencyId { get; set; }

    public int? DepartmentId { get; set; }

    public string? DisplayString { get; set; }

    public string? Description { get; set; }

    public bool? IsSystemData { get; set; }

    public int? DisplaySeq { get; set; }

    public string? RefCategory { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? DataValue { get; set; }

    public bool? IsDefaultToCategory { get; set; }

    public string? SubRefCategory { get; set; }

    public int? RefDepartmentOverrideFrom { get; set; }

    public string? Rptcode { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumDirectionFromNearestLandmarkNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumUnitOfMeasureNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<DepartmentOrg> DepartmentOrgs { get; set; } = new List<DepartmentOrg>();

    public virtual ICollection<EmployeeEquipment> EmployeeEquipmentEquipmentConditionCodeNavigations { get; set; } = new List<EmployeeEquipment>();

    public virtual ICollection<EmployeeEquipment> EmployeeEquipmentEquipmentTypeCodeNavigations { get; set; } = new List<EmployeeEquipment>();

    public virtual ICollection<EmployeesCourseSkill> EmployeesCourseSkillCourseCodeNavigations { get; set; } = new List<EmployeesCourseSkill>();

    public virtual ICollection<EmployeesCourseSkill> EmployeesCourseSkillCourseStatusCodeNavigations { get; set; } = new List<EmployeesCourseSkill>();

    public virtual ICollection<FieldInterviewPersonInvolvment> FieldInterviewPersonInvolvments { get; set; } = new List<FieldInterviewPersonInvolvment>();

    public virtual ICollection<FieldInterviewVehicleInvolvment> FieldInterviewVehicleInvolvments { get; set; } = new List<FieldInterviewVehicleInvolvment>();

    public virtual ICollection<Postinstructor> Postinstructors { get; set; } = new List<Postinstructor>();

    public virtual ICollection<PostoutSideInstructor> PostoutSideInstructors { get; set; } = new List<PostoutSideInstructor>();

    public virtual ICollection<RefNarrativeTemplate> RefNarrativeTemplates { get; set; } = new List<RefNarrativeTemplate>();
}
