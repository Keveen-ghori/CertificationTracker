using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RmsdataProcessDetailStep
{
    public decimal RmsdataProcessControllerDetailId { get; set; }

    public decimal? RmsdataProcessControllerId { get; set; }

    public int? UserProcessStepId { get; set; }

    public decimal? UserProcessStepDataItemId { get; set; }

    public int? UserProcessDetailStepId { get; set; }

    public string? UserProcessStepDataItemEnterValue { get; set; }

    public string? UserProcessStepDataItemName { get; set; }

    public string? UserProcessStepDataItemEnterString { get; set; }

    public string? StepStatus { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? DataMappingSubObjectName { get; set; }

    public decimal? DataMappingSubObjectId { get; set; }

    public bool? IsContainRule { get; set; }

    public string? DataMappingObjectPropertyName { get; set; }

    public string? MappingTableName { get; set; }

    public string? MappingTableColumn { get; set; }

    public decimal? MappingTablePkvalue { get; set; }

    public string? DataMappingSubObjectPropertyName { get; set; }

    public string? RefDataId { get; set; }

    public string? RefDataTable { get; set; }

    public virtual RmsdataProcessController? RmsdataProcessController { get; set; }

    public virtual ICollection<RmsdataProcessDetailStepRulesAction> RmsdataProcessDetailStepRulesActions { get; set; } = new List<RmsdataProcessDetailStepRulesAction>();

    public virtual DataProcessDetailStep? UserProcessDetailStep { get; set; }

    public virtual DataProcessStep? UserProcessStep { get; set; }

    public virtual DataProcessStepDataItem? UserProcessStepDataItem { get; set; }
}
