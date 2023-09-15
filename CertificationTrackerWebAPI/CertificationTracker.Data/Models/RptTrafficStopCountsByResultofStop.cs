using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptTrafficStopCountsByResultofStop
{
    public int? DepartmentId { get; set; }

    public decimal TrafficStopId { get; set; }

    public DateTime? TrafficStopDateTime { get; set; }

    public string? DisplayString { get; set; }

    public bool? IsPaperTicketUsed { get; set; }

    public string JuvenileOrAdult { get; set; } = null!;
}
