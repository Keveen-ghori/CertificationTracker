using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrxref2classProp
{
    public int DepartmentId { get; set; }

    public string? Department { get; set; }

    public decimal IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public int? IncidentStatusId { get; set; }

    public int? ValueRangeCode { get; set; }

    public string? ValueRange { get; set; }

    public decimal? TotStolenPropValue { get; set; }

    public decimal? TotRecPropValue { get; set; }

    public string? Ucrcode { get; set; }

    public string? UcrcodeDisplayName { get; set; }
}
