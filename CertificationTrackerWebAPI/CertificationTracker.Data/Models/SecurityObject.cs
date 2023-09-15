using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SecurityObject
{
    public int SecurityObjectId { get; set; }

    public int? DepartmentId { get; set; }

    public int? AgencyId { get; set; }

    public string? Name { get; set; }

    public string? Comments { get; set; }

    public string? DirectoryMapping { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<SecurityObjectToprofile> SecurityObjectToprofiles { get; set; } = new List<SecurityObjectToprofile>();

    public virtual ICollection<SecurityObjectTouserRole> SecurityObjectTouserRoles { get; set; } = new List<SecurityObjectTouserRole>();
}
