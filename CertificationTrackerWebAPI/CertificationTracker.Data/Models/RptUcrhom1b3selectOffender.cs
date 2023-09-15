using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrhom1b3selectOffender
{
    public string? UcrcodeDisplayName { get; set; }

    public string? DepartName { get; set; }

    public int DepartmentId { get; set; }

    public decimal Mpid { get; set; }

    public decimal IncId { get; set; }

    public int? OffenderAge { get; set; }

    public string? OffenderSex { get; set; }

    public string? GenderCode { get; set; }

    public string? OffenderRace { get; set; }

    public string? RaceCode { get; set; }

    public string? OffenderEthnicity { get; set; }

    public string? EthnicityCode { get; set; }

    public string? WeaponUsed { get; set; }

    public DateTime? DateofOccurrence { get; set; }

    public string? Circumstances { get; set; }

    public DateTime? CadreprotedDateTime { get; set; }

    public int? Offender { get; set; }

    public DateTime? Dob { get; set; }

    public string? Ucrcode { get; set; }

    public int? IncidentStatusId { get; set; }

    public bool? IsPrimary { get; set; }
}
