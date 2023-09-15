using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class NibrsreportPerson
{
    public decimal NibrsreportPersonsId { get; set; }

    public decimal? NibrsreportAdminId { get; set; }

    public decimal? Mpid { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public decimal? Moid { get; set; }

    public decimal? IncidentOrganizationInvolvementId { get; set; }

    public int? PersonType { get; set; }

    public int? Sequence { get; set; }

    public int? SexCode { get; set; }

    public int? RaceCode { get; set; }

    public int? EthnicityCode { get; set; }

    public int? ResidentStatusCode { get; set; }

    public string? VrelatedOffenseCode { get; set; }

    public string? VrelatedOffender { get; set; }

    public int? Vtype { get; set; }

    public int? VofficerActivity { get; set; }

    public int? VofficerAssignment { get; set; }

    public string? VotherOfficerOri { get; set; }

    public string? Vcircumstances { get; set; }

    public int? VcircumstancesAdditional { get; set; }

    public string? VinjuryCode { get; set; }

    public int? Atype { get; set; }

    public int? AmultipleArrest { get; set; }

    public int? AoffenseCode { get; set; }

    public string? Aweapon { get; set; }

    public int? Adisposition { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsInvolvementAddedByQa { get; set; }

    public string? UnknownPersonAge { get; set; }

    public bool? IsLeofromOtherJurisdiction { get; set; }

    public virtual NibrsreferenceDatum? AdispositionNavigation { get; set; }

    public virtual NibrsreferenceDatum? AmultipleArrestNavigation { get; set; }

    public virtual NibrsreferenceDatum? AtypeNavigation { get; set; }

    public virtual NibrsreferenceDatum? EthnicityCodeNavigation { get; set; }

    public virtual IncidentOrganizationInvolvement? IncidentOrganizationInvolvement { get; set; }

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }

    public virtual Mstrorganization? Mo { get; set; }

    public virtual Mstrperson? Mp { get; set; }

    public virtual NibrsreportAdmin? NibrsreportAdmin { get; set; }

    public virtual NibrsreferenceDatum? RaceCodeNavigation { get; set; }

    public virtual NibrsreferenceDatum? ResidentStatusCodeNavigation { get; set; }

    public virtual NibrsreferenceDatum? SexCodeNavigation { get; set; }

    public virtual NibrsreferenceDatum? VcircumstancesAdditionalNavigation { get; set; }

    public virtual NibrsreferenceDatum? VofficerActivityNavigation { get; set; }

    public virtual NibrsreferenceDatum? VofficerAssignmentNavigation { get; set; }

    public virtual NibrsreferenceDatum? VtypeNavigation { get; set; }
}
