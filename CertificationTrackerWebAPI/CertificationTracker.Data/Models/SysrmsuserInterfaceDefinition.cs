using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysrmsuserInterfaceDefinition
{
    public decimal SysrmsuserInterfaceDefinitionId { get; set; }

    public int? SysrmsapplicationTypeId { get; set; }

    public string? MappingUicontrolName { get; set; }

    public string? ControlType { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? DisplayName { get; set; }

    public string? Icon { get; set; }

    public string? Description { get; set; }

    public string? Uicategory { get; set; }

    public string? CodeId { get; set; }

    public string? MappingUi { get; set; }

    public bool? IsActive { get; set; }

    public int? DepartmentId { get; set; }

    public int? RefDepartmentOverrideFrom { get; set; }

    public bool? IsNeedtoCheckatRuntimeforContextMenu { get; set; }

    public int? DisplaySeq { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<SysapplicationStatusAllowedUi> SysapplicationStatusAllowedUis { get; set; } = new List<SysapplicationStatusAllowedUi>();

    public virtual SysrmsapplicationType? SysrmsapplicationType { get; set; }

    public virtual ICollection<WfallowedUi> WfallowedUis { get; set; } = new List<WfallowedUi>();
}
