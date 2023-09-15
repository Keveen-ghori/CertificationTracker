using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysImage
{
    public int SysImageId { get; set; }

    public int? AgencyId { get; set; }

    public int? DepartmentId { get; set; }

    public string? ImageType { get; set; }

    public byte[]? ImageData { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual Department? Department { get; set; }
}
