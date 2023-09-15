using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Offense
{
    public decimal OffenseId { get; set; }

    public decimal? ArrestBookingId { get; set; }

    public int? DepartmentId { get; set; }

    public int? RefstatuteDefinition { get; set; }

    public int? AclflagCode { get; set; }

    public decimal? SummonsInfractionId { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public int? OffenseCount { get; set; }

    public string? Description { get; set; }

    public int? CdRefstatuteDefinition { get; set; }

    public string? Uarnumber { get; set; }

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

    public string? UserNotes { get; set; }

    public int? NibrscodeId { get; set; }

    public int? UcrcodeId { get; set; }

    public virtual RefIncidentReferenceDatum? AclflagCodeNavigation { get; set; }

    public virtual ArrestBooking? ArrestBooking { get; set; }

    public virtual RefIncidentReferenceDatum? CdCcswitchNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CdConditionalDischargeTypeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CdJailTypeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CdPleaNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CdProbationTypeNavigation { get; set; }

    public virtual RefStatuteDefinition? CdRefstatuteDefinitionNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CdSpecialParoleTypeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CdSuspendedJailTypeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CdVerdictFindingNavigation { get; set; }

    public virtual ICollection<CourtChargeInfo> CourtChargeInfos { get; set; } = new List<CourtChargeInfo>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<DispositionsChargesImport> DispositionsChargesImports { get; set; } = new List<DispositionsChargesImport>();

    public virtual RefNibrscodeDefinition? Nibrscode { get; set; }

    public virtual RefStatuteDefinition? RefstatuteDefinitionNavigation { get; set; }

    public virtual SummonsInfraction? SummonsInfraction { get; set; }

    public virtual RefUcrcodeDefinition? Ucrcode { get; set; }
}
