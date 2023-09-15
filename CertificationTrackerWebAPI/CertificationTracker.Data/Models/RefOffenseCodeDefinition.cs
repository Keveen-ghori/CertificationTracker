using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RefOffenseCodeDefinition
{
    public int OffenseCodeDefinitionId { get; set; }

    public int? AgencyId { get; set; }

    public int? DepartmentId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public string? OffenseName { get; set; }

    public string? Description { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual ICollection<DataProcessTrigger> DataProcessTriggers { get; set; } = new List<DataProcessTrigger>();

    public virtual Department? Department { get; set; }
}
