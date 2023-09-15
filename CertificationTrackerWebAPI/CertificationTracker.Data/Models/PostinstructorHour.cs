using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PostinstructorHour
{
    public decimal PostinstructorHoursId { get; set; }

    public decimal? PostinstructorCertifiedAreaId { get; set; }

    public DateTime? CompletedDate { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public bool? IsInsideInstructor { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? EditedName { get; set; }

    public decimal? PostcourseId { get; set; }

    public virtual Postcourse? Postcourse { get; set; }
}
