using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentFamilyViolence
{
    public decimal IncidentFamilyViolenceId { get; set; }

    public decimal? IncidentId { get; set; }

    public int? ChildUnder18Was { get; set; }

    public int? LiguorDrugsInvolvedCode { get; set; }

    public int? DomesticCourtOrderYncode { get; set; }

    public int? DomesticCourtOrderStatusCode { get; set; }

    public int? DomesticCourtOrderTypeCode { get; set; }

    public short? NumberOfFirearmUsed { get; set; }

    public short? NumberOfKnivesUsed { get; set; }

    public short? NumberOfDangerousWeaponsUsed { get; set; }

    public short? NumberOfHandsFistsFeet { get; set; }

    public short? NumberOfVictimsOffenders { get; set; }

    public string? DangerousWeaponsDescription { get; set; }

    public string? Remarks { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsCurrentIrrecord { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public DateTime? ZeroReportingPeriod { get; set; }

    public virtual RefIncidentReferenceDatum? ChildUnder18WasNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? DomesticCourtOrderStatusCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? DomesticCourtOrderTypeCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? DomesticCourtOrderYncodeNavigation { get; set; }

    public virtual Incident? Incident { get; set; }

    public virtual RefIncidentReferenceDatum? LiguorDrugsInvolvedCodeNavigation { get; set; }
}
