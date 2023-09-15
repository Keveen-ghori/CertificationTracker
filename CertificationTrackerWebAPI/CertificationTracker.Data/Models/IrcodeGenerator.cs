using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IrcodeGenerator
{
    public int IrcodeGeneratorId { get; set; }

    public string? Name { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual ICollection<IrcodeGeneratorRule> IrcodeGeneratorRules { get; set; } = new List<IrcodeGeneratorRule>();
}
