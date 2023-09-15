using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpersonName
{
    public decimal Mpnid { get; set; }

    public decimal? Mpid { get; set; }

    public int? NameCategoryCode { get; set; }

    public int? PersonSexCode { get; set; }

    public int? ApplicationType { get; set; }

    public string? GivenName { get; set; }

    public string? MiddleName { get; set; }

    public string? SurName { get; set; }

    public string? NameSuffixText { get; set; }

    public string? MaidenName { get; set; }

    public string? NameInitialsText { get; set; }

    public string? NamePrefixText { get; set; }

    public bool? IsMasterName { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public bool? IsConfidential { get; set; }

    public string? SearchName { get; set; }

    public string? Description { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public DateTime? Dob { get; set; }

    public int? DobyearTo { get; set; }

    public int? DobyearFrom { get; set; }

    public bool? IsUscitizen { get; set; }

    public string? CopiedFromSource { get; set; }

    public string? CopiedFromPersonId { get; set; }

    public DateTime? CopiedOn { get; set; }

    public string? CopiedByName { get; set; }

    public string? FullName { get; set; }

    public bool? IsApplicationMasterEntry { get; set; }

    public string? Ssnidentification { get; set; }

    public decimal? CopiedFromPrpersonMpnid { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual Mstrperson? Mp { get; set; }

    public virtual RefMstrinxreferenceDatum? NameCategoryCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? PersonSexCodeNavigation { get; set; }
}
