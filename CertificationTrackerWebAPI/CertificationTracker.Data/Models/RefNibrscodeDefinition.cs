using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RefNibrscodeDefinition
{
    public int NibrscodeId { get; set; }

    public int? AgencyId { get; set; }

    public int? DepartmentId { get; set; }

    public string? OffenseGroup { get; set; }

    public string? OffenseCode { get; set; }

    public string? OffenseName { get; set; }

    public string? Definition { get; set; }

    public bool? IsActive { get; set; }

    public string? OffenseSubCode { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public string? Description { get; set; }

    public bool? IsPropertyRequired { get; set; }

    public string? OffenseCategory { get; set; }

    public bool CargoTheftReq { get; set; }

    public bool WeaponForceReq { get; set; }

    public bool MethodofEntryReq { get; set; }

    public bool NumPremisesReq { get; set; }

    public bool RobberyRelated { get; set; }

    public bool FireRelated { get; set; }

    public bool SexualAssaultRelated { get; set; }

    public string? Survey { get; set; }

    public int? CriminalActivityReq { get; set; }

    public bool IsCrimeAgainstSociety { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual ICollection<DataProcessTrigger> DataProcessTriggers { get; set; } = new List<DataProcessTrigger>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<IncidentGeneralCategory> IncidentGeneralCategories { get; set; } = new List<IncidentGeneralCategory>();

    public virtual ICollection<IrcodeGeneratorRule> IrcodeGeneratorRules { get; set; } = new List<IrcodeGeneratorRule>();

    public virtual ICollection<NibrsreportOffense> NibrsreportOffenses { get; set; } = new List<NibrsreportOffense>();

    public virtual ICollection<Offense> Offenses { get; set; } = new List<Offense>();

    public virtual ICollection<RefStatuteDefinition> RefStatuteDefinitions { get; set; } = new List<RefStatuteDefinition>();

    public virtual ICollection<RefUcrcodeDefinition> RefUcrcodeDefinitions { get; set; } = new List<RefUcrcodeDefinition>();
}
