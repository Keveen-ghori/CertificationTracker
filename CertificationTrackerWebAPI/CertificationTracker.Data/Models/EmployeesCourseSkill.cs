using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class EmployeesCourseSkill
{
    public decimal EmployeesCourseSkillId { get; set; }

    public int? CourseCode { get; set; }

    public int? CourseStatusCode { get; set; }

    public string? Instructor { get; set; }

    public string? Location { get; set; }

    public DateTime? StatusDataTime { get; set; }

    public DateTime? ReceivedDateTime { get; set; }

    public DateTime? Expires { get; set; }

    public DateTime? CourseDateTime { get; set; }

    public decimal? Score { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public decimal? Hours { get; set; }

    public virtual RefMiscReferenceDatum? CourseCodeNavigation { get; set; }

    public virtual RefMiscReferenceDatum? CourseStatusCodeNavigation { get; set; }
}
