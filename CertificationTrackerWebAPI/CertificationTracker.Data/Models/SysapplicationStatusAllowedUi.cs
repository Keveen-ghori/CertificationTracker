using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysapplicationStatusAllowedUi
{
    public decimal SysapplicationStatusAllowedUiid { get; set; }

    public decimal? SysrmsuserInterfaceDefinitionId { get; set; }

    public int? UserSecurityRoleId { get; set; }

    public int? SysrmsapplicationTypeId { get; set; }

    public decimal? DepartmentOrgId { get; set; }

    public int? ApplicationStatusId { get; set; }

    public int? ReportStatusId { get; set; }

    public int? InvestgativeStatusId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public int? DisplaySeq { get; set; }

    public bool? MustBeAuthor { get; set; }

    public int? DepartmentId { get; set; }

    public int? RefDepartmentOverrideFrom { get; set; }

    public virtual SysApplicationStatus? ApplicationStatus { get; set; }

    public virtual Department? Department { get; set; }

    public virtual DepartmentOrg? DepartmentOrg { get; set; }

    public virtual SysApplicationStatus? InvestgativeStatus { get; set; }

    public virtual SysApplicationStatus? ReportStatus { get; set; }

    public virtual SysrmsapplicationType? SysrmsapplicationType { get; set; }

    public virtual SysrmsuserInterfaceDefinition? SysrmsuserInterfaceDefinition { get; set; }

    public virtual SecurityRole? UserSecurityRole { get; set; }
}
