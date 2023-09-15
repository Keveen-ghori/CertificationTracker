using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysNumberAssignment
{
    public decimal NumberAssignmentId { get; set; }

    public int? NumberControllerId { get; set; }

    public int? RequestedEmployeeId { get; set; }

    public int? DepartmentId { get; set; }

    public int? RequestedAppllication { get; set; }

    public DateTime? NumberAssignedDate { get; set; }

    public TimeSpan? NumberAssignedTime { get; set; }

    public string? NumberPrefix { get; set; }

    public string? FullNumber { get; set; }

    public string? Number { get; set; }

    public decimal? RequestedApplicaionPkid { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual Department? Department { get; set; }

    public virtual SysNumberController? NumberController { get; set; }

    public virtual SysrmsapplicationType? RequestedAppllicationNavigation { get; set; }

    public virtual DepartmentEmployee? RequestedEmployee { get; set; }
}
