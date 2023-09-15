using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysapplicationValidation
{
    public decimal SysapplicationValidationId { get; set; }

    public int ApplicationType { get; set; }

    public decimal ApplicationPkid { get; set; }

    public int EmployeeId { get; set; }

    public DateTime OpenedDate { get; set; }

    public DateTime AddedOn { get; set; }

    public int AddedById { get; set; }

    public DateTime EditedOn { get; set; }

    public int EditedById { get; set; }

    public virtual DepartmentEmployee AddedBy { get; set; } = null!;

    public virtual SysrmsapplicationType ApplicationTypeNavigation { get; set; } = null!;

    public virtual DepartmentEmployee EditedBy { get; set; } = null!;

    public virtual DepartmentEmployee Employee { get; set; } = null!;
}
