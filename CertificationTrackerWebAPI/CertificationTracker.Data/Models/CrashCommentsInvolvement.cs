﻿using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class CrashCommentsInvolvement
{
    public decimal CommentsInvolvement { get; set; }

    public decimal? CrashId { get; set; }

    public string? Comments { get; set; }

    public string? CommentSource { get; set; }

    public string? CommentCreatedByName { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? TypeOfInvolvement { get; set; }

    public int? InvolvementPkid { get; set; }

    public int? CadcommentId { get; set; }

    public int? AddedById { get; set; }

    public int? EditedById { get; set; }

    public virtual DepartmentEmployee? AddedBy { get; set; }

    public virtual Crash? Crash { get; set; }

    public virtual DepartmentEmployee? EditedBy { get; set; }
}
