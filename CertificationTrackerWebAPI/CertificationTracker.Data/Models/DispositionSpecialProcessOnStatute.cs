using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DispositionSpecialProcessOnStatute
{
    public decimal DispositionSpecialProcessOnStatutesId { get; set; }

    public decimal DispositionSpecialProcessId { get; set; }

    public int RefStatutedefinitionId { get; set; }

    public virtual DispositionSpecialProcess DispositionSpecialProcess { get; set; } = null!;

    public virtual RefStatuteDefinition RefStatutedefinition { get; set; } = null!;
}
