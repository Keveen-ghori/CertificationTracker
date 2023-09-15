using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptArresteeListOp2
{
    public decimal ArrestBookingId { get; set; }

    public int? DepartmentId { get; set; }

    public string? ArrestNumber { get; set; }

    public DateTime? ArrestDateTime { get; set; }

    public int? PersonRaceCode { get; set; }

    public string? Race { get; set; }

    public int? PersonEthnicityCode { get; set; }

    public string? Ethnicity { get; set; }

    public int? PersonSexCode { get; set; }

    public string? Gender { get; set; }

    public string? FullName { get; set; }

    public string? SurName { get; set; }

    public DateTime? Dob { get; set; }

    public string? StatuteCode { get; set; }

    public string? Statue { get; set; }
}
