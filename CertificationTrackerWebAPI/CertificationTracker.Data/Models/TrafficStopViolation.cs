using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class TrafficStopViolation
{
    public decimal TrafficStopViolationId { get; set; }

    public decimal? TrafficStopId { get; set; }

    public int? RefstatuteDefinitionId { get; set; }

    public int? ViolationId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public short? Sequence { get; set; }

    public int? Count { get; set; }

    public decimal? Amount { get; set; }

    public bool? IsViolationForTrafficStop { get; set; }

    public int? CdRefstatuteDefinitionId { get; set; }

    public string? CourtDispositionRaw { get; set; }

    public string? CdDocketNumber { get; set; }

    public int? CdRecordNumber { get; set; }

    public int? CdChargeNumber { get; set; }

    public string? CdStatuteCode { get; set; }

    public string? CdStatuteDescription { get; set; }

    public string? CdStatuteCax { get; set; }

    public string? CdStatuteType { get; set; }

    public string? CdStatuteClass { get; set; }

    public int? CdStatuteCount { get; set; }

    public int? CdPlea { get; set; }

    public int? CdVerdictFinding { get; set; }

    public string? CdTimeServed { get; set; }

    public decimal? CdFineAmount { get; set; }

    public decimal? CdFineRemitted { get; set; }

    public decimal? CdOtherFeesAmount { get; set; }

    public int? CdJailTerm { get; set; }

    public int? CdJailType { get; set; }

    public int? CdSuspendedJailTerm { get; set; }

    public int? CdSuspendedJailType { get; set; }

    public int? CdProbationTerm { get; set; }

    public int? CdProbationType { get; set; }

    public int? CdSpecialParoleTerm { get; set; }

    public int? CdSpecialParoleType { get; set; }

    public int? CdConditionalDischargeTerm { get; set; }

    public int? CdConditionalDischargeType { get; set; }

    public int? CdCcswitch { get; set; }

    public string? CdDvindicator { get; set; }

    public bool? ExcludeStatueInPrint { get; set; }

    public string? UserNotes { get; set; }

    public virtual RefIncidentReferenceDatum? CdCcswitchNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CdConditionalDischargeTypeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CdJailTypeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CdPleaNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CdProbationTypeNavigation { get; set; }

    public virtual RefStatuteDefinition? CdRefstatuteDefinition { get; set; }

    public virtual RefIncidentReferenceDatum? CdSpecialParoleTypeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CdSuspendedJailTypeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CdVerdictFindingNavigation { get; set; }

    public virtual ICollection<DispositionsChargesImport> DispositionsChargesImports { get; set; } = new List<DispositionsChargesImport>();

    public virtual RefStatuteDefinition? RefstatuteDefinition { get; set; }

    public virtual TrafficStop? TrafficStop { get; set; }

    public virtual RefViolation? Violation { get; set; }
}
