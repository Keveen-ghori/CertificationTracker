using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DispositionsChargesImport
{
    public decimal DispositionsChargesImportId { get; set; }

    public decimal DispositionsImportId { get; set; }

    public decimal? OffenseId { get; set; }

    public decimal? TrafficStopViolationId { get; set; }

    public int? SysApplicationStatusId { get; set; }

    public string? Error { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? PoliceCode { get; set; }

    public string? DocketNumber { get; set; }

    public int? RecordNumber { get; set; }

    public string? SortSwitch { get; set; }

    public int? ChargeNumber { get; set; }

    public string? DefendantName { get; set; }

    public string? OriginalStatuteCode { get; set; }

    public string? OriginalStatuteDescription { get; set; }

    public string? OriginalStatuteCax { get; set; }

    public string? OriginalStatuteType { get; set; }

    public string? OriginalStatuteClass { get; set; }

    public int? OriginalStatuteCount { get; set; }

    public string? StatuteCode { get; set; }

    public string? StatuteDescription { get; set; }

    public string? StatuteCax { get; set; }

    public string? StatuteType { get; set; }

    public string? StatuteClass { get; set; }

    public int? StatuteCount { get; set; }

    public string? Plea { get; set; }

    public string? VerdictFinding { get; set; }

    public string? TimeServed { get; set; }

    public decimal? FineAmount { get; set; }

    public decimal? FineRemitted { get; set; }

    public decimal? OtherFeesAmount { get; set; }

    public decimal? JailTerm { get; set; }

    public string? JailType { get; set; }

    public decimal? SuspendedJailTerm { get; set; }

    public string? SuspendedJailType { get; set; }

    public decimal? ProbationTerm { get; set; }

    public string? ProbationType { get; set; }

    public decimal? SpecialParoleTerm { get; set; }

    public string? SpecialParoleType { get; set; }

    public decimal? ConditionalDischargeTerm { get; set; }

    public string? ConditionalDischargeType { get; set; }

    public string? Ccswitch { get; set; }

    public string? Dvindicator { get; set; }

    public byte? ErrorType { get; set; }

    public virtual DispositionsImport DispositionsImport { get; set; } = null!;

    public virtual Offense? Offense { get; set; }

    public virtual SysApplicationStatus? SysApplicationStatus { get; set; }

    public virtual TrafficStopViolation? TrafficStopViolation { get; set; }
}
