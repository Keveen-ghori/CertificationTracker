using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DataProcessRuleAction
{
    public int DataProcessRuleActionId { get; set; }

    public decimal? DataProcessRuleId { get; set; }

    public string? ActionName { get; set; }

    public int? ExecuteSeq { get; set; }

    public bool? IsWaitingActionCompleted { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsActive { get; set; }

    public string? ActionDetailXml { get; set; }

    public virtual DataProcessRule? DataProcessRule { get; set; }

    public virtual ICollection<RmsdataProcessDetailStepRulesAction> RmsdataProcessDetailStepRulesActions { get; set; } = new List<RmsdataProcessDetailStepRulesAction>();
}
