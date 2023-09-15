using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IrcodeGeneratorRule
{
    public int IrcodeGeneratorRuleId { get; set; }

    public int? GeneratedUcrcodeId { get; set; }

    public int? GeneratedNibrscodeId { get; set; }

    public int? IrcodeGeneratorId { get; set; }

    public string? RuleName { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public int? RuleSeq { get; set; }

    public virtual RefNibrscodeDefinition? GeneratedNibrscode { get; set; }

    public virtual RefUcrcodeDefinition? GeneratedUcrcode { get; set; }

    public virtual IrcodeGenerator? IrcodeGenerator { get; set; }

    public virtual ICollection<IrcodeGeneratorRuleCondition> IrcodeGeneratorRuleConditions { get; set; } = new List<IrcodeGeneratorRuleCondition>();
}
