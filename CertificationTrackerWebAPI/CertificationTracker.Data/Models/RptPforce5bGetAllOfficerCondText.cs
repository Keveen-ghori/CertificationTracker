using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptPforce5bGetAllOfficerCondText
{
    public decimal? IncidentId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public string? OfficerCondition { get; set; }

    public string? DisplayString { get; set; }
}
