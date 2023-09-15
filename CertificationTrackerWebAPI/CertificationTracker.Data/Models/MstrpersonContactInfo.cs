using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpersonContactInfo
{
    public decimal MstrcontactId { get; set; }

    public int SeqNumber { get; set; }

    public decimal? Mpid { get; set; }

    public int? ApplicationType { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public string? ApplicationNumber { get; set; }

    public bool? IsCurrentContact { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? EditedOnString { get; set; }

    public int? TypeOfContact { get; set; }

    public string? TypeOfContactString { get; set; }

    public string? ContactData { get; set; }

    public string? ContactDataDigitsOnly { get; set; }

    public string? TenDigitPhone { get; set; }

    public string? UpToExt { get; set; }

    public string? Extension { get; set; }
}
