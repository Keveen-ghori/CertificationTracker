using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptCriminalHistory
{
    public string? IncidentNumber { get; set; }

    public string? ArrestNumber { get; set; }

    public string? ArrestingOfficer { get; set; }

    public string? ReportedOfficer { get; set; }

    public DateTime? ArrestDate { get; set; }

    public string? StatuteCode { get; set; }

    public string? Statue { get; set; }

    public int? OffenseCount { get; set; }

    public string? CdStatuteCode { get; set; }

    public string? CdStatuteDescription { get; set; }

    public int? CdCount { get; set; }

    public DateTime? CdDispositionDate { get; set; }

    public DateTime? CdErasureDate { get; set; }

    public int? CdJailTerm { get; set; }

    public string? CdJailTypeString { get; set; }

    public int? CdSuspendedJailTerm { get; set; }

    public string? CdSuspendedJailString { get; set; }

    public int? CdProbationTerm { get; set; }

    public string? CdProbationTypeString { get; set; }

    public int? CdConditionalDischargeTerm { get; set; }

    public string? CdConditionalDischargeString { get; set; }

    public int? CdSpecialParoleTerm { get; set; }

    public string? CdSpecialParoleString { get; set; }

    public string? CdType { get; set; }

    public string? CdClass { get; set; }

    public decimal? CdFineAmount { get; set; }

    public decimal? CdFineRemitted { get; set; }

    public decimal? CdOtherFeesAmount { get; set; }

    public decimal? Mpid { get; set; }

    public int? DepartmentId { get; set; }

    public string? CdCcswitch { get; set; }

    public string? CdVerdict { get; set; }
}
