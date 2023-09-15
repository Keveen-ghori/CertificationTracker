using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptArrestByRaceSex
{
    public int? DepartmentId { get; set; }

    public decimal? IncidentId { get; set; }

    public decimal ArrestBookingId { get; set; }

    public string? Department { get; set; }

    public DateTime? ArrestDate { get; set; }

    public int? PersonRaceCode { get; set; }

    public int? PersonSexCode { get; set; }

    public string? Race { get; set; }

    public string? Gender { get; set; }

    public decimal Mpid { get; set; }

    public int? PersonInvolvementCode { get; set; }

    public int? ReportStatusId { get; set; }
}
