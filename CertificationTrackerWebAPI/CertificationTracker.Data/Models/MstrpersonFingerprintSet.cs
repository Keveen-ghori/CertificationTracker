using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpersonFingerprintSet
{
    public decimal MpfingerprintSetId { get; set; }

    public decimal? Mpid { get; set; }

    public int? FingerPositionCode { get; set; }

    public int? FingerPositionIndicatorCode { get; set; }

    public string? FingerprintSetData { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public bool? IsConfidential { get; set; }

    public string? Description { get; set; }

    public virtual RefMstrinxreferenceDatum? FingerPositionCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? FingerPositionIndicatorCodeNavigation { get; set; }

    public virtual Mstrperson? Mp { get; set; }
}
