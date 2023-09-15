using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RmsdataProcessDetailStepRulesAction
{
    public decimal RmsdataProcessDetailStepRulesActionId { get; set; }

    public decimal? RmsdataProcessControllerDetailId { get; set; }

    public decimal? DataProcessRuleId { get; set; }

    public int? DataProcessRuleActionId { get; set; }

    public bool? IsAllConditionMeet { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public virtual DataProcessRule? DataProcessRule { get; set; }

    public virtual DataProcessRuleAction? DataProcessRuleAction { get; set; }

    public virtual RmsdataProcessDetailStep? RmsdataProcessControllerDetail { get; set; }
}
