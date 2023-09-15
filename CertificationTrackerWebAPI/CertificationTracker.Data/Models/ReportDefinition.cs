using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ReportDefinition
{
    public int ReportDefinitionId { get; set; }

    public int? ReportContainerId { get; set; }

    public int? SecurityRoleRequired { get; set; }

    public string? Name { get; set; }

    public int? DisplaySeq { get; set; }

    public bool? IsUsingReportService { get; set; }

    public string? RptserviceLink { get; set; }

    public string? RptServicePara { get; set; }

    public string? InternalLink { get; set; }

    public string? Icons { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? ExternalLink { get; set; }

    public string? RptdefintionName { get; set; }

    public string? ExternalLinkPara { get; set; }

    public string? ReportType { get; set; }

    public bool? IsActive { get; set; }

    public virtual ReportContainer? ReportContainer { get; set; }

    public virtual ICollection<ReportHelper> ReportHelpers { get; set; } = new List<ReportHelper>();

    public virtual SecurityRole? SecurityRoleRequiredNavigation { get; set; }
}
