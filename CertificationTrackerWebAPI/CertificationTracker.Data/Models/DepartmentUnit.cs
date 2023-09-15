using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DepartmentUnit
{
    public decimal DepartmentUnitId { get; set; }

    public int? DepartmentId { get; set; }

    public decimal? DepartmentOrgId { get; set; }

    public decimal? DefaultVehicleId { get; set; }

    public decimal? DepartmentUnitTypeId { get; set; }

    public int? MappingCadunitId { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? UnitId { get; set; }

    public int? MaxNumberofOfficer { get; set; }

    public int? MinNumberofOfficer { get; set; }

    public virtual DepartmentVehicle? DefaultVehicle { get; set; }

    public virtual ICollection<DepOrgUnit> DepOrgUnits { get; set; } = new List<DepOrgUnit>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<DepartmentDailyRoster> DepartmentDailyRosters { get; set; } = new List<DepartmentDailyRoster>();

    public virtual DepartmentOrg? DepartmentOrg { get; set; }

    public virtual DepartmentUnitType? DepartmentUnitType { get; set; }
}
