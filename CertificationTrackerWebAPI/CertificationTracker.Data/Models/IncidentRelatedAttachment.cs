using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentRelatedAttachment
{
    public decimal IncidentRelatedAttachmentId { get; set; }

    public decimal? IncidentId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public decimal? IncidentVehicleInvolvementId { get; set; }

    public decimal? IncidentPropertyInvolvementId { get; set; }

    public string? AttachmentName { get; set; }

    public string? AttachmentType { get; set; }

    public byte[]? AttachmentContent { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public string? Comment { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public string? AttachmentContentPath { get; set; }

    public virtual Incident? Incident { get; set; }

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }

    public virtual IncidentPropertyInvolvement? IncidentPropertyInvolvement { get; set; }

    public virtual IncidentVehicleInvolvement? IncidentVehicleInvolvement { get; set; }
}
