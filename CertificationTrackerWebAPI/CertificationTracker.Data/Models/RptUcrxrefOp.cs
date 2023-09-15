using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrxrefOp
{
    public int DepartmentId { get; set; }

    public decimal IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public string? UcrcodeDisplayName { get; set; }

    public string? ValueRange { get; set; }

    public decimal? TotStolenPropValue { get; set; }

    public decimal? TotRecPropValue { get; set; }

    public decimal? TotStolenVehValue { get; set; }

    public decimal? TotRecVehValue { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? Race { get; set; }

    public string? Ethnicity { get; set; }

    public DateTime? ArrestDateTime { get; set; }

    public string? Ucrcode { get; set; }
}
