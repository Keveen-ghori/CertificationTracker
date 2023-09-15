using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IndividualSecurityToUser
{
    public decimal IndividualSecurityToUserId { get; set; }

    public int? GrantedByEmployeeId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public decimal? CrashPersonInvolvementId { get; set; }

    public int? SysrmsapplicationTypeId { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public int? SecurityRoleId { get; set; }

    public decimal? DepartmentOrgId { get; set; }

    public int? AllowedEmployeeId { get; set; }

    public string? Reason { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual DepartmentEmployee? AllowedEmployee { get; set; }

    public virtual CrashPersonInvolvement? CrashPersonInvolvement { get; set; }

    public virtual DepartmentOrg? DepartmentOrg { get; set; }

    public virtual DepartmentEmployee? GrantedByEmployee { get; set; }

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }

    public virtual SecurityRole? SecurityRole { get; set; }

    public virtual SysrmsapplicationType? SysrmsapplicationType { get; set; }
}
