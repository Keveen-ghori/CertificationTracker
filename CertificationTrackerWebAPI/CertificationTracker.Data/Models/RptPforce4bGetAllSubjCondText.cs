using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptPforce4bGetAllSubjCondText
{
    public decimal? IncidentId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public string? SubjectCondition { get; set; }

    public string? DisplayString { get; set; }
}
