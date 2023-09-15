using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RmsdeptWorkFlowReviewRequirement
{
    public int RmsdeptWorkFlowReviewRequirementsId { get; set; }

    public int? RmsdeptWorkFlowId { get; set; }

    public decimal? RmsworkFlowDefId { get; set; }

    public decimal? ReqReviewOrgId { get; set; }

    public int? ReqReviewEmployeeId { get; set; }

    public bool? AnyEmployeeCanReview { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsUsingSchedulingToLookup { get; set; }

    public virtual DepartmentEmployee? ReqReviewEmployee { get; set; }

    public virtual DepartmentOrg? ReqReviewOrg { get; set; }

    public virtual RmsdeptWorkFlow? RmsdeptWorkFlow { get; set; }

    public virtual RmsworkFlowDef? RmsworkFlowDef { get; set; }
}
