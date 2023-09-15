using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysNotificationCondition
{
    public int SysNotificationConditionsId { get; set; }

    public int? DepartmentId { get; set; }

    public decimal? SysNotificationTemplateId { get; set; }

    public int? SysrmsapplicationTypeId { get; set; }

    public int? ApplicationStatusId { get; set; }

    public int? ReportStatusId { get; set; }

    public int? InvestigativeStatusId { get; set; }

    public decimal? Mpid { get; set; }

    public decimal? Mvid { get; set; }

    public decimal? Moid { get; set; }

    public decimal? LocationId { get; set; }

    public decimal? Mppid { get; set; }

    public int? UcrcodeId { get; set; }

    public int? SysNotificationPlanId { get; set; }

    public int? StatusDuration { get; set; }

    public int? InvolvementRefCodeId { get; set; }

    public string? InvolvementRefCodeTable { get; set; }

    public string? InvolvementCode { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual SysApplicationStatus? ApplicationStatus { get; set; }

    public virtual Department? Department { get; set; }

    public virtual SysApplicationStatus? InvestigativeStatus { get; set; }

    public virtual Mstrlocation? Location { get; set; }

    public virtual Mstrorganization? Mo { get; set; }

    public virtual Mstrperson? Mp { get; set; }

    public virtual Mstrproperty? Mpp { get; set; }

    public virtual Mstrvehicle? Mv { get; set; }

    public virtual SysApplicationStatus? ReportStatus { get; set; }

    public virtual ICollection<RmsnotificationLog> RmsnotificationLogs { get; set; } = new List<RmsnotificationLog>();

    public virtual SysNotificationPlan? SysNotificationPlan { get; set; }

    public virtual SysNotificationTemplate? SysNotificationTemplate { get; set; }

    public virtual SysrmsapplicationType? SysrmsapplicationType { get; set; }

    public virtual RefUcrcodeDefinition? Ucrcode { get; set; }
}
