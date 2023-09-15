using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RefIncidentReferenceDatum
{
    public int RefIncidentReferenceDataId { get; set; }

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

    public string? DataValue { get; set; }

    public bool? IsDefaultToCategory { get; set; }

    public string? SubRefCategory { get; set; }

    public int? RefDepartmentOverrideFrom { get; set; }

    public string? Rptcode { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual ICollection<ArrestBooking> ArrestBookingArrestCategoryCodeNavigations { get; set; } = new List<ArrestBooking>();

    public virtual ICollection<ArrestBooking> ArrestBookingCdCostIndicatorNavigations { get; set; } = new List<ArrestBooking>();

    public virtual ICollection<ArrestBooking> ArrestBookingCourtCodeNavigations { get; set; } = new List<ArrestBooking>();

    public virtual ICollection<BookingReleaseInfo> BookingReleaseInfoBondTypeNavigations { get; set; } = new List<BookingReleaseInfo>();

    public virtual ICollection<BookingReleaseInfo> BookingReleaseInfoReleaseMethodNavigations { get; set; } = new List<BookingReleaseInfo>();

    public virtual ICollection<CustodyLog> CustodyLogBlockNavigations { get; set; } = new List<CustodyLog>();

    public virtual ICollection<CustodyLog> CustodyLogCellNavigations { get; set; } = new List<CustodyLog>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<IncidentBiasHateCrimeFactor> IncidentBiasHateCrimeFactorOffenderEthnicityCodeNavigations { get; set; } = new List<IncidentBiasHateCrimeFactor>();

    public virtual ICollection<IncidentBiasHateCrimeFactor> IncidentBiasHateCrimeFactorOffenderRaceCodeNavigations { get; set; } = new List<IncidentBiasHateCrimeFactor>();

    public virtual ICollection<IncidentBiasHateCrimeFactorsOffense> IncidentBiasHateCrimeFactorsOffenseHateCrimeTypeCodeNavigations { get; set; } = new List<IncidentBiasHateCrimeFactorsOffense>();

    public virtual ICollection<IncidentBiasHateCrimeFactorsOffense> IncidentBiasHateCrimeFactorsOffensePlaceofIncidentCodeNavigations { get; set; } = new List<IncidentBiasHateCrimeFactorsOffense>();

    public virtual ICollection<IncidentFamilyViolence> IncidentFamilyViolenceChildUnder18WasNavigations { get; set; } = new List<IncidentFamilyViolence>();

    public virtual ICollection<IncidentFamilyViolence> IncidentFamilyViolenceDomesticCourtOrderStatusCodeNavigations { get; set; } = new List<IncidentFamilyViolence>();

    public virtual ICollection<IncidentFamilyViolence> IncidentFamilyViolenceDomesticCourtOrderTypeCodeNavigations { get; set; } = new List<IncidentFamilyViolence>();

    public virtual ICollection<IncidentFamilyViolence> IncidentFamilyViolenceDomesticCourtOrderYncodeNavigations { get; set; } = new List<IncidentFamilyViolence>();

    public virtual ICollection<IncidentFamilyViolence> IncidentFamilyViolenceLiguorDrugsInvolvedCodeNavigations { get; set; } = new List<IncidentFamilyViolence>();

    public virtual ICollection<IncidentForceInvolvement> IncidentForceInvolvementForceTypeCodeNavigations { get; set; } = new List<IncidentForceInvolvement>();

    public virtual ICollection<IncidentForceInvolvement> IncidentForceInvolvementWeaponTypeCodeNavigations { get; set; } = new List<IncidentForceInvolvement>();

    public virtual ICollection<IncidentForceReport> IncidentForceReportPoliceForceLocationCodeNavigations { get; set; } = new List<IncidentForceReport>();

    public virtual ICollection<IncidentForceReport> IncidentForceReportTaserTypeOfUseNavigations { get; set; } = new List<IncidentForceReport>();

    public virtual ICollection<IncidentGeneralCategory> IncidentGeneralCategories { get; set; } = new List<IncidentGeneralCategory>();

    public virtual ICollection<IncidentInvestigationManagement> IncidentInvestigationManagements { get; set; } = new List<IncidentInvestigationManagement>();

    public virtual ICollection<IncidentMo> IncidentMos { get; set; } = new List<IncidentMo>();

    public virtual ICollection<IncidentOrganizationInvolvement> IncidentOrganizationInvolvements { get; set; } = new List<IncidentOrganizationInvolvement>();

    public virtual ICollection<IncidentOutOfTownWarrant> IncidentOutOfTownWarrantReasonForContactCodeNavigations { get; set; } = new List<IncidentOutOfTownWarrant>();

    public virtual ICollection<IncidentOutOfTownWarrant> IncidentOutOfTownWarrantWantedAgencyNameCodeNavigations { get; set; } = new List<IncidentOutOfTownWarrant>();

    public virtual ICollection<IncidentPersonFamilyViolence> IncidentPersonFamilyViolenceInjuryCodeNavigations { get; set; } = new List<IncidentPersonFamilyViolence>();

    public virtual ICollection<IncidentPersonFamilyViolence> IncidentPersonFamilyViolenceLiquorDrugsInvolvedCodeNavigations { get; set; } = new List<IncidentPersonFamilyViolence>();

    public virtual ICollection<IncidentPersonFamilyViolence> IncidentPersonFamilyViolenceRelationshiptoVictimNavigations { get; set; } = new List<IncidentPersonFamilyViolence>();

    public virtual ICollection<IncidentPersonFamilyViolence> IncidentPersonFamilyViolenceViolenceStatusCodeNavigations { get; set; } = new List<IncidentPersonFamilyViolence>();

    public virtual ICollection<IncidentPersonInjuryDetail> IncidentPersonInjuryDetailInjuredTransportationSourceCodeNavigations { get; set; } = new List<IncidentPersonInjuryDetail>();

    public virtual ICollection<IncidentPersonInjuryDetail> IncidentPersonInjuryDetailInjuryStatusCodeNavigations { get; set; } = new List<IncidentPersonInjuryDetail>();

    public virtual ICollection<IncidentPersonInjuryDetail> IncidentPersonInjuryDetailInjuryTypeCodeNavigations { get; set; } = new List<IncidentPersonInjuryDetail>();

    public virtual ICollection<IncidentPersonInvolvement> IncidentPersonInvolvements { get; set; } = new List<IncidentPersonInvolvement>();

    public virtual ICollection<IncidentPersonVictimDetail> IncidentPersonVictimDetailPenetrationMethodCodeNavigations { get; set; } = new List<IncidentPersonVictimDetail>();

    public virtual ICollection<IncidentPersonVictimDetail> IncidentPersonVictimDetailSexAssaultVictimPenetraTypeNavigations { get; set; } = new List<IncidentPersonVictimDetail>();

    public virtual ICollection<IncidentPropertyDrugDetail> IncidentPropertyDrugDetailContainersCodeNavigations { get; set; } = new List<IncidentPropertyDrugDetail>();

    public virtual ICollection<IncidentPropertyDrugDetail> IncidentPropertyDrugDetailDrugWeightUnitsCodeNavigations { get; set; } = new List<IncidentPropertyDrugDetail>();

    public virtual ICollection<IncidentPropertyDrugDetail> IncidentPropertyDrugDetailSuspectArsonByUcrNavigations { get; set; } = new List<IncidentPropertyDrugDetail>();

    public virtual ICollection<IncidentPropertyInvolvement> IncidentPropertyInvolvementCustodyReasonNavigations { get; set; } = new List<IncidentPropertyInvolvement>();

    public virtual ICollection<IncidentPropertyInvolvement> IncidentPropertyInvolvementPropertyInvolvementCodeNavigations { get; set; } = new List<IncidentPropertyInvolvement>();

    public virtual ICollection<IncidentPropertyInvolvement> IncidentPropertyInvolvementPropertyLockerNavigations { get; set; } = new List<IncidentPropertyInvolvement>();

    public virtual ICollection<IncidentPropertyInvolvement> IncidentPropertyInvolvementSecuredLocationNavigations { get; set; } = new List<IncidentPropertyInvolvement>();

    public virtual ICollection<IncidentPropertyInvolvement> IncidentPropertyInvolvementStolenRecoveredWhereNavigations { get; set; } = new List<IncidentPropertyInvolvement>();

    public virtual ICollection<IncidentReportDistribution> IncidentReportDistributions { get; set; } = new List<IncidentReportDistribution>();

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetailActualAttemptedCodeNavigations { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetailDayNightCodeNavigations { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetailFireTypeCodeNavigations { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetailLocationTypeCodeNavigations { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetailMostSeriousIncidentInjuryCodeNavigations { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetailObjectofTheftCodeNavigations { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetailPenetrationCodeNavigations { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetailTypeofForgeryCodeNavigations { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetailTypeofIdentityTheftCodeNavigations { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetailTypeofLarcenyCodeNavigations { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetailTypeofRobberyCodeNavigations { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetailValueRangeCodeNavigations { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual ICollection<IncidentUseOfForceInjuryDetail> IncidentUseOfForceInjuryDetailOfficerCheckedByMedicalCodeNavigations { get; set; } = new List<IncidentUseOfForceInjuryDetail>();

    public virtual ICollection<IncidentUseOfForceInjuryDetail> IncidentUseOfForceInjuryDetailSubjectCheckedByMedicalCodeNavigations { get; set; } = new List<IncidentUseOfForceInjuryDetail>();

    public virtual ICollection<IncidentUseOfForce> IncidentUseOfForces { get; set; } = new List<IncidentUseOfForce>();

    public virtual ICollection<IncidentVehicleInvolvement> IncidentVehicleInvolvementAutoTheftCodeNavigations { get; set; } = new List<IncidentVehicleInvolvement>();

    public virtual ICollection<IncidentVehicleInvolvement> IncidentVehicleInvolvementLocationOfEvidenceNavigations { get; set; } = new List<IncidentVehicleInvolvement>();

    public virtual ICollection<IncidentVehicleInvolvement> IncidentVehicleInvolvementReasonNotTowedCodeNavigations { get; set; } = new List<IncidentVehicleInvolvement>();

    public virtual ICollection<IncidentVehicleInvolvement> IncidentVehicleInvolvementStolenRecoveredWhereNavigations { get; set; } = new List<IncidentVehicleInvolvement>();

    public virtual ICollection<IncidentVehicleInvolvement> IncidentVehicleInvolvementTypeofStolenVehicleNavigations { get; set; } = new List<IncidentVehicleInvolvement>();

    public virtual ICollection<IncidentVehicleInvolvement> IncidentVehicleInvolvementVehicleInvolvementCodeNavigations { get; set; } = new List<IncidentVehicleInvolvement>();

    public virtual ICollection<Incident> Incidents { get; set; } = new List<Incident>();

    public virtual ICollection<Offense> OffenseAclflagCodeNavigations { get; set; } = new List<Offense>();

    public virtual ICollection<Offense> OffenseCdCcswitchNavigations { get; set; } = new List<Offense>();

    public virtual ICollection<Offense> OffenseCdConditionalDischargeTypeNavigations { get; set; } = new List<Offense>();

    public virtual ICollection<Offense> OffenseCdJailTypeNavigations { get; set; } = new List<Offense>();

    public virtual ICollection<Offense> OffenseCdPleaNavigations { get; set; } = new List<Offense>();

    public virtual ICollection<Offense> OffenseCdProbationTypeNavigations { get; set; } = new List<Offense>();

    public virtual ICollection<Offense> OffenseCdSpecialParoleTypeNavigations { get; set; } = new List<Offense>();

    public virtual ICollection<Offense> OffenseCdSuspendedJailTypeNavigations { get; set; } = new List<Offense>();

    public virtual ICollection<Offense> OffenseCdVerdictFindingNavigations { get; set; } = new List<Offense>();

    public virtual ICollection<PropertyCustodyTracking> PropertyCustodyTrackingCheckOutReasonNavigations { get; set; } = new List<PropertyCustodyTracking>();

    public virtual ICollection<PropertyCustodyTracking> PropertyCustodyTrackingStorageAisleNavigations { get; set; } = new List<PropertyCustodyTracking>();

    public virtual ICollection<PropertyCustodyTracking> PropertyCustodyTrackingStorageRoomNavigations { get; set; } = new List<PropertyCustodyTracking>();

    public virtual ICollection<PropertyCustodyTracking> PropertyCustodyTrackingStorageShelfNavigations { get; set; } = new List<PropertyCustodyTracking>();

    public virtual ICollection<PropertyRoomItem> PropertyRoomItems { get; set; } = new List<PropertyRoomItem>();

    public virtual ICollection<SummonsInfraction> SummonsInfractionBondTypeNavigations { get; set; } = new List<SummonsInfraction>();

    public virtual ICollection<SummonsInfraction> SummonsInfractionCdCostIndicatorNavigations { get; set; } = new List<SummonsInfraction>();

    public virtual ICollection<SummonsInfraction> SummonsInfractionCourtCodeNavigations { get; set; } = new List<SummonsInfraction>();

    public virtual ICollection<TrafficStopViolation> TrafficStopViolationCdCcswitchNavigations { get; set; } = new List<TrafficStopViolation>();

    public virtual ICollection<TrafficStopViolation> TrafficStopViolationCdConditionalDischargeTypeNavigations { get; set; } = new List<TrafficStopViolation>();

    public virtual ICollection<TrafficStopViolation> TrafficStopViolationCdJailTypeNavigations { get; set; } = new List<TrafficStopViolation>();

    public virtual ICollection<TrafficStopViolation> TrafficStopViolationCdPleaNavigations { get; set; } = new List<TrafficStopViolation>();

    public virtual ICollection<TrafficStopViolation> TrafficStopViolationCdProbationTypeNavigations { get; set; } = new List<TrafficStopViolation>();

    public virtual ICollection<TrafficStopViolation> TrafficStopViolationCdSpecialParoleTypeNavigations { get; set; } = new List<TrafficStopViolation>();

    public virtual ICollection<TrafficStopViolation> TrafficStopViolationCdSuspendedJailTypeNavigations { get; set; } = new List<TrafficStopViolation>();

    public virtual ICollection<TrafficStopViolation> TrafficStopViolationCdVerdictFindingNavigations { get; set; } = new List<TrafficStopViolation>();

    public virtual ICollection<TrafficStop> TrafficStops { get; set; } = new List<TrafficStop>();

    public virtual ICollection<WarrantAttempt> WarrantAttempts { get; set; } = new List<WarrantAttempt>();

    public virtual ICollection<Warrant> WarrantBondTypeCodeNavigations { get; set; } = new List<Warrant>();

    public virtual ICollection<Warrant> WarrantCourtNavigations { get; set; } = new List<Warrant>();

    public virtual ICollection<WarrantOffense> WarrantOffenseAclflagCodeNavigations { get; set; } = new List<WarrantOffense>();

    public virtual ICollection<WarrantOffense> WarrantOffenseAgencies { get; set; } = new List<WarrantOffense>();

    public virtual ICollection<Warrant> WarrantWarrantSourceCodeNavigations { get; set; } = new List<Warrant>();

    public virtual ICollection<Warrant> WarrantWarrantTypeCodeNavigations { get; set; } = new List<Warrant>();
}
