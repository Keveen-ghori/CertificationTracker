using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DailyArrestLog3
{
    public int? DepartmentId { get; set; }

    public string? Number { get; set; }

    public DateTime? ArrestDate { get; set; }

    public string? FullName { get; set; }

    public string? Address { get; set; }

    public string? SexRace { get; set; }

    public string? IncidentNumber { get; set; }

    public string? Dob { get; set; }

    public int? Age { get; set; }

    public string? Offense { get; set; }

    public string? Narrative { get; set; }
}
