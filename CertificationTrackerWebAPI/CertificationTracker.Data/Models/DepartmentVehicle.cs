using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DepartmentVehicle
{
    public decimal DepartmentVehicleId { get; set; }

    public int? DepartmentId { get; set; }

    public decimal? DepartmentOrgId { get; set; }

    public string? VehicleName { get; set; }

    public string? VehicleType { get; set; }

    public string? VehicleComputerName { get; set; }

    public string? Imei { get; set; }

    public string? Nimscategory { get; set; }

    public string? Nimskind { get; set; }

    public string? Nimsresource { get; set; }

    public string? NimsminCapability { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Simipaddress { get; set; }

    public string? MdtmodemIpaddress { get; set; }

    public string? Mdtipaddress { get; set; }

    public string? MdtmodemSerialNumber { get; set; }

    public int? MappingHbcadvehicleId { get; set; }

    public string? Vin { get; set; }

    public string? FleetNumber { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<DepartmentDailyRoster> DepartmentDailyRosters { get; set; } = new List<DepartmentDailyRoster>();

    public virtual DepartmentOrg? DepartmentOrg { get; set; }

    public virtual ICollection<DepartmentUnit> DepartmentUnits { get; set; } = new List<DepartmentUnit>();
}
