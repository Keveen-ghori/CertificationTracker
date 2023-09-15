using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PostcurriculumArea
{
    public decimal PostcurriculumAreaId { get; set; }

    public string? GeneralArea { get; set; }

    public string? AreaDescription { get; set; }

    public int? MandatedHours { get; set; }

    public int? MaximumHours { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? EditedName { get; set; }

    public virtual ICollection<Postarea> Postareas { get; set; } = new List<Postarea>();
}
