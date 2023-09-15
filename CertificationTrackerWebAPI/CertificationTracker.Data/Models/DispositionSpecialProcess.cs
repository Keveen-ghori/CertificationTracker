using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DispositionSpecialProcess
{
    public decimal DispositionSpecialProcessId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int DepartmentId { get; set; }

    public string? ErrorString { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<DispositionSpecialProcessOnStatute> DispositionSpecialProcessOnStatutes { get; set; } = new List<DispositionSpecialProcessOnStatute>();
}
