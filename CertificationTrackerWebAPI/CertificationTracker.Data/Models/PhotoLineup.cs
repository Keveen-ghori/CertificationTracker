using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PhotoLineup
{
    public decimal PhotoLineupId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public decimal? IncidentId { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public string? PhotoLineupNumber { get; set; }

    public int? StatusId { get; set; }

    public string? Comment { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual Incident? Incident { get; set; }

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }

    public virtual ICollection<PhotoLineupPhoto> PhotoLineupPhotos { get; set; } = new List<PhotoLineupPhoto>();

    public virtual ICollection<PhotoLineupViewer> PhotoLineupViewers { get; set; } = new List<PhotoLineupViewer>();

    public virtual Incident? PrimaryIncident { get; set; }

    public virtual SysApplicationStatus? Status { get; set; }
}
