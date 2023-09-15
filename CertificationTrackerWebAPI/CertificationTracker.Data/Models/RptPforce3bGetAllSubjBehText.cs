using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptPforce3bGetAllSubjBehText
{
    public decimal? IncidentId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public string? SubjectBehavior { get; set; }

    public string? DisplayString { get; set; }
}
