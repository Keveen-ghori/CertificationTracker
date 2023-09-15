using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PostcourseAttachment
{
    public int PostCourseAttachmentId { get; set; }

    public decimal PostcourseId { get; set; }

    public string? AttachmentName { get; set; }

    public string? AttachmentType { get; set; }

    public string? AttachmentDescription { get; set; }

    public string? AttachmentPath { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }

    public virtual Postcourse Postcourse { get; set; } = null!;
}
