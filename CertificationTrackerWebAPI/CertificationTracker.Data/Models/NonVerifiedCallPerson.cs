using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class NonVerifiedCallPerson
{
    public decimal ServiceCallPersonId { get; set; }

    public decimal? ServiceCallId { get; set; }

    public int? CadpersonId { get; set; }

    public string? PhoneNumber { get; set; }

    public string? CallBackPhoneNumber { get; set; }

    public string? CreatedBy { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Source { get; set; }

    public string? Name { get; set; }

    public bool? IsActive { get; set; }

    public string? Oln { get; set; }

    public string? Olnstate { get; set; }

    public DateTime? Dob { get; set; }

    public bool? IsConfidential { get; set; }

    public string? Description { get; set; }

    public string? PersonType { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public bool? IsReviewedbyOfficer { get; set; }

    public decimal? ResidentialAddress { get; set; }

    public int? ApplicationType { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public string? MiddleName { get; set; }

    public decimal? LinkedMpid { get; set; }

    public int? SexCodeId { get; set; }

    public decimal? GeneratedByRmsuserQueryResultId { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual ICollection<CrashPersonInvolvement> CrashPersonInvolvements { get; set; } = new List<CrashPersonInvolvement>();

    public virtual ICollection<IncidentPersonInvolvement> IncidentPersonInvolvements { get; set; } = new List<IncidentPersonInvolvement>();

    public virtual Mstrperson? LinkedMp { get; set; }

    public virtual ICollection<MstrvehicleRegOwner> MstrvehicleRegOwners { get; set; } = new List<MstrvehicleRegOwner>();

    public virtual Mstrlocation? ResidentialAddressNavigation { get; set; }

    public virtual ServiceCall? ServiceCall { get; set; }

    public virtual ICollection<ServiceCallQuestionAnswer> ServiceCallQuestionAnswers { get; set; } = new List<ServiceCallQuestionAnswer>();

    public virtual RefMstrinxreferenceDatum? SexCode { get; set; }

    public virtual ICollection<TrxBackgroundCheck> TrxBackgroundChecks { get; set; } = new List<TrxBackgroundCheck>();
}
