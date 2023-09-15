using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RefUcrcodeDefinition
{
    public int UcrcodeId { get; set; }

    public int? AgencyId { get; set; }

    public int? DepartmentId { get; set; }

    public int? DataProcessId { get; set; }

    public string? Ucrcode { get; set; }

    public string? UcrcodeDisplayName { get; set; }

    public int? HierarchyRank { get; set; }

    public short? Classification { get; set; }

    public string? ToolTip { get; set; }

    public string? DropdownDescription { get; set; }

    public string? UcrsubCode { get; set; }

    public string? UcrmajorCode { get; set; }

    public string? CategoryGroup { get; set; }

    public string? IncidentReportType { get; set; }

    public bool? IsRequiredQc { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public int? RefDepartmentOverrideFrom { get; set; }

    public bool? IsUcrcategoryCode { get; set; }

    public int? NibrscodeId { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual DataProcess? DataProcess { get; set; }

    public virtual ICollection<DataProcessTrigger> DataProcessTriggers { get; set; } = new List<DataProcessTrigger>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<IncidentGeneralCategory> IncidentGeneralCategories { get; set; } = new List<IncidentGeneralCategory>();

    public virtual ICollection<IrcodeGeneratorRule> IrcodeGeneratorRules { get; set; } = new List<IrcodeGeneratorRule>();

    public virtual RefNibrscodeDefinition? Nibrscode { get; set; }

    public virtual ICollection<Offense> Offenses { get; set; } = new List<Offense>();

    public virtual ICollection<RefStatuteDefinition> RefStatuteDefinitions { get; set; } = new List<RefStatuteDefinition>();

    public virtual ICollection<SysNotificationCondition> SysNotificationConditions { get; set; } = new List<SysNotificationCondition>();
}
