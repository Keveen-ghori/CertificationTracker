using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RmsapplicationActionTrace
{
    public decimal RmsapplicationActionTraceId { get; set; }

    public int? SysapplicationActionTraceTemplateId { get; set; }

    public decimal? RmsworkFlowDefId { get; set; }

    public int? ApplicationStatusId { get; set; }

    public int? ReportStatusStatusId { get; set; }

    public int? InvestigativeStatusId { get; set; }

    public int? ApplicationType { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationPkid { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public decimal? RmsuserAccessId { get; set; }

    public string? Action { get; set; }

    public int? EmployeeId { get; set; }

    public int? DepartmentId { get; set; }

    public virtual SysApplicationStatus? ApplicationStatus { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual SysApplicationStatus? InvestigativeStatus { get; set; }

    public virtual SysApplicationStatus? ReportStatusStatus { get; set; }

    public virtual RmsworkFlowDef? RmsworkFlowDef { get; set; }

    public virtual SysapplicationActionTraceTemplate? SysapplicationActionTraceTemplate { get; set; }
}
