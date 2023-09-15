using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class CrashVehicleInvolvement
{
    public decimal CrashVehicleInvolvementId { get; set; }

    public decimal? CrashId { get; set; }

    public decimal? NonVerifiedVehicleId { get; set; }

    public decimal? Mvid { get; set; }

    public int? CrashVehicleInvolvementCode { get; set; }

    public bool? IsHitandRun { get; set; }

    public string? CrashVehicleInvolvementDetailXml { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public bool? IsConfidential { get; set; }

    public string? Source { get; set; }

    public string? Comment { get; set; }

    public int? Seq { get; set; }

    public decimal? TowRequestId { get; set; }

    public virtual Crash? Crash { get; set; }

    public virtual ICollection<CrashPersonInvolvement> CrashPersonInvolvements { get; set; } = new List<CrashPersonInvolvement>();

    public virtual ICollection<CrashPropertyInvolvement> CrashPropertyInvolvements { get; set; } = new List<CrashPropertyInvolvement>();

    public virtual ICollection<CrashRelatedAttachment> CrashRelatedAttachments { get; set; } = new List<CrashRelatedAttachment>();

    public virtual ICollection<CrashVehicleAreaImpact> CrashVehicleAreaImpacts { get; set; } = new List<CrashVehicleAreaImpact>();

    public virtual CrashVehicleCommericalInfo? CrashVehicleCommericalInfo { get; set; }

    public virtual RefCrashReferenceDatum? CrashVehicleInvolvementCodeNavigation { get; set; }

    public virtual CrashVehicleSummaryDatum? CrashVehicleSummaryDatum { get; set; }

    public virtual ICollection<HelpQueryVehicleInvolvement> HelpQueryVehicleInvolvements { get; set; } = new List<HelpQueryVehicleInvolvement>();

    public virtual Mstrvehicle? Mv { get; set; }

    public virtual NonVerifiedCallVehicle? NonVerifiedVehicle { get; set; }

    public virtual TowRequest? TowRequest { get; set; }
}
