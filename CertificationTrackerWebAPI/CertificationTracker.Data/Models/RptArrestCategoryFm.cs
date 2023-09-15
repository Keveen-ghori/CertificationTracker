using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptArrestCategoryFm
{
    public int Otype { get; set; }

    public int? DepartmentId { get; set; }

    public decimal IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public string? ArrestNumber { get; set; }

    public DateTime? ArrestDateTime { get; set; }

    public string? FullName { get; set; }

    public string? SurName { get; set; }

    public string? GivenName { get; set; }

    public string? StatuteCode { get; set; }

    public string? Statue { get; set; }

    public string? OffenseType { get; set; }

    public string? State { get; set; }

    public string? DriverLicenseNumber { get; set; }

    public DateTime? Dob { get; set; }
}
