using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PhotoLineupSequence
{
    public decimal PhotoLineupSequenceId { get; set; }

    public decimal? PhotoLineupViewerId { get; set; }

    public decimal? PhotoLineupPhotoId { get; set; }

    public int? Sequence { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual PhotoLineupPhoto? PhotoLineupPhoto { get; set; }

    public virtual PhotoLineupViewer? PhotoLineupViewer { get; set; }

    public virtual ICollection<PhotoLineupViewer> PhotoLineupViewers { get; set; } = new List<PhotoLineupViewer>();
}
