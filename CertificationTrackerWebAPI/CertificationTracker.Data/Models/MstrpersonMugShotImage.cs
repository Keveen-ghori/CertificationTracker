using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpersonMugShotImage
{
    public decimal MstrpersonMugShotImageId { get; set; }

    public decimal? MstrpersonMugShotId { get; set; }

    public int? MugShotImageTypeCode { get; set; }

    public byte[]? ImageContent { get; set; }

    public string? ImageContentPath { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public decimal? ActualIncidentIdforArrest { get; set; }

    public bool? FileExists { get; set; }

    public DateTime? AddedonBeforeCorrection { get; set; }

    public decimal? ActualIncidentIdforArrestBeforeCorrection { get; set; }

    public string? AddedNameBeforeCorrection { get; set; }

    public string? CopiedByName { get; set; }

    public DateTime? CopiedOn { get; set; }

    public decimal? CopiedFromPrpersonMstrpersonMugShotImageId { get; set; }

    public virtual MstrpersonMugShot? MstrpersonMugShot { get; set; }

    public virtual RefMstrinxreferenceDatum? MugShotImageTypeCodeNavigation { get; set; }
}
