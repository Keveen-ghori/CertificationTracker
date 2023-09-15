using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RmsnotificationLog
{
    public int SysNotificationLogId { get; set; }

    public int? EmployeeNotifiedId { get; set; }

    public decimal? SysNotificationTemplateId { get; set; }

    public int? SysNotificationConditionsId { get; set; }

    public int? EmployeeCreatedId { get; set; }

    public int? SysrmsapplicationTypeId { get; set; }

    public string? NotifcationCategory { get; set; }

    public DateTime? DateTimeCreated { get; set; }

    public string? NotificationText { get; set; }

    public string? CreatedName { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationPkid { get; set; }

    public bool? Unacknowledged { get; set; }

    public DateTime? AcknowledgedDateTime { get; set; }

    public virtual DepartmentEmployee? EmployeeCreated { get; set; }

    public virtual DepartmentEmployee? EmployeeNotified { get; set; }

    public virtual SysNotificationCondition? SysNotificationConditions { get; set; }

    public virtual SysNotificationTemplate? SysNotificationTemplate { get; set; }

    public virtual SysrmsapplicationType? SysrmsapplicationType { get; set; }
}
