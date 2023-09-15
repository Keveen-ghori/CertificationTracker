using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class CrashRelatedAttachment
{
    public decimal CrashRelatedAttachmentId { get; set; }

    public decimal? CrashId { get; set; }

    public decimal? CrashPropertyInvolvementId { get; set; }

    public decimal? CrashVehicleInvolvementId { get; set; }

    public decimal? CrashPersonInvolvementId { get; set; }

    public string? AttachmentName { get; set; }

    public string? AttachmentType { get; set; }

    public byte[]? AttachmentContent { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public string? Comment { get; set; }

    public string? AttachmentContentPath { get; set; }

    public virtual Crash? Crash { get; set; }

    public virtual CrashPersonInvolvement? CrashPersonInvolvement { get; set; }

    public virtual CrashPropertyInvolvement? CrashPropertyInvolvement { get; set; }

    public virtual CrashVehicleInvolvement? CrashVehicleInvolvement { get; set; }
}
