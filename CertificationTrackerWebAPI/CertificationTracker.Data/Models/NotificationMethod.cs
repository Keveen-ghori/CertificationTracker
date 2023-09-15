using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class NotificationMethod
{
    public decimal NotificationMethodId { get; set; }

    public decimal? DirectoryContactId { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public int? NotificationTypeCode { get; set; }

    public string? TypeData { get; set; }

    public int? Seq { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }

    public virtual DirectoryContact? DirectoryContact { get; set; }

    public virtual RefMstrinxreferenceDatum? NotificationTypeCodeNavigation { get; set; }

    public virtual ICollection<SysNotificationAction> SysNotificationActions { get; set; } = new List<SysNotificationAction>();
}
