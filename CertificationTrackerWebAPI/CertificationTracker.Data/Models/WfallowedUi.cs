using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class WfallowedUi
{
    public decimal WfallowedUiid { get; set; }

    public decimal? RmsworkFlowDefId { get; set; }

    public decimal? SysrmsuserInterfaceDefinitionId { get; set; }

    public decimal? OkactionWf { get; set; }

    public int? ApplicationStatusId { get; set; }

    public int? ReportStatusId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public short? DisplaySeq { get; set; }

    public virtual SysApplicationStatus? ApplicationStatus { get; set; }

    public virtual RmsworkFlowDef? OkactionWfNavigation { get; set; }

    public virtual SysApplicationStatus? ReportStatus { get; set; }

    public virtual RmsworkFlowDef? RmsworkFlowDef { get; set; }

    public virtual SysrmsuserInterfaceDefinition? SysrmsuserInterfaceDefinition { get; set; }
}
