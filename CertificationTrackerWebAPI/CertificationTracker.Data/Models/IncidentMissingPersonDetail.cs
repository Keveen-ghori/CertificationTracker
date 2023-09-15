using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentMissingPersonDetail
{
    public decimal IncidentMissingPersonDetailId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public string? FormOfTransportation { get; set; }

    public string? DirectionOfTravel { get; set; }

    public string? Disabilities { get; set; }

    public string? MissingPersonFactors { get; set; }

    public bool? IsUsingPrescriptionMedications { get; set; }

    public string? MedicationDescription { get; set; }

    public bool? DidPersonTakeMedicationswithThem { get; set; }

    public bool? IsMissingPersonAtRisk { get; set; }

    public string? RiskExplain { get; set; }

    public string? Markings { get; set; }

    public bool? IsAmberAlert { get; set; }

    public bool? IsSilverAlert { get; set; }

    public Guid? UniqueId { get; set; }

    public string? MissingPersonIncidenType { get; set; }

    public string? MissingPersonPossibleType { get; set; }

    public string? MissingPersonActionTaken { get; set; }

    public string? SearchArea { get; set; }

    public string? KnownHangouts { get; set; }

    public string? KnownTravelPlans { get; set; }

    public string? HobbiesInterests { get; set; }

    public string? SocialNetworkingSitesUserNames { get; set; }

    public string? ItemsTaken { get; set; }

    public string? BankCreditUnionNameBranch { get; set; }

    public string? RecentFinancialActivity { get; set; }

    public string? CallAttempt { get; set; }

    public string? OtherAgenciesK9assistance { get; set; }

    public string? CourtOrders { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? MissingPersonIncidentTypeOtherTxt { get; set; }

    public string? MissingPersonActionTakenOtherTxt { get; set; }

    public string? SuspiciousAtScene { get; set; }

    public bool? HaveDna { get; set; }

    public string? Dnalocation { get; set; }

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }
}
