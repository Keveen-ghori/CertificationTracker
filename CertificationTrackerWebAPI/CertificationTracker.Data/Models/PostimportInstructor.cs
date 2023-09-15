using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PostimportInstructor
{
    public int PostimportInstructorsId { get; set; }

    public int? InstructorNumber { get; set; }

    public string? SponsorName { get; set; }

    public string? ImportLastName { get; set; }

    public string? ImportFirstName { get; set; }

    public string? LastName { get; set; }

    public string? Suffix { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? Rank { get; set; }

    public string? CertificationType { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public DateTime? ImportDate { get; set; }

    public string? ProcessStatus { get; set; }

    public DateTime? ProcessDate { get; set; }

    public int? EmployeeId { get; set; }

    public int? DepartmentId { get; set; }

    public string? ProcessError { get; set; }

    public bool? IsImported { get; set; }

    public string? LastInstructorChange { get; set; }

    public virtual ICollection<PostimportInstructorArea> PostimportInstructorAreas { get; set; } = new List<PostimportInstructorArea>();
}
