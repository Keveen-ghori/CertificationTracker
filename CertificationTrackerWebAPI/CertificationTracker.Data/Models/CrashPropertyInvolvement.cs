using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class CrashPropertyInvolvement
{
    public decimal CrashPropertyInvolvementId { get; set; }

    public decimal? CrashId { get; set; }

    public decimal? Mppid { get; set; }

    public int? CrashPropertyInvolvementCode { get; set; }

    public decimal? RelatedVehicleInvolvementId { get; set; }

    public decimal? RelatedPersonInvolvementId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public bool? IsConfidential { get; set; }

    public string? Source { get; set; }

    public string? Comment { get; set; }

    public bool? IsDamageThresholdMet { get; set; }

    public int? NumberofnonMotorists { get; set; }

    public virtual Crash? Crash { get; set; }

    public virtual RefCrashReferenceDatum? CrashPropertyInvolvementCodeNavigation { get; set; }

    public virtual ICollection<CrashRelatedAttachment> CrashRelatedAttachments { get; set; } = new List<CrashRelatedAttachment>();

    public virtual ICollection<HelpQueryPropertyInvolvement> HelpQueryPropertyInvolvements { get; set; } = new List<HelpQueryPropertyInvolvement>();

    public virtual Mstrproperty? Mpp { get; set; }

    public virtual CrashPersonInvolvement? RelatedPersonInvolvement { get; set; }

    public virtual CrashVehicleInvolvement? RelatedVehicleInvolvement { get; set; }
}
