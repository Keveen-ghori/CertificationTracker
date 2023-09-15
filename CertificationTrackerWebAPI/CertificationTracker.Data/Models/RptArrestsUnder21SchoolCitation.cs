using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptArrestsUnder21SchoolCitation
{
    public string? ArrestNumber { get; set; }

    public int? ArrestAge { get; set; }

    public DateTime? ArrestDateTime { get; set; }

    public string? FullName { get; set; }

    public string? LocationDetailDisplayString { get; set; }

    public string? IncidentNumber { get; set; }

    public string? Dob { get; set; }

    public int? Age { get; set; }

    public int? DepartmentId { get; set; }

    public string? Statute { get; set; }

    public string? StatuteCode { get; set; }

    public string? SchoolName { get; set; }
}
