using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PistolPermit
{
    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public DateTime? IncidentDate { get; set; }

    public string? IncidentNumber { get; set; }

    public string? OtherDate { get; set; }

    public string? ResponseDate1 { get; set; }

    public string? ResponseDate2 { get; set; }

    public string? DateIssued { get; set; }

    public string? DateSent { get; set; }

    public double? TempPermit { get; set; }

    public double? Permit { get; set; }

    public int? RowId { get; set; }

    public string? IsImported { get; set; }

    public string? Comment { get; set; }
}
