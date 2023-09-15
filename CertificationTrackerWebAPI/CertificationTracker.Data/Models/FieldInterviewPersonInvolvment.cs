using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class FieldInterviewPersonInvolvment
{
    public decimal FieldInterviewPersonInvolvmentId { get; set; }

    public decimal? Mpid { get; set; }

    public decimal? FieldInterviewId { get; set; }

    public int? PersonInvolvementCode { get; set; }

    public decimal? RelatedVehicleInvolvmentId { get; set; }

    public string? Comments { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual FieldInterview? FieldInterview { get; set; }

    public virtual ICollection<HelpQueryPersonInvolvement> HelpQueryPersonInvolvements { get; set; } = new List<HelpQueryPersonInvolvement>();

    public virtual Mstrperson? Mp { get; set; }

    public virtual RefMiscReferenceDatum? PersonInvolvementCodeNavigation { get; set; }

    public virtual FieldInterviewVehicleInvolvment? RelatedVehicleInvolvment { get; set; }
}
