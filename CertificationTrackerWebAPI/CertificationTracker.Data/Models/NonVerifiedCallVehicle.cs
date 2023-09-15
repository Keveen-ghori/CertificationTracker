using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class NonVerifiedCallVehicle
{
    public decimal ServiceCallVehicleId { get; set; }

    public decimal? ServiceCallId { get; set; }

    public int? CadvehicleId { get; set; }

    public string? CreatedBy { get; set; }

    public string? Regnum { get; set; }

    public string? Regstate { get; set; }

    public string? Source { get; set; }

    public bool? IsActive { get; set; }

    public string? Vinnum { get; set; }

    public int? Regyear { get; set; }

    public string? Regtype { get; set; }

    public string? Make { get; set; }

    public string? Model { get; set; }

    public int? Year { get; set; }

    public string? Color { get; set; }

    public string? Style { get; set; }

    public string? Comment { get; set; }

    public string? OwnerInfo { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public bool? IsReviewedbyOfficer { get; set; }

    public virtual ICollection<CrashVehicleInvolvement> CrashVehicleInvolvements { get; set; } = new List<CrashVehicleInvolvement>();

    public virtual ICollection<IncidentVehicleInvolvement> IncidentVehicleInvolvements { get; set; } = new List<IncidentVehicleInvolvement>();

    public virtual ServiceCall? ServiceCall { get; set; }

    public virtual ICollection<TowRequest> TowRequests { get; set; } = new List<TowRequest>();

    public virtual ICollection<TrxBackgroundCheck> TrxBackgroundChecks { get; set; } = new List<TrxBackgroundCheck>();
}
