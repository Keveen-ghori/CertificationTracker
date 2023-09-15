using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RmsdataProcessController
{
    public decimal RmsdataProcessControllerId { get; set; }

    public int? ProcessRmsdataProcessId { get; set; }

    public decimal? ProcessGeneratedByControllerId { get; set; }

    public int? DepartmentId { get; set; }

    public int? CurrentProcessStepDetailId { get; set; }

    public int? CurrentProcessStepId { get; set; }

    public int? ApplicationType { get; set; }

    public decimal? ApplicationPkid { get; set; }

    public string? Status { get; set; }

    public DateTime? StatusDateTime { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public int? CurrentProcessDataItemSeq { get; set; }

    public string? DataMappingObjectName { get; set; }

    public decimal? DataMappingObjectId { get; set; }

    public bool? IsSubProcess { get; set; }

    public decimal? GeneratedByDataProcessRuleId { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual DataProcessStep? CurrentProcessStep { get; set; }

    public virtual DataProcessDetailStep? CurrentProcessStepDetail { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<RmsdataProcessController> InverseProcessGeneratedByController { get; set; } = new List<RmsdataProcessController>();

    public virtual RmsdataProcessController? ProcessGeneratedByController { get; set; }

    public virtual DataProcess? ProcessRmsdataProcess { get; set; }

    public virtual ICollection<RmsdataProcessDetailStep> RmsdataProcessDetailSteps { get; set; } = new List<RmsdataProcessDetailStep>();
}
