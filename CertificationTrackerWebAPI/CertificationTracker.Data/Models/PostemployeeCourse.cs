using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PostemployeeCourse
{
    public decimal PostemployeeCourseId { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public decimal? PostcourseId { get; set; }

    public decimal? AttendenceHours { get; set; }

    public bool? Passed { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }

    public virtual Postcourse? Postcourse { get; set; }

    public virtual ICollection<PostemployeeCourseArea> PostemployeeCourseAreas { get; set; } = new List<PostemployeeCourseArea>();
}
