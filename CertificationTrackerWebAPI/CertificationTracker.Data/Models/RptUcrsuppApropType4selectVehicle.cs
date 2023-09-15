using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrsuppApropType4selectVehicle
{
    public int? DepartmentId { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public decimal? Value { get; set; }

    public string? Name { get; set; }

    public string Ucrtype { get; set; } = null!;

    public int? VehicleInvolvementCode { get; set; }
}
