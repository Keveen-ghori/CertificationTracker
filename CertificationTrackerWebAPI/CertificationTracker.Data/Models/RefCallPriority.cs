using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RefCallPriority
{
    public int CfspriorityId { get; set; }

    public int? AgencyId { get; set; }

    public int? DepartmentId { get; set; }

    public string? Description { get; set; }

    public int? DefaultPriorityValue { get; set; }

    public int? PriorityValueIncrement { get; set; }

    public int? MaxPriorityValue { get; set; }

    public int? MinutesToEscalePriority { get; set; }

    public string? PriorityName { get; set; }

    public bool? IsActive { get; set; }

    public int? UnitEligibleTimeRemain { get; set; }

    public int? ColorCode { get; set; }

    public bool? IsFlashing { get; set; }

    public int? MaximumAge { get; set; }

    public bool? IsTeleserve { get; set; }

    public bool? IsBeeping { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public int? CadeventPriorityId { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual Department? Department { get; set; }
}
