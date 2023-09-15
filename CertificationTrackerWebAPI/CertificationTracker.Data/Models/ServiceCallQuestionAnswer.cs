using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ServiceCallQuestionAnswer
{
    public decimal ServiceCallQuestionAnswerId { get; set; }

    public decimal? ServiceCallPersonId { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }

    public int? Cadqaid { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public virtual NonVerifiedCallPerson? ServiceCallPerson { get; set; }
}
