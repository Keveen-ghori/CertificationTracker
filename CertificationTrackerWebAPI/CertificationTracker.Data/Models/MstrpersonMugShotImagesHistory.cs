using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpersonMugShotImagesHistory
{
    public decimal? MstrpersonMugShotImageId { get; set; }

    public decimal? MstrpersonMugShotId { get; set; }

    public int? MugShotImageTypeCode { get; set; }

    public byte[]? ImageContent { get; set; }

    public string? ImageContentPath { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public string? OperationPerformed { get; set; }

    public DateTime? OperationPerformedTime { get; set; }
}
