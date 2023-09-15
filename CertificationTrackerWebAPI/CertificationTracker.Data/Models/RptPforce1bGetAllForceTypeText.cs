using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptPforce1bGetAllForceTypeText
{
    public decimal? IncidentId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public string? ForceType { get; set; }

    public string? DisplayString { get; set; }
}
