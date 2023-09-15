using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RmsworkFlowController
{
    public decimal RmsworkFlowControllerId { get; set; }

    public int? WfactionAssignedEmpId { get; set; }

    public int? ReportWriterId { get; set; }

    public decimal? RefWorkFlowDefId { get; set; }

    public int? DepartmentId { get; set; }

    public DateTime? WfstartDt { get; set; }

    public decimal? WfactionAssignedOrgId { get; set; }

    public int? ApplicationType { get; set; }

    public string? Comment { get; set; }

    public decimal? ApplicationId { get; set; }

    public string? ApplicationNumber { get; set; }

    public bool? IsWffinished { get; set; }

    public DateTime? WffinishedDt { get; set; }

    public bool? IsLastWorkFlowForApplication { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual ICollection<CrashGeneratedReport> CrashGeneratedReports { get; set; } = new List<CrashGeneratedReport>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<IncidentGeneratedReport> IncidentGeneratedReports { get; set; } = new List<IncidentGeneratedReport>();

    public virtual RmsworkFlowDef? RefWorkFlowDef { get; set; }

    public virtual DepartmentEmployee? ReportWriter { get; set; }

    public virtual ICollection<WarrantGeneratedReport> WarrantGeneratedReports { get; set; } = new List<WarrantGeneratedReport>();

    public virtual DepartmentEmployee? WfactionAssignedEmp { get; set; }

    public virtual DepartmentOrg? WfactionAssignedOrg { get; set; }
}
