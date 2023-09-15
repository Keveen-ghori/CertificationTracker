using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DataProcessDetailStep
{
    public int DataProcessDetailStepId { get; set; }

    public int? ProcessStepId { get; set; }

    public int? RmsdataProcessId { get; set; }

    public int? Sequence { get; set; }

    public bool? IsRequired { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<DataProcessRuleCondition> DataProcessRuleConditions { get; set; } = new List<DataProcessRuleCondition>();

    public virtual ICollection<DataProcessRule> DataProcessRules { get; set; } = new List<DataProcessRule>();

    public virtual DataProcessStep? ProcessStep { get; set; }

    public virtual DataProcess? RmsdataProcess { get; set; }

    public virtual ICollection<RmsdataProcessController> RmsdataProcessControllers { get; set; } = new List<RmsdataProcessController>();

    public virtual ICollection<RmsdataProcessDetailStep> RmsdataProcessDetailSteps { get; set; } = new List<RmsdataProcessDetailStep>();
}
