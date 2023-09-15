using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptMissingPerson
{
    public int? DepartmentId { get; set; }

    public decimal Mpid { get; set; }

    public string Givenname { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string? PersonAge { get; set; }

    public string? ResidentialLocation { get; set; }

    public decimal IncidentId { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public string? Cadnumber { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }
}
