using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class EnfieldImportArrestHisotry
{
    public string? Inum { get; set; }

    public decimal? IncidentId { get; set; }

    public decimal? PersonInvolvementId { get; set; }

    public decimal? Mpid { get; set; }

    public decimal? ArrestBookingId { get; set; }

    public string? InvolvementString { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime? AddedOn { get; set; }
}
