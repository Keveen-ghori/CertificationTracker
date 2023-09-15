using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Mstrvehicle
{
    public decimal Mvid { get; set; }

    public int? AgencyId { get; set; }

    public decimal? LatestBackgroundCheckId { get; set; }

    public int? VehicleBodyCategoryCode { get; set; }

    public string? Vinnum { get; set; }

    public string? VehicleColorCode { get; set; }

    public string? VehicleMakeCode { get; set; }

    public string? VehicleModelCode { get; set; }

    public string? VehicleUseCode { get; set; }

    public string? VehicleStyleCode { get; set; }

    public int? VehicleYear { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public string? VehicleDetailXml { get; set; }

    public Guid? UniqueId { get; set; }

    public string? CopiedFromSource { get; set; }

    public string? CopiedFromVehicleId { get; set; }

    public DateTime? CopiedOn { get; set; }

    public string? CopiedByName { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public int? NibrsdescriptionCode { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual ICollection<CrashVehicleInvolvement> CrashVehicleInvolvements { get; set; } = new List<CrashVehicleInvolvement>();

    public virtual ICollection<FieldInterviewVehicleInvolvment> FieldInterviewVehicleInvolvments { get; set; } = new List<FieldInterviewVehicleInvolvment>();

    public virtual ICollection<HelpQueryVehicleInvolvement> HelpQueryVehicleInvolvements { get; set; } = new List<HelpQueryVehicleInvolvement>();

    public virtual ICollection<IncidentVehicleInvolvement> IncidentVehicleInvolvements { get; set; } = new List<IncidentVehicleInvolvement>();

    public virtual TrxBackgroundCheck? LatestBackgroundCheck { get; set; }

    public virtual ICollection<MstrorganizationRelatedIndex> MstrorganizationRelatedIndices { get; set; } = new List<MstrorganizationRelatedIndex>();

    public virtual ICollection<MstrvehicleRegOwner> MstrvehicleRegOwners { get; set; } = new List<MstrvehicleRegOwner>();

    public virtual ICollection<MstrvehicleRelatedMedium> MstrvehicleRelatedMedia { get; set; } = new List<MstrvehicleRelatedMedium>();

    public virtual ICollection<MstrvehicleStatus> MstrvehicleStatuses { get; set; } = new List<MstrvehicleStatus>();

    public virtual NibrsreferenceDatum? NibrsdescriptionCodeNavigation { get; set; }

    public virtual ICollection<PropertyRoomItem> PropertyRoomItems { get; set; } = new List<PropertyRoomItem>();

    public virtual ICollection<SysNotificationCondition> SysNotificationConditions { get; set; } = new List<SysNotificationCondition>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual ICollection<TrafficStop> TrafficStops { get; set; } = new List<TrafficStop>();

    public virtual ICollection<TrxBackgroundCheck> TrxBackgroundChecks { get; set; } = new List<TrxBackgroundCheck>();

    public virtual RefMstrinxreferenceDatum? VehicleBodyCategoryCodeNavigation { get; set; }
}
