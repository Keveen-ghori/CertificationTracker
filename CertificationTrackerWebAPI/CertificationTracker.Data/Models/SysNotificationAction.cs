using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysNotificationAction
{
    public int SysNotificationActionId { get; set; }

    public decimal? DepartmentOrgId { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public int? SecurityRoleId { get; set; }

    public decimal? NotificationMethodId { get; set; }

    public int? DepartmentId { get; set; }

    public int? SysNotificationPlanId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public int? Sequence { get; set; }

    public virtual Department? Department { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }

    public virtual DepartmentOrg? DepartmentOrg { get; set; }

    public virtual NotificationMethod? NotificationMethod { get; set; }

    public virtual SecurityRole? SecurityRole { get; set; }

    public virtual SysNotificationPlan? SysNotificationPlan { get; set; }
}
