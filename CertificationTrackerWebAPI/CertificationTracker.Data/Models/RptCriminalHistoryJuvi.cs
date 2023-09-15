using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptCriminalHistoryJuvi
{
    public decimal? Mpid { get; set; }

    public string? Cad { get; set; }

    public string? Cadnumber { get; set; }

    public string? IncidentNumber { get; set; }

    public int? SupplementSeq { get; set; }

    public string? ArrestNumber { get; set; }

    public string? SummonsNumber { get; set; }

    public DateTime? ArrestDateTime { get; set; }

    public string? Statue { get; set; }

    public string? StatuteCode { get; set; }

    public string? Acl { get; set; }

    public DateTime? Jrbdate { get; set; }

    public bool? IsAppeared { get; set; }

    public bool? IsDetention { get; set; }

    public bool? IsJuvCourt { get; set; }

    public bool? IsLetterRepr { get; set; }

    public bool? IsLetterNfa { get; set; }

    public DateTime? ErasedDt { get; set; }

    public bool? IsRestitution { get; set; }

    public DateTime? RestitutionCompletedDate { get; set; }

    public bool? IsFirehawks { get; set; }

    public bool? IsCounseling { get; set; }

    public bool? IsYouthService { get; set; }

    public DateTime? YouthServiceCompletedDt { get; set; }

    public bool? IsCommService { get; set; }

    public DateTime? CommServiceCompletedDt { get; set; }

    public bool? OutofTownParticipatingJrb { get; set; }

    public string? ArrestingOfficer { get; set; }

    public int? OffenseCount { get; set; }
}
