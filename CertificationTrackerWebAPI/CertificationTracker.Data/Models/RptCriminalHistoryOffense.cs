using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptCriminalHistoryOffense
{
    public int? DepartmentId { get; set; }

    public decimal? Mpid { get; set; }

    public string? ArrestNumber { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? ArrestDateTime { get; set; }

    public DateTime? CdDispositionDate { get; set; }

    public int? MonthsSinceDisp { get; set; }

    public DateTime? CdErasureDate { get; set; }

    public string? Description { get; set; }

    public string? RefstatuteCode { get; set; }

    public string? RefstatuteDefinition { get; set; }

    public int? OffenseCount { get; set; }

    public string? CdRefStatuteCode { get; set; }

    public string? CdRefstatuteDefinition { get; set; }

    public int? CdVerdictCode { get; set; }

    public string? CdVerdictFinding { get; set; }

    public string? CdStatuteCode { get; set; }

    public string? CdStatuteDescription { get; set; }

    public string? CdStatuteType { get; set; }

    public string? CdStatuteClass { get; set; }

    public int? CdStatuteCount { get; set; }

    public string? CdTimeServed { get; set; }

    public decimal? CdFineAmount { get; set; }

    public decimal? CdFineRemitted { get; set; }

    public decimal? CdOtherFeesAmount { get; set; }

    public int? CdJailTerm { get; set; }

    public string? CdJailTermString { get; set; }

    public int? CdSuspendedJailTerm { get; set; }

    public string? CdSuspendedJailTermString { get; set; }

    public int? CdProbationTerm { get; set; }

    public string? CdProbationTermString { get; set; }

    public int? CdSpecialParoleTerm { get; set; }

    public string? CdSpecialParoleTermString { get; set; }

    public int? CdConditionalDischargeTerm { get; set; }

    public string? CdConditionalDischargeTermString { get; set; }

    public int? CdCcswitch { get; set; }

    public string? CdDocketNumber { get; set; }

    public string? ArrestingFirstN { get; set; }

    public string? ArrestingLastN { get; set; }

    public string? ArrestingFullN { get; set; }

    public int? PersonInvolvementCode { get; set; }
}
