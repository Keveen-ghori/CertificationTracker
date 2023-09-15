using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class FieldInterviewVehicleInvolvment
{
    public decimal FieldInterviewVehicleInvolvmentId { get; set; }

    public decimal? Mvid { get; set; }

    public decimal? FieldInterviewId { get; set; }

    public int? VehicleInvolvementCode { get; set; }

    public string? Comments { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public decimal? TowRequestId { get; set; }

    public virtual FieldInterview? FieldInterview { get; set; }

    public virtual ICollection<FieldInterviewPersonInvolvment> FieldInterviewPersonInvolvments { get; set; } = new List<FieldInterviewPersonInvolvment>();

    public virtual ICollection<HelpQueryVehicleInvolvement> HelpQueryVehicleInvolvements { get; set; } = new List<HelpQueryVehicleInvolvement>();

    public virtual Mstrvehicle? Mv { get; set; }

    public virtual TowRequest? TowRequest { get; set; }

    public virtual RefMiscReferenceDatum? VehicleInvolvementCodeNavigation { get; set; }
}
