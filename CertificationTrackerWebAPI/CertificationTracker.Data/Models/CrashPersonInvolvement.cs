using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class CrashPersonInvolvement
{
    public decimal CrashPersonInvolvementId { get; set; }

    public decimal? CrashId { get; set; }

    public decimal? RelatedtoVehicleInvolvementId { get; set; }

    public decimal? NonVerifiedPersonId { get; set; }

    public decimal? Mpid { get; set; }

    public int? CrashPersonInvolvementCode { get; set; }

    public string? CrashPersonInvolvementDetailXml { get; set; }

    public string? InjuryCode { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public bool? IsConfidential { get; set; }

    public bool? IsIndividualSecurityApply { get; set; }

    public string? Source { get; set; }

    public string? Comment { get; set; }

    public virtual Crash? Crash { get; set; }

    public virtual RefCrashReferenceDatum? CrashPersonInvolvementCodeNavigation { get; set; }

    public virtual CrashPersonSummaryDatum? CrashPersonSummaryDatum { get; set; }

    public virtual ICollection<CrashPropertyInvolvement> CrashPropertyInvolvements { get; set; } = new List<CrashPropertyInvolvement>();

    public virtual ICollection<CrashRelatedAttachment> CrashRelatedAttachments { get; set; } = new List<CrashRelatedAttachment>();

    public virtual ICollection<HelpQueryPersonInvolvement> HelpQueryPersonInvolvements { get; set; } = new List<HelpQueryPersonInvolvement>();

    public virtual ICollection<IndividualSecurityToUser> IndividualSecurityToUsers { get; set; } = new List<IndividualSecurityToUser>();

    public virtual Mstrperson? Mp { get; set; }

    public virtual NonVerifiedCallPerson? NonVerifiedPerson { get; set; }

    public virtual CrashVehicleInvolvement? RelatedtoVehicleInvolvement { get; set; }
}
