using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ImportPostcourse
{
    public int PrimaryId { get; set; }

    public string? CourseName { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public bool? ImportedSuccessfully { get; set; }

    public int? DepartmentEmployeeId { get; set; }
}
