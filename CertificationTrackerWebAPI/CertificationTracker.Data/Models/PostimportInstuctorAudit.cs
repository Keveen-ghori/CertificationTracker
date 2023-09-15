using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PostimportInstuctorAudit
{
    public int PostimportInstuctorAuditId { get; set; }

    public int? PostimportInstructorId { get; set; }

    public int? PostimportInstrcutorAreaId { get; set; }

    public int? PostinstructorId { get; set; }

    public int? PostinstructorCertifiedAreaId { get; set; }

    public string? Action { get; set; }

    public string? Details { get; set; }

    public DateTime? AuditDateTime { get; set; }
}
