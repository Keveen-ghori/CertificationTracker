using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RefDirectoryCategory
{
    public int CategoryId { get; set; }

    public int? AgencyId { get; set; }

    public int? DepartmentId { get; set; }

    public string? CategoryName { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsSystemDefined { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsTowProvider { get; set; }

    public virtual ICollection<LnkaddressDirectoryToCategory> LnkaddressDirectoryToCategories { get; set; } = new List<LnkaddressDirectoryToCategory>();
}
