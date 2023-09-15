using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PostoutSideInstructor
{
    public decimal PostoutSideInstructorId { get; set; }

    public string? InstructorName { get; set; }

    public string? InstructorIdnumber { get; set; }

    public DateTime? InstructorCertificationExpireDate { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? EditedName { get; set; }

    public int? DepartmentId { get; set; }

    public int? CertificationType { get; set; }

    public virtual RefMiscReferenceDatum? CertificationTypeNavigation { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<PostinstructorCertifiedArea> PostinstructorCertifiedAreas { get; set; } = new List<PostinstructorCertifiedArea>();
}
