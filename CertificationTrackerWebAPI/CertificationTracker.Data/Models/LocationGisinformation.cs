using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class LocationGisinformation
{
    public int LocationGisinformationId { get; set; }

    public int? HitgislayerId { get; set; }

    public int? HitgeometryId { get; set; }

    public decimal? LocationId { get; set; }

    public string? HitgislayerName { get; set; }

    public string? HitgeometryName { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public virtual DepartmentGisgeometry? Hitgeometry { get; set; }

    public virtual DepartmentGislayer? Hitgislayer { get; set; }

    public virtual Mstrlocation? Location { get; set; }
}
