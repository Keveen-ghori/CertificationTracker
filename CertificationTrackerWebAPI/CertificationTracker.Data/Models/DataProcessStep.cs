using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DataProcessStep
{
    public int ProcessStepId { get; set; }

    public string? Name { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual ICollection<DataProcessDetailStep> DataProcessDetailSteps { get; set; } = new List<DataProcessDetailStep>();

    public virtual ICollection<DataProcessStepDataItem> DataProcessStepDataItems { get; set; } = new List<DataProcessStepDataItem>();

    public virtual ICollection<RmsdataProcessController> RmsdataProcessControllers { get; set; } = new List<RmsdataProcessController>();

    public virtual ICollection<RmsdataProcessDetailStep> RmsdataProcessDetailSteps { get; set; } = new List<RmsdataProcessDetailStep>();
}
