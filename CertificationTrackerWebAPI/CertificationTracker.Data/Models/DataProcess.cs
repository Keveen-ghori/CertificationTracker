using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DataProcess
{
    public int DataProcessId { get; set; }

    public int? DepartmentId { get; set; }

    public string? ProcessName { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsActive { get; set; }

    public string? DataMappingObjectName { get; set; }

    public decimal? DataMappingObjectSupportValue { get; set; }

    public virtual ICollection<DataProcessDetailStep> DataProcessDetailSteps { get; set; } = new List<DataProcessDetailStep>();

    public virtual ICollection<DataProcessRule> DataProcessRules { get; set; } = new List<DataProcessRule>();

    public virtual ICollection<DataProcessTrigger> DataProcessTriggers { get; set; } = new List<DataProcessTrigger>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<RefStatuteDefinition> RefStatuteDefinitions { get; set; } = new List<RefStatuteDefinition>();

    public virtual ICollection<RefUcrcodeDefinition> RefUcrcodeDefinitions { get; set; } = new List<RefUcrcodeDefinition>();

    public virtual ICollection<RmsdataProcessController> RmsdataProcessControllers { get; set; } = new List<RmsdataProcessController>();
}
