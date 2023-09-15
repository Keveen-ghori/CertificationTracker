using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrhom1b1selectVictim
{
    public string? DepartName { get; set; }

    public int? DepartmentId { get; set; }

    public int? PersonInvolvementCode { get; set; }

    public decimal? Mpid { get; set; }

    public decimal? IncId { get; set; }

    public decimal? ArresteeInvolveIncId { get; set; }

    public string? VictimEthnicity { get; set; }

    public string? EthnicityCode { get; set; }

    public int? VictimAge { get; set; }

    public string? VictimSex { get; set; }

    public string? VictimRace { get; set; }

    public string? GenderCode { get; set; }

    public string? RaceCode { get; set; }

    public string? WeaponUsed { get; set; }

    public DateTime? DateofOccurrence { get; set; }

    public string? Circumstances { get; set; }

    public DateTime? CadreprotedDateTime { get; set; }

    public int? PersonRelationLnkcode { get; set; }

    public decimal? LinkedPersonId { get; set; }

    public decimal? PrimaryPersonId { get; set; }

    public string? VictimRelationship { get; set; }

    public int? Arrestee { get; set; }

    public string? UcrcodeDisplayName { get; set; }

    public int? IncidentStatusId { get; set; }
}
