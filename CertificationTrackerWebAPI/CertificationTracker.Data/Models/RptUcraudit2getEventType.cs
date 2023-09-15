using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcraudit2getEventType
{
    public decimal IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public string? Cadnumber { get; set; }

    public int? CallTypeId { get; set; }

    public string? CallForServiceType { get; set; }

    public string? DeterminantDescriptor { get; set; }

    public int? IncidentStatusId { get; set; }

    public string? AssignedNumber { get; set; }
}
