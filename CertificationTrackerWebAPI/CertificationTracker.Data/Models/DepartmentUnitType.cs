using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DepartmentUnitType
{
    public decimal DepartmentUnitTypeId { get; set; }

    public int? DepartmentId { get; set; }

    public string? UnitTypeName { get; set; }

    public int? MappingCadunitTypeId { get; set; }

    public bool? IsActive { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<DepartmentUnit> DepartmentUnits { get; set; } = new List<DepartmentUnit>();
}
