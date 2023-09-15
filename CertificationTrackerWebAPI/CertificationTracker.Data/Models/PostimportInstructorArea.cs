using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PostimportInstructorArea
{
    public int PostimportInstructorAreasId { get; set; }

    public int? PostimportInstructorsId { get; set; }

    public int? InstructorNumber { get; set; }

    public string? Area { get; set; }

    public string? ProcessStatus { get; set; }

    public DateTime? ProcessDate { get; set; }

    public int? PostareaId { get; set; }

    public int? PostinstructorCertifiedAreaId { get; set; }

    public string? ProcessError { get; set; }

    public bool? IsImported { get; set; }

    public virtual PostimportInstructor? PostimportInstructors { get; set; }
}
