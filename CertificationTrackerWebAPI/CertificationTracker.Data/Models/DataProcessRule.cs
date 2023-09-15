using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DataProcessRule
{
    public decimal DataProcessRuleId { get; set; }

    public decimal? ProcessStepDataItemId { get; set; }

    public int? DataProcessDetailStepId { get; set; }

    public int? DataProcessId { get; set; }

    public string? RuleName { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? CleanAllDpbeforeExecuteRule { get; set; }

    public int? RuleSeq { get; set; }

    public virtual DataProcess? DataProcess { get; set; }

    public virtual DataProcessDetailStep? DataProcessDetailStep { get; set; }

    public virtual ICollection<DataProcessRuleAction> DataProcessRuleActions { get; set; } = new List<DataProcessRuleAction>();

    public virtual ICollection<DataProcessRuleCondition> DataProcessRuleConditions { get; set; } = new List<DataProcessRuleCondition>();

    public virtual DataProcessStepDataItem? ProcessStepDataItem { get; set; }

    public virtual ICollection<RmsdataProcessDetailStepRulesAction> RmsdataProcessDetailStepRulesActions { get; set; } = new List<RmsdataProcessDetailStepRulesAction>();
}
