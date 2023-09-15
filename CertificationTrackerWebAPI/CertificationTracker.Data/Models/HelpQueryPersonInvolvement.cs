using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class HelpQueryPersonInvolvement
{
    public decimal MstrpersonApplictionInvolvementId { get; set; }

    public decimal? Mpid { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public decimal? CrashPersonInvolvementId { get; set; }

    public decimal? TrafficStopId { get; set; }

    public int? ApplicationType { get; set; }

    public decimal? FieldInterviewPersonInvolvmentId { get; set; }

    public string? InvolvementCode { get; set; }

    public string? ApplicationNumber { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public int? InvolvementRefCodeId { get; set; }

    public string? InvolvementRefCodeTable { get; set; }

    public string? MasterIndexTable { get; set; }

    public decimal? MasterIndexId { get; set; }

    public string? FieldName { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual CrashPersonInvolvement? CrashPersonInvolvement { get; set; }

    public virtual FieldInterviewPersonInvolvment? FieldInterviewPersonInvolvment { get; set; }

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }

    public virtual Mstrperson? Mp { get; set; }

    public virtual TrafficStop? TrafficStop { get; set; }
}
