using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PostimportEmployee
{
    public int PostimportEmployeesId { get; set; }

    public int? DepartmentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string? Suffix { get; set; }

    public string? BadgeNumber { get; set; }

    public string? Rank { get; set; }

    public DateTime? DateOfHiring { get; set; }

    public string? Email { get; set; }

    public int? Postidnumber { get; set; }

    public DateTime? PostexpirationDate { get; set; }

    public bool? ImportOk { get; set; }

    public string? ImportDetail { get; set; }

    public int? ImportEmployeeId { get; set; }

    public DateTime? ImportDateTime { get; set; }
}
