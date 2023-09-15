using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrlocationAlert
{
    public decimal MstrlocationAlertId { get; set; }

    public decimal? LocationId { get; set; }

    public int? ApplicationType { get; set; }

    public int? AlertTypeCode { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? Description { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public int? Rank { get; set; }

    public bool? IsActive { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public virtual RefMstrinxreferenceDatum? AlertTypeCodeNavigation { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual Mstrlocation? Location { get; set; }
}
