using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptDrug
{
    public string? IncidentNumber { get; set; }

    public string? Officer { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Drug { get; set; }

    public string? DrugType { get; set; }

    public string? Weight { get; set; }

    public string? Unit { get; set; }

    public decimal? Value { get; set; }

    public string? Description { get; set; }

    public int DepartmentId { get; set; }

    public string? Name { get; set; }

    public DateTime? IncidentStart { get; set; }
}
