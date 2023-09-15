using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptTrafficStopOp
{
    public int? DepartmentId { get; set; }

    public string? Name { get; set; }

    public string? TrafficStopNumber { get; set; }

    public DateTime? TrafficStopDateTime { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? DepEmployeeId { get; set; }

    public string? BadgeNumber { get; set; }

    public string? FullName { get; set; }

    public string? LocationShortDisplayString { get; set; }

    public string? LocationDetailDisplayString { get; set; }

    public string? Statue { get; set; }

    public string? StatuteCode { get; set; }

    public string? OffenseType { get; set; }

    public string? ShortName { get; set; }

    public string? HouseNumber { get; set; }

    public string? Location { get; set; }

    public string? Apartment { get; set; }

    public string? Floor { get; set; }

    public string? Building { get; set; }

    public string? Unit { get; set; }

    public string? Suite { get; set; }

    public string? City { get; set; }

    public decimal LocationId { get; set; }

    public int? TrafficStopResultCode { get; set; }

    public string? Result { get; set; }
}
