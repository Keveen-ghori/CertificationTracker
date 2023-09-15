using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptArrestee
{
    public string? Department { get; set; }

    public decimal IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? ArrestDate { get; set; }

    public string? SurName { get; set; }

    public string? GivenName { get; set; }

    public int? PersonSexCode { get; set; }

    public string? Gender { get; set; }

    public int? PersonRaceCode { get; set; }

    public string? Race { get; set; }

    public int? PersonEthnicityCode { get; set; }

    public string? Ethnicity { get; set; }

    public DateTime? Dob { get; set; }

    public int? Age { get; set; }

    public decimal? Mpid { get; set; }

    public int? PersonInvolvementCode { get; set; }

    public int? IncidentStatusId { get; set; }

    public int? ReportStatusId { get; set; }

    public bool? IsMasterName { get; set; }

    public int? Rank { get; set; }

    public int? DepartmentId { get; set; }

    public string? Statute { get; set; }

    public string? StatuteCode { get; set; }

    public int? ReportDefinitionId { get; set; }

    public string? ReportGroup { get; set; }

    public string? LocationDetailDisplayString { get; set; }
}
