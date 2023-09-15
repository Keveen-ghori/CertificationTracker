using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RmsworkFlowDef
{
    public decimal RmsworkFlowDefId { get; set; }

    public int? PendingApplicationStatusId { get; set; }

    public int? PendingReportStatusId { get; set; }

    public int? ApplicationType { get; set; }

    public int? ReviewingApplicationStatusId { get; set; }

    public int? ReviewingReportStatusId { get; set; }

    public int? RmsworkFlowPlanId { get; set; }

    public int? Sequence { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? WorkFlowName { get; set; }

    public bool? IsLastWorkflow { get; set; }

    public bool? IsRequiredWfaction { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual SysApplicationStatus? PendingApplicationStatus { get; set; }

    public virtual SysApplicationStatus? PendingReportStatus { get; set; }

    public virtual SysApplicationStatus? ReviewingApplicationStatus { get; set; }

    public virtual SysApplicationStatus? ReviewingReportStatus { get; set; }

    public virtual ICollection<RmsapplicationActionTrace> RmsapplicationActionTraces { get; set; } = new List<RmsapplicationActionTrace>();

    public virtual ICollection<RmsdeptWorkFlowReviewRequirement> RmsdeptWorkFlowReviewRequirements { get; set; } = new List<RmsdeptWorkFlowReviewRequirement>();

    public virtual ICollection<RmsworkFlowController> RmsworkFlowControllers { get; set; } = new List<RmsworkFlowController>();

    public virtual RmsworkFlowPlan? RmsworkFlowPlan { get; set; }

    public virtual ICollection<WfallowedUi> WfallowedUiOkactionWfNavigations { get; set; } = new List<WfallowedUi>();

    public virtual ICollection<WfallowedUi> WfallowedUiRmsworkFlowDefs { get; set; } = new List<WfallowedUi>();
}
