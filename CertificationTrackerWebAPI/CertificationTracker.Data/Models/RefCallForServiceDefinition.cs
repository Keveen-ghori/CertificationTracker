using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RefCallForServiceDefinition
{
    public int CfsdefinitionId { get; set; }

    public int? DepartmentId { get; set; }

    public int? AgencyId { get; set; }

    public string? CallForServiceType { get; set; }

    public string? DeterminantDescriptor { get; set; }

    public string? CallHandlerCode { get; set; }

    public string? EventTypeCategory { get; set; }

    public int? AutoClearMinutes { get; set; }

    public int? Rank { get; set; }

    public bool? IsTalkGroupNeeded { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsAlarm { get; set; }

    public int? DefaultPriority { get; set; }

    public string? CallForServiceCode { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? DefaultPriorityName { get; set; }

    public Guid? UniqueId { get; set; }

    public int? CadeventDefinitionId { get; set; }

    public int? DisplaySeq { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual ICollection<DataProcessTrigger> DataProcessTriggers { get; set; } = new List<DataProcessTrigger>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<ServiceCall> ServiceCalls { get; set; } = new List<ServiceCall>();
}
