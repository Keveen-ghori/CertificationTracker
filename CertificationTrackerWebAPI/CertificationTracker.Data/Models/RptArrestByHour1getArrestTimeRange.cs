using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptArrestByHour1getArrestTimeRange
{
    public DateTime? ArrestDate { get; set; }

    public string? ArresttimeRange { get; set; }

    public int? DepartmentId { get; set; }

    public decimal IncidentId { get; set; }

    public decimal ArrestbookingId { get; set; }
}
