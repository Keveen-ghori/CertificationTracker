using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DataProcessTrigger
{
    public int DataProcessTriggerId { get; set; }

    public int? DataProcessId { get; set; }

    public int? OffenseCodeDefinitionId { get; set; }

    public int? NibrscodeId { get; set; }

    public int? UcrcodeId { get; set; }

    public int? CfsdefinitionId { get; set; }

    public int? ApplicationType { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsActive { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual RefCallForServiceDefinition? Cfsdefinition { get; set; }

    public virtual DataProcess? DataProcess { get; set; }

    public virtual RefNibrscodeDefinition? Nibrscode { get; set; }

    public virtual RefOffenseCodeDefinition? OffenseCodeDefinition { get; set; }

    public virtual RefUcrcodeDefinition? Ucrcode { get; set; }
}
