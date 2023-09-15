using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysDataValidationRule
{
    public decimal SysDataValidationRuleId { get; set; }

    public int? RequestedApplication { get; set; }

    public string? ErrorCode { get; set; }

    public string? ErrorGrouping { get; set; }

    public string? ErrorType { get; set; }

    public bool? IsStopAfterError { get; set; }

    public string? UidisplayString { get; set; }

    public string? ValidationCondition { get; set; }

    public string? ValidationEdit { get; set; }

    public int? AgencyId { get; set; }

    public int? DepartmentId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public int? RefDepartmentOverrideFrom { get; set; }

    public short? DisplaySeq { get; set; }

    public bool? IsActiveRule { get; set; }

    public string? CtdotruleId { get; set; }

    public virtual SysrmsapplicationType? RequestedApplicationNavigation { get; set; }

    public virtual ICollection<SysDataValidationControlConfiguration> SysDataValidationControlConfigurations { get; set; } = new List<SysDataValidationControlConfiguration>();
}
