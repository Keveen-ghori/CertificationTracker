using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DailyArrestLog
{
    public string? Number { get; set; }

    public string? Date { get; set; }

    public string? Time { get; set; }

    public string? FullName { get; set; }

    public string? Address { get; set; }

    public string? SexRace { get; set; }

    public string? IncidentNumber { get; set; }

    public string? Dob { get; set; }

    public int? Age { get; set; }

    public string? Offense { get; set; }

    public string S1 { get; set; } = null!;

    public string S2 { get; set; } = null!;

    public string S3 { get; set; } = null!;

    public string S4 { get; set; } = null!;

    public string S5 { get; set; } = null!;

    public string S6 { get; set; } = null!;

    public string S7 { get; set; } = null!;

    public string S8 { get; set; } = null!;

    public string S9 { get; set; } = null!;

    public string S10 { get; set; } = null!;

    public string Aa { get; set; } = null!;
}
