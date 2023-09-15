using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrxref1arrestee
{
    public int? DepartmentId { get; set; }

    public string? Department { get; set; }

    public decimal? IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public int? PersonEthnicityCode { get; set; }

    public string? Ethnicity { get; set; }

    public int? PersonRaceCode { get; set; }

    public string? Race { get; set; }

    public int? PersonSexCode { get; set; }

    public string? Gender { get; set; }

    public DateTime? Dob { get; set; }

    public int? Age { get; set; }

    public decimal? Mpid { get; set; }

    public int? PersonInvolvementCode { get; set; }

    public int? IncidentStatusId { get; set; }

    public int? ReportStatusId { get; set; }

    public DateTime? ArrestDateTime { get; set; }

    public bool? IsApplicationMasterEntry { get; set; }

    public int? ApplicationType { get; set; }

    public decimal? ApplicationTypePk { get; set; }
}
