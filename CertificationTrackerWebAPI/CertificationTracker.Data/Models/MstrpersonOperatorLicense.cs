using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpersonOperatorLicense
{
    public decimal MpoperatorLicenseId { get; set; }

    public decimal? Mpid { get; set; }

    public int? DriverLicenseClassificationCode { get; set; }

    public int? DriverLicenseStatusCode { get; set; }

    public int? DrivingRestrictionCode { get; set; }

    public int? DriverLicenseState { get; set; }

    public int? DriverLicenseJurisdictionCode { get; set; }

    public int? ApplicationType { get; set; }

    public string? DriverLicenseNumber { get; set; }

    public DateTime? DriverLicenseExpirationDate { get; set; }

    public DateTime? DriverLicenseIssueDate { get; set; }

    public DateTime? DrivingRestrictionEndDate { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? Description { get; set; }

    public bool? IsCurrentLicense { get; set; }

    public bool? IsCommericalLicense { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public string? DriverLicenseEndorsementCodeLst { get; set; }

    public string? CopiedFromSource { get; set; }

    public string? CopiedFromPersonId { get; set; }

    public DateTime? CopiedOn { get; set; }

    public string? CopiedByName { get; set; }

    public string? Dups { get; set; }

    public DateTime? ExpDate { get; set; }

    public DateTime? RenewDate { get; set; }

    public DateTime? CancelDate { get; set; }

    public DateTime? SuspDate { get; set; }

    public string? Suspended { get; set; }

    public string? WithPend { get; set; }

    public string? Restrictions { get; set; }

    public string? Cdl { get; set; }

    public string? Pptp { get; set; }

    public string? OrganDonor { get; set; }

    public string? CancelState { get; set; }

    public string? Idcard { get; set; }

    public decimal? CopiedFromPrpersonMpoperatorLicenseId { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? DriverLicenseClassificationCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? DriverLicenseJurisdictionCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? DriverLicenseStateNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? DriverLicenseStatusCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? DrivingRestrictionCodeNavigation { get; set; }

    public virtual Mstrperson? Mp { get; set; }
}
