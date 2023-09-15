using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ViewMstrcontactPhone
{
    public decimal MstrcontactId { get; set; }

    public decimal? Mpid { get; set; }

    public int? ApplicationType { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public string? ApplicationNumber { get; set; }

    public bool? IsCurrentContact { get; set; }

    public int SeqNumber { get; set; }

    public string? EditedOnDateTime { get; set; }

    public string? EditedOn { get; set; }

    public int? TypeOfContact { get; set; }

    public string? TypeOfContactString { get; set; }

    public string? ContactData { get; set; }

    public string? PhoneNumber { get; set; }

    public int? StartOfExt { get; set; }

    public string? Extension { get; set; }
}
