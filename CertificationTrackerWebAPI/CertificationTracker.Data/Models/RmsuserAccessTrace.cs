using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RmsuserAccessTrace
{
    public decimal RmsuserAccessId { get; set; }

    public string? Description { get; set; }

    public string? Ip { get; set; }

    public string? MachineName { get; set; }

    public DateTime? LoginDateTime { get; set; }

    public DateTime? LogoffDateTime { get; set; }

    public string? BrowserInformation { get; set; }

    public string? AccessToken { get; set; }

    public string? SessionTrace { get; set; }

    public DateTime? LastIdleDateTime { get; set; }

    public bool? IsSystemLogoff { get; set; }

    public int? UserId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool IsCtcmobileLogin { get; set; }

    public bool? CtcrmsloginFromCtcmobile { get; set; }
}
