using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptDuireport
{
    public decimal? PrimaryIncidentId { get; set; }

    public decimal IncidentId { get; set; }

    public decimal ArrestBookingId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public DateTime? ArrestDateTime { get; set; }

    public int? SupplementSeq { get; set; }

    public string? GivenName { get; set; }

    public string? SurName { get; set; }

    public string? FullName { get; set; }

    public DateTime? Dob { get; set; }

    public int? UcrcodeId { get; set; }

    public string? PickUpCategoryGroup { get; set; }

    public string? PickUpClassification { get; set; }

    public DateTime? DateCreated { get; set; }
}
