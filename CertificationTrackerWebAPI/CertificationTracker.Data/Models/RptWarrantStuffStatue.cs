using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptWarrantStuffStatue
{
    public int? DepartmentId { get; set; }

    public string? IncidentNumber { get; set; }

    public string? WarrantNumber { get; set; }

    public string? WarrantType { get; set; }

    public string? WarrantStatus { get; set; }

    public string? RptStatus { get; set; }

    public string? Officer { get; set; }

    public string? Name { get; set; }

    public DateTime? Dob { get; set; }

    public int? Age { get; set; }

    public bool? IsCurrentLocation { get; set; }

    public string? City { get; set; }

    public string? LocationDetailDisplayString { get; set; }

    public bool? IsMasterName { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? WarrantEffectDateTime { get; set; }

    public DateTime? WarrantExpirationDateTime { get; set; }

    public DateTime? IssuedDateTime { get; set; }

    public DateTime? ReceivedDateTime { get; set; }

    public DateTime? CourtDate { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public DateTime? SwornDate { get; set; }

    public decimal? BondAmount { get; set; }

    public string? LocationShortDisplayString { get; set; }

    public string? Zip { get; set; }

    public string? State { get; set; }

    public string? Street { get; set; }

    public string? CityStateKey { get; set; }

    public string? Phone { get; set; }

    public string? Charges { get; set; }
}
