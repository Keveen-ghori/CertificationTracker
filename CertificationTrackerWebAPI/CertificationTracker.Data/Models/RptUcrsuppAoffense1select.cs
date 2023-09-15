using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrsuppAoffense1select
{
    public int? DepartmentId { get; set; }

    public string? Department { get; set; }

    public decimal IncidentId { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public string? CategoryGroup { get; set; }

    public string? DropdownDescription { get; set; }

    public int? Offense { get; set; }

    public int? UcrcodeId { get; set; }

    public bool? IsPrimary { get; set; }

    public string? Ucrcode { get; set; }

    public string? UcrcodeDisplayName { get; set; }

    public decimal? Value { get; set; }

    public decimal? EstimatedVehicleValue { get; set; }

    public decimal? PropertyValue { get; set; }

    public decimal? VehicleValue { get; set; }

    public decimal? PropertyId { get; set; }
}
