using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptArresteeListOp
{
    public string? Department { get; set; }

    public decimal? IncidentId { get; set; }

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

    public int? StatusId { get; set; }

    public bool? IsApplicationMasterEntry { get; set; }

    public string? PrimaryUcrcode { get; set; }

    public string? PrimaryUcr { get; set; }

    public int? Rank { get; set; }

    public int? DepartmentId { get; set; }

    public string? Statute { get; set; }

    public string? StatuteCode { get; set; }

    public string? Block { get; set; }

    public string? Cell { get; set; }

    public string? FullName { get; set; }

    public string? ArrestNumber { get; set; }

    public string? Comments { get; set; }

    public string? Other { get; set; }
}
