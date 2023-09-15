using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysNotificationPlan
{
    public int SysNotificationPlanId { get; set; }

    public int? DepartmentId { get; set; }

    public string? PlanName { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<SysNotificationAction> SysNotificationActions { get; set; } = new List<SysNotificationAction>();

    public virtual ICollection<SysNotificationCondition> SysNotificationConditions { get; set; } = new List<SysNotificationCondition>();
}
