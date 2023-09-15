using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysapplicationActionTraceTemplate
{
    public int SysapplicationActionTraceTemplateId { get; set; }

    public string ActionTemplate { get; set; } = null!;

    public string? ActionTemplateParameters { get; set; }

    public string? Category { get; set; }

    public string? ActionDescription { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? EditedName { get; set; }

    public virtual ICollection<RmsapplicationActionTrace> RmsapplicationActionTraces { get; set; } = new List<RmsapplicationActionTrace>();
}
