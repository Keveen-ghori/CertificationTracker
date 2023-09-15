using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ImportInstructor
{
    public int Id { get; set; }

    public int? InstructorIdnumber { get; set; }

    public string? CertificationType { get; set; }

    public string? InstructorName { get; set; }

    public DateTime? InstructorExpiration { get; set; }

    public string? AreaCode { get; set; }

    public string? AreaDescription { get; set; }

    public bool? ImportedSuccessfully { get; set; }

    public int? DepartmentEmployeeId { get; set; }
}
