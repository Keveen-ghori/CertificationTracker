using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class TrafficStop
{
    public decimal TrafficStopId { get; set; }

    public int? TrafficStopResultCode { get; set; }

    public decimal? ViolatorId { get; set; }

    public decimal? TrafficStopLocationId { get; set; }

    public decimal? VehicleId { get; set; }

    public int? DepartmentId { get; set; }

    public int? ReportedEmployeeId { get; set; }

    public int? UsedNarrativeTemplateId { get; set; }

    public int? TrafficStopStatusCode { get; set; }

    public decimal? OffenseLocationId { get; set; }

    public int? DataEntryEmployeeId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public string? Cadnumber { get; set; }

    public string? ReportingUnit { get; set; }

    public string? ReportingUnitShift { get; set; }

    public string? ReportingUnitProvider { get; set; }

    public string? ReportingUnitArea { get; set; }

    public string? TrafficStopNumber { get; set; }

    public string? Narrative { get; set; }

    public string? NarrativeEditedName { get; set; }

    public DateTime? NarrativeEditedOn { get; set; }

    public DateTime? TrafficStopDateTime { get; set; }

    public bool? IsBoatingCertificate { get; set; }

    public bool? IsBoatingReg { get; set; }

    public DateTime? TicketPrintOutDt { get; set; }

    public decimal? TotallAmountDue { get; set; }

    public decimal? TowRequestId { get; set; }

    public string? CourtDispositionRaw { get; set; }

    public string? CdDocketNumber { get; set; }

    public DateTime? CdDispositionDate { get; set; }

    public DateTime? CdErasureDate { get; set; }

    public string? CdYoswitch { get; set; }

    public string? CdRearrestIndicator { get; set; }

    public DateTime? CdAppealFiledDate { get; set; }

    public DateTime? CdAppealDecidedDate { get; set; }

    public decimal? CdBondForfeitureAmount { get; set; }

    public decimal? CdCostAmount { get; set; }

    public int? CdCostIndicator { get; set; }

    public string? CdCibindicator { get; set; }

    public string? CdDispositionMessage { get; set; }

    public string? CdAdditionalTicketNumbers { get; set; }

    public string? CdAdditionalPdandCaseNumbers { get; set; }

    public string? CdRevisedIndicator { get; set; }

    public string? CdCsindicator { get; set; }

    public bool? IsPaperTicketUsed { get; set; }

    public bool? IsTwoSidedPdf { get; set; }

    public bool? IsReopened { get; set; }

    public virtual RefIncidentReferenceDatum? CdCostIndicatorNavigation { get; set; }

    public virtual DepartmentEmployee? DataEntryEmployee { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<DispositionsImport> DispositionsImports { get; set; } = new List<DispositionsImport>();

    public virtual ICollection<HelpQueryPersonInvolvement> HelpQueryPersonInvolvements { get; set; } = new List<HelpQueryPersonInvolvement>();

    public virtual ICollection<HelpQueryVehicleInvolvement> HelpQueryVehicleInvolvements { get; set; } = new List<HelpQueryVehicleInvolvement>();

    public virtual Mstrlocation? OffenseLocation { get; set; }

    public virtual ICollection<RacialProfiling> RacialProfilings { get; set; } = new List<RacialProfiling>();

    public virtual DepartmentEmployee? ReportedEmployee { get; set; }

    public virtual ICollection<SummonsInfraction> SummonsInfractions { get; set; } = new List<SummonsInfraction>();

    public virtual TowRequest? TowRequest { get; set; }

    public virtual ICollection<TrafficStopCitationDetail> TrafficStopCitationDetails { get; set; } = new List<TrafficStopCitationDetail>();

    public virtual Mstrlocation? TrafficStopLocation { get; set; }

    public virtual RefTrafficStopTicketReferenceDatum? TrafficStopResultCodeNavigation { get; set; }

    public virtual SysApplicationStatus? TrafficStopStatusCodeNavigation { get; set; }

    public virtual ICollection<TrafficStopViolation> TrafficStopViolations { get; set; } = new List<TrafficStopViolation>();

    public virtual ICollection<TrafficStopWarningDetail> TrafficStopWarningDetails { get; set; } = new List<TrafficStopWarningDetail>();

    public virtual RefNarrativeTemplate? UsedNarrativeTemplate { get; set; }

    public virtual Mstrvehicle? Vehicle { get; set; }

    public virtual Mstrperson? Violator { get; set; }
}
