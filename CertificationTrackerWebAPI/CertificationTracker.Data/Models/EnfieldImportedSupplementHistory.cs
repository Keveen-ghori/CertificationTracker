using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class EnfieldImportedSupplementHistory
{
    public decimal? OriginalIncidentId { get; set; }

    public decimal? SupplementId { get; set; }

    public decimal? PersonInvolvementId { get; set; }

    public decimal? Mpid { get; set; }

    public string? InvolvementString { get; set; }

    public string? ErrorString { get; set; }

    public DateTime? AddedOn { get; set; }

    public bool? IsDeleted { get; set; }
}
