using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PostinstructorCertifiedArea
{
    public decimal PostinstructorCertifiedAreaId { get; set; }

    public decimal? PostinstructorId { get; set; }

    public decimal? PostoutSideInstructorId { get; set; }

    public decimal? PostareaId { get; set; }

    public DateTime? DateOfIssue { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? EditedName { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual Postarea? Postarea { get; set; }

    public virtual Postinstructor? Postinstructor { get; set; }

    public virtual PostoutSideInstructor? PostoutSideInstructor { get; set; }
}
