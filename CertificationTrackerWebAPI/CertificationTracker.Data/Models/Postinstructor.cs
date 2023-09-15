using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Postinstructor
{
    public decimal PostinstructorId { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public int? InstructorIdnumber { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? EditedName { get; set; }

    public DateTime? CertifiedExpDate { get; set; }

    public int? CertificationType { get; set; }

    public virtual RefMiscReferenceDatum? CertificationTypeNavigation { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }

    public virtual ICollection<PostinstructorCertifiedArea> PostinstructorCertifiedAreas { get; set; } = new List<PostinstructorCertifiedArea>();
}
