using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysNumberController
{
    public int NumberControllerId { get; set; }

    public int? ReferenceToNumberControllerId { get; set; }

    public int? DepartmentId { get; set; }

    public int? ApplicationType { get; set; }

    public string? Name { get; set; }

    public DateTime? CurrentProcessDt { get; set; }

    public int? CurrentProcessSeq { get; set; }

    public short? Seqdigits { get; set; }

    public string? ResetPeriod { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public int? StartSequence { get; set; }

    public int? EndSequence { get; set; }

    public string? NumberPreFix { get; set; }

    public string? DateTimeFormat { get; set; }

    public bool? CopyNumber { get; set; }

    public bool? MultiCopyAllowed { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<SysNumberController> InverseReferenceToNumberController { get; set; } = new List<SysNumberController>();

    public virtual SysNumberController? ReferenceToNumberController { get; set; }

    public virtual ICollection<SysNumberAssignment> SysNumberAssignments { get; set; } = new List<SysNumberAssignment>();
}
