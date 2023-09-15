using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RefTrafficStopTicketReferenceDatum
{
    public int RefTrafficStopTicketReferenceDataId { get; set; }

    public int? DepartmentId { get; set; }

    public int? AgencyId { get; set; }

    public string? DisplayString { get; set; }

    public string? Description { get; set; }

    public bool? IsSystemData { get; set; }

    public int? DisplaySeq { get; set; }

    public string? RefCategory { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsDefaultToCategory { get; set; }

    public string? DataValue { get; set; }

    public string? SubRefCategory { get; set; }

    public int? RefDepartmentOverrideFrom { get; set; }

    public string? Rptcode { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<RacialProfiling> RacialProfilingAuthorityforSearchCodeNavigations { get; set; } = new List<RacialProfiling>();

    public virtual ICollection<RacialProfiling> RacialProfilingDurationofStopCodeNavigations { get; set; } = new List<RacialProfiling>();

    public virtual ICollection<RacialProfiling> RacialProfilingEnforcementCategoryCodeNavigations { get; set; } = new List<RacialProfiling>();

    public virtual ICollection<RacialProfiling> RacialProfilingNatureofstopCodeNavigations { get; set; } = new List<RacialProfiling>();

    public virtual ICollection<RacialProfiling> RacialProfilingSearchDispositionCodeNavigations { get; set; } = new List<RacialProfiling>();

    public virtual ICollection<RacialProfiling> RacialProfilingStatutoryCitationofAllegedViolationCodeNavigations { get; set; } = new List<RacialProfiling>();

    public virtual ICollection<TrafficStopCitationDetail> TrafficStopCitationDetailLocationAreaCodeNavigations { get; set; } = new List<TrafficStopCitationDetail>();

    public virtual ICollection<TrafficStopCitationDetail> TrafficStopCitationDetailRoadSurfaceConditionCodeNavigations { get; set; } = new List<TrafficStopCitationDetail>();

    public virtual ICollection<TrafficStopCitationDetail> TrafficStopCitationDetailTrafficeConditionCodeNavigations { get; set; } = new List<TrafficStopCitationDetail>();

    public virtual ICollection<TrafficStopCitationDetail> TrafficStopCitationDetailVisibilityConditionCodeNavigations { get; set; } = new List<TrafficStopCitationDetail>();

    public virtual ICollection<TrafficStopWarningDetail> TrafficStopWarningDetailConditionsRoadCodeNavigations { get; set; } = new List<TrafficStopWarningDetail>();

    public virtual ICollection<TrafficStopWarningDetail> TrafficStopWarningDetailConditionsTimeCodeNavigations { get; set; } = new List<TrafficStopWarningDetail>();

    public virtual ICollection<TrafficStopWarningDetail> TrafficStopWarningDetailConditionsTrafficCodeNavigations { get; set; } = new List<TrafficStopWarningDetail>();

    public virtual ICollection<TrafficStopWarningDetail> TrafficStopWarningDetailConditionsWeatherCodeNavigations { get; set; } = new List<TrafficStopWarningDetail>();

    public virtual ICollection<TrafficStopWarningDetail> TrafficStopWarningDetailDefectiveEquipmentCodeNavigations { get; set; } = new List<TrafficStopWarningDetail>();

    public virtual ICollection<TrafficStop> TrafficStops { get; set; } = new List<TrafficStop>();
}
