using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Postrenewal
{
    public decimal PostrenewalId { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public DateTime? RenewalDate { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public bool? IsCurrent { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? EditedName { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }
}
