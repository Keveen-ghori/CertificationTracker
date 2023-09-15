using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Postcourse
{
    public decimal PostcourseId { get; set; }

    public decimal? PostcostPeriodId { get; set; }

    public string? CourseTitle { get; set; }

    public string? Sponsor { get; set; }

    public DateTime? CourseStartDate { get; set; }

    public DateTime? CourseEndDate { get; set; }

    public decimal? CourseHours { get; set; }

    public decimal? CourseFee { get; set; }

    public bool? CertifiedCourse { get; set; }

    public bool? OutOfDepartment { get; set; }

    public string? Street { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public string? Zip { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? DepartmentEmployeeXml { get; set; }

    public decimal? AttendenceHours { get; set; }

    public int? DepartmentId { get; set; }

    public string? AddressName { get; set; }

    public string? Comments { get; set; }

    public bool? IsCompletedCourse { get; set; }

    public virtual Department? Department { get; set; }

    public virtual PostcostPeriod? PostcostPeriod { get; set; }

    public virtual ICollection<PostcourseArea> PostcourseAreas { get; set; } = new List<PostcourseArea>();

    public virtual ICollection<PostcourseAttachment> PostcourseAttachments { get; set; } = new List<PostcourseAttachment>();

    public virtual ICollection<PostemployeeCourse> PostemployeeCourses { get; set; } = new List<PostemployeeCourse>();

    public virtual ICollection<PostinstructorHour> PostinstructorHours { get; set; } = new List<PostinstructorHour>();
}
