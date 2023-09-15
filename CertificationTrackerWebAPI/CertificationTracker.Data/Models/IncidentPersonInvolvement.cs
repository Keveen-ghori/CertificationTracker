using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentPersonInvolvement
{
    public decimal IncidentPersonInvolvementId { get; set; }

    public decimal? IncidentId { get; set; }

    public decimal? Mpid { get; set; }

    public decimal? NonVerifiedPersonId { get; set; }

    public decimal? InvolvementLocationId { get; set; }

    public int? PersonInvolvementCode { get; set; }

    public decimal? RelatedVehicleInvolvementId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public bool? IsConfidential { get; set; }

    public bool? IsIndividualSecurityApply { get; set; }

    public string? Source { get; set; }

    public string? Comment { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public string? NcicmessageNumber { get; set; }

    public DateTime? InvolvementDateTime { get; set; }

    public string? CollectMessageNumber { get; set; }

    public bool? IsJuvenile { get; set; }

    public DateTime? InvolvementDateTo { get; set; }

    public decimal? JuvenileBookingId { get; set; }

    public bool? HidePersonNameOnPdf { get; set; }

    public bool? ExcludeForNibrsdetail { get; set; }

    public bool? IsLeoka { get; set; }

    public int? Leokaactivity { get; set; }

    public int? Leokaassignment { get; set; }

    public bool? IsLeofromOtherJurisdiction { get; set; }

    public string? Leojurisdiction { get; set; }

    public virtual ICollection<ArrestBooking> ArrestBookings { get; set; } = new List<ArrestBooking>();

    public virtual ICollection<CustodyLog> CustodyLogs { get; set; } = new List<CustodyLog>();

    public virtual ICollection<DispositionsImport> DispositionsImports { get; set; } = new List<DispositionsImport>();

    public virtual ICollection<HelpQueryPersonInvolvement> HelpQueryPersonInvolvements { get; set; } = new List<HelpQueryPersonInvolvement>();

    public virtual Incident? Incident { get; set; }

    public virtual ICollection<IncidentForceInvolvement> IncidentForceInvolvements { get; set; } = new List<IncidentForceInvolvement>();

    public virtual ICollection<IncidentForceReport> IncidentForceReports { get; set; } = new List<IncidentForceReport>();

    public virtual ICollection<IncidentGeneralCategory> IncidentGeneralCategories { get; set; } = new List<IncidentGeneralCategory>();

    public virtual ICollection<IncidentMissingPersonDetail> IncidentMissingPersonDetails { get; set; } = new List<IncidentMissingPersonDetail>();

    public virtual ICollection<IncidentPersonFamilyViolence> IncidentPersonFamilyViolences { get; set; } = new List<IncidentPersonFamilyViolence>();

    public virtual ICollection<IncidentPersonInjuryDetail> IncidentPersonInjuryDetails { get; set; } = new List<IncidentPersonInjuryDetail>();

    public virtual ICollection<IncidentPersonVictimDetail> IncidentPersonVictimDetailIncidentPersonInvolvements { get; set; } = new List<IncidentPersonVictimDetail>();

    public virtual ICollection<IncidentPersonVictimDetail> IncidentPersonVictimDetailPerpetrators { get; set; } = new List<IncidentPersonVictimDetail>();

    public virtual ICollection<IncidentPersonWitnessDetail> IncidentPersonWitnessDetails { get; set; } = new List<IncidentPersonWitnessDetail>();

    public virtual ICollection<IncidentPropertyInvolvement> IncidentPropertyInvolvements { get; set; } = new List<IncidentPropertyInvolvement>();

    public virtual ICollection<IncidentRelatedAttachment> IncidentRelatedAttachments { get; set; } = new List<IncidentRelatedAttachment>();

    public virtual ICollection<IncidentUseOfForce> IncidentUseOfForces { get; set; } = new List<IncidentUseOfForce>();

    public virtual ICollection<IndividualSecurityToUser> IndividualSecurityToUsers { get; set; } = new List<IndividualSecurityToUser>();

    public virtual JuvenileBookingDetail? JuvenileBooking { get; set; }

    public virtual NibrsreferenceDatum? LeokaactivityNavigation { get; set; }

    public virtual NibrsreferenceDatum? LeokaassignmentNavigation { get; set; }

    public virtual Mstrperson? Mp { get; set; }

    public virtual ICollection<NibrsreportPerson> NibrsreportPeople { get; set; } = new List<NibrsreportPerson>();

    public virtual NonVerifiedCallPerson? NonVerifiedPerson { get; set; }

    public virtual RefIncidentReferenceDatum? PersonInvolvementCodeNavigation { get; set; }

    public virtual ICollection<PhotoLineupViewer> PhotoLineupViewers { get; set; } = new List<PhotoLineupViewer>();

    public virtual ICollection<PhotoLineup> PhotoLineups { get; set; } = new List<PhotoLineup>();

    public virtual IncidentVehicleInvolvement? RelatedVehicleInvolvement { get; set; }

    public virtual ICollection<SummonsInfraction> SummonsInfractions { get; set; } = new List<SummonsInfraction>();
}
