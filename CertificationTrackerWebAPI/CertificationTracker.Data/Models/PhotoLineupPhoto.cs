using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PhotoLineupPhoto
{
    public decimal PhotoLineupPhotoId { get; set; }

    public decimal? PhotoLineupId { get; set; }

    public string? AttachmentName { get; set; }

    public string? PersonName { get; set; }

    public DateTime? Dob { get; set; }

    public string? CaseNumber { get; set; }

    public int? DepartmentId { get; set; }

    public string? Source { get; set; }

    public string? Comment { get; set; }

    public bool? IsSuspect { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual Department? Department { get; set; }

    public virtual PhotoLineup? PhotoLineup { get; set; }

    public virtual ICollection<PhotoLineupSequence> PhotoLineupSequences { get; set; } = new List<PhotoLineupSequence>();

    public virtual ICollection<PhotoLineupViewer> PhotoLineupViewers { get; set; } = new List<PhotoLineupViewer>();
}
