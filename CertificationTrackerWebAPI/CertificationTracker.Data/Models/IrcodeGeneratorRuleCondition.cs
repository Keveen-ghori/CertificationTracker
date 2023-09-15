using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IrcodeGeneratorRuleCondition
{
    public int IrcodeGeneratorRuleConditionId { get; set; }

    public int? IrcodeGeneratorRuleId { get; set; }

    public string? ConditionName { get; set; }

    public string? CoditionSql { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual IrcodeGeneratorRule? IrcodeGeneratorRule { get; set; }
}
