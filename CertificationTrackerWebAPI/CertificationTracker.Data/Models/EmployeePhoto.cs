using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class EmployeePhoto
{
    public decimal DepartmentEmployeePhotoId { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public DateTime? PictureTakenDate { get; set; }

    public byte[]? Image { get; set; }

    public bool? IsCurrent { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }
}
