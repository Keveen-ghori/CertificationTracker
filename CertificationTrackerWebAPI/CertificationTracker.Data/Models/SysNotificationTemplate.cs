using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysNotificationTemplate
{
    public decimal SysNotificationTemplateId { get; set; }

    public string? NotificationCategory { get; set; }

    public int? NotificationLevel { get; set; }

    public string? NotificationTemplate { get; set; }

    public string? NotificationTemplateParameters { get; set; }

    public string? Description { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? EditedName { get; set; }

    public virtual ICollection<RmsnotificationLog> RmsnotificationLogs { get; set; } = new List<RmsnotificationLog>();

    public virtual ICollection<SysNotificationCondition> SysNotificationConditions { get; set; } = new List<SysNotificationCondition>();
}
