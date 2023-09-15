using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrhom1b2countVictim
{
    public int? NumOfVictim { get; set; }

    public decimal? Mpid { get; set; }

    public string? Ucrcategory { get; set; }

    public decimal? IncidentId { get; set; }

    public string? DepartmentName { get; set; }

    public int? DepartmentId { get; set; }

    public int? VictimAge { get; set; }

    public string? VictimSex { get; set; }

    public string? VictimRace { get; set; }

    public string? VictimEthnicity { get; set; }

    public string? WeaponUsed { get; set; }

    public DateTime? DateofOccurrence { get; set; }

    public string? Circumstances { get; set; }

    public DateTime? CadreprotedDateTime { get; set; }

    public string? VictimRelationship { get; set; }

    public decimal? LinkedPersonId { get; set; }

    public string? RaceCode { get; set; }

    public string? GenderCode { get; set; }

    public string? EthnicityCode { get; set; }
}
