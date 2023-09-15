using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ReportContainer
{
    public int ReportContainerId { get; set; }

    public int? DepApplicationUsageId { get; set; }

    public int? DepartmentId { get; set; }

    public int? SecurityRoleRequired { get; set; }

    public string? Name { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsActive { get; set; }

    public string? Icons { get; set; }

    public int? DisplaySeq { get; set; }

    public virtual DepApplicationUsage? DepApplicationUsage { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<ReportDefinition> ReportDefinitions { get; set; } = new List<ReportDefinition>();

    public virtual SecurityRole? SecurityRoleRequiredNavigation { get; set; }
}
