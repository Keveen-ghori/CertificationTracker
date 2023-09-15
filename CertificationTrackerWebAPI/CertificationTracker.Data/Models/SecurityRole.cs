using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SecurityRole
{
    public int SecurityRoleId { get; set; }

    public int? SpecialRoleForDepartmentId { get; set; }

    public string? RoleName { get; set; }

    public string? Description { get; set; }

    public bool? IsSupportWidgetAccessible { get; set; }

    public virtual ICollection<IndividualSecurityToUser> IndividualSecurityToUsers { get; set; } = new List<IndividualSecurityToUser>();

    public virtual ICollection<ReportContainer> ReportContainers { get; set; } = new List<ReportContainer>();

    public virtual ICollection<ReportDefinition> ReportDefinitions { get; set; } = new List<ReportDefinition>();

    public virtual ICollection<SecurityObjectTouserRole> SecurityObjectTouserRoles { get; set; } = new List<SecurityObjectTouserRole>();

    public virtual ICollection<SecurityRoleToUser> SecurityRoleToUsers { get; set; } = new List<SecurityRoleToUser>();

    public virtual Department? SpecialRoleForDepartment { get; set; }

    public virtual ICollection<SysNotificationAction> SysNotificationActions { get; set; } = new List<SysNotificationAction>();

    public virtual ICollection<SysapplicationStatusAllowedUi> SysapplicationStatusAllowedUis { get; set; } = new List<SysapplicationStatusAllowedUi>();
}
