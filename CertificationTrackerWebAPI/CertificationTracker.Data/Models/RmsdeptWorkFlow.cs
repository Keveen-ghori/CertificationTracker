using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RmsdeptWorkFlow
{
    public int RmsdeptWorkFlowId { get; set; }

    public int? RmsworkFlowPlanId { get; set; }

    public int? DepartmentId { get; set; }

    public int? SysrmsapplicationTypeId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsActive { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<RmsdeptWorkFlowReviewRequirement> RmsdeptWorkFlowReviewRequirements { get; set; } = new List<RmsdeptWorkFlowReviewRequirement>();

    public virtual RmsworkFlowPlan? RmsworkFlowPlan { get; set; }

    public virtual SysrmsapplicationType? SysrmsapplicationType { get; set; }
}
