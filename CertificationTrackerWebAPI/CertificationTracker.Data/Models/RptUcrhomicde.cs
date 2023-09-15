using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrhomicde
{
    public int? DepartmentId { get; set; }

    public string? DropdownDescription { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? Race { get; set; }

    public string? Ethnicity { get; set; }

    public string? Type { get; set; }
}
