using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RacialProfiling
{
    public decimal RacialProfilingId { get; set; }

    public int? NatureofstopCode { get; set; }

    public int? StatutoryCitationofAllegedViolationCode { get; set; }

    public int? EnforcementCategoryCode { get; set; }

    public int? AuthorityforSearchCode { get; set; }

    public int? DurationofStopCode { get; set; }

    public decimal? TrafficStopId { get; set; }

    public int? SearchDispositionCode { get; set; }

    public string? Location { get; set; }

    public bool? IsResident { get; set; }

    public bool? IsCtresident { get; set; }

    public bool? IsSearchConducted { get; set; }

    public bool? IsDriverArrested { get; set; }

    public bool? IsTowed { get; set; }

    public string? StatutoryViolationCharged { get; set; }

    public virtual RefTrafficStopTicketReferenceDatum? AuthorityforSearchCodeNavigation { get; set; }

    public virtual RefTrafficStopTicketReferenceDatum? DurationofStopCodeNavigation { get; set; }

    public virtual RefTrafficStopTicketReferenceDatum? EnforcementCategoryCodeNavigation { get; set; }

    public virtual RefTrafficStopTicketReferenceDatum? NatureofstopCodeNavigation { get; set; }

    public virtual RefTrafficStopTicketReferenceDatum? SearchDispositionCodeNavigation { get; set; }

    public virtual RefTrafficStopTicketReferenceDatum? StatutoryCitationofAllegedViolationCodeNavigation { get; set; }

    public virtual TrafficStop? TrafficStop { get; set; }
}
