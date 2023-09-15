using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PhotoLineupViewer
{
    public decimal PhotoLineupViewerId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public decimal? SelectedPhotoId { get; set; }

    public decimal? PhotoLineupSequenceId { get; set; }

    public decimal? PhotoLineupId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }

    public virtual PhotoLineup? PhotoLineup { get; set; }

    public virtual PhotoLineupSequence? PhotoLineupSequence { get; set; }

    public virtual ICollection<PhotoLineupSequence> PhotoLineupSequences { get; set; } = new List<PhotoLineupSequence>();

    public virtual PhotoLineupPhoto? SelectedPhoto { get; set; }
}
