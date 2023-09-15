using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptPuofOfficerControlMethod
{
    public int? DepartmentId { get; set; }

    public decimal IncidentId { get; set; }

    public DateTime? InvolvementDateTime { get; set; }

    public int OfficerId { get; set; }

    public string? OfficerName { get; set; }

    public string? InvolvedEmployee1ControlMethod { get; set; }
}
