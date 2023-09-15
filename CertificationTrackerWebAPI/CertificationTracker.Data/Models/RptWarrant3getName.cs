using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptWarrant3getName
{
    public decimal? Mpid { get; set; }

    public bool? IsCurrentContact { get; set; }

    public string? GivenName { get; set; }

    public string? SurName { get; set; }

    public string? MiddleName { get; set; }

    public string? FullName { get; set; }

    public string? ApplicationNumber { get; set; }
}
