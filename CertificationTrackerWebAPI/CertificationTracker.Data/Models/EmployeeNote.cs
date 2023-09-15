using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class EmployeeNote
{
    public decimal EmployeeNoteId { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public DateTime? Date { get; set; }

    public string? Subject { get; set; }

    public string? Notes { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }
}
