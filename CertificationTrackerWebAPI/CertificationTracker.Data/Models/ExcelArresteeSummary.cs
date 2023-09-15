using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ExcelArresteeSummary
{
    public decimal? Mpid { get; set; }

    public string? FullName { get; set; }

    public int? Age { get; set; }

    public string AgeStatus { get; set; } = null!;

    public string? Gender { get; set; }

    public string? Ethnicity { get; set; }

    public string? Race { get; set; }

    public string? StatuteCode { get; set; }

    public string? Statue { get; set; }

    public string? ArrestNumber { get; set; }

    public DateTime? ArrestDateTime { get; set; }

    public string? ArrestStatus { get; set; }

    public string ArrestType { get; set; } = null!;

    public string? Location { get; set; }

    public string? HitgislayerName { get; set; }

    public string? HitgeometryName { get; set; }

    public string? IncidentNumber { get; set; }
}
