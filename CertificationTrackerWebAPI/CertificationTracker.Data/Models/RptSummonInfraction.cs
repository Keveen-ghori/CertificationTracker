using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptSummonInfraction
{
    public string? ReportingOfficer { get; set; }

    public string? SummonsNumber { get; set; }

    public string? IncidentNumber { get; set; }

    public int? SupplementSeq { get; set; }

    public string? Cadnumber { get; set; }

    public string? IncidentReportType { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public string? LocationDetailDisplayString { get; set; }

    public string? Arrestee { get; set; }

    public string? StatuteCode { get; set; }

    public string? Statue { get; set; }

    public string? Acl { get; set; }

    public decimal OffenseId { get; set; }

    public decimal SummonsInfractionId { get; set; }

    public int? DepartmentId { get; set; }
}
