using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrsuppApropType1selectProperty
{
    public int? DepartmentId { get; set; }

    public string? Department { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public int? PropertyInvolvementCode { get; set; }

    public string? Rptcategory { get; set; }

    public decimal? Value { get; set; }

    public bool? IsActive { get; set; }

    public decimal? RecoveredValue { get; set; }
}
