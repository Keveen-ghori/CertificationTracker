using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptPforce5aGetAllOfficerCond
{
    public decimal? IncidentId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public string? OfficerCondition { get; set; }
}
