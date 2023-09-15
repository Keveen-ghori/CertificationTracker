using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DepartmentGislayer
{
    public int GislayerId { get; set; }

    public int? DepartmentId { get; set; }

    public string? CadgislayerName { get; set; }

    public string? GislayerName { get; set; }

    public string? Description { get; set; }

    public string? KeyAttributeName { get; set; }

    public TimeSpan? StartTime { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public TimeSpan? EndTime { get; set; }

    public bool? IsActive { get; set; }

    public int? Weight { get; set; }

    public int? DisplaySeq { get; set; }

    public bool? IsDefinedByCad { get; set; }

    public bool? IsCadaliasLayer { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public int? CadgislayerId { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<DepartmentGisgeometry> DepartmentGisgeometries { get; set; } = new List<DepartmentGisgeometry>();

    public virtual ICollection<LocationGisinformation> LocationGisinformations { get; set; } = new List<LocationGisinformation>();
}
