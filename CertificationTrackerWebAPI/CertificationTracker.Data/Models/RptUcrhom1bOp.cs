using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrhom1bOp
{
    public decimal? Id { get; set; }

    public int? NumberOfVictim { get; set; }

    public int? NumberOfOffender { get; set; }

    public string? Classification { get; set; }

    public decimal? Mpid { get; set; }

    public int? VictimAge { get; set; }

    public string? VictimSex { get; set; }

    public string? VictimRace { get; set; }

    public string? VictimEthnicity { get; set; }

    public decimal? Mpid2 { get; set; }

    public int? OffenderAge { get; set; }

    public string? OffenderSex { get; set; }

    public string? OffenderRace { get; set; }

    public string? OffenderEthnicity { get; set; }

    public string? WeaponUsed { get; set; }

    public string? VictimRelationship { get; set; }

    public DateTime? OccurDate { get; set; }

    public string? Circumstances { get; set; }

    public int? DepartmentId { get; set; }

    public int? DepartmentId3 { get; set; }

    public int? DepartmentId2 { get; set; }

    public string? RaceCodeVic { get; set; }

    public string? GenderCodeVic { get; set; }

    public string? EthnicityCodeVic { get; set; }

    public string? GenderCodeOff { get; set; }

    public string? RaceCodeOff { get; set; }

    public string? EthnicityCodeOff { get; set; }
}
