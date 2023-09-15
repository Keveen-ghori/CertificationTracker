using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DispositionsImport
{
    public decimal DispositionsImportId { get; set; }

    public decimal? RmsimportLogId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public decimal? TrafficStopId { get; set; }

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

    public int? NumberOfCharges { get; set; }

    public string? DefendantName { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressCity { get; set; }

    public string? AddressState { get; set; }

    public string? AddressZipCode { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? Sex { get; set; }

    public string? AliasName1 { get; set; }

    public string? AliasName2 { get; set; }

    public string? AliasName3 { get; set; }

    public string? LicenseNumber { get; set; }

    public string? LicenseState { get; set; }

    public string? RegistrationNumber { get; set; }

    public string? RegistrationState { get; set; }

    public string? OffenseTown { get; set; }

    public DateTime? ArrestDate { get; set; }

    public DateTime? DispositionDate { get; set; }

    public DateTime? ErasureDate { get; set; }

    public string? PdcaseNumber { get; set; }

    public string? ShieldNumber { get; set; }

    public string? Yoswitch { get; set; }

    public string? RearrestIndicator { get; set; }

    public DateTime? AppealFiledDate { get; set; }

    public DateTime? AppealDecidedDate { get; set; }

    public decimal? BondForfeitureAmount { get; set; }

    public decimal? CostAmount { get; set; }

    public string? CostIndicator { get; set; }

    public string? Cibindicator { get; set; }

    public string? DispositionMessage { get; set; }

    public string? AdditionalTicketNumber1 { get; set; }

    public string? AdditionalTicketNumber2 { get; set; }

    public string? AdditionalTicketNumber3 { get; set; }

    public string? AdditionalTicketNumber4 { get; set; }

    public string? AdditionalPdcaseNumbers1 { get; set; }

    public string? AdditionalPdcaseNumbers2 { get; set; }

    public string? AdditionalPdcaseNumbers3 { get; set; }

    public string? RevisedIndicator { get; set; }

    public string? Csindicator { get; set; }

    public decimal? ErrorType { get; set; }

    public bool? IsDataOverWrite { get; set; }

    public virtual ICollection<DispositionsChargesImport> DispositionsChargesImports { get; set; } = new List<DispositionsChargesImport>();

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }

    public virtual RmsimportLog? RmsimportLog { get; set; }

    public virtual SysApplicationStatus? SysApplicationStatus { get; set; }

    public virtual TrafficStop? TrafficStop { get; set; }
}
