using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Ticket
{
    public decimal TicketId { get; set; }

    public decimal? ViolatorId { get; set; }

    public decimal? RelatedVehicleId { get; set; }

    public decimal? ViolationLocationId { get; set; }

    public int? ReportedEmployeeId { get; set; }

    public int? DepartmentId { get; set; }

    public int? MstrnarrativeTemplateId { get; set; }

    public string? TicketType { get; set; }

    public string? TicketNumber { get; set; }

    public DateTime? TicketCreatedDateTime { get; set; }

    public DateTime? ViolationDateTime { get; set; }

    public DateTime? LastReviewDateTime { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public decimal? TotallAmountDue { get; set; }

    public string? TicketStatus { get; set; }

    public string? Narrative { get; set; }

    public string? NarrativeEditedName { get; set; }

    public DateTime? NarrativeEditedOn { get; set; }

    public string? Description { get; set; }

    public virtual Department? Department { get; set; }

    public virtual RefNarrativeTemplate? MstrnarrativeTemplate { get; set; }

    public virtual Mstrvehicle? RelatedVehicle { get; set; }

    public virtual DepartmentEmployee? ReportedEmployee { get; set; }

    public virtual ICollection<TicketViolation> TicketViolations { get; set; } = new List<TicketViolation>();

    public virtual Mstrlocation? ViolationLocation { get; set; }

    public virtual Mstrperson? Violator { get; set; }
}
