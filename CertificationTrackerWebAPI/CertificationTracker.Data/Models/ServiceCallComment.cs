using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ServiceCallComment
{
    public decimal ServiceCallCommentsId { get; set; }

    public decimal? ServiceCallId { get; set; }

    public string? Comments { get; set; }

    public string? CommentsCreatedBy { get; set; }

    public DateTime? CommentsCreatedDateTime { get; set; }

    public int? CadcommentId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public virtual ServiceCall? ServiceCall { get; set; }
}
