using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptArrestsUnder21School
{
    public decimal? ArrestBookingId { get; set; }

    public string? ArrestNumber { get; set; }

    public DateTime? ArrestDateTime { get; set; }

    public int? ArrestAge { get; set; }

    public DateTime? Dob { get; set; }

    public int? ArrestOfficerId { get; set; }

    public string? IncidentNumber { get; set; }

    public string? StatuteCode { get; set; }

    public string? Statute { get; set; }

    public decimal? Mpid { get; set; }

    public string? FullName { get; set; }

    public string? GivenName { get; set; }

    public string? MiddleName { get; set; }

    public string? SurName { get; set; }

    public string? Zip { get; set; }

    public string? SchoolName { get; set; }

    public int? DepartmentId { get; set; }

    public string? LocationDetailDisplayString { get; set; }
}
