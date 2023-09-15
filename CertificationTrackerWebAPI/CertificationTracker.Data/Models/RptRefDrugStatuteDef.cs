using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptRefDrugStatuteDef
{
    public int RefstatuteDefinitionId { get; set; }

    public int? AgencyId { get; set; }

    public int? DepartmentId { get; set; }

    public int? DataProcessId { get; set; }

    public int? UcrcodeId { get; set; }

    public int? NibrscodeId { get; set; }

    public string? Statue { get; set; }

    public string? StatuteCode { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public string? OffenseType { get; set; }

    public string? OffenseClass { get; set; }

    public string? KeyGroupName { get; set; }

    public string? KeySort { get; set; }

    public string? Description { get; set; }

    public bool? IsUsedForCitation { get; set; }

    public bool? IsUsedForIncident { get; set; }

    public bool? IsUsedForCrash { get; set; }

    public int? Rank { get; set; }

    public string? CiteAs { get; set; }

    public DateTime? CashEffectDate { get; set; }

    public DateTime? CashRepealDate { get; set; }

    public decimal? CashTotalAmt { get; set; }

    public decimal? CashFineAmt { get; set; }

    public decimal? CashFeeAmt { get; set; }

    public decimal? CashSurchargeAmt { get; set; }

    public decimal? CashStfAmt { get; set; }

    public decimal? CashPlusAmt { get; set; }

    public decimal? CashMunicipalFee { get; set; }

    public string? Appendix { get; set; }

    public int? RefDepartmentOverrideFrom { get; set; }

    public string? Notes { get; set; }

    public string? ShortName { get; set; }

    public DateTime? ImportDateTime { get; set; }

    public string? ImportSource { get; set; }

    public int? SpeedOver { get; set; }

    public int? ActualSpeed { get; set; }

    public string? Category { get; set; }

    public string? Zone { get; set; }

    public string? Court { get; set; }

    public DateTime? CitationUpdateDateTime { get; set; }

    public DateTime? CissverifiedDateTime { get; set; }
}
