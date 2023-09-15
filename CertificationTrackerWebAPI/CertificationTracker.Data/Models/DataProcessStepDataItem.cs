using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DataProcessStepDataItem
{
    public decimal ProcessStepDataItemId { get; set; }

    public int? ProcessStepId { get; set; }

    public int? DepartmentId { get; set; }

    public int? Sequence { get; set; }

    public string? Name { get; set; }

    public string? ControlType { get; set; }

    public string? DataBindingXml { get; set; }

    public string? DefaultValue { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? ItemToolTip { get; set; }

    public string? DataMappingObjectPropertyName { get; set; }

    public string? DataMappingSubObjectName { get; set; }

    public string? DataMappingSubObjectPropertyName { get; set; }

    public bool? IsActive { get; set; }

    public int? MaxLength { get; set; }

    public string? DataValue { get; set; }

    public virtual ICollection<DataProcessRuleCondition> DataProcessRuleConditions { get; set; } = new List<DataProcessRuleCondition>();

    public virtual ICollection<DataProcessRule> DataProcessRules { get; set; } = new List<DataProcessRule>();

    public virtual Department? Department { get; set; }

    public virtual DataProcessStep? ProcessStep { get; set; }

    public virtual ICollection<RmsdataProcessDetailStep> RmsdataProcessDetailSteps { get; set; } = new List<RmsdataProcessDetailStep>();
}
