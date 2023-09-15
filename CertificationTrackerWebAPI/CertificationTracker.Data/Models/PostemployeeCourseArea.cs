using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PostemployeeCourseArea
{
    public decimal PostemployeeCourseAreaId { get; set; }

    public decimal? PostemployeeCourseId { get; set; }

    public decimal? PostareaId { get; set; }

    public decimal? CreditEarned { get; set; }

    public bool? IsPastEmployeeCourseArea { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? EditedName { get; set; }

    public virtual Postarea? Postarea { get; set; }

    public virtual PostemployeeCourse? PostemployeeCourse { get; set; }
}
