using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PostcourseArea
{
    public decimal PostcourseAreaId { get; set; }

    public decimal? PostcourseId { get; set; }

    public decimal? PostareaId { get; set; }

    public decimal? AreaCredits { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? EditedName { get; set; }

    public string? PostinstructorDetail { get; set; }

    public string? PostoutSideInstructorDetail { get; set; }

    public virtual Postarea? Postarea { get; set; }

    public virtual Postcourse? Postcourse { get; set; }
}
