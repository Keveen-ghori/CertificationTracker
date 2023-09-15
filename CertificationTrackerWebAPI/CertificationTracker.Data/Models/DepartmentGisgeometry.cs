using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DepartmentGisgeometry
{
    public int GeometryId { get; set; }

    public int? GislayerId { get; set; }

    public int? DepartmentId { get; set; }

    public string? GisgeometryName { get; set; }

    public string? CadgeometryName { get; set; }

    public string? Description { get; set; }

    public bool? IsGeometryValidated { get; set; }

    public string? GeometryType { get; set; }

    public bool? IsActive { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public int? CadgeometryId { get; set; }

    public virtual Department? Department { get; set; }

    public virtual DepartmentGislayer? Gislayer { get; set; }

    public virtual ICollection<LocationGisinformation> LocationGisinformations { get; set; } = new List<LocationGisinformation>();
}
