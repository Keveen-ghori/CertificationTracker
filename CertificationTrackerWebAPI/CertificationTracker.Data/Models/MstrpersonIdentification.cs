using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpersonIdentification
{
    public decimal MpidentificationId { get; set; }

    public decimal? Mpid { get; set; }

    public int? IdcategoryCode { get; set; }

    public DateTime? IdentificationEffectiveDate { get; set; }

    public DateTime? IdentificationExpirationDate { get; set; }

    public string? Iddata { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public bool? IsConfidential { get; set; }

    public string? Description { get; set; }

    public decimal? CopiedFromPrpersonMpidentificationId { get; set; }

    public virtual RefMstrinxreferenceDatum? IdcategoryCodeNavigation { get; set; }

    public virtual Mstrperson? Mp { get; set; }
}
