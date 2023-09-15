using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PropertyCustodyTracking
{
    public decimal PropertyCustodyTrackingId { get; set; }

    public decimal? PropertyRoomItemId { get; set; }

    public int? Status { get; set; }

    public int? ActionDoneBy { get; set; }

    public int? CheckOutReason { get; set; }

    public int? StorageRoom { get; set; }

    public int? StorageAisle { get; set; }

    public int? StorageShelf { get; set; }

    public string? StorageBin { get; set; }

    public string? StorageDesc { get; set; }

    public DateTime? StatusDateTime { get; set; }

    public string? ReceivedFromName { get; set; }

    public string? CheckOutToName { get; set; }

    public string? LocationOut { get; set; }

    public bool? CheckOutSignatureOk { get; set; }

    public string? Comment { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsCurrent { get; set; }

    public virtual DepartmentEmployee? ActionDoneByNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CheckOutReasonNavigation { get; set; }

    public virtual PropertyRoomItem? PropertyRoomItem { get; set; }

    public virtual SysApplicationStatus? StatusNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? StorageAisleNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? StorageRoomNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? StorageShelfNavigation { get; set; }
}
