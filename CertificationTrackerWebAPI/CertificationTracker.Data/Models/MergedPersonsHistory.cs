using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MergedPersonsHistory
{
    public int PrpersonMpid { get; set; }

    public int RelatedPkpersonMpid { get; set; }

    public int? InvolvementCount { get; set; }

    public int? InvolvementPkId { get; set; }

    public string? Surname { get; set; }

    public string? Givenname { get; set; }

    public DateTime? Dob { get; set; }

    public DateTime? MergedAtTime { get; set; }

    public string? StatusofMergeData { get; set; }

    public string? ExtraComments { get; set; }
}
