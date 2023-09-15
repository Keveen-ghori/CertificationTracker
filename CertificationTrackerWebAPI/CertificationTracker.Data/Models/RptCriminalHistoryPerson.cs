using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptCriminalHistoryPerson
{
    public decimal? Mpid { get; set; }

    public DateTime? Dob { get; set; }

    public string? Sex { get; set; }

    public string? Race { get; set; }

    public string? Ethnicity { get; set; }

    public int? Height { get; set; }

    public int? Weight { get; set; }

    public string? GivenName { get; set; }

    public string? MiddleName { get; set; }

    public string? SurName { get; set; }

    public string? FullName { get; set; }

    public bool? IsMasterName { get; set; }
}
