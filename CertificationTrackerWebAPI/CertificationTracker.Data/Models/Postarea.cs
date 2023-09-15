using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Postarea
{
    public decimal PostareaId { get; set; }

    public decimal? PostcurriculumAreaId { get; set; }

    public string? Area { get; set; }

    public string? AreaDescription { get; set; }

    public int? MandatedHours { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsRequired { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? EditedName { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<PostcourseArea> PostcourseAreas { get; set; } = new List<PostcourseArea>();

    public virtual PostcurriculumArea? PostcurriculumArea { get; set; }

    public virtual ICollection<PostemployeeCourseArea> PostemployeeCourseAreas { get; set; } = new List<PostemployeeCourseArea>();

    public virtual ICollection<PostinstructorCertifiedArea> PostinstructorCertifiedAreas { get; set; } = new List<PostinstructorCertifiedArea>();
}
