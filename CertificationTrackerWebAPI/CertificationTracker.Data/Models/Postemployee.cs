using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Postemployee
{
    public decimal PostemployeeId { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public int? Postidnumber { get; set; }

    public DateTime? PostexpirationDate { get; set; }

    public bool? IsSystemImported { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? EditedName { get; set; }

    public bool? ReqMet { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? OriginalCertifiedDate { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }
}
