using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class HelpQueryPropertyInvolvement
{
    public decimal HelpQueryPropertyInvolvementId { get; set; }

    public decimal? Mppid { get; set; }

    public decimal? CrashPropertyInvolvementId { get; set; }

    public decimal? IncidentPropertyInvolvementId { get; set; }

    public int? ApplicationType { get; set; }

    public string? InvolvementCode { get; set; }

    public string? ApplicationNumber { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public int? InvolvementRefCodeId { get; set; }

    public string? InvolvementRefCodeTable { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual CrashPropertyInvolvement? CrashPropertyInvolvement { get; set; }

    public virtual IncidentPropertyInvolvement? IncidentPropertyInvolvement { get; set; }

    public virtual Mstrproperty? Mpp { get; set; }
}
