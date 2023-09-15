using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysDataValidationControlConfiguration
{
    public int SysDataValidationControlConfigurationId { get; set; }

    public decimal SysDataValidationRuleId { get; set; }

    public int? RequestedApplication { get; set; }

    public string? ErrorCode { get; set; }

    public bool? IsActiveRule { get; set; }

    public string? ParentControlId { get; set; }

    public string? ChildControlId { get; set; }

    public string? SubChildControlId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? AdditionalDisplayString { get; set; }

    public string? ControlType { get; set; }

    public virtual SysrmsapplicationType? RequestedApplicationNavigation { get; set; }

    public virtual SysDataValidationRule SysDataValidationRule { get; set; } = null!;
}
