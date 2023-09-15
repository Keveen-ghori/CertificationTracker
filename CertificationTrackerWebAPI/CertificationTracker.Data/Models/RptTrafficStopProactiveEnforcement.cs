using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptTrafficStopProactiveEnforcement
{
    public int? DepartmentId { get; set; }

    public decimal TrafficStopId { get; set; }

    public DateTime? TrafficStopDateTime { get; set; }

    public string? ResultOfStop { get; set; }

    public string? OffenseCity { get; set; }
}
