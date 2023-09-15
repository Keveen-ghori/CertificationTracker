using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PropertyRoomItem
{
    public decimal PropertyRoomItemId { get; set; }

    public int? DepartmentId { get; set; }

    public int? ItemStatus { get; set; }

    public decimal? Mppid { get; set; }

    public int? ReportStatus { get; set; }

    public int? FinalDisposition { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public decimal? Mvid { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? TransferLabelNumber { get; set; }

    public DateTime? LastInventoryDate { get; set; }

    public DateTime? PotentialPurgeDate { get; set; }

    public DateTime? ActualPurgeDate { get; set; }

    public string? DisposalMethod { get; set; }

    public string? Barcode { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public string? CourtInventoryNumber { get; set; }

    public virtual Department? Department { get; set; }

    public virtual RefIncidentReferenceDatum? FinalDispositionNavigation { get; set; }

    public virtual SysApplicationStatus? ItemStatusNavigation { get; set; }

    public virtual Mstrproperty? Mpp { get; set; }

    public virtual Mstrvehicle? Mv { get; set; }

    public virtual Incident? PrimaryIncident { get; set; }

    public virtual ICollection<PropertyCustodyTracking> PropertyCustodyTrackings { get; set; } = new List<PropertyCustodyTracking>();

    public virtual SysApplicationStatus? ReportStatusNavigation { get; set; }
}
