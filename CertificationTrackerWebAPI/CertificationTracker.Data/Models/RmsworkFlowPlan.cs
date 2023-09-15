using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RmsworkFlowPlan
{
    public int RmsworkFlowPlanId { get; set; }

    public string? WorkFlowPlanName { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<RmsdeptWorkFlow> RmsdeptWorkFlows { get; set; } = new List<RmsdeptWorkFlow>();

    public virtual ICollection<RmsworkFlowDef> RmsworkFlowDefs { get; set; } = new List<RmsworkFlowDef>();
}
