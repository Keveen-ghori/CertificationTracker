using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptPforce1aGetAllForceType
{
    public decimal? IncidentId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public string? ForceType { get; set; }
}
