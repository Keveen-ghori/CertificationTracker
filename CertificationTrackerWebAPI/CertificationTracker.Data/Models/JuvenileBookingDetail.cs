using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class JuvenileBookingDetail
{
    public decimal JuvenileBookingId { get; set; }

    public int? DepartmentId { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? School { get; set; }

    public string? SchoolGrade { get; set; }

    public bool? IsDetention { get; set; }

    public bool? IsJuvCourt { get; set; }

    public string? JuvCourtDesc { get; set; }

    public bool? IsLetterRepr { get; set; }

    public DateTime? ErasedDt { get; set; }

    public bool? IsRestitution { get; set; }

    public bool? IsFirehawks { get; set; }

    public bool? IsCounseling { get; set; }

    public string? CounselingDesc { get; set; }

    public bool? IsYouthService { get; set; }

    public DateTime? YouthServiceCompletedDt { get; set; }

    public string? YouthServiceDesc { get; set; }

    public bool? IsCommService { get; set; }

    public DateTime? CommServiceCompletedDt { get; set; }

    public string? CommServiceDesc { get; set; }

    public DateTime? Jrbdate { get; set; }

    public bool? IsAppeared { get; set; }

    public bool? IsLetterNfa { get; set; }

    public DateTime? RestitutionCompletedDate { get; set; }

    public bool? OutofTownParticipatingJrb { get; set; }

    public string? UserNotes { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<IncidentPersonInvolvement> IncidentPersonInvolvements { get; set; } = new List<IncidentPersonInvolvement>();
}
