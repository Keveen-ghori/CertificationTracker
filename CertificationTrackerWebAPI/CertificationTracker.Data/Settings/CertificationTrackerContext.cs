using System;
using System.Collections.Generic;
using CertificationTracker.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CertificationTracker.Data.Settings;

public partial class CertificationTrackerContext : DbContext
{
    public CertificationTrackerContext()
    {
    }

    public CertificationTrackerContext(DbContextOptions<CertificationTrackerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddressDirecctory> AddressDirecctories { get; set; }

    public virtual DbSet<ArrestBooking> ArrestBookings { get; set; }

    public virtual DbSet<BookingProperty> BookingProperties { get; set; }

    public virtual DbSet<BookingReleaseInfo> BookingReleaseInfos { get; set; }

    public virtual DbSet<CgsmappingtoNibr> CgsmappingtoNibrs { get; set; }

    public virtual DbSet<CorrectionMergedPersonsHistory> CorrectionMergedPersonsHistories { get; set; }

    public virtual DbSet<CourtChargeInfo> CourtChargeInfos { get; set; }

    public virtual DbSet<Crash> Crashes { get; set; }

    public virtual DbSet<CrashCommentsInvolvement> CrashCommentsInvolvements { get; set; }

    public virtual DbSet<CrashGeneratedReport> CrashGeneratedReports { get; set; }

    public virtual DbSet<CrashInProgress> CrashInProgresses { get; set; }

    public virtual DbSet<CrashOfficialInvolvement> CrashOfficialInvolvements { get; set; }

    public virtual DbSet<CrashPersonInvolvement> CrashPersonInvolvements { get; set; }

    public virtual DbSet<CrashPersonSummaryDatum> CrashPersonSummaryData { get; set; }

    public virtual DbSet<CrashPropertyInvolvement> CrashPropertyInvolvements { get; set; }

    public virtual DbSet<CrashRelatedAttachment> CrashRelatedAttachments { get; set; }

    public virtual DbSet<CrashSummaryDatum> CrashSummaryData { get; set; }

    public virtual DbSet<CrashVehicleAreaImpact> CrashVehicleAreaImpacts { get; set; }

    public virtual DbSet<CrashVehicleCommericalInfo> CrashVehicleCommericalInfos { get; set; }

    public virtual DbSet<CrashVehicleInvolvement> CrashVehicleInvolvements { get; set; }

    public virtual DbSet<CrashVehicleSummaryDatum> CrashVehicleSummaryData { get; set; }

    public virtual DbSet<CustodyLog> CustodyLogs { get; set; }

    public virtual DbSet<DailyArrestLog> DailyArrestLogs { get; set; }

    public virtual DbSet<DailyArrestLog2> DailyArrestLog2s { get; set; }

    public virtual DbSet<DailyArrestLog3> DailyArrestLog3s { get; set; }

    public virtual DbSet<DataProcess> DataProcesses { get; set; }

    public virtual DbSet<DataProcessDetailStep> DataProcessDetailSteps { get; set; }

    public virtual DbSet<DataProcessRule> DataProcessRules { get; set; }

    public virtual DbSet<DataProcessRuleAction> DataProcessRuleActions { get; set; }

    public virtual DbSet<DataProcessRuleCondition> DataProcessRuleConditions { get; set; }

    public virtual DbSet<DataProcessStep> DataProcessSteps { get; set; }

    public virtual DbSet<DataProcessStepDataItem> DataProcessStepDataItems { get; set; }

    public virtual DbSet<DataProcessTrigger> DataProcessTriggers { get; set; }

    public virtual DbSet<DeletedIncidentPersonInvolvementHistory> DeletedIncidentPersonInvolvementHistories { get; set; }

    public virtual DbSet<DepApplicationUsage> DepApplicationUsages { get; set; }

    public virtual DbSet<DepOrgEmployee> DepOrgEmployees { get; set; }

    public virtual DbSet<DepOrgUnit> DepOrgUnits { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DepartmentDailyRoster> DepartmentDailyRosters { get; set; }

    public virtual DbSet<DepartmentEmployee> DepartmentEmployees { get; set; }

    public virtual DbSet<DepartmentEmployeeManagement> DepartmentEmployeeManagements { get; set; }

    public virtual DbSet<DepartmentGisgeometry> DepartmentGisgeometries { get; set; }

    public virtual DbSet<DepartmentGislayer> DepartmentGislayers { get; set; }

    public virtual DbSet<DepartmentOrg> DepartmentOrgs { get; set; }

    public virtual DbSet<DepartmentUnit> DepartmentUnits { get; set; }

    public virtual DbSet<DepartmentUnitShiftGroup> DepartmentUnitShiftGroups { get; set; }

    public virtual DbSet<DepartmentUnitType> DepartmentUnitTypes { get; set; }

    public virtual DbSet<DepartmentVehicle> DepartmentVehicles { get; set; }

    public virtual DbSet<DirectoryContact> DirectoryContacts { get; set; }

    public virtual DbSet<DispositionSpecialProcess> DispositionSpecialProcesses { get; set; }

    public virtual DbSet<DispositionSpecialProcessOnStatute> DispositionSpecialProcessOnStatutes { get; set; }

    public virtual DbSet<DispositionsChargesImport> DispositionsChargesImports { get; set; }

    public virtual DbSet<DispositionsImport> DispositionsImports { get; set; }

    public virtual DbSet<EmployeeEquipment> EmployeeEquipments { get; set; }

    public virtual DbSet<EmployeeHistory> EmployeeHistories { get; set; }

    public virtual DbSet<EmployeeNote> EmployeeNotes { get; set; }

    public virtual DbSet<EmployeePhoto> EmployeePhotos { get; set; }

    public virtual DbSet<EmployeeWorkingLog> EmployeeWorkingLogs { get; set; }

    public virtual DbSet<EmployeesCourseSkill> EmployeesCourseSkills { get; set; }

    public virtual DbSet<EnfieldDatacPendingIncidentRemoveRmsuserQueryResult> EnfieldDatacPendingIncidentRemoveRmsuserQueryResults { get; set; }

    public virtual DbSet<EnfieldImportArrestHisotry> EnfieldImportArrestHisotries { get; set; }

    public virtual DbSet<EnfieldImportedInacivePersonSupplementHistory> EnfieldImportedInacivePersonSupplementHistories { get; set; }

    public virtual DbSet<EnfieldImportedSupplementHistory> EnfieldImportedSupplementHistories { get; set; }

    public virtual DbSet<EnforcementOfficialUnit> EnforcementOfficialUnits { get; set; }

    public virtual DbSet<EnforcementOfficialUnitStatusDetail> EnforcementOfficialUnitStatusDetails { get; set; }

    public virtual DbSet<EvidenceDataExport> EvidenceDataExports { get; set; }

    public virtual DbSet<ExcelArresteeSummary> ExcelArresteeSummaries { get; set; }

    public virtual DbSet<ExcelCrashSummary> ExcelCrashSummaries { get; set; }

    public virtual DbSet<ExcelIncidentCrime> ExcelIncidentCrimes { get; set; }

    public virtual DbSet<ExcelIncidentSummary> ExcelIncidentSummaries { get; set; }

    public virtual DbSet<ExcelTssummary> ExcelTssummaries { get; set; }

    public virtual DbSet<ExportPropertyEvidenceRecord> ExportPropertyEvidenceRecords { get; set; }

    public virtual DbSet<FieldInterview> FieldInterviews { get; set; }

    public virtual DbSet<FieldInterviewPersonInvolvment> FieldInterviewPersonInvolvments { get; set; }

    public virtual DbSet<FieldInterviewVehicleInvolvment> FieldInterviewVehicleInvolvments { get; set; }

    public virtual DbSet<GetIncidentUcr> GetIncidentUcrs { get; set; }

    public virtual DbSet<HelpQueryLocationInvolvement> HelpQueryLocationInvolvements { get; set; }

    public virtual DbSet<HelpQueryOrganizationInvolvement> HelpQueryOrganizationInvolvements { get; set; }

    public virtual DbSet<HelpQueryPersonInvolvement> HelpQueryPersonInvolvements { get; set; }

    public virtual DbSet<HelpQueryPropertyInvolvement> HelpQueryPropertyInvolvements { get; set; }

    public virtual DbSet<HelpQueryVehicleInvolvement> HelpQueryVehicleInvolvements { get; set; }

    public virtual DbSet<ImportEmployeePostrecord> ImportEmployeePostrecords { get; set; }

    public virtual DbSet<ImportInstructor> ImportInstructors { get; set; }

    public virtual DbSet<ImportPostcourse> ImportPostcourses { get; set; }

    public virtual DbSet<ImportedIncident> ImportedIncidents { get; set; }

    public virtual DbSet<Incident> Incidents { get; set; }

    public virtual DbSet<IncidentBiasHateCrimeFactor> IncidentBiasHateCrimeFactors { get; set; }

    public virtual DbSet<IncidentBiasHateCrimeFactorsOffense> IncidentBiasHateCrimeFactorsOffenses { get; set; }

    public virtual DbSet<IncidentCommentsInvolvement> IncidentCommentsInvolvements { get; set; }

    public virtual DbSet<IncidentFamilyViolence> IncidentFamilyViolences { get; set; }

    public virtual DbSet<IncidentForceInvolvement> IncidentForceInvolvements { get; set; }

    public virtual DbSet<IncidentForceReport> IncidentForceReports { get; set; }

    public virtual DbSet<IncidentGeneralCategory> IncidentGeneralCategories { get; set; }

    public virtual DbSet<IncidentGeneratedReport> IncidentGeneratedReports { get; set; }

    public virtual DbSet<IncidentInvestigationManagement> IncidentInvestigationManagements { get; set; }

    public virtual DbSet<IncidentMissingPersonDetail> IncidentMissingPersonDetails { get; set; }

    public virtual DbSet<IncidentMo> IncidentMos { get; set; }

    public virtual DbSet<IncidentNibrsoffenseBase> IncidentNibrsoffenseBases { get; set; }

    public virtual DbSet<IncidentOfficialInvolvement> IncidentOfficialInvolvements { get; set; }

    public virtual DbSet<IncidentOrganizationInvolvement> IncidentOrganizationInvolvements { get; set; }

    public virtual DbSet<IncidentOtherFactor> IncidentOtherFactors { get; set; }

    public virtual DbSet<IncidentOutOfTownWarrant> IncidentOutOfTownWarrants { get; set; }

    public virtual DbSet<IncidentPersonFamilyViolence> IncidentPersonFamilyViolences { get; set; }

    public virtual DbSet<IncidentPersonInjuryDetail> IncidentPersonInjuryDetails { get; set; }

    public virtual DbSet<IncidentPersonInvolvement> IncidentPersonInvolvements { get; set; }

    public virtual DbSet<IncidentPersonVictimDetail> IncidentPersonVictimDetails { get; set; }

    public virtual DbSet<IncidentPersonWitnessDetail> IncidentPersonWitnessDetails { get; set; }

    public virtual DbSet<IncidentPropertyDrugDetail> IncidentPropertyDrugDetails { get; set; }

    public virtual DbSet<IncidentPropertyInvolvement> IncidentPropertyInvolvements { get; set; }

    public virtual DbSet<IncidentRelatedAttachment> IncidentRelatedAttachments { get; set; }

    public virtual DbSet<IncidentReportDistribution> IncidentReportDistributions { get; set; }

    public virtual DbSet<IncidentReportTypeDetail> IncidentReportTypeDetails { get; set; }

    public virtual DbSet<IncidentUseOfForce> IncidentUseOfForces { get; set; }

    public virtual DbSet<IncidentUseOfForceEquipment> IncidentUseOfForceEquipments { get; set; }

    public virtual DbSet<IncidentUseOfForceInjuryDetail> IncidentUseOfForceInjuryDetails { get; set; }

    public virtual DbSet<IncidentUseOfForceOfficerDetail> IncidentUseOfForceOfficerDetails { get; set; }

    public virtual DbSet<IncidentVehicleInvolvement> IncidentVehicleInvolvements { get; set; }

    public virtual DbSet<IndividualSecurityToUser> IndividualSecurityToUsers { get; set; }

    public virtual DbSet<IrcodeGenerator> IrcodeGenerators { get; set; }

    public virtual DbSet<IrcodeGeneratorRule> IrcodeGeneratorRules { get; set; }

    public virtual DbSet<IrcodeGeneratorRuleCondition> IrcodeGeneratorRuleConditions { get; set; }

    public virtual DbSet<JuvenileBookingDetail> JuvenileBookingDetails { get; set; }

    public virtual DbSet<LnkaddressDirectoryToCategory> LnkaddressDirectoryToCategories { get; set; }

    public virtual DbSet<LnkdrugStatute> LnkdrugStatutes { get; set; }

    public virtual DbSet<LocationGisinformation> LocationGisinformations { get; set; }

    public virtual DbSet<MergePersonApplicationWiseMasterHistory> MergePersonApplicationWiseMasterHistories { get; set; }

    public virtual DbSet<MergePersonApplicationWiseRecordsHistory> MergePersonApplicationWiseRecordsHistories { get; set; }

    public virtual DbSet<MergedPersonsHistory> MergedPersonsHistories { get; set; }

    public virtual DbSet<MissingPersonApplicationWiseRecordsHistory> MissingPersonApplicationWiseRecordsHistories { get; set; }

    public virtual DbSet<Mstrlocation> Mstrlocations { get; set; }

    public virtual DbSet<MstrlocationAlert> MstrlocationAlerts { get; set; }

    public virtual DbSet<MstrlocationImage> MstrlocationImages { get; set; }

    public virtual DbSet<MstrlocationRelatedMedium> MstrlocationRelatedMedia { get; set; }

    public virtual DbSet<MstrmediaContentInfo> MstrmediaContentInfos { get; set; }

    public virtual DbSet<Mstrorganization> Mstrorganizations { get; set; }

    public virtual DbSet<MstrorganizationImage> MstrorganizationImages { get; set; }

    public virtual DbSet<MstrorganizationRelatedIndex> MstrorganizationRelatedIndices { get; set; }

    public virtual DbSet<MstrorganizationRelatedMedium> MstrorganizationRelatedMedia { get; set; }

    public virtual DbSet<Mstrperson> Mstrpeople { get; set; }

    public virtual DbSet<MstrpersonAlert> MstrpersonAlerts { get; set; }

    public virtual DbSet<MstrpersonCharacteristic> MstrpersonCharacteristics { get; set; }

    public virtual DbSet<MstrpersonContactDetail> MstrpersonContactDetails { get; set; }

    public virtual DbSet<MstrpersonContactInfo> MstrpersonContactInfos { get; set; }

    public virtual DbSet<MstrpersonFingerprintSet> MstrpersonFingerprintSets { get; set; }

    public virtual DbSet<MstrpersonIdentification> MstrpersonIdentifications { get; set; }

    public virtual DbSet<MstrpersonLocation> MstrpersonLocations { get; set; }

    public virtual DbSet<MstrpersonMedicalCondition> MstrpersonMedicalConditions { get; set; }

    public virtual DbSet<MstrpersonMugShot> MstrpersonMugShots { get; set; }

    public virtual DbSet<MstrpersonMugShotImage> MstrpersonMugShotImages { get; set; }

    public virtual DbSet<MstrpersonMugShotImagesHistory> MstrpersonMugShotImagesHistories { get; set; }

    public virtual DbSet<MstrpersonMugShotsHistory> MstrpersonMugShotsHistories { get; set; }

    public virtual DbSet<MstrpersonName> MstrpersonNames { get; set; }

    public virtual DbSet<MstrpersonOperatorLicense> MstrpersonOperatorLicenses { get; set; }

    public virtual DbSet<MstrpersonPhysicalFeature> MstrpersonPhysicalFeatures { get; set; }

    public virtual DbSet<MstrpersonRelatedMedium> MstrpersonRelatedMedia { get; set; }

    public virtual DbSet<MstrpersonRelation> MstrpersonRelations { get; set; }

    public virtual DbSet<MstrpersonsSetActive> MstrpersonsSetActives { get; set; }

    public virtual DbSet<Mstrproperty> Mstrproperties { get; set; }

    public virtual DbSet<MstrpropertyDetail> MstrpropertyDetails { get; set; }

    public virtual DbSet<MstrpropertyImage> MstrpropertyImages { get; set; }

    public virtual DbSet<MstrpropertyOwner> MstrpropertyOwners { get; set; }

    public virtual DbSet<MstrpropertyRelatedMedium> MstrpropertyRelatedMedia { get; set; }

    public virtual DbSet<Mstrvehicle> Mstrvehicles { get; set; }

    public virtual DbSet<MstrvehicleRegOwner> MstrvehicleRegOwners { get; set; }

    public virtual DbSet<MstrvehicleRelatedMedium> MstrvehicleRelatedMedia { get; set; }

    public virtual DbSet<MstrvehicleStatus> MstrvehicleStatuses { get; set; }

    public virtual DbSet<NibrsexportHistory> NibrsexportHistories { get; set; }

    public virtual DbSet<NibrsreferenceDatum> NibrsreferenceData { get; set; }

    public virtual DbSet<NibrsreportAdmin> NibrsreportAdmins { get; set; }

    public virtual DbSet<NibrsreportOffense> NibrsreportOffenses { get; set; }

    public virtual DbSet<NibrsreportPerson> NibrsreportPersons { get; set; }

    public virtual DbSet<NibrsreportProperty> NibrsreportProperties { get; set; }

    public virtual DbSet<NibrsreportPropertyDetail> NibrsreportPropertyDetails { get; set; }

    public virtual DbSet<NonVerifiedCallPerson> NonVerifiedCallPeople { get; set; }

    public virtual DbSet<NonVerifiedCallVehicle> NonVerifiedCallVehicles { get; set; }

    public virtual DbSet<NotificationMethod> NotificationMethods { get; set; }

    public virtual DbSet<Offense> Offenses { get; set; }

    public virtual DbSet<OldcgsmappingtoNibr> OldcgsmappingtoNibrs { get; set; }

    public virtual DbSet<PhotoLineup> PhotoLineups { get; set; }

    public virtual DbSet<PhotoLineupPhoto> PhotoLineupPhotos { get; set; }

    public virtual DbSet<PhotoLineupSequence> PhotoLineupSequences { get; set; }

    public virtual DbSet<PhotoLineupViewer> PhotoLineupViewers { get; set; }

    public virtual DbSet<PistolPermit> PistolPermits { get; set; }

    public virtual DbSet<Postarea> Postareas { get; set; }

    public virtual DbSet<PostcostPeriod> PostcostPeriods { get; set; }

    public virtual DbSet<PostcostRank> PostcostRanks { get; set; }

    public virtual DbSet<Postcourse> Postcourses { get; set; }

    public virtual DbSet<PostcourseArea> PostcourseAreas { get; set; }

    public virtual DbSet<PostcourseAttachment> PostcourseAttachments { get; set; }

    public virtual DbSet<PostcurriculumArea> PostcurriculumAreas { get; set; }

    public virtual DbSet<Postemployee> Postemployees { get; set; }

    public virtual DbSet<PostemployeeCourse> PostemployeeCourses { get; set; }

    public virtual DbSet<PostemployeeCourseArea> PostemployeeCourseAreas { get; set; }

    public virtual DbSet<PostimportEmployee> PostimportEmployees { get; set; }

    public virtual DbSet<PostimportInstructor> PostimportInstructors { get; set; }

    public virtual DbSet<PostimportInstructorArea> PostimportInstructorAreas { get; set; }

    public virtual DbSet<PostimportInstuctorAudit> PostimportInstuctorAudits { get; set; }

    public virtual DbSet<Postinstructor> Postinstructors { get; set; }

    public virtual DbSet<PostinstructorCertifiedArea> PostinstructorCertifiedAreas { get; set; }

    public virtual DbSet<PostinstructorHour> PostinstructorHours { get; set; }

    public virtual DbSet<PostoutSideInstructor> PostoutSideInstructors { get; set; }

    public virtual DbSet<Postrenewal> Postrenewals { get; set; }

    public virtual DbSet<PropertyCustodyTracking> PropertyCustodyTrackings { get; set; }

    public virtual DbSet<PropertyRoomItem> PropertyRoomItems { get; set; }

    public virtual DbSet<PrtPropertyReceipt1property> PrtPropertyReceipt1properties { get; set; }

    public virtual DbSet<PrtPropertyReceipt2propertyInvolvement> PrtPropertyReceipt2propertyInvolvements { get; set; }

    public virtual DbSet<PrtPropertyReceipt3groupInvolvement> PrtPropertyReceipt3groupInvolvements { get; set; }

    public virtual DbSet<PrtPropertyReceipt4custody> PrtPropertyReceipt4custodies { get; set; }

    public virtual DbSet<PrtPropertyReceiptOp> PrtPropertyReceiptOps { get; set; }

    public virtual DbSet<RacialProfiling> RacialProfilings { get; set; }

    public virtual DbSet<RefCallForServiceDefinition> RefCallForServiceDefinitions { get; set; }

    public virtual DbSet<RefCallPriority> RefCallPriorities { get; set; }

    public virtual DbSet<RefCrashReferenceDatum> RefCrashReferenceData { get; set; }

    public virtual DbSet<RefDirectoryCategory> RefDirectoryCategories { get; set; }

    public virtual DbSet<RefDispositionCode> RefDispositionCodes { get; set; }

    public virtual DbSet<RefDrugDataAlternative> RefDrugDataAlternatives { get; set; }

    public virtual DbSet<RefDrugDatum> RefDrugData { get; set; }

    public virtual DbSet<RefIncidentReferenceDatum> RefIncidentReferenceData { get; set; }

    public virtual DbSet<RefMiscReferenceDatum> RefMiscReferenceData { get; set; }

    public virtual DbSet<RefMstrinxreferenceDatum> RefMstrinxreferenceData { get; set; }

    public virtual DbSet<RefNarrativeTemplate> RefNarrativeTemplates { get; set; }

    public virtual DbSet<RefNibrscodeDefinition> RefNibrscodeDefinitions { get; set; }

    public virtual DbSet<RefOffenseCodeDefinition> RefOffenseCodeDefinitions { get; set; }

    public virtual DbSet<RefPropertyDatum> RefPropertyData { get; set; }

    public virtual DbSet<RefStatuteDefinition> RefStatuteDefinitions { get; set; }

    public virtual DbSet<RefTrafficStopTicketReferenceDatum> RefTrafficStopTicketReferenceData { get; set; }

    public virtual DbSet<RefUcrcodeDefinition> RefUcrcodeDefinitions { get; set; }

    public virtual DbSet<RefViolation> RefViolations { get; set; }

    public virtual DbSet<ReportContainer> ReportContainers { get; set; }

    public virtual DbSet<ReportDefinition> ReportDefinitions { get; set; }

    public virtual DbSet<ReportHelper> ReportHelpers { get; set; }

    public virtual DbSet<RestoreCancelledApplicationDatum> RestoreCancelledApplicationData { get; set; }

    public virtual DbSet<RmsapplicationActionTrace> RmsapplicationActionTraces { get; set; }

    public virtual DbSet<RmsapplicationDataExportLog> RmsapplicationDataExportLogs { get; set; }

    public virtual DbSet<RmsdataChangeTrace> RmsdataChangeTraces { get; set; }

    public virtual DbSet<RmsdataDeleteTrace> RmsdataDeleteTraces { get; set; }

    public virtual DbSet<RmsdataProcessController> RmsdataProcessControllers { get; set; }

    public virtual DbSet<RmsdataProcessDetailStep> RmsdataProcessDetailSteps { get; set; }

    public virtual DbSet<RmsdataProcessDetailStepRulesAction> RmsdataProcessDetailStepRulesActions { get; set; }

    public virtual DbSet<RmsdeptWorkFlow> RmsdeptWorkFlows { get; set; }

    public virtual DbSet<RmsdeptWorkFlowReviewRequirement> RmsdeptWorkFlowReviewRequirements { get; set; }

    public virtual DbSet<RmsimportLog> RmsimportLogs { get; set; }

    public virtual DbSet<RmsnotificationLog> RmsnotificationLogs { get; set; }

    public virtual DbSet<RmsuserAccessTrace> RmsuserAccessTraces { get; set; }

    public virtual DbSet<RmsuserQueryResult> RmsuserQueryResults { get; set; }

    public virtual DbSet<RmsworkFlowController> RmsworkFlowControllers { get; set; }

    public virtual DbSet<RmsworkFlowDef> RmsworkFlowDefs { get; set; }

    public virtual DbSet<RmsworkFlowPlan> RmsworkFlowPlans { get; set; }

    public virtual DbSet<RptArrestByHour1getArrestTimeRange> RptArrestByHour1getArrestTimeRanges { get; set; }

    public virtual DbSet<RptArrestByHour2allHour> RptArrestByHour2allHours { get; set; }

    public virtual DbSet<RptArrestByRaceSex> RptArrestByRaceSexes { get; set; }

    public virtual DbSet<RptArrestCategoryFm> RptArrestCategoryFms { get; set; }

    public virtual DbSet<RptArrestCount> RptArrestCounts { get; set; }

    public virtual DbSet<RptArrestDrugDetail> RptArrestDrugDetails { get; set; }

    public virtual DbSet<RptArrestee> RptArrestees { get; set; }

    public virtual DbSet<RptArresteeListOp> RptArresteeListOps { get; set; }

    public virtual DbSet<RptArresteeListOp2> RptArresteeListOp2s { get; set; }

    public virtual DbSet<RptArrestsUnder21School> RptArrestsUnder21Schools { get; set; }

    public virtual DbSet<RptArrestsUnder21SchoolCitation> RptArrestsUnder21SchoolCitations { get; set; }

    public virtual DbSet<RptArrestsUnder21SchoolIncident> RptArrestsUnder21SchoolIncidents { get; set; }

    public virtual DbSet<RptCaseSum1getClearanceDatum> RptCaseSum1getClearanceData { get; set; }

    public virtual DbSet<RptCaseSum2getComplainant> RptCaseSum2getComplainants { get; set; }

    public virtual DbSet<RptCaseSum3defineUcrstatus> RptCaseSum3defineUcrstatuses { get; set; }

    public virtual DbSet<RptCaseSumOp> RptCaseSumOps { get; set; }

    public virtual DbSet<RptCaseSumOpx> RptCaseSumOpxes { get; set; }

    public virtual DbSet<RptClassificationSearch> RptClassificationSearches { get; set; }

    public virtual DbSet<RptCrashEnforcementWinjury> RptCrashEnforcementWinjuries { get; set; }

    public virtual DbSet<RptCrashReportHfd> RptCrashReportHfds { get; set; }

    public virtual DbSet<RptCrashReportHfdActivity> RptCrashReportHfdActivities { get; set; }

    public virtual DbSet<RptCrashRptInProgress> RptCrashRptInProgresses { get; set; }

    public virtual DbSet<RptCrashWmostSeriousInjury> RptCrashWmostSeriousInjuries { get; set; }

    public virtual DbSet<RptCriminalHistory> RptCriminalHistories { get; set; }

    public virtual DbSet<RptCriminalHistoryAdult> RptCriminalHistoryAdults { get; set; }

    public virtual DbSet<RptCriminalHistoryAdultNolle> RptCriminalHistoryAdultNolles { get; set; }

    public virtual DbSet<RptCriminalHistoryJuvi> RptCriminalHistoryJuvis { get; set; }

    public virtual DbSet<RptCriminalHistoryMisdemeanor> RptCriminalHistoryMisdemeanors { get; set; }

    public virtual DbSet<RptCriminalHistoryNolle> RptCriminalHistoryNolles { get; set; }

    public virtual DbSet<RptCriminalHistoryOffense> RptCriminalHistoryOffenses { get; set; }

    public virtual DbSet<RptCriminalHistoryOfficer> RptCriminalHistoryOfficers { get; set; }

    public virtual DbSet<RptCriminalHistoryPerson> RptCriminalHistoryPeople { get; set; }

    public virtual DbSet<RptCriminalHistoryTrafficStop> RptCriminalHistoryTrafficStops { get; set; }

    public virtual DbSet<RptDrug> RptDrugs { get; set; }

    public virtual DbSet<RptDrugArrestCount> RptDrugArrestCounts { get; set; }

    public virtual DbSet<RptDuireport> RptDuireports { get; set; }

    public virtual DbSet<RptEvadePpawaction> RptEvadePpawactions { get; set; }

    public virtual DbSet<RptEvadePpawcount> RptEvadePpawcounts { get; set; }

    public virtual DbSet<RptLarcenyAuto> RptLarcenyAutos { get; set; }

    public virtual DbSet<RptLarcenyAutoArrest> RptLarcenyAutoArrests { get; set; }

    public virtual DbSet<RptMissingPerson> RptMissingPeople { get; set; }

    public virtual DbSet<RptMissingPersonEver> RptMissingPersonEvers { get; set; }

    public virtual DbSet<RptNarrativesIncident> RptNarrativesIncidents { get; set; }

    public virtual DbSet<RptOfficerActivityArrestCustodial> RptOfficerActivityArrestCustodials { get; set; }

    public virtual DbSet<RptOfficerActivityArrestNonCust> RptOfficerActivityArrestNonCusts { get; set; }

    public virtual DbSet<RptOfficerActivityCrash> RptOfficerActivityCrashes { get; set; }

    public virtual DbSet<RptOfficerActivityGetArrest> RptOfficerActivityGetArrests { get; set; }

    public virtual DbSet<RptOfficerActivityGetArrestMisd> RptOfficerActivityGetArrestMisds { get; set; }

    public virtual DbSet<RptOfficerActivityGetCrash> RptOfficerActivityGetCrashes { get; set; }

    public virtual DbSet<RptOfficerActivityGetIncident> RptOfficerActivityGetIncidents { get; set; }

    public virtual DbSet<RptOfficerActivityGetIncidentNc> RptOfficerActivityGetIncidentNcs { get; set; }

    public virtual DbSet<RptOfficerActivityGetTrafficStop> RptOfficerActivityGetTrafficStops { get; set; }

    public virtual DbSet<RptOfficerActivityGetWarrant> RptOfficerActivityGetWarrants { get; set; }

    public virtual DbSet<RptOfficerActivityIncident> RptOfficerActivityIncidents { get; set; }

    public virtual DbSet<RptOfficerActivityTrafficStop> RptOfficerActivityTrafficStops { get; set; }

    public virtual DbSet<RptOfficerActivityWarrant> RptOfficerActivityWarrants { get; set; }

    public virtual DbSet<RptPforce1aGetAllForceType> RptPforce1aGetAllForceTypes { get; set; }

    public virtual DbSet<RptPforce1bGetAllForceTypeText> RptPforce1bGetAllForceTypeTexts { get; set; }

    public virtual DbSet<RptPforce2aGetAllWeaponType> RptPforce2aGetAllWeaponTypes { get; set; }

    public virtual DbSet<RptPforce2bGetAllWeaponTypeText> RptPforce2bGetAllWeaponTypeTexts { get; set; }

    public virtual DbSet<RptPforce3aGetAllSubjBeh> RptPforce3aGetAllSubjBehs { get; set; }

    public virtual DbSet<RptPforce3bGetAllSubjBehText> RptPforce3bGetAllSubjBehTexts { get; set; }

    public virtual DbSet<RptPforce4aGetAllSubjCond> RptPforce4aGetAllSubjConds { get; set; }

    public virtual DbSet<RptPforce4bGetAllSubjCondText> RptPforce4bGetAllSubjCondTexts { get; set; }

    public virtual DbSet<RptPforce5aGetAllOfficerCond> RptPforce5aGetAllOfficerConds { get; set; }

    public virtual DbSet<RptPforce5bGetAllOfficerCondText> RptPforce5bGetAllOfficerCondTexts { get; set; }

    public virtual DbSet<RptPuofOfficerControlMethod> RptPuofOfficerControlMethods { get; set; }

    public virtual DbSet<RptPuofSummary> RptPuofSummaries { get; set; }

    public virtual DbSet<RptRacialProfile> RptRacialProfiles { get; set; }

    public virtual DbSet<RptRecentlyFiledCrash> RptRecentlyFiledCrashes { get; set; }

    public virtual DbSet<RptRefDrugStatuteDef> RptRefDrugStatuteDefs { get; set; }

    public virtual DbSet<RptRpsexRace> RptRpsexRaces { get; set; }

    public virtual DbSet<RptSummonInfraction> RptSummonInfractions { get; set; }

    public virtual DbSet<RptTcexportLog> RptTcexportLogs { get; set; }

    public virtual DbSet<RptTrafficStopCountsByResultofStop> RptTrafficStopCountsByResultofStops { get; set; }

    public virtual DbSet<RptTrafficStopOp> RptTrafficStopOps { get; set; }

    public virtual DbSet<RptTrafficStopProactiveEnforcement> RptTrafficStopProactiveEnforcements { get; set; }

    public virtual DbSet<RptUcrasradult1select> RptUcrasradult1selects { get; set; }

    public virtual DbSet<RptUcrasradult2case> RptUcrasradult2cases { get; set; }

    public virtual DbSet<RptUcrasradult3aAllDept> RptUcrasradult3aAllDepts { get; set; }

    public virtual DbSet<RptUcrasradult3bGroupRefUcr> RptUcrasradult3bGroupRefUcrs { get; set; }

    public virtual DbSet<RptUcrasradult4> RptUcrasradult4s { get; set; }

    public virtual DbSet<RptUcrasradultDrugTotal> RptUcrasradultDrugTotals { get; set; }

    public virtual DbSet<RptUcrasradultDrugTotalF> RptUcrasradultDrugTotalves { get; set; }

    public virtual DbSet<RptUcrasradultDrugTotalM> RptUcrasradultDrugTotalMs { get; set; }

    public virtual DbSet<RptUcrasradultOp> RptUcrasradultOps { get; set; }

    public virtual DbSet<RptUcrasradultOp1> RptUcrasradultOp1s { get; set; }

    public virtual DbSet<RptUcrasradultOp2> RptUcrasradultOp2s { get; set; }

    public virtual DbSet<RptUcrasrjuv1select> RptUcrasrjuv1selects { get; set; }

    public virtual DbSet<RptUcrasrjuv2case> RptUcrasrjuv2cases { get; set; }

    public virtual DbSet<RptUcrasrjuv3bGroupRefUcr> RptUcrasrjuv3bGroupRefUcrs { get; set; }

    public virtual DbSet<RptUcrasrjuv4> RptUcrasrjuv4s { get; set; }

    public virtual DbSet<RptUcrasrjuvDrugTotal> RptUcrasrjuvDrugTotals { get; set; }

    public virtual DbSet<RptUcrasrjuvDrugTotalF> RptUcrasrjuvDrugTotalves { get; set; }

    public virtual DbSet<RptUcrasrjuvDrugTotalM> RptUcrasrjuvDrugTotalMs { get; set; }

    public virtual DbSet<RptUcrasrjuvOp> RptUcrasrjuvOps { get; set; }

    public virtual DbSet<RptUcrasrjuvOp1> RptUcrasrjuvOp1s { get; set; }

    public virtual DbSet<RptUcrasrjuvOp2> RptUcrasrjuvOp2s { get; set; }

    public virtual DbSet<RptUcraudit1getIncident> RptUcraudit1getIncidents { get; set; }

    public virtual DbSet<RptUcraudit2getEventType> RptUcraudit2getEventTypes { get; set; }

    public virtual DbSet<RptUcraudit3getStolenRecProp> RptUcraudit3getStolenRecProps { get; set; }

    public virtual DbSet<RptUcraudit4getStolenRecVeh> RptUcraudit4getStolenRecVehs { get; set; }

    public virtual DbSet<RptUcraudit5unionPropVeh> RptUcraudit5unionPropVehs { get; set; }

    public virtual DbSet<RptUcrauditOp> RptUcrauditOps { get; set; }

    public virtual DbSet<RptUcrhom1a1selectVictim> RptUcrhom1a1selectVictims { get; set; }

    public virtual DbSet<RptUcrhom1a2countVictim> RptUcrhom1a2countVictims { get; set; }

    public virtual DbSet<RptUcrhom1a3selectOffender> RptUcrhom1a3selectOffenders { get; set; }

    public virtual DbSet<RptUcrhom1a4countOffender> RptUcrhom1a4countOffenders { get; set; }

    public virtual DbSet<RptUcrhom1a5countVictimOffender> RptUcrhom1a5countVictimOffenders { get; set; }

    public virtual DbSet<RptUcrhom1aOp> RptUcrhom1aOps { get; set; }

    public virtual DbSet<RptUcrhom1b1selectVictim> RptUcrhom1b1selectVictims { get; set; }

    public virtual DbSet<RptUcrhom1b2countVictim> RptUcrhom1b2countVictims { get; set; }

    public virtual DbSet<RptUcrhom1b3selectOffender> RptUcrhom1b3selectOffenders { get; set; }

    public virtual DbSet<RptUcrhom1b4countOffender> RptUcrhom1b4countOffenders { get; set; }

    public virtual DbSet<RptUcrhom1b5countVictimOffender> RptUcrhom1b5countVictimOffenders { get; set; }

    public virtual DbSet<RptUcrhom1bOp> RptUcrhom1bOps { get; set; }

    public virtual DbSet<RptUcrhomicde> RptUcrhomicdes { get; set; }

    public virtual DbSet<RptUcrmonthlyArson1bSelectClearance> RptUcrmonthlyArson1bSelectClearances { get; set; }

    public virtual DbSet<RptUcrmonthlyArson1select> RptUcrmonthlyArson1selects { get; set; }

    public virtual DbSet<RptUcrmonthlyArson2bGroupArson> RptUcrmonthlyArson2bGroupArsons { get; set; }

    public virtual DbSet<RptUcrmonthlyArson3aGetVehicleValue> RptUcrmonthlyArson3aGetVehicleValues { get; set; }

    public virtual DbSet<RptUcrmonthlyArson3getPropertyValue> RptUcrmonthlyArson3getPropertyValues { get; set; }

    public virtual DbSet<RptUcrmonthlyArson4clearanceJuv> RptUcrmonthlyArson4clearanceJuvs { get; set; }

    public virtual DbSet<RptUcrmonthlyArson5> RptUcrmonthlyArson5s { get; set; }

    public virtual DbSet<RptUcrmonthlyArsonOp> RptUcrmonthlyArsonOps { get; set; }

    public virtual DbSet<RptUcrreturnA1bSelectClearance> RptUcrreturnA1bSelectClearances { get; set; }

    public virtual DbSet<RptUcrreturnA1select> RptUcrreturnA1selects { get; set; }

    public virtual DbSet<RptUcrreturnA2aAllDept> RptUcrreturnA2aAllDepts { get; set; }

    public virtual DbSet<RptUcrreturnA2bGroupRefUcr> RptUcrreturnA2bGroupRefUcrs { get; set; }

    public virtual DbSet<RptUcrreturnA3aArresteeAge> RptUcrreturnA3aArresteeAges { get; set; }

    public virtual DbSet<RptUcrreturnA3bArresteeJuv> RptUcrreturnA3bArresteeJuvs { get; set; }

    public virtual DbSet<RptUcrreturnA4clearanceJuv> RptUcrreturnA4clearanceJuvs { get; set; }

    public virtual DbSet<RptUcrreturnAOp> RptUcrreturnAOps { get; set; }

    public virtual DbSet<RptUcrsuppAoffense1select> RptUcrsuppAoffense1selects { get; set; }

    public virtual DbSet<RptUcrsuppAoffense3bGroupUcr> RptUcrsuppAoffense3bGroupUcrs { get; set; }

    public virtual DbSet<RptUcrsuppAoffense3cGroupStolenRecWhere> RptUcrsuppAoffense3cGroupStolenRecWheres { get; set; }

    public virtual DbSet<RptUcrsuppAoffense4> RptUcrsuppAoffense4s { get; set; }

    public virtual DbSet<RptUcrsuppAoffenseOp> RptUcrsuppAoffenseOps { get; set; }

    public virtual DbSet<RptUcrsuppAoffenseOp7x> RptUcrsuppAoffenseOp7xes { get; set; }

    public virtual DbSet<RptUcrsuppApropType1selectProperty> RptUcrsuppApropType1selectProperties { get; set; }

    public virtual DbSet<RptUcrsuppApropType2sumStolenRec> RptUcrsuppApropType2sumStolenRecs { get; set; }

    public virtual DbSet<RptUcrsuppApropType3aAllDept> RptUcrsuppApropType3aAllDepts { get; set; }

    public virtual DbSet<RptUcrsuppApropType3bGroupPropUcr> RptUcrsuppApropType3bGroupPropUcrs { get; set; }

    public virtual DbSet<RptUcrsuppApropType3cGroupVehUcr> RptUcrsuppApropType3cGroupVehUcrs { get; set; }

    public virtual DbSet<RptUcrsuppApropType4selectVehicle> RptUcrsuppApropType4selectVehicles { get; set; }

    public virtual DbSet<RptUcrsuppApropType5sumStolenRecVeh> RptUcrsuppApropType5sumStolenRecVehs { get; set; }

    public virtual DbSet<RptUcrsuppApropTypeOp> RptUcrsuppApropTypeOps { get; set; }

    public virtual DbSet<RptUcrsuppApropTypeOpveh> RptUcrsuppApropTypeOpvehs { get; set; }

    public virtual DbSet<RptUcrxref1arrestee> RptUcrxref1arrestees { get; set; }

    public virtual DbSet<RptUcrxref2classProp> RptUcrxref2classProps { get; set; }

    public virtual DbSet<RptUcrxref4veh> RptUcrxref4vehs { get; set; }

    public virtual DbSet<RptUcrxrefOp> RptUcrxrefOps { get; set; }

    public virtual DbSet<RptWarrant1getContact> RptWarrant1getContacts { get; set; }

    public virtual DbSet<RptWarrant2getPhone> RptWarrant2getPhones { get; set; }

    public virtual DbSet<RptWarrant3getName> RptWarrant3getNames { get; set; }

    public virtual DbSet<RptWarrantOp> RptWarrantOps { get; set; }

    public virtual DbSet<RptWarrantStuffStatue> RptWarrantStuffStatues { get; set; }

    public virtual DbSet<Sample> Samples { get; set; }

    public virtual DbSet<SecuredIncident> SecuredIncidents { get; set; }

    public virtual DbSet<SecurityGroupMember> SecurityGroupMembers { get; set; }

    public virtual DbSet<SecurityObject> SecurityObjects { get; set; }

    public virtual DbSet<SecurityObjectToprofile> SecurityObjectToprofiles { get; set; }

    public virtual DbSet<SecurityObjectTouserRole> SecurityObjectTouserRoles { get; set; }

    public virtual DbSet<SecurityProfile> SecurityProfiles { get; set; }

    public virtual DbSet<SecurityRole> SecurityRoles { get; set; }

    public virtual DbSet<SecurityRoleToUser> SecurityRoleToUsers { get; set; }

    public virtual DbSet<SerialLock> SerialLocks { get; set; }

    public virtual DbSet<ServiceCall> ServiceCalls { get; set; }

    public virtual DbSet<ServiceCallComment> ServiceCallComments { get; set; }

    public virtual DbSet<ServiceCallDispatchedOffical> ServiceCallDispatchedOfficals { get; set; }

    public virtual DbSet<ServiceCallDisposition> ServiceCallDispositions { get; set; }

    public virtual DbSet<ServiceCallLog> ServiceCallLogs { get; set; }

    public virtual DbSet<ServiceCallQuestionAnswer> ServiceCallQuestionAnswers { get; set; }

    public virtual DbSet<ShiftLogView> ShiftLogViews { get; set; }

    public virtual DbSet<SummonsInfraction> SummonsInfractions { get; set; }

    public virtual DbSet<SysAgency> SysAgencies { get; set; }

    public virtual DbSet<SysApplicationRelation> SysApplicationRelations { get; set; }

    public virtual DbSet<SysApplicationRelationHierarchy> SysApplicationRelationHierarchies { get; set; }

    public virtual DbSet<SysApplicationStatus> SysApplicationStatuses { get; set; }

    public virtual DbSet<SysDataValidationControlConfiguration> SysDataValidationControlConfigurations { get; set; }

    public virtual DbSet<SysDataValidationRule> SysDataValidationRules { get; set; }

    public virtual DbSet<SysImage> SysImages { get; set; }

    public virtual DbSet<SysNotificationAction> SysNotificationActions { get; set; }

    public virtual DbSet<SysNotificationCondition> SysNotificationConditions { get; set; }

    public virtual DbSet<SysNotificationPlan> SysNotificationPlans { get; set; }

    public virtual DbSet<SysNotificationTemplate> SysNotificationTemplates { get; set; }

    public virtual DbSet<SysNumberAssignment> SysNumberAssignments { get; set; }

    public virtual DbSet<SysNumberController> SysNumberControllers { get; set; }

    public virtual DbSet<SysapplicationActionTraceTemplate> SysapplicationActionTraceTemplates { get; set; }

    public virtual DbSet<SysapplicationStatusAllowedUi> SysapplicationStatusAllowedUis { get; set; }

    public virtual DbSet<SysapplicationValidation> SysapplicationValidations { get; set; }

    public virtual DbSet<SysreleaseHistory> SysreleaseHistories { get; set; }

    public virtual DbSet<SysrmsapplicationType> SysrmsapplicationTypes { get; set; }

    public virtual DbSet<SysrmsuserInterfaceDefinition> SysrmsuserInterfaceDefinitions { get; set; }

    public virtual DbSet<SystemConfiguration> SystemConfigurations { get; set; }

    public virtual DbSet<TestRmsapplicationDataExportLog> TestRmsapplicationDataExportLogs { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<TicketViolation> TicketViolations { get; set; }

    public virtual DbSet<TowRequest> TowRequests { get; set; }

    public virtual DbSet<TrafficStop> TrafficStops { get; set; }

    public virtual DbSet<TrafficStopCitationDetail> TrafficStopCitationDetails { get; set; }

    public virtual DbSet<TrafficStopViolation> TrafficStopViolations { get; set; }

    public virtual DbSet<TrafficStopWarningDetail> TrafficStopWarningDetails { get; set; }

    public virtual DbSet<TrxBackgroundCheck> TrxBackgroundChecks { get; set; }

    public virtual DbSet<UnknownNameChangeHelpQueryPersonHistory> UnknownNameChangeHelpQueryPersonHistories { get; set; }

    public virtual DbSet<UnknownNameChangeHistory> UnknownNameChangeHistories { get; set; }

    public virtual DbSet<UnknownRegNumChangeHelpQueryVehicleHistory> UnknownRegNumChangeHelpQueryVehicleHistories { get; set; }

    public virtual DbSet<UnknownRegNumChangeHistory> UnknownRegNumChangeHistories { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserToken> UserTokens { get; set; }

    public virtual DbSet<ViewMstrcontactPhone> ViewMstrcontactPhones { get; set; }

    public virtual DbSet<VwApplicationDataProcessItemDetail> VwApplicationDataProcessItemDetails { get; set; }

    public virtual DbSet<Warrant> Warrants { get; set; }

    public virtual DbSet<WarrantAttempt> WarrantAttempts { get; set; }

    public virtual DbSet<WarrantGeneratedReport> WarrantGeneratedReports { get; set; }

    public virtual DbSet<WarrantOffense> WarrantOffenses { get; set; }

    public virtual DbSet<WfallowedUi> WfallowedUis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AddressDirecctory>(entity =>
        {
            entity.HasKey(e => e.AddressDirecctoryId).HasName("PK_ADDRESSDIRECCTORY");

            entity.ToTable("AddressDirecctory");

            entity.HasIndex(e => e.DirectoryLocationId, "IX_AddressDirecctory_DirectoryLocationID");

            entity.Property(e => e.AddressDirecctoryId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AddressDirecctoryID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DirectoryLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DirectoryLocationID");
            entity.Property(e => e.DirectoryPhoneNumber).HasMaxLength(50);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ImportSource).HasMaxLength(50);
            entity.Property(e => e.NameOfDirectory).HasMaxLength(200);

            entity.HasOne(d => d.DirectoryLocation).WithMany(p => p.AddressDirecctories)
                .HasForeignKey(d => d.DirectoryLocationId)
                .HasConstraintName("FK_ADDRESSD_REFERENCE_MSTRLOCA");
        });

        modelBuilder.Entity<ArrestBooking>(entity =>
        {
            entity.HasKey(e => e.ArrestBookingId).HasName("PK_ARRESTBOOKING");

            entity.ToTable("ArrestBooking");

            entity.HasIndex(e => new { e.DepartmentId, e.ArrestNumber }, "ArrestBooking_DA_AIAAISCRAE");

            entity.HasIndex(e => e.DepartmentId, "ArrestBooking_DepartmentID_AIA");

            entity.HasIndex(e => new { e.IncidentPersonInvolvementId, e.DepartmentId }, "ArrestBooking_ID_AA");

            entity.HasIndex(e => e.IncidentId, "ArrestBooking_IncidentID");

            entity.HasIndex(e => new { e.StatusId, e.ReportStatusId }, "ArrestBooking_SR_AIAAICAAI");

            entity.HasIndex(e => e.ArrestLocationId, "IX_ArrestBooking_ArrestLocationID");

            entity.HasIndex(e => e.ArrestOfficerId, "IX_ArrestBooking_ArrestOfficerID");

            entity.HasIndex(e => e.AttorneyOrg, "IX_ArrestBooking_AttorneyOrg");

            entity.HasIndex(e => e.BondCompany, "IX_ArrestBooking_BondCompany");

            entity.HasIndex(e => e.BookingLocationId, "IX_ArrestBooking_BookingLocationID");

            entity.HasIndex(e => e.BookingOfficerId, "IX_ArrestBooking_BookingOfficerID");

            entity.HasIndex(e => e.CurrentEditorId, "IX_ArrestBooking_CurrentEditorID");

            entity.HasIndex(e => e.IdentifyingOfficerId, "IX_ArrestBooking_IdentifyingOfficerID");

            entity.HasIndex(e => e.OffenseLocationId, "IX_ArrestBooking_OffenseLocationID");

            entity.HasIndex(e => e.WarrantId, "IX_ArrestBooking_WarrantID");

            entity.Property(e => e.ArrestBookingId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArrestBookingID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Afisnumber)
                .HasMaxLength(20)
                .HasColumnName("AFISNumber");
            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArrestLocationID");
            entity.Property(e => e.ArrestNumber).HasMaxLength(20);
            entity.Property(e => e.ArrestOfficerId).HasColumnName("ArrestOfficerID");
            entity.Property(e => e.AttorneyOrg).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BondCompany).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BookingDateTime).HasColumnType("datetime");
            entity.Property(e => e.BookingLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BookingLocationID");
            entity.Property(e => e.BookingOfficerId).HasColumnName("BookingOfficerID");
            entity.Property(e => e.CdAdditionalPdandCaseNumbers)
                .HasMaxLength(100)
                .HasColumnName("cdAdditionalPDandCaseNumbers");
            entity.Property(e => e.CdAdditionalTicketNumbers)
                .HasMaxLength(50)
                .HasColumnName("cdAdditionalTicketNumbers");
            entity.Property(e => e.CdAppealDecidedDate)
                .HasColumnType("date")
                .HasColumnName("cdAppealDecidedDate");
            entity.Property(e => e.CdAppealFiledDate)
                .HasColumnType("date")
                .HasColumnName("cdAppealFiledDate");
            entity.Property(e => e.CdBondForfeitureAmount)
                .HasColumnType("money")
                .HasColumnName("cdBondForfeitureAmount");
            entity.Property(e => e.CdCibindicator)
                .HasMaxLength(10)
                .HasColumnName("cdCIBIndicator");
            entity.Property(e => e.CdCostAmount)
                .HasColumnType("money")
                .HasColumnName("cdCostAmount");
            entity.Property(e => e.CdCostIndicator).HasColumnName("cdCostIndicator");
            entity.Property(e => e.CdCsindicator)
                .HasMaxLength(10)
                .HasColumnName("cdCSIndicator");
            entity.Property(e => e.CdDispositionDate)
                .HasColumnType("date")
                .HasColumnName("cdDispositionDate");
            entity.Property(e => e.CdDispositionMessage)
                .HasMaxLength(30)
                .HasColumnName("cdDispositionMessage");
            entity.Property(e => e.CdDocketNumber)
                .HasMaxLength(20)
                .HasColumnName("cdDocketNumber");
            entity.Property(e => e.CdErasureDate)
                .HasColumnType("date")
                .HasColumnName("cdErasureDate");
            entity.Property(e => e.CdRearrestIndicator)
                .HasMaxLength(10)
                .HasColumnName("cdRearrestIndicator");
            entity.Property(e => e.CdRevisedIndicator)
                .HasMaxLength(10)
                .HasColumnName("cdRevisedIndicator");
            entity.Property(e => e.CdYoswitch)
                .HasMaxLength(10)
                .HasColumnName("cdYOSwitch");
            entity.Property(e => e.CourtDate).HasColumnType("datetime");
            entity.Property(e => e.CourtGanum)
                .HasMaxLength(100)
                .HasColumnName("CourtGANum");
            entity.Property(e => e.CurrentEditStartTime).HasColumnType("datetime");
            entity.Property(e => e.CurrentEditorId).HasColumnName("CurrentEditorID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmergencyContact).HasMaxLength(200);
            entity.Property(e => e.EmergencyContactPhone).HasMaxLength(50);
            entity.Property(e => e.EntryNumberType).HasMaxLength(50);
            entity.Property(e => e.FingerPrintDateTime).HasColumnType("datetime");
            entity.Property(e => e.IdentifyingOfficerId).HasColumnName("IdentifyingOfficerID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(50);
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.IsTransferedAfis).HasColumnName("IsTransferedAFIS");
            entity.Property(e => e.NarrativeEditedOn).HasColumnType("datetime");
            entity.Property(e => e.OffenseDateTime).HasColumnType("datetime");
            entity.Property(e => e.OffenseLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OffenseLocationID");
            entity.Property(e => e.OtherAgencyWarrantNumber).HasMaxLength(100);
            entity.Property(e => e.Prawnnumber)
                .HasMaxLength(100)
                .HasColumnName("PRAWNNumber");
            entity.Property(e => e.ReleaseDateTime).HasColumnType("datetime");
            entity.Property(e => e.ReleaseMethodOther).HasMaxLength(100);
            entity.Property(e => e.ReleaseToPerson).HasMaxLength(300);
            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
            entity.Property(e => e.StatusDateTime).HasColumnType("datetime");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TownOfArrest).HasMaxLength(100);
            entity.Property(e => e.TownOfOffense).HasMaxLength(100);
            entity.Property(e => e.TownOfWarrant).HasMaxLength(100);
            entity.Property(e => e.Uarnumber)
                .HasMaxLength(20)
                .HasColumnName("UARNumber");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.UsedNarrativeTemplateId).HasColumnName("UsedNarrativeTemplateID");
            entity.Property(e => e.WarrantId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("WarrantID");

            entity.HasOne(d => d.ArrestCategoryCodeNavigation).WithMany(p => p.ArrestBookingArrestCategoryCodeNavigations)
                .HasForeignKey(d => d.ArrestCategoryCode)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_REFINCID2");

            entity.HasOne(d => d.ArrestLocation).WithMany(p => p.ArrestBookingArrestLocations)
                .HasForeignKey(d => d.ArrestLocationId)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_MSTRLOCA2");

            entity.HasOne(d => d.ArrestOfficer).WithMany(p => p.ArrestBookingArrestOfficers)
                .HasForeignKey(d => d.ArrestOfficerId)
                .HasConstraintName("FK_ARREST_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.AttorneyOrgNavigation).WithMany(p => p.ArrestBookingAttorneyOrgNavigations)
                .HasForeignKey(d => d.AttorneyOrg)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_MSTRORGA2");

            entity.HasOne(d => d.BondCompanyNavigation).WithMany(p => p.ArrestBookingBondCompanyNavigations)
                .HasForeignKey(d => d.BondCompany)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_MSTRORGA");

            entity.HasOne(d => d.BookingLocation).WithMany(p => p.ArrestBookingBookingLocations)
                .HasForeignKey(d => d.BookingLocationId)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_MSTRLOCA");

            entity.HasOne(d => d.BookingOfficer).WithMany(p => p.ArrestBookingBookingOfficers)
                .HasForeignKey(d => d.BookingOfficerId)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_DEPARTME3");

            entity.HasOne(d => d.CdCostIndicatorNavigation).WithMany(p => p.ArrestBookingCdCostIndicatorNavigations)
                .HasForeignKey(d => d.CdCostIndicator)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_REFINCID");

            entity.HasOne(d => d.CourtCodeNavigation).WithMany(p => p.ArrestBookingCourtCodeNavigations)
                .HasForeignKey(d => d.CourtCode)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_REFINCID3");

            entity.HasOne(d => d.CurrentEditor).WithMany(p => p.ArrestBookingCurrentEditors)
                .HasForeignKey(d => d.CurrentEditorId)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_DEPARTME");

            entity.HasOne(d => d.Department).WithMany(p => p.ArrestBookings)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.FingerPrintStatusNavigation).WithMany(p => p.ArrestBookingFingerPrintStatusNavigations)
                .HasForeignKey(d => d.FingerPrintStatus)
                .HasConstraintName("fk_ArrestBookingFingerPrintStatus");

            entity.HasOne(d => d.IdentifyingOfficer).WithMany(p => p.ArrestBookingIdentifyingOfficers)
                .HasForeignKey(d => d.IdentifyingOfficerId)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_DEPARTME4");

            entity.HasOne(d => d.Incident).WithMany(p => p.ArrestBookings)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_INCIDENT");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.ArrestBookings)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_INCIDENT2");

            entity.HasOne(d => d.OffenseLocation).WithMany(p => p.ArrestBookingOffenseLocations)
                .HasForeignKey(d => d.OffenseLocationId)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_MSTRLOCA3");

            entity.HasOne(d => d.ReportStatus).WithMany(p => p.ArrestBookingReportStatuses)
                .HasForeignKey(d => d.ReportStatusId)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_SYSAPPLI");

            entity.HasOne(d => d.Status).WithMany(p => p.ArrestBookingStatuses)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_SYSAPPLI2");

            entity.HasOne(d => d.UsedNarrativeTemplate).WithMany(p => p.ArrestBookings)
                .HasForeignKey(d => d.UsedNarrativeTemplateId)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_REFNARRA");

            entity.HasOne(d => d.Warrant).WithMany(p => p.ArrestBookings)
                .HasForeignKey(d => d.WarrantId)
                .HasConstraintName("FK_ARRESTBO_REFERENCE_WARRANTS");
        });

        modelBuilder.Entity<BookingProperty>(entity =>
        {
            entity.HasKey(e => e.BookingPropertyId).HasName("PK_BOOKINGPROPERTY");

            entity.ToTable("BookingProperty");

            entity.HasIndex(e => e.ArrestBookingId, "IX_BookingProperty_ArrestBookingID");

            entity.Property(e => e.BookingPropertyId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BookingPropertyID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ArrestBookingId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArrestBookingID");
            entity.Property(e => e.CurrencyBillsTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CurrencyCoinsTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Properties).HasColumnType("xml");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.ArrestBooking).WithMany(p => p.BookingProperties)
                .HasForeignKey(d => d.ArrestBookingId)
                .HasConstraintName("FK_BOOKINGP_REFERENCE_ARRESTBO2");
        });

        modelBuilder.Entity<BookingReleaseInfo>(entity =>
        {
            entity.HasKey(e => e.BookingReleaseInfoId).HasName("PK_BOOKINGRELEASEINFO");

            entity.ToTable("BookingReleaseInfo");

            entity.HasIndex(e => e.ArrestBookingId, "BookingReleaseInfo_ArrestBookingID");

            entity.HasIndex(e => e.ReleaseOfficerId, "IX_BookingReleaseInfo_ReleaseOfficerID");

            entity.Property(e => e.BookingReleaseInfoId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BookingReleaseInfoID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ArrestBookingId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArrestBookingID");
            entity.Property(e => e.AttorneyAddress).HasMaxLength(100);
            entity.Property(e => e.AttorneyAddressCityStateZip)
                .HasMaxLength(100)
                .HasColumnName("AttorneyAddressCityStateZIP");
            entity.Property(e => e.AttorneyName).HasMaxLength(100);
            entity.Property(e => e.AttorneyPhone).HasMaxLength(50);
            entity.Property(e => e.BondAddress).HasMaxLength(100);
            entity.Property(e => e.BondAddressCityStateZip)
                .HasMaxLength(100)
                .HasColumnName("BondAddressCityStateZIP");
            entity.Property(e => e.BondPayment).HasColumnType("money");
            entity.Property(e => e.BondPhone).HasMaxLength(50);
            entity.Property(e => e.BondPostedBy).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Jurisdiction).HasMaxLength(100);
            entity.Property(e => e.ReleaseDate).HasColumnType("datetime");
            entity.Property(e => e.ReleaseMethodOther).HasMaxLength(100);
            entity.Property(e => e.ReleaseOfficerId).HasColumnName("ReleaseOfficerID");

            entity.HasOne(d => d.ArrestBooking).WithMany(p => p.BookingReleaseInfos)
                .HasForeignKey(d => d.ArrestBookingId)
                .HasConstraintName("FK_BOOKINGR_REFERENCE_ARRESTBO");

            entity.HasOne(d => d.BondTypeNavigation).WithMany(p => p.BookingReleaseInfoBondTypeNavigations)
                .HasForeignKey(d => d.BondType)
                .HasConstraintName("FK_BOOKINGR_REFERENCE_REFINCID2");

            entity.HasOne(d => d.ReleaseMethodNavigation).WithMany(p => p.BookingReleaseInfoReleaseMethodNavigations)
                .HasForeignKey(d => d.ReleaseMethod)
                .HasConstraintName("FK_BOOKINGR_REFERENCE_REFINCID");

            entity.HasOne(d => d.ReleaseOfficer).WithMany(p => p.BookingReleaseInfos)
                .HasForeignKey(d => d.ReleaseOfficerId)
                .HasConstraintName("FK_BOOKINGR_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<CgsmappingtoNibr>(entity =>
        {
            entity.HasKey(e => e.CgsmappingtoNibrsid).HasName("PK_CGSMNOV2019");

            entity.ToTable("CGSMappingtoNIBRS");

            entity.Property(e => e.CgsmappingtoNibrsid)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CGSMappingtoNIBRSID");
            entity.Property(e => e.EffectiveDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GrName).HasMaxLength(50);
            entity.Property(e => e.MultiNibrs).HasColumnName("MultiNIBRS");
            entity.Property(e => e.MultiUcr).HasColumnName("MultiUCR");
            entity.Property(e => e.Nibrscode)
                .HasMaxLength(10)
                .HasColumnName("NIBRSCode");
            entity.Property(e => e.OffenseClass).HasMaxLength(100);
            entity.Property(e => e.OffenseType).HasMaxLength(100);
            entity.Property(e => e.RepealDate).HasColumnType("datetime");
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(10)
                .HasColumnName("UCRCode");
        });

        modelBuilder.Entity<CorrectionMergedPersonsHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CorrectionMergedPersonsHistory");

            entity.Property(e => e.MergedAtTime).HasColumnType("datetime");
            entity.Property(e => e.PrpersonMpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PRPersonMPID");
            entity.Property(e => e.RelatedPkpersonMpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RelatedPKPersonMPID");
        });

        modelBuilder.Entity<CourtChargeInfo>(entity =>
        {
            entity.HasKey(e => e.CourtChargeInfoId).HasName("PK_COURTCHARGEINFO");

            entity.ToTable("CourtChargeInfo");

            entity.HasIndex(e => e.ArrestBookingId, "IX_CourtChargeInfo_ArrestBookingID");

            entity.HasIndex(e => e.OffenseId, "IX_CourtChargeInfo_OffenseID");

            entity.Property(e => e.CourtChargeInfoId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CourtChargeInfoID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ArrestBookingId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArrestBookingID");
            entity.Property(e => e.CourtDocketNum).HasMaxLength(100);
            entity.Property(e => e.Disposition).HasMaxLength(100);
            entity.Property(e => e.DispositionDate).HasColumnType("date");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OffenseId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OffenseID");

            entity.HasOne(d => d.ArrestBooking).WithMany(p => p.CourtChargeInfos)
                .HasForeignKey(d => d.ArrestBookingId)
                .HasConstraintName("FK_COURTCHA_REFERENCE_ARRESTBO");

            entity.HasOne(d => d.Offense).WithMany(p => p.CourtChargeInfos)
                .HasForeignKey(d => d.OffenseId)
                .HasConstraintName("FK_COURTCHA_REFERENCE_OFFENSE");
        });

        modelBuilder.Entity<Crash>(entity =>
        {
            entity.HasKey(e => e.CrashId).HasName("PK_CRASH");

            entity.ToTable("Crash");

            entity.HasIndex(e => e.ReportStatusId, "Crash_ReportStatusID_CCRCDCRCC");

            entity.HasIndex(e => e.CrashLocationId, "IX_Crash_CrashLocationID");

            entity.HasIndex(e => e.CrashStatusId, "IX_Crash_CrashStatusID");

            entity.HasIndex(e => e.CrashType, "IX_Crash_CrashType");

            entity.HasIndex(e => e.DataEntryEmployeeId, "IX_Crash_DataEntryEmployeeID");

            entity.HasIndex(e => e.ReportedEmployeeId, "IX_Crash_ReportedEmployeeID");

            entity.Property(e => e.CrashId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Cadnumber)
                .HasMaxLength(1000)
                .HasColumnName("CADNumber");
            entity.Property(e => e.CadreportedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("CADReportedDateTime");
            entity.Property(e => e.CrashDetail).HasColumnType("xml");
            entity.Property(e => e.CrashLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashLocationID");
            entity.Property(e => e.CrashNumber).HasMaxLength(100);
            entity.Property(e => e.CrashOccuredDtend)
                .HasColumnType("datetime")
                .HasColumnName("CrashOccuredDTEnd");
            entity.Property(e => e.CrashOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("CrashOccuredDTStart");
            entity.Property(e => e.CrashStatusId).HasColumnName("CrashStatusID");
            entity.Property(e => e.DataEntryEmployeeId).HasColumnName("DataEntryEmployeeID");
            entity.Property(e => e.DateClosed).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDotsubmitted).HasColumnName("IsDOTSubmitted");
            entity.Property(e => e.NarrativeEditedOn).HasColumnType("datetime");
            entity.Property(e => e.RelatedIncidentNumber).HasMaxLength(25);
            entity.Property(e => e.ReportStatusDataTime).HasColumnType("datetime");
            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
            entity.Property(e => e.ReportedEmployeeId).HasColumnName("ReportedEmployeeID");
            entity.Property(e => e.ReportingUnit).HasMaxLength(100);
            entity.Property(e => e.ReportingUnitArea).HasMaxLength(100);
            entity.Property(e => e.ReportingUnitProvider).HasMaxLength(50);
            entity.Property(e => e.ReportingUnitShift).HasMaxLength(50);
            entity.Property(e => e.StateRouteNumber).HasMaxLength(100);
            entity.Property(e => e.SuppressedDt)
                .HasColumnType("datetime")
                .HasColumnName("SuppressedDT");
            entity.Property(e => e.Uiaction)
                .HasMaxLength(100)
                .HasColumnName("UIAction");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.UsedNarrativeTemplateId).HasColumnName("UsedNarrativeTemplateID");

            entity.HasOne(d => d.CrashLocation).WithMany(p => p.Crashes)
                .HasForeignKey(d => d.CrashLocationId)
                .HasConstraintName("FK_CRASH_REFERENCE_MSTRLOCA");

            entity.HasOne(d => d.CrashStatus).WithMany(p => p.CrashCrashStatuses)
                .HasForeignKey(d => d.CrashStatusId)
                .HasConstraintName("FK_CRASH_REFERENCE_SYSAPPLI2");

            entity.HasOne(d => d.CrashTypeNavigation).WithMany(p => p.CrashCrashTypeNavigations)
                .HasForeignKey(d => d.CrashType)
                .HasConstraintName("FK_CRASH_REFERENCE_REFCRASH2");

            entity.HasOne(d => d.DataEntryEmployee).WithMany(p => p.CrashDataEntryEmployees)
                .HasForeignKey(d => d.DataEntryEmployeeId)
                .HasConstraintName("FK_CRASH_REFERENCE_DEPARTME");

            entity.HasOne(d => d.Department).WithMany(p => p.Crashes)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_CRASH_REFERENCE_DEPARTME3");

            entity.HasOne(d => d.ReportStatus).WithMany(p => p.CrashReportStatuses)
                .HasForeignKey(d => d.ReportStatusId)
                .HasConstraintName("FK_CRASH_REFERENCE_SYSAPPLI");

            entity.HasOne(d => d.ReportedEmployee).WithMany(p => p.CrashReportedEmployees)
                .HasForeignKey(d => d.ReportedEmployeeId)
                .HasConstraintName("FK_CRASH_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.TimAttributeCodeNavigation).WithMany(p => p.CrashTimAttributeCodeNavigations)
                .HasForeignKey(d => d.TimAttributeCode)
                .HasConstraintName("FK_CRASH_REFERENCE_REFCRASH");

            entity.HasOne(d => d.UsedNarrativeTemplate).WithMany(p => p.Crashes)
                .HasForeignKey(d => d.UsedNarrativeTemplateId)
                .HasConstraintName("FK_CRASH_REFERENCE_REFNARRA");
        });

        modelBuilder.Entity<CrashCommentsInvolvement>(entity =>
        {
            entity.HasKey(e => e.CommentsInvolvement).HasName("PK_CRASH_COMMENTSINVOLVEMENT");

            entity.ToTable("Crash_CommentsInvolvement");

            entity.HasIndex(e => e.AddedById, "IX_Crash_CommentsInvolvement_AddedByID");

            entity.HasIndex(e => e.CrashId, "IX_Crash_CommentsInvolvement_CrashID");

            entity.HasIndex(e => e.EditedById, "IX_Crash_CommentsInvolvement_EditedByID");

            entity.Property(e => e.CommentsInvolvement)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AddedById).HasColumnName("AddedByID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CadcommentId).HasColumnName("CADCommentID");
            entity.Property(e => e.CrashId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashID");
            entity.Property(e => e.EditedById).HasColumnName("EditedByID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InvolvementPkid).HasColumnName("InvolvementPKID");

            entity.HasOne(d => d.AddedBy).WithMany(p => p.CrashCommentsInvolvementAddedBies)
                .HasForeignKey(d => d.AddedById)
                .HasConstraintName("FK_Crash_CommentsInvolvement_Crash_CommentsInvolvement");

            entity.HasOne(d => d.Crash).WithMany(p => p.CrashCommentsInvolvements)
                .HasForeignKey(d => d.CrashId)
                .HasConstraintName("FK_CRASH_CO_REFERENCE_CRASH");

            entity.HasOne(d => d.EditedBy).WithMany(p => p.CrashCommentsInvolvementEditedBies)
                .HasForeignKey(d => d.EditedById)
                .HasConstraintName("FK_Crash_CommentsInvolvement_DepartmentEmployees");
        });

        modelBuilder.Entity<CrashGeneratedReport>(entity =>
        {
            entity.HasKey(e => e.CrashGeneratedReportId).HasName("PK_CRASHGENERATEDREPORTS");

            entity.HasIndex(e => e.CrashId, "IX_CrashGeneratedReports_CrashID");

            entity.HasIndex(e => e.RmsworkFlowControllerId, "IX_CrashGeneratedReports_RMSWorkFlowControllerID");

            entity.Property(e => e.CrashGeneratedReportId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashGeneratedReportID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CrashId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ReportContent).HasColumnType("image");
            entity.Property(e => e.RmsworkFlowControllerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSWorkFlowControllerID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Crash).WithMany(p => p.CrashGeneratedReports)
                .HasForeignKey(d => d.CrashId)
                .HasConstraintName("FK_CRASHGEN_REFERENCE_CRASH");

            entity.HasOne(d => d.CrashStatusNavigation).WithMany(p => p.CrashGeneratedReportCrashStatusNavigations)
                .HasForeignKey(d => d.CrashStatus)
                .HasConstraintName("FK_CRASHGEN_REFERENCE_SYSAPPLI2");

            entity.HasOne(d => d.ReportStatusNavigation).WithMany(p => p.CrashGeneratedReportReportStatusNavigations)
                .HasForeignKey(d => d.ReportStatus)
                .HasConstraintName("FK_CRASHGEN_REFERENCE_SYSAPPLI");

            entity.HasOne(d => d.RmsworkFlowController).WithMany(p => p.CrashGeneratedReports)
                .HasForeignKey(d => d.RmsworkFlowControllerId)
                .HasConstraintName("FK_CrashGeneratedReports_RMSWorkFlowController");
        });

        modelBuilder.Entity<CrashInProgress>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CrashInProgress");

            entity.Property(e => e.Cadnumber)
                .HasMaxLength(1000)
                .HasColumnName("CADNumber");
            entity.Property(e => e.CrashLocation).HasMaxLength(800);
            entity.Property(e => e.CrashNumber).HasMaxLength(100);
            entity.Property(e => e.CrashStart).HasColumnType("datetime");
            entity.Property(e => e.CrashType).HasMaxLength(1000);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.ReportWriter).HasMaxLength(101);
            entity.Property(e => e.ReportingUnit).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(100);
        });

        modelBuilder.Entity<CrashOfficialInvolvement>(entity =>
        {
            entity.HasKey(e => e.OfficialInvolvement).HasName("PK_CRASH_OFFICIALINVOLVEMENT");

            entity.ToTable("Crash_OfficialInvolvement");

            entity.HasIndex(e => e.CrashId, "IX_Crash_OfficialInvolvement_CrashID");

            entity.HasIndex(e => e.DepartmentEmployeeId, "IX_Crash_OfficialInvolvement_DepartmentEmployeeID");

            entity.Property(e => e.OfficialInvolvement)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AssignedUnit).HasMaxLength(100);
            entity.Property(e => e.AssignedUnitShift).HasMaxLength(20);
            entity.Property(e => e.CrashId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashID");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OfficialInvolvementCode).HasMaxLength(100);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Crash).WithMany(p => p.CrashOfficialInvolvements)
                .HasForeignKey(d => d.CrashId)
                .HasConstraintName("FK_CRASH_OF_REFERENCE_CRASH");

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.CrashOfficialInvolvements)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK_CRASH_OF_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<CrashPersonInvolvement>(entity =>
        {
            entity.HasKey(e => e.CrashPersonInvolvementId).HasName("PK_CRASH_PERSONINVOLVEMENT");

            entity.ToTable("Crash_PersonInvolvement");

            entity.HasIndex(e => e.Mpid, "Crash_PersonInvolvement_MPID");

            entity.HasIndex(e => e.RelatedtoVehicleInvolvementId, "INX_CPI_RelatedVehicleInvolvementID");

            entity.HasIndex(e => e.CrashId, "IX_Crash_PersonInvolvement_CrashID");

            entity.HasIndex(e => e.NonVerifiedPersonId, "IX_Crash_PersonInvolvement_NonVerifiedPersonID");

            entity.Property(e => e.CrashPersonInvolvementId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_PersonInvolvementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CrashId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashID");
            entity.Property(e => e.CrashPersonInvolvementCode).HasColumnName("Crash_PersonInvolvementCode");
            entity.Property(e => e.CrashPersonInvolvementDetailXml)
                .HasColumnType("xml")
                .HasColumnName("CrashPersonInvolvementDetailXML");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InjuryCode).HasMaxLength(100);
            entity.Property(e => e.IsConfidential).HasDefaultValueSql("((0))");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.NonVerifiedPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NonVerifiedPersonID");
            entity.Property(e => e.RelatedtoVehicleInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RelatedtoVehicleInvolvementID");
            entity.Property(e => e.Source).HasMaxLength(100);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Crash).WithMany(p => p.CrashPersonInvolvements)
                .HasForeignKey(d => d.CrashId)
                .HasConstraintName("FK_CRASH_PE_REFERENCE_CRASH");

            entity.HasOne(d => d.CrashPersonInvolvementCodeNavigation).WithMany(p => p.CrashPersonInvolvements)
                .HasForeignKey(d => d.CrashPersonInvolvementCode)
                .HasConstraintName("FK_CRASH_PE_REFERENCE_REFCRASH");

            entity.HasOne(d => d.Mp).WithMany(p => p.CrashPersonInvolvements)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_CRASH_PE_REFERENCE_MSTRPERS");

            entity.HasOne(d => d.NonVerifiedPerson).WithMany(p => p.CrashPersonInvolvements)
                .HasForeignKey(d => d.NonVerifiedPersonId)
                .HasConstraintName("FK_CRASH_PE_REFERENCE_NONVERIF");

            entity.HasOne(d => d.RelatedtoVehicleInvolvement).WithMany(p => p.CrashPersonInvolvements)
                .HasForeignKey(d => d.RelatedtoVehicleInvolvementId)
                .HasConstraintName("FK_CRASH_PE_REFERENCE_CRASH_VE");
        });

        modelBuilder.Entity<CrashPersonSummaryDatum>(entity =>
        {
            entity.HasKey(e => e.CrashPersonInvolvementId).HasName("PK_CRASHPERSONSUMMARYDATA");

            entity.Property(e => e.CrashPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_PersonInvolvementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.BusSeatingPosition).HasMaxLength(5);
            entity.Property(e => e.ConditionOfPersonAtTimeOfCrash).HasColumnType("xml");
            entity.Property(e => e.DateTimeofDeath).HasColumnType("datetime");
            entity.Property(e => e.DriverActions).HasColumnType("xml");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmscompanyName).HasColumnName("EMSCompanyName");
            entity.Property(e => e.EmsresponseRunNumber)
                .HasMaxLength(100)
                .HasColumnName("EMSResponseRunNumber");
            entity.Property(e => e.NameOfIntendedReceivingFacility).HasMaxLength(255);
            entity.Property(e => e.NonMotoristActionOrCircumstancePriorToCrashToOrFromSchool).HasColumnName("NonMotoristActionOrCircumstancePriorToCrash_ToOrFromSchool");
            entity.Property(e => e.NonMotoristActionsOrCircumstancesAtTimeofCrash).HasColumnType("xml");
            entity.Property(e => e.SafetyEquipment).HasColumnType("xml");
            entity.Property(e => e.StrikingMotorVehicleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("StrikingMotorVehicleID");
            entity.Property(e => e.ViolationCodes).HasColumnType("xml");
            entity.Property(e => e.WitnessObservationVerification).HasColumnType("xml");
            entity.Property(e => e.WitnessStatementSource).HasColumnType("xml");
            entity.Property(e => e.WitnessStatementType).HasColumnType("xml");

            entity.HasOne(d => d.ActionTakenByOfficerNavigation).WithMany(p => p.CrashPersonSummaryDatumActionTakenByOfficerNavigations)
                .HasForeignKey(d => d.ActionTakenByOfficer)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH8");

            entity.HasOne(d => d.AirBagDeploymentNavigation).WithMany(p => p.CrashPersonSummaryDatumAirBagDeploymentNavigations)
                .HasForeignKey(d => d.AirBagDeployment)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH12");

            entity.HasOne(d => d.AlcoholTestStatusNavigation).WithMany(p => p.CrashPersonSummaryDatumAlcoholTestStatusNavigations)
                .HasForeignKey(d => d.AlcoholTestStatus)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH3");

            entity.HasOne(d => d.AlcoholTestTypeNavigation).WithMany(p => p.CrashPersonSummaryDatumAlcoholTestTypeNavigations)
                .HasForeignKey(d => d.AlcoholTestType)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH4");

            entity.HasOne(d => d.CrashPersonInvolvement).WithOne(p => p.CrashPersonSummaryDatum)
                .HasForeignKey<CrashPersonSummaryDatum>(d => d.CrashPersonInvolvementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CRASHPER_REFERENCE_CRASH_PE");

            entity.HasOne(d => d.DriverDistractedByNavigation).WithMany(p => p.CrashPersonSummaryDatumDriverDistractedByNavigations)
                .HasForeignKey(d => d.DriverDistractedBy)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH15");

            entity.HasOne(d => d.DrugTestStatusNavigation).WithMany(p => p.CrashPersonSummaryDatumDrugTestStatusNavigations)
                .HasForeignKey(d => d.DrugTestStatus)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH5");

            entity.HasOne(d => d.DrugTestTypeNavigation).WithMany(p => p.CrashPersonSummaryDatumDrugTestTypeNavigations)
                .HasForeignKey(d => d.DrugTestType)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH6");

            entity.HasOne(d => d.EjectionStatusNavigation).WithMany(p => p.CrashPersonSummaryDatumEjectionStatusNavigations)
                .HasForeignKey(d => d.EjectionStatus)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH13");

            entity.HasOne(d => d.HelmetUseNavigation).WithMany(p => p.CrashPersonSummaryDatumHelmetUseNavigations)
                .HasForeignKey(d => d.HelmetUse)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH11");

            entity.HasOne(d => d.InjuryStatusNavigation).WithMany(p => p.CrashPersonSummaryDatumInjuryStatusNavigations)
                .HasForeignKey(d => d.InjuryStatus)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH2");

            entity.HasOne(d => d.LogTravelingDirectionNavigation).WithMany(p => p.CrashPersonSummaryDatumLogTravelingDirectionNavigations)
                .HasForeignKey(d => d.LogTravelingDirection)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH");

            entity.HasOne(d => d.NonBusSeatingPositionNavigation).WithMany(p => p.CrashPersonSummaryDatumNonBusSeatingPositionNavigations)
                .HasForeignKey(d => d.NonBusSeatingPosition)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH9");

            entity.HasOne(d => d.NonMotoristActionOrCircumstancePriorToCrashNavigation).WithMany(p => p.CrashPersonSummaryDatumNonMotoristActionOrCircumstancePriorToCrashNavigations)
                .HasForeignKey(d => d.NonMotoristActionOrCircumstancePriorToCrash)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH17");

            entity.HasOne(d => d.NonMotoristActionOrCircumstancePriorToCrashToOrFromSchoolNavigation).WithMany(p => p.CrashPersonSummaryDatumNonMotoristActionOrCircumstancePriorToCrashToOrFromSchoolNavigations)
                .HasForeignKey(d => d.NonMotoristActionOrCircumstancePriorToCrashToOrFromSchool)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH20");

            entity.HasOne(d => d.NonMotoristLocationAtTimeOfCrashNavigation).WithMany(p => p.CrashPersonSummaryDatumNonMotoristLocationAtTimeOfCrashNavigations)
                .HasForeignKey(d => d.NonMotoristLocationAtTimeOfCrash)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH18");

            entity.HasOne(d => d.NonmotoristDistractedByNavigation).WithMany(p => p.CrashPersonSummaryDatumNonmotoristDistractedByNavigations)
                .HasForeignKey(d => d.NonmotoristDistractedBy)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH19");

            entity.HasOne(d => d.RestraintSystemNavigation).WithMany(p => p.CrashPersonSummaryDatumRestraintSystemNavigations)
                .HasForeignKey(d => d.RestraintSystem)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH10");

            entity.HasOne(d => d.SpeedingRelatedNavigation).WithMany(p => p.CrashPersonSummaryDatumSpeedingRelatedNavigations)
                .HasForeignKey(d => d.SpeedingRelated)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH14");

            entity.HasOne(d => d.TransportSourceNavigation).WithMany(p => p.CrashPersonSummaryDatumTransportSourceNavigations)
                .HasForeignKey(d => d.TransportSource)
                .HasConstraintName("FK_CRASHPER_REFERENCE_REFCRASH7");
        });

        modelBuilder.Entity<CrashPropertyInvolvement>(entity =>
        {
            entity.HasKey(e => e.CrashPropertyInvolvementId).HasName("PK_CRASH_PROPERTYINVOLVEMENT");

            entity.ToTable("Crash_PropertyInvolvement");

            entity.HasIndex(e => e.CrashId, "IX_Crash_PropertyInvolvement_CrashID");

            entity.HasIndex(e => e.Mppid, "IX_Crash_PropertyInvolvement_MPPID");

            entity.HasIndex(e => e.RelatedPersonInvolvementId, "IX_Crash_PropertyInvolvement_RelatedPersonInvolvementID");

            entity.HasIndex(e => e.RelatedVehicleInvolvementId, "IX_Crash_PropertyInvolvement_RelatedVehicleInvolvementID");

            entity.Property(e => e.CrashPropertyInvolvementId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_PropertyInvolvementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CrashId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashID");
            entity.Property(e => e.CrashPropertyInvolvementCode).HasColumnName("Crash_PropertyInvolvementCode");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsConfidential).HasDefaultValueSql("((0))");
            entity.Property(e => e.Mppid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPID");
            entity.Property(e => e.RelatedPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RelatedPersonInvolvementID");
            entity.Property(e => e.RelatedVehicleInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RelatedVehicleInvolvementID");
            entity.Property(e => e.Source).HasMaxLength(100);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Crash).WithMany(p => p.CrashPropertyInvolvements)
                .HasForeignKey(d => d.CrashId)
                .HasConstraintName("FK_CRASH_PR_REFERENCE_CRASH");

            entity.HasOne(d => d.CrashPropertyInvolvementCodeNavigation).WithMany(p => p.CrashPropertyInvolvements)
                .HasForeignKey(d => d.CrashPropertyInvolvementCode)
                .HasConstraintName("FK_CRASH_PR_REFERENCE_REFCRASH2");

            entity.HasOne(d => d.Mpp).WithMany(p => p.CrashPropertyInvolvements)
                .HasForeignKey(d => d.Mppid)
                .HasConstraintName("FK_CRASH_PR_REFERENCE_MSTRPROP");

            entity.HasOne(d => d.RelatedPersonInvolvement).WithMany(p => p.CrashPropertyInvolvements)
                .HasForeignKey(d => d.RelatedPersonInvolvementId)
                .HasConstraintName("FK_CRASH_PR_REFERENCE_CRASH_PE");

            entity.HasOne(d => d.RelatedVehicleInvolvement).WithMany(p => p.CrashPropertyInvolvements)
                .HasForeignKey(d => d.RelatedVehicleInvolvementId)
                .HasConstraintName("FK_CRASH_PR_REFERENCE_CRASH_VE");
        });

        modelBuilder.Entity<CrashRelatedAttachment>(entity =>
        {
            entity.HasKey(e => e.CrashRelatedAttachmentId).HasName("PK_CRASHRELATEDATTACHMENTS");

            entity.HasIndex(e => e.CrashId, "IX_CrashRelatedAttachments_CrashID");

            entity.HasIndex(e => e.CrashPersonInvolvementId, "IX_CrashRelatedAttachments_Crash_PersonInvolvementID");

            entity.HasIndex(e => e.CrashPropertyInvolvementId, "IX_CrashRelatedAttachments_Crash_PropertyInvolvementID");

            entity.HasIndex(e => e.CrashVehicleInvolvementId, "IX_CrashRelatedAttachments_Crash_VehicleInvolvementID");

            entity.Property(e => e.CrashRelatedAttachmentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashRelatedAttachmentID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AttachmentContent).HasColumnType("image");
            entity.Property(e => e.AttachmentType).HasMaxLength(100);
            entity.Property(e => e.CrashId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashID");
            entity.Property(e => e.CrashPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_PersonInvolvementID");
            entity.Property(e => e.CrashPropertyInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_PropertyInvolvementID");
            entity.Property(e => e.CrashVehicleInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_VehicleInvolvementID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Crash).WithMany(p => p.CrashRelatedAttachments)
                .HasForeignKey(d => d.CrashId)
                .HasConstraintName("FK_CRASHREL_REFERENCE_CRASH");

            entity.HasOne(d => d.CrashPersonInvolvement).WithMany(p => p.CrashRelatedAttachments)
                .HasForeignKey(d => d.CrashPersonInvolvementId)
                .HasConstraintName("FK_CRASHREL_REFERENCE_CRASH_PE");

            entity.HasOne(d => d.CrashPropertyInvolvement).WithMany(p => p.CrashRelatedAttachments)
                .HasForeignKey(d => d.CrashPropertyInvolvementId)
                .HasConstraintName("FK_CRASHREL_REFERENCE_CRASH_PR");

            entity.HasOne(d => d.CrashVehicleInvolvement).WithMany(p => p.CrashRelatedAttachments)
                .HasForeignKey(d => d.CrashVehicleInvolvementId)
                .HasConstraintName("FK_CRASHREL_REFERENCE_CRASH_VE");
        });

        modelBuilder.Entity<CrashSummaryDatum>(entity =>
        {
            entity.HasKey(e => e.CrashId).HasName("PK_CRASHSUMMARYDATA");

            entity.Property(e => e.CrashId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ContributingCircumstancesEnvironment).HasColumnType("xml");
            entity.Property(e => e.ContributingCircumstancesRoad).HasColumnType("xml");
            entity.Property(e => e.CrashClassificationTrafficwayClassType).HasColumnName("CrashClassification_TrafficwayClassType");
            entity.Property(e => e.CrashClassificationTrafficwayOwnershipType).HasColumnName("CrashClassification_TrafficwayOwnershipType");
            entity.Property(e => e.CrashDrawingApplicationImage).HasColumnType("image");
            entity.Property(e => e.CrashOccurredOnStreet).HasMaxLength(500);
            entity.Property(e => e.CrashOccurredOnStreetId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CrashOccurredOnStreetID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IntersectionStreet1).HasMaxLength(500);
            entity.Property(e => e.IntersectionStreet1Id)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("IntersectionStreet1ID");
            entity.Property(e => e.IsContactBoardEdnotified).HasColumnName("IsContactBoardEDNotified");
            entity.Property(e => e.IsCrashRelatedToAworkZone).HasColumnName("IsCrashRelatedToAWorkZone");
            entity.Property(e => e.IsSosactivated).HasColumnName("IsSOSactivated");
            entity.Property(e => e.RelationToJunctionCrashSpecificLocation).HasColumnName("RelationToJunction_CrashSpecificLocation");
            entity.Property(e => e.WeatherCondition).HasColumnType("xml");

            entity.HasOne(d => d.CrashClassificationTrafficwayClassTypeNavigation).WithMany(p => p.CrashSummaryDatumCrashClassificationTrafficwayClassTypeNavigations)
                .HasForeignKey(d => d.CrashClassificationTrafficwayClassType)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH2");

            entity.HasOne(d => d.CrashClassificationTrafficwayOwnershipTypeNavigation).WithMany(p => p.CrashSummaryDatumCrashClassificationTrafficwayOwnershipTypeNavigations)
                .HasForeignKey(d => d.CrashClassificationTrafficwayOwnershipType)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH3");

            entity.HasOne(d => d.Crash).WithOne(p => p.CrashSummaryDatum)
                .HasForeignKey<CrashSummaryDatum>(d => d.CrashId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_CRASH");

            entity.HasOne(d => d.DirectionFromNearestLandmarkNavigation).WithMany(p => p.CrashSummaryDatumDirectionFromNearestLandmarkNavigations)
                .HasForeignKey(d => d.DirectionFromNearestLandmark)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH18");

            entity.HasOne(d => d.FirstHarmfulEventNavigation).WithMany(p => p.CrashSummaryDatumFirstHarmfulEventNavigations)
                .HasForeignKey(d => d.FirstHarmfulEvent)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH5");

            entity.HasOne(d => d.IsCrashRelatedToAworkZoneNavigation).WithMany(p => p.CrashSummaryDatumIsCrashRelatedToAworkZoneNavigations)
                .HasForeignKey(d => d.IsCrashRelatedToAworkZone)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH12");

            entity.HasOne(d => d.LawEnforcementPresenceNavigation).WithMany(p => p.CrashSummaryDatumLawEnforcementPresenceNavigations)
                .HasForeignKey(d => d.LawEnforcementPresence)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH16");

            entity.HasOne(d => d.LightConditionNavigation).WithMany(p => p.CrashSummaryDatumLightConditionNavigations)
                .HasForeignKey(d => d.LightCondition)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH7");

            entity.HasOne(d => d.LocFirstHarmfulEventRelativeToTrafficwayNavigation).WithMany(p => p.CrashSummaryDatumLocFirstHarmfulEventRelativeToTrafficwayNavigations)
                .HasForeignKey(d => d.LocFirstHarmfulEventRelativeToTrafficway)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH4");

            entity.HasOne(d => d.LocationOfCrashRelativeToWorkZoneNavigation).WithMany(p => p.CrashSummaryDatumLocationOfCrashRelativeToWorkZoneNavigations)
                .HasForeignKey(d => d.LocationOfCrashRelativeToWorkZone)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH13");

            entity.HasOne(d => d.MannerOfCrashCollisionImpactNavigation).WithMany(p => p.CrashSummaryDatumMannerOfCrashCollisionImpactNavigations)
                .HasForeignKey(d => d.MannerOfCrashCollisionImpact)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH6");

            entity.HasOne(d => d.MedianBarrierPenetrationNavigation).WithMany(p => p.CrashSummaryDatumMedianBarrierPenetrationNavigations)
                .HasForeignKey(d => d.MedianBarrierPenetration)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH20");

            entity.HasOne(d => d.PoliceCaseStatusNavigation).WithMany(p => p.CrashSummaryDatumPoliceCaseStatusNavigations)
                .HasForeignKey(d => d.PoliceCaseStatus)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH");

            entity.HasOne(d => d.RelationToJunctionCrashSpecificLocationNavigation).WithMany(p => p.CrashSummaryDatumRelationToJunctionCrashSpecificLocationNavigations)
                .HasForeignKey(d => d.RelationToJunctionCrashSpecificLocation)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH11");

            entity.HasOne(d => d.SchoolBusRelatedNavigation).WithMany(p => p.CrashSummaryDatumSchoolBusRelatedNavigations)
                .HasForeignKey(d => d.SchoolBusRelated)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH10");

            entity.HasOne(d => d.SourceOfInformationNavigation).WithMany(p => p.CrashSummaryDatumSourceOfInformationNavigations)
                .HasForeignKey(d => d.SourceOfInformation)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH19");

            entity.HasOne(d => d.TrafficSurfaceConditionNavigation).WithMany(p => p.CrashSummaryDatumTrafficSurfaceConditionNavigations)
                .HasForeignKey(d => d.TrafficSurfaceCondition)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH8");

            entity.HasOne(d => d.TypeOfIntersectionNavigation).WithMany(p => p.CrashSummaryDatumTypeOfIntersectionNavigations)
                .HasForeignKey(d => d.TypeOfIntersection)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH9");

            entity.HasOne(d => d.TypeOfWorkZoneNavigation).WithMany(p => p.CrashSummaryDatumTypeOfWorkZoneNavigations)
                .HasForeignKey(d => d.TypeOfWorkZone)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH14");

            entity.HasOne(d => d.UnitOfMeasureNavigation).WithMany(p => p.CrashSummaryDatumUnitOfMeasureNavigations)
                .HasForeignKey(d => d.UnitOfMeasure)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH17");

            entity.HasOne(d => d.WorkerPresenceNavigation).WithMany(p => p.CrashSummaryDatumWorkerPresenceNavigations)
                .HasForeignKey(d => d.WorkerPresence)
                .HasConstraintName("FK_CRASHSUM_REFERENCE_REFCRASH15");
        });

        modelBuilder.Entity<CrashVehicleAreaImpact>(entity =>
        {
            entity.ToTable("CrashVehicleAreaImpact");

            entity.HasIndex(e => e.CrashVehicleInvolvementId, "IX_CrashVehicleAreaImpact_Crash_VehicleInvolvementID");

            entity.Property(e => e.CrashVehicleAreaImpactId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashVehicleAreaImpactID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CrashVehicleInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_VehicleInvolvementID");
            entity.Property(e => e.Description).HasMaxLength(300);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ImageContentPath).HasMaxLength(300);

            entity.HasOne(d => d.CrashVehicleInvolvement).WithMany(p => p.CrashVehicleAreaImpacts)
                .HasForeignKey(d => d.CrashVehicleInvolvementId)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_CRASH_VE3");

            entity.HasOne(d => d.DamageAreaPointNavigation).WithMany(p => p.CrashVehicleAreaImpacts)
                .HasForeignKey(d => d.DamageAreaPoint)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH13");
        });

        modelBuilder.Entity<CrashVehicleCommericalInfo>(entity =>
        {
            entity.HasKey(e => e.CrashVehicleInvolvementId);

            entity.ToTable("CrashVehicleCommericalInfo");

            entity.HasIndex(e => e.CarrierAddress, "IX_CrashVehicleCommericalInfo_CarrierAddress");

            entity.Property(e => e.CrashVehicleInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_VehicleInvolvementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CarrierAddress).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CarrierName).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HazardousMaterialsDescription).HasMaxLength(100);
            entity.Property(e => e.HazardousMaterialsPlacardClassNumber).HasMaxLength(100);
            entity.Property(e => e.HazardousMaterialsPlacardNumber).HasMaxLength(100);
            entity.Property(e => e.PowerUnitInformationInformationSameAsCarrier).HasColumnName("PowerUnitInformation_InformationSameAsCarrier");
            entity.Property(e => e.PowerUnitInformationOwnerAddress)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PowerUnitInformation_OwnerAddress");
            entity.Property(e => e.PowerUnitInformationOwnerName)
                .HasMaxLength(100)
                .HasColumnName("PowerUnitInformation_OwnerName");
            entity.Property(e => e.StateIssuedIdentificationNumber).HasMaxLength(100);
            entity.Property(e => e.TrailerInformationInformationOwnerAddress)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrailerInformationInformation_OwnerAddress");
            entity.Property(e => e.TrailerInformationInformationSameAsCarrier).HasColumnName("TrailerInformation_InformationSameAsCarrier");
            entity.Property(e => e.TrailerInformationInformationSameAsOtherTrailer).HasColumnName("TrailerInformation_InformationSameAsOtherTrailer");
            entity.Property(e => e.TrailerInformationInformationSameAsPowerUnit).HasColumnName("TrailerInformation_InformationSameAsPowerUnit");
            entity.Property(e => e.TrailerInformationOwnerName)
                .HasMaxLength(100)
                .HasColumnName("TrailerInformation_OwnerName");
            entity.Property(e => e.TrailerLicensePlateNumber).HasMaxLength(100);
            entity.Property(e => e.TrailerVehicleIdentificationNumber).HasMaxLength(100);
            entity.Property(e => e.Usdotnumber)
                .HasMaxLength(100)
                .HasColumnName("USDOTNumber");

            entity.HasOne(d => d.CargoBodyTypeNavigation).WithMany(p => p.CrashVehicleCommericalInfoCargoBodyTypeNavigations)
                .HasForeignKey(d => d.CargoBodyType)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH29");

            entity.HasOne(d => d.CarrierAddressNavigation).WithMany(p => p.CrashVehicleCommericalInfoCarrierAddressNavigations)
                .HasForeignKey(d => d.CarrierAddress)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_MSTRLOCA6");

            entity.HasOne(d => d.CommercialOrNoncommercialNavigation).WithMany(p => p.CrashVehicleCommericalInfoCommercialOrNoncommercialNavigations)
                .HasForeignKey(d => d.CommercialOrNoncommercial)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH25");

            entity.HasOne(d => d.CrashVehicleInvolvement).WithOne(p => p.CrashVehicleCommericalInfo)
                .HasForeignKey<CrashVehicleCommericalInfo>(d => d.CrashVehicleInvolvementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_CRASH_VE");

            entity.HasOne(d => d.GrossVehicleWeightRatingNavigation).WithMany(p => p.CrashVehicleCommericalInfoGrossVehicleWeightRatingNavigations)
                .HasForeignKey(d => d.GrossVehicleWeightRating)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH26");

            entity.HasOne(d => d.HazardousMaterialsPlacardDisplayNavigation).WithMany(p => p.CrashVehicleCommericalInfoHazardousMaterialsPlacardDisplayNavigations)
                .HasForeignKey(d => d.HazardousMaterialsPlacardDisplay)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH28");

            entity.HasOne(d => d.PowerUnitInformationOwnerAddressNavigation).WithMany(p => p.CrashVehicleCommericalInfoPowerUnitInformationOwnerAddressNavigations)
                .HasForeignKey(d => d.PowerUnitInformationOwnerAddress)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_MSTRLOCA5");

            entity.HasOne(d => d.StateIssuingIdentificationNumberNavigation).WithMany(p => p.CrashVehicleCommericalInfoStateIssuingIdentificationNumberNavigations)
                .HasForeignKey(d => d.StateIssuingIdentificationNumber)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFMSTRI4");

            entity.HasOne(d => d.TrailerInformationInformationOwnerAddressNavigation).WithMany(p => p.CrashVehicleCommericalInfoTrailerInformationInformationOwnerAddressNavigations)
                .HasForeignKey(d => d.TrailerInformationInformationOwnerAddress)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_MSTRLOCA");

            entity.HasOne(d => d.TrailerLicensePlateIssuingStateCodeNavigation).WithMany(p => p.CrashVehicleCommericalInfoTrailerLicensePlateIssuingStateCodeNavigations)
                .HasForeignKey(d => d.TrailerLicensePlateIssuingStateCode)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFMSTRI");

            entity.HasOne(d => d.VehicleConfigurationNavigation).WithMany(p => p.CrashVehicleCommericalInfoVehicleConfigurationNavigations)
                .HasForeignKey(d => d.VehicleConfiguration)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH27");

            entity.HasOne(d => d.WereHazardousMaterialsReleasedNavigation).WithMany(p => p.CrashVehicleCommericalInfoWereHazardousMaterialsReleasedNavigations)
                .HasForeignKey(d => d.WereHazardousMaterialsReleased)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH30");
        });

        modelBuilder.Entity<CrashVehicleInvolvement>(entity =>
        {
            entity.HasKey(e => e.CrashVehicleInvolvementId).HasName("PK_CRASH_VEHICLEINVOLVEMENT");

            entity.ToTable("Crash_VehicleInvolvement");

            entity.HasIndex(e => e.CrashId, "Crash_VehicleInvolvement_CrashId");

            entity.HasIndex(e => e.Mvid, "IX_Crash_VehicleInvolvement_MVID");

            entity.HasIndex(e => e.NonVerifiedVehicleId, "IX_Crash_VehicleInvolvement_NonVerifiedVehicleID");

            entity.HasIndex(e => e.TowRequestId, "IX_Crash_VehicleInvolvement_TowRequestID");

            entity.Property(e => e.CrashVehicleInvolvementId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_VehicleInvolvementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CrashId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashID");
            entity.Property(e => e.CrashVehicleInvolvementCode).HasColumnName("Crash_VehicleInvolvementCode");
            entity.Property(e => e.CrashVehicleInvolvementDetailXml)
                .HasColumnType("xml")
                .HasColumnName("CrashVehicleInvolvementDetailXML");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsConfidential).HasDefaultValueSql("((0))");
            entity.Property(e => e.Mvid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MVID");
            entity.Property(e => e.NonVerifiedVehicleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NonVerifiedVehicleID");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Source).HasMaxLength(100);
            entity.Property(e => e.TowRequestId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TowRequestID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Crash).WithMany(p => p.CrashVehicleInvolvements)
                .HasForeignKey(d => d.CrashId)
                .HasConstraintName("FK_CRASH_VE_REFERENCE_CRASH");

            entity.HasOne(d => d.CrashVehicleInvolvementCodeNavigation).WithMany(p => p.CrashVehicleInvolvements)
                .HasForeignKey(d => d.CrashVehicleInvolvementCode)
                .HasConstraintName("FK_CRASH_VE_REFERENCE_REFCRASH");

            entity.HasOne(d => d.Mv).WithMany(p => p.CrashVehicleInvolvements)
                .HasForeignKey(d => d.Mvid)
                .HasConstraintName("FK_CRASH_VE_REFERENCE_MSTRVEHI");

            entity.HasOne(d => d.NonVerifiedVehicle).WithMany(p => p.CrashVehicleInvolvements)
                .HasForeignKey(d => d.NonVerifiedVehicleId)
                .HasConstraintName("FK_CRASH_VE_REFERENCE_NONVERIF");

            entity.HasOne(d => d.TowRequest).WithMany(p => p.CrashVehicleInvolvements)
                .HasForeignKey(d => d.TowRequestId)
                .HasConstraintName("FK_CRASH_VE_REFERENCE_TOWREQUE");
        });

        modelBuilder.Entity<CrashVehicleSummaryDatum>(entity =>
        {
            entity.HasKey(e => e.CrashVehicleInvolvementId).HasName("PK_CRASHVEHICLESUMMARYDATA");

            entity.HasIndex(e => e.Towed, "IX_CrashVehicleSummaryData_Towed");

            entity.Property(e => e.CrashVehicleInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_VehicleInvolvementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ContributingCircumstancesVehicle).HasColumnType("xml");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpirationDate).HasColumnType("date");
            entity.Property(e => e.NameOfIssuingInsuranceCompany).HasMaxLength(100);
            entity.Property(e => e.NameOfRoadwayOnWhichVehicleWasTraveling).HasMaxLength(100);
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.SequenceOfEvents).HasColumnType("xml");
            entity.Property(e => e.VehicleDamageExtentOfVehicleDamage).HasColumnName("VehicleDamage_ExtentOfVehicleDamage");

            entity.HasOne(d => d.BusUseNavigation).WithMany(p => p.CrashVehicleSummaryDatumBusUseNavigations)
                .HasForeignKey(d => d.BusUse)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH18");

            entity.HasOne(d => d.CrashVehicleInvolvement).WithOne(p => p.CrashVehicleSummaryDatum)
                .HasForeignKey<CrashVehicleSummaryDatum>(d => d.CrashVehicleInvolvementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_CRASH_VE2");

            entity.HasOne(d => d.DirectionOfTravelBeforeCrashNavigation).WithMany(p => p.CrashVehicleSummaryDatumDirectionOfTravelBeforeCrashNavigations)
                .HasForeignKey(d => d.DirectionOfTravelBeforeCrash)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH6");

            entity.HasOne(d => d.EmergencyVehicleUseNavigation).WithMany(p => p.CrashVehicleSummaryDatumEmergencyVehicleUseNavigations)
                .HasForeignKey(d => d.EmergencyVehicleUse)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH4");

            entity.HasOne(d => d.MostHarmfulEventForThisVehicleNavigation).WithMany(p => p.CrashVehicleSummaryDatumMostHarmfulEventForThisVehicleNavigations)
                .HasForeignKey(d => d.MostHarmfulEventForThisVehicle)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH15");

            entity.HasOne(d => d.PostedStatutorySpeedLimitNavigation).WithMany(p => p.CrashVehicleSummaryDatumPostedStatutorySpeedLimitNavigations)
                .HasForeignKey(d => d.PostedStatutorySpeedLimit)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH5");

            entity.HasOne(d => d.RoadwayAlignmentNavigation).WithMany(p => p.CrashVehicleSummaryDatumRoadwayAlignmentNavigations)
                .HasForeignKey(d => d.RoadwayAlignment)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH8");

            entity.HasOne(d => d.RoadwayGradeNavigation).WithMany(p => p.CrashVehicleSummaryDatumRoadwayGradeNavigations)
                .HasForeignKey(d => d.RoadwayGrade)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH9");

            entity.HasOne(d => d.SpecialFunctionOfVehicleInOperationNavigation).WithMany(p => p.CrashVehicleSummaryDatumSpecialFunctionOfVehicleInOperationNavigations)
                .HasForeignKey(d => d.SpecialFunctionOfVehicleInOperation)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH3");

            entity.HasOne(d => d.TowedNavigation).WithMany(p => p.CrashVehicleSummaryDatumTowedNavigations)
                .HasForeignKey(d => d.Towed)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH16");

            entity.HasOne(d => d.TrafficControlDeviceStatusNavigation).WithMany(p => p.CrashVehicleSummaryDatumTrafficControlDeviceStatusNavigations)
                .HasForeignKey(d => d.TrafficControlDeviceStatus)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH11");

            entity.HasOne(d => d.TrafficControlDeviceTypeNavigation).WithMany(p => p.CrashVehicleSummaryDatumTrafficControlDeviceTypeNavigations)
                .HasForeignKey(d => d.TrafficControlDeviceType)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH10");

            entity.HasOne(d => d.TrafficwayDescriptionNavigation).WithMany(p => p.CrashVehicleSummaryDatumTrafficwayDescriptionNavigations)
                .HasForeignKey(d => d.TrafficwayDescription)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH7");

            entity.HasOne(d => d.UnitTypeNavigation).WithMany(p => p.CrashVehicleSummaryDatumUnitTypeNavigations)
                .HasForeignKey(d => d.UnitType)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH2");

            entity.HasOne(d => d.VehicleActionNavigation).WithMany(p => p.CrashVehicleSummaryDatumVehicleActionNavigations)
                .HasForeignKey(d => d.VehicleAction)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH12");

            entity.HasOne(d => d.VehicleBodyTypeNavigation).WithMany(p => p.CrashVehicleSummaryDatumVehicleBodyTypeNavigations)
                .HasForeignKey(d => d.VehicleBodyType)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH17");

            entity.HasOne(d => d.VehicleDamageExtentOfVehicleDamageNavigation).WithMany(p => p.CrashVehicleSummaryDatumVehicleDamageExtentOfVehicleDamageNavigations)
                .HasForeignKey(d => d.VehicleDamageExtentOfVehicleDamage)
                .HasConstraintName("FK_CRASHVEH_REFERENCE_REFCRASH14");
        });

        modelBuilder.Entity<CustodyLog>(entity =>
        {
            entity.HasKey(e => e.CustodyLogId).HasName("PK_CUSTODYLOG");

            entity.ToTable("CustodyLog");

            entity.HasIndex(e => e.Block, "IX_CustodyLog_Block");

            entity.HasIndex(e => e.Cell, "IX_CustodyLog_Cell");

            entity.HasIndex(e => e.IncidentPersonInvolvementId, "IX_CustodyLog_IncidentPersonInvolvementID");

            entity.HasIndex(e => e.LocationId, "IX_CustodyLog_LocationID");

            entity.HasIndex(e => e.OfficerId, "IX_CustodyLog_OfficerID");

            entity.Property(e => e.CustodyLogId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CustodyLogID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Agency).HasMaxLength(100);
            entity.Property(e => e.CustodyDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.LocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LocationID");
            entity.Property(e => e.OfficerId).HasColumnName("OfficerID");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.CustodyLogBlockNavigations)
                .HasForeignKey(d => d.Block)
                .HasConstraintName("FK_CUSTODYL_REFERENCE_REFINCID2");

            entity.HasOne(d => d.CellNavigation).WithMany(p => p.CustodyLogCellNavigations)
                .HasForeignKey(d => d.Cell)
                .HasConstraintName("FK_CUSTODYL_REFERENCE_REFINCID");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.CustodyLogs)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_CUSTODYL_REFERENCE_INCIDENT");

            entity.HasOne(d => d.Location).WithMany(p => p.CustodyLogs)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_CUSTODYL_REFERENCE_MSTRLOCA");

            entity.HasOne(d => d.Officer).WithMany(p => p.CustodyLogs)
                .HasForeignKey(d => d.OfficerId)
                .HasConstraintName("FK_CUSTODYL_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<DailyArrestLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Daily Arrest Log");

            entity.Property(e => e.Aa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("aa");
            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.Date)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Dob)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.FullName).HasMaxLength(206);
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.Number).HasMaxLength(100);
            entity.Property(e => e.S1)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S10)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S3)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S4)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S5)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S6)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S7)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S8)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S9)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SexRace)
                .HasMaxLength(201)
                .HasColumnName("Sex Race");
            entity.Property(e => e.Time)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DailyArrestLog2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Daily Arrest Log2");

            entity.Property(e => e.Aa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("aa");
            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.Date)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.Dob)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.FullName).HasMaxLength(206);
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.Number).HasMaxLength(100);
            entity.Property(e => e.S1)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S10)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S3)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S4)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S5)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S6)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S7)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S8)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.S9)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SexRace)
                .HasMaxLength(201)
                .HasColumnName("Sex Race");
            entity.Property(e => e.Time)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DailyArrestLog3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Daily Arrest Log3");

            entity.Property(e => e.Address).HasMaxLength(800);
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.FullName).HasMaxLength(206);
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.Number).HasMaxLength(100);
            entity.Property(e => e.SexRace)
                .HasMaxLength(201)
                .HasColumnName("Sex Race");
        });

        modelBuilder.Entity<DataProcess>(entity =>
        {
            entity.HasKey(e => e.DataProcessId).HasName("PK_DATAPROCESS");

            entity.ToTable("DataProcess");

            entity.Property(e => e.DataProcessId).HasColumnName("DataProcessID");
            entity.Property(e => e.AddedName).HasMaxLength(100);
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataMappingObjectName).HasMaxLength(100);
            entity.Property(e => e.DataMappingObjectSupportValue).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedName).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Department).WithMany(p => p.DataProcesses)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_RMSDATAP_REFERENCE_DEPARTME2");
        });

        modelBuilder.Entity<DataProcessDetailStep>(entity =>
        {
            entity.HasKey(e => e.DataProcessDetailStepId).HasName("PK_DATAPROCESSDETAILSTEP");

            entity.ToTable("DataProcessDetailStep");

            entity.HasIndex(e => e.ProcessStepId, "IX_DataProcessDetailStep_ProcessStepID");

            entity.HasIndex(e => e.RmsdataProcessId, "IX_DataProcessDetailStep_RMSDataProcessID");

            entity.Property(e => e.DataProcessDetailStepId).HasColumnName("DataProcessDetailStepID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");
            entity.Property(e => e.RmsdataProcessId).HasColumnName("RMSDataProcessID");

            entity.HasOne(d => d.ProcessStep).WithMany(p => p.DataProcessDetailSteps)
                .HasForeignKey(d => d.ProcessStepId)
                .HasConstraintName("FK_DATAPROC_REFERENCE_PROCESSS2");

            entity.HasOne(d => d.RmsdataProcess).WithMany(p => p.DataProcessDetailSteps)
                .HasForeignKey(d => d.RmsdataProcessId)
                .HasConstraintName("FK_DATAPROC_REFERENCE_DATAPROC2");
        });

        modelBuilder.Entity<DataProcessRule>(entity =>
        {
            entity.HasKey(e => e.DataProcessRuleId).HasName("PK_DATAPROCESSRULES");

            entity.HasIndex(e => e.DataProcessDetailStepId, "IX_DataProcessRules_DataProcessDetailStepID");

            entity.HasIndex(e => e.DataProcessId, "IX_DataProcessRules_DataProcessID");

            entity.HasIndex(e => e.ProcessStepDataItemId, "IX_DataProcessRules_ProcessStepDataItemID");

            entity.Property(e => e.DataProcessRuleId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DataProcessRuleID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CleanAllDpbeforeExecuteRule).HasColumnName("CleanAllDPBeforeExecuteRule");
            entity.Property(e => e.DataProcessDetailStepId).HasColumnName("DataProcessDetailStepID");
            entity.Property(e => e.DataProcessId).HasColumnName("DataProcessID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ProcessStepDataItemId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ProcessStepDataItemID");
            entity.Property(e => e.RuleName).HasMaxLength(100);
            entity.Property(e => e.RuleSeq).HasColumnName("RuleSEQ");

            entity.HasOne(d => d.DataProcessDetailStep).WithMany(p => p.DataProcessRules)
                .HasForeignKey(d => d.DataProcessDetailStepId)
                .HasConstraintName("FK_DATAPROC_REFERENCE_DATAPROC8");

            entity.HasOne(d => d.DataProcess).WithMany(p => p.DataProcessRules)
                .HasForeignKey(d => d.DataProcessId)
                .HasConstraintName("FK_DATAPROC_REFERENCE_DATAPROC");

            entity.HasOne(d => d.ProcessStepDataItem).WithMany(p => p.DataProcessRules)
                .HasForeignKey(d => d.ProcessStepDataItemId)
                .HasConstraintName("FK_DATAPROC_REFERENCE_DATAPROC7");
        });

        modelBuilder.Entity<DataProcessRuleAction>(entity =>
        {
            entity.HasKey(e => e.DataProcessRuleActionId).HasName("PK_DATAPROCESSRULEACTIONS");

            entity.HasIndex(e => e.DataProcessRuleId, "IX_DataProcessRuleActions_DataProcessRuleID");

            entity.Property(e => e.DataProcessRuleActionId).HasColumnName("DataProcessRuleActionID");
            entity.Property(e => e.ActionDetailXml)
                .HasColumnType("xml")
                .HasColumnName("ActionDetailXML");
            entity.Property(e => e.ActionName).HasMaxLength(100);
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataProcessRuleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DataProcessRuleID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExecuteSeq).HasColumnName("ExecuteSEQ");

            entity.HasOne(d => d.DataProcessRule).WithMany(p => p.DataProcessRuleActions)
                .HasForeignKey(d => d.DataProcessRuleId)
                .HasConstraintName("FK_DATAPROC_REFERENCE_DATAPROC3");
        });

        modelBuilder.Entity<DataProcessRuleCondition>(entity =>
        {
            entity.HasKey(e => e.DataProcessRuleConditionId).HasName("PK_DATAPROCESSRULECONDITIONS");

            entity.HasIndex(e => e.DataProcessRuleId, "IX_DataProcessRuleConditions_DataProcessRuleID");

            entity.HasIndex(e => e.ExtCoditionValueDataItemId, "IX_DataProcessRuleConditions_ExtCoditionValueDataItemID");

            entity.HasIndex(e => e.ExtCoditionValueProcessDetailStepId, "IX_DataProcessRuleConditions_ExtCoditionValueProcessDetailStepID");

            entity.Property(e => e.DataProcessRuleConditionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DataProcessRuleConditionID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Comparisonmethod).HasMaxLength(100);
            entity.Property(e => e.ConditionSeq).HasColumnName("ConditionSEQ");
            entity.Property(e => e.DataProcessRuleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DataProcessRuleID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExtCoditionValueDataItemId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ExtCoditionValueDataItemID");
            entity.Property(e => e.ExtCoditionValueProcessDetailStepId).HasColumnName("ExtCoditionValueProcessDetailStepID");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.SpecialConditionName).HasMaxLength(100);

            entity.HasOne(d => d.DataProcessRule).WithMany(p => p.DataProcessRuleConditions)
                .HasForeignKey(d => d.DataProcessRuleId)
                .HasConstraintName("FK_DATAPROC_REFERENCE_DATAPROC4");

            entity.HasOne(d => d.ExtCoditionValueDataItem).WithMany(p => p.DataProcessRuleConditions)
                .HasForeignKey(d => d.ExtCoditionValueDataItemId)
                .HasConstraintName("FK_DATAPROC_REFERENCE_PROCESSS3");

            entity.HasOne(d => d.ExtCoditionValueProcessDetailStep).WithMany(p => p.DataProcessRuleConditions)
                .HasForeignKey(d => d.ExtCoditionValueProcessDetailStepId)
                .HasConstraintName("FK_DATAPROC_REFERENCE_DATAPROC9");
        });

        modelBuilder.Entity<DataProcessStep>(entity =>
        {
            entity.HasKey(e => e.ProcessStepId).HasName("PK_DATAPROCESSSTEP");

            entity.ToTable("DataProcessStep");

            entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<DataProcessStepDataItem>(entity =>
        {
            entity.HasKey(e => e.ProcessStepDataItemId).HasName("PK_DATAPROCESSSTEPDATAITEM");

            entity.ToTable("DataProcessStepDataItem");

            entity.HasIndex(e => e.ProcessStepId, "IX_DataProcessStepDataItem_ProcessStepID");

            entity.Property(e => e.ProcessStepDataItemId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ProcessStepDataItemID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ControlType).HasMaxLength(100);
            entity.Property(e => e.DataBindingXml)
                .HasColumnType("xml")
                .HasColumnName("DataBindingXML");
            entity.Property(e => e.DataMappingObjectPropertyName).HasMaxLength(100);
            entity.Property(e => e.DataMappingSubObjectName).HasMaxLength(100);
            entity.Property(e => e.DataMappingSubObjectPropertyName).HasMaxLength(100);
            entity.Property(e => e.DefaultValue).HasMaxLength(100);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

            entity.HasOne(d => d.Department).WithMany(p => p.DataProcessStepDataItems)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_DATAPROC_REFERENCE_DEPARTME");

            entity.HasOne(d => d.ProcessStep).WithMany(p => p.DataProcessStepDataItems)
                .HasForeignKey(d => d.ProcessStepId)
                .HasConstraintName("FK_DATAPROC_REFERENCE_DATAPROC6");
        });

        modelBuilder.Entity<DataProcessTrigger>(entity =>
        {
            entity.HasKey(e => e.DataProcessTriggerId).HasName("PK_DATAPROCESSTRIGGER");

            entity.ToTable("DataProcessTrigger");

            entity.HasIndex(e => e.ApplicationType, "IX_DataProcessTrigger_ApplicationType");

            entity.HasIndex(e => e.CfsdefinitionId, "IX_DataProcessTrigger_CFSDefinitionID");

            entity.HasIndex(e => e.DataProcessId, "IX_DataProcessTrigger_DataProcessID");

            entity.HasIndex(e => e.NibrscodeId, "IX_DataProcessTrigger_NIBRSCodeID");

            entity.HasIndex(e => e.OffenseCodeDefinitionId, "IX_DataProcessTrigger_OffenseCodeDefinitionID");

            entity.HasIndex(e => e.UcrcodeId, "IX_DataProcessTrigger_UCRCodeID");

            entity.Property(e => e.DataProcessTriggerId).HasColumnName("DataProcessTriggerID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CfsdefinitionId).HasColumnName("CFSDefinitionID");
            entity.Property(e => e.DataProcessId).HasColumnName("DataProcessID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NibrscodeId).HasColumnName("NIBRSCodeID");
            entity.Property(e => e.OffenseCodeDefinitionId).HasColumnName("OffenseCodeDefinitionID");
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.DataProcessTriggers)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_DATAPROC_REFERENCE_SYSRMSAP");

            entity.HasOne(d => d.Cfsdefinition).WithMany(p => p.DataProcessTriggers)
                .HasForeignKey(d => d.CfsdefinitionId)
                .HasConstraintName("FK_DATAPROC_REFERENCE_REFCALLF");

            entity.HasOne(d => d.DataProcess).WithMany(p => p.DataProcessTriggers)
                .HasForeignKey(d => d.DataProcessId)
                .HasConstraintName("FK_DATAPROC_REFERENCE_DATAPROC5");

            entity.HasOne(d => d.Nibrscode).WithMany(p => p.DataProcessTriggers)
                .HasForeignKey(d => d.NibrscodeId)
                .HasConstraintName("FK_DATAPROC_REFERENCE_REFNIBRS");

            entity.HasOne(d => d.OffenseCodeDefinition).WithMany(p => p.DataProcessTriggers)
                .HasForeignKey(d => d.OffenseCodeDefinitionId)
                .HasConstraintName("FK_DATAPROC_REFERENCE_REFOFFEN");

            entity.HasOne(d => d.Ucrcode).WithMany(p => p.DataProcessTriggers)
                .HasForeignKey(d => d.UcrcodeId)
                .HasConstraintName("FK_DATAPROC_REFERENCE_REFUCRCO");
        });

        modelBuilder.Entity<DeletedIncidentPersonInvolvementHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DeletedIncidentPersonInvolvementHistory");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
        });

        modelBuilder.Entity<DepApplicationUsage>(entity =>
        {
            entity.HasKey(e => e.DepApplicationUsageId).HasName("PK_DEPAPPLICATIONUSAGE");

            entity.ToTable("DepApplicationUsage");

            entity.Property(e => e.DepApplicationUsageId).HasColumnName("DepApplicationUsageID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumberGeneratedMethod).HasMaxLength(20);
            entity.Property(e => e.ApplicationSeq).HasColumnName("ApplicationSEQ");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SysapplicationTypeId).HasColumnName("SYSApplicationTypeID");

            entity.HasOne(d => d.Department).WithMany(p => p.DepApplicationUsages)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_DEPAPPLI_REFERENCE_DEPARTME");

            entity.HasOne(d => d.SysapplicationType).WithMany(p => p.DepApplicationUsages)
                .HasForeignKey(d => d.SysapplicationTypeId)
                .HasConstraintName("FK_DEPAPPLI_REFERENCE_SYSRMSAP");
        });

        modelBuilder.Entity<DepOrgEmployee>(entity =>
        {
            entity.HasKey(e => e.DepOrgEmployeeId).HasName("PK_DEPORGEMPLOYEES");

            entity.HasIndex(e => e.DepartmentEmployeeId, "IX_DepOrgEmployees_DepartmentEmployeeID");

            entity.HasIndex(e => e.DepartmentOrgId, "IX_DepOrgEmployees_DepartmentOrgID");

            entity.Property(e => e.DepOrgEmployeeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepOrgEmployeeID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.DepartmentOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentOrgID");
            entity.Property(e => e.DirectSupervisorId).HasColumnName("DirectSupervisorID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.DepOrgEmployeeDepartmentEmployees)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK_DEPORGEM_REFERENCE_DEPARTME3");

            entity.HasOne(d => d.DepartmentOrg).WithMany(p => p.DepOrgEmployees)
                .HasForeignKey(d => d.DepartmentOrgId)
                .HasConstraintName("FK_DEPORGEM_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.DirectSupervisor).WithMany(p => p.DepOrgEmployeeDirectSupervisors)
                .HasForeignKey(d => d.DirectSupervisorId)
                .HasConstraintName("FK_DEPORGEM_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<DepOrgUnit>(entity =>
        {
            entity.HasKey(e => e.DepOrgUnitId).HasName("PK_DEPORGUNITS");

            entity.Property(e => e.DepOrgUnitId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepOrgUnitID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentOrgID");
            entity.Property(e => e.DepartmentUnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentUnitID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.DepartmentOrg).WithMany(p => p.DepOrgUnits)
                .HasForeignKey(d => d.DepartmentOrgId)
                .HasConstraintName("FK_DEPORGUN_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.DepartmentUnit).WithMany(p => p.DepOrgUnits)
                .HasForeignKey(d => d.DepartmentUnitId)
                .HasConstraintName("FK_DEPORGUN_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK_DEPARTMENTS");

            entity.HasIndex(e => e.AgencyId, "IX_Departments_AgencyID");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Address).HasMaxLength(300);
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.CaddefaultDepartmentEmployeeId).HasColumnName("CADDefaultDepartmentEmployeeID");
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CodingSystem).HasMaxLength(30);
            entity.Property(e => e.DepartmentAttributesXml)
                .HasColumnType("xml")
                .HasColumnName("DepartmentAttributesXML");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MapConfiguration).HasColumnType("xml");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.SearchOtherTownSetting).HasColumnType("xml");
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.StateOri)
                .HasMaxLength(30)
                .HasColumnName("StateORI");
            entity.Property(e => e.TownCode).HasMaxLength(30);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Agency).WithMany(p => p.Departments)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.CaddefaultDepartmentEmployee).WithMany(p => p.Departments)
                .HasForeignKey(d => d.CaddefaultDepartmentEmployeeId)
                .HasConstraintName("FK_Departments_DepartmentEmployees");

            entity.HasOne(d => d.DefaultCourtNavigation).WithMany(p => p.Departments)
                .HasForeignKey(d => d.DefaultCourt)
                .HasConstraintName("FK_DEPARTME_REFERENCE_REFINCID");
        });

        modelBuilder.Entity<DepartmentDailyRoster>(entity =>
        {
            entity.HasKey(e => e.DepartmentDailyRosterId).HasName("PK_DEPARTMENTDAILYROSTER");

            entity.ToTable("DepartmentDailyRoster");

            entity.Property(e => e.DepartmentDailyRosterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentDailyRosterID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DepartmentUnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentUnitID");
            entity.Property(e => e.DepartmentUnitShiftGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentUnitShiftGroupID");
            entity.Property(e => e.DepartmentVehicleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentVehicleID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MappingCadunitShiftStatusId).HasColumnName("MappingCADUnitShiftStatusID");
            entity.Property(e => e.OfflineDateTime).HasColumnType("datetime");
            entity.Property(e => e.OnlineDateTime).HasColumnType("datetime");
            entity.Property(e => e.ScheduledEndDateTime).HasColumnType("datetime");
            entity.Property(e => e.ScheduledStartDateTime).HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.DepartmentDailyRosters)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME20");

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentDailyRosters)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME16");

            entity.HasOne(d => d.DepartmentUnit).WithMany(p => p.DepartmentDailyRosters)
                .HasForeignKey(d => d.DepartmentUnitId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME18");

            entity.HasOne(d => d.DepartmentUnitShiftGroup).WithMany(p => p.DepartmentDailyRosters)
                .HasForeignKey(d => d.DepartmentUnitShiftGroupId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME19");

            entity.HasOne(d => d.DepartmentVehicle).WithMany(p => p.DepartmentDailyRosters)
                .HasForeignKey(d => d.DepartmentVehicleId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME17");
        });

        modelBuilder.Entity<DepartmentEmployee>(entity =>
        {
            entity.HasKey(e => e.DepartmentEmployeeId).HasName("PK_DEPARTMENTEMPLOYEES");

            entity.HasIndex(e => e.IsActive, "DepartmentEmployees_IsActive_DDF");

            entity.HasIndex(e => e.DepartmentId, "IX_DepartmentEmployees_DepartmentID");

            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.Allergies).HasMaxLength(100);
            entity.Property(e => e.BadgeNumber).HasMaxLength(50);
            entity.Property(e => e.BloodType).HasMaxLength(10);
            entity.Property(e => e.CellPhone).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(200);
            entity.Property(e => e.DateOfHiring).HasColumnType("date");
            entity.Property(e => e.DateOfSepration).HasColumnType("datetime");
            entity.Property(e => e.DepEmployeeId)
                .HasMaxLength(50)
                .HasColumnName("DepEmployeeID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptCellPhone).HasMaxLength(50);
            entity.Property(e => e.Divison).HasMaxLength(100);
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("DOB");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmergAddress).HasMaxLength(200);
            entity.Property(e => e.EmergCity).HasMaxLength(200);
            entity.Property(e => e.EmergPhone).HasMaxLength(50);
            entity.Property(e => e.EmergRelationship).HasMaxLength(100);
            entity.Property(e => e.EmergState).HasMaxLength(2);
            entity.Property(e => e.EmergZipCode).HasMaxLength(10);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.FullName)
                .HasMaxLength(164)
                .HasComputedColumnSql("(((case when [LastName] IS NULL OR len([LastName])=(0) then '' else [LastName] end+case when [Suffix] IS NULL OR len([Suffix])=(0) then '' else ' '+[Suffix] end)+case when [LastName] IS NOT NULL AND len([LastName])>(0) AND [FirstName] IS NOT NULL AND len([FirstName])>(0) then ', '+[FirstName] when [FirstName] IS NOT NULL AND len([FirstName])>(0) then [FirstName] else '' end)+case when [MiddleName] IS NOT NULL AND len([MiddleName])>(0) AND ([FirstName] IS NOT NULL AND len([FirstName])>(0) OR [LastName] IS NOT NULL AND len([LastName])>(0)) then ' '+[MiddleName] when [MiddleName] IS NOT NULL then [MiddleName] else '' end)", false);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.HomePhone).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.RadioNumber).HasMaxLength(20);
            entity.Property(e => e.Rank).HasMaxLength(50);
            entity.Property(e => e.Religion).HasMaxLength(100);
            entity.Property(e => e.Ssn)
                .HasMaxLength(10)
                .HasColumnName("SSN");
            entity.Property(e => e.State).HasMaxLength(2);
            entity.Property(e => e.StateWideId)
                .HasMaxLength(20)
                .HasColumnName("StateWideID");
            entity.Property(e => e.Suffix)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.ZipCode).HasMaxLength(10);

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentEmployees)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME2");
        });

        modelBuilder.Entity<DepartmentEmployeeManagement>(entity =>
        {
            entity.HasKey(e => e.EmployeeManagementId).HasName("PK_DEPARTMENTEMPLOYEEMANAGEMEN");

            entity.ToTable("DepartmentEmployeeManagement");

            entity.Property(e => e.EmployeeManagementId).HasColumnName("EmployeeManagementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.DepartmentEmployeeManagementDepartmentEmployees)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME3");

            entity.HasOne(d => d.Manager).WithMany(p => p.DepartmentEmployeeManagementManagers)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME5");
        });

        modelBuilder.Entity<DepartmentGisgeometry>(entity =>
        {
            entity.HasKey(e => e.GeometryId)
                .HasName("PK_DEPARTMENTGISGEOMETRY")
                .IsClustered(false);

            entity.ToTable("DepartmentGISGeometry");

            entity.HasIndex(e => e.DepartmentId, "IX_DepartmentGISGeometry_DepartmentID");

            entity.HasIndex(e => e.GislayerId, "IX_DepartmentGISGeometry_GISLayerID");

            entity.Property(e => e.GeometryId).HasColumnName("GeometryID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CadgeometryId).HasColumnName("CADGeometryID");
            entity.Property(e => e.CadgeometryName)
                .HasMaxLength(50)
                .HasColumnName("CADGeometryName");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GeometryType).HasMaxLength(50);
            entity.Property(e => e.GisgeometryName)
                .HasMaxLength(50)
                .HasColumnName("GISGeometryName");
            entity.Property(e => e.GislayerId).HasColumnName("GISLayerID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentGisgeometries)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME7");

            entity.HasOne(d => d.Gislayer).WithMany(p => p.DepartmentGisgeometries)
                .HasForeignKey(d => d.GislayerId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME4");
        });

        modelBuilder.Entity<DepartmentGislayer>(entity =>
        {
            entity.HasKey(e => e.GislayerId)
                .HasName("PK_DEPARTMENTGISLAYERS")
                .IsClustered(false);

            entity.ToTable("DepartmentGISLayers");

            entity.HasIndex(e => e.DepartmentId, "IX_DepartmentGISLayers_DepartmentID");

            entity.Property(e => e.GislayerId).HasColumnName("GISLayerID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CadgislayerId).HasColumnName("CADGISLayerID");
            entity.Property(e => e.CadgislayerName)
                .HasMaxLength(50)
                .HasColumnName("CADGISLayerName");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DisplaySeq)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("DisplaySEQ");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.GislayerName)
                .HasMaxLength(50)
                .HasColumnName("GISLayerName");
            entity.Property(e => e.IsCadaliasLayer).HasColumnName("IsCADAliasLayer");
            entity.Property(e => e.IsDefinedByCad).HasColumnName("IsDefinedByCAD");
            entity.Property(e => e.KeyAttributeName).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.Weight).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentGislayers)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME6");
        });

        modelBuilder.Entity<DepartmentOrg>(entity =>
        {
            entity.HasKey(e => e.DepartmentOrgId).HasName("PK_DEPARTMENTORG");

            entity.ToTable("DepartmentOrg");

            entity.HasIndex(e => e.DepartmentId, "IX_DepartmentOrg_DepartmentID");

            entity.HasIndex(e => e.RootOrgId, "IX_DepartmentOrg_RootOrgID");

            entity.Property(e => e.DepartmentOrgId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentOrgID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RootOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RootOrgID");

            entity.HasOne(d => d.CategoryCodeNavigation).WithMany(p => p.DepartmentOrgs)
                .HasForeignKey(d => d.CategoryCode)
                .HasConstraintName("FK_DEPARTME_REFERENCE_REFMISCR");

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentOrgs)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME8");

            entity.HasOne(d => d.RootOrg).WithMany(p => p.InverseRootOrg)
                .HasForeignKey(d => d.RootOrgId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME9");
        });

        modelBuilder.Entity<DepartmentUnit>(entity =>
        {
            entity.HasKey(e => e.DepartmentUnitId).HasName("PK_DEPARTMENTUNITS");

            entity.HasIndex(e => e.DefaultVehicleId, "IX_DepartmentUnits_DefaultVehicleID");

            entity.HasIndex(e => e.DepartmentId, "IX_DepartmentUnits_DepartmentID");

            entity.Property(e => e.DepartmentUnitId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentUnitID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DefaultVehicleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DefaultVehicleID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DepartmentOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentOrgID");
            entity.Property(e => e.DepartmentUnitTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentUnitTypeID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MappingCadunitId).HasColumnName("MappingCADUnitID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.UnitId)
                .HasMaxLength(20)
                .HasColumnName("UnitID");

            entity.HasOne(d => d.DefaultVehicle).WithMany(p => p.DepartmentUnits)
                .HasForeignKey(d => d.DefaultVehicleId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME14");

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentUnits)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME12");

            entity.HasOne(d => d.DepartmentOrg).WithMany(p => p.DepartmentUnits)
                .HasForeignKey(d => d.DepartmentOrgId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME13");

            entity.HasOne(d => d.DepartmentUnitType).WithMany(p => p.DepartmentUnits)
                .HasForeignKey(d => d.DepartmentUnitTypeId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME15");
        });

        modelBuilder.Entity<DepartmentUnitShiftGroup>(entity =>
        {
            entity.HasKey(e => e.DepartmentUnitShiftGroupId).HasName("PK_DEPARTMENTUNITSHIFTGROUP");

            entity.ToTable("DepartmentUnitShiftGroup");

            entity.Property(e => e.DepartmentUnitShiftGroupId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentUnitShiftGroupID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ShiftGroupName).HasMaxLength(50);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentUnitShiftGroups)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME21");
        });

        modelBuilder.Entity<DepartmentUnitType>(entity =>
        {
            entity.HasKey(e => e.DepartmentUnitTypeId).HasName("PK_DEPARTMENTUNITTYPE");

            entity.ToTable("DepartmentUnitType");

            entity.Property(e => e.DepartmentUnitTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentUnitTypeID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MappingCadunitTypeId).HasColumnName("MappingCADUnitTypeID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.UnitTypeName).HasMaxLength(100);

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentUnitTypes)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME22");
        });

        modelBuilder.Entity<DepartmentVehicle>(entity =>
        {
            entity.HasKey(e => e.DepartmentVehicleId).HasName("PK_DEPARTMENTVEHICLES");

            entity.Property(e => e.DepartmentVehicleId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentVehicleID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DepartmentOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentOrgID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FleetNumber).HasMaxLength(20);
            entity.Property(e => e.Imei)
                .HasMaxLength(100)
                .HasColumnName("IMEI");
            entity.Property(e => e.MappingHbcadvehicleId).HasColumnName("MappingHBCADVehicleID");
            entity.Property(e => e.Mdtipaddress)
                .HasMaxLength(100)
                .HasColumnName("MDTIPAddress");
            entity.Property(e => e.MdtmodemIpaddress)
                .HasMaxLength(100)
                .HasColumnName("MDTModemIPAddress");
            entity.Property(e => e.MdtmodemSerialNumber)
                .HasMaxLength(100)
                .HasColumnName("MDTModemSerialNumber");
            entity.Property(e => e.Nimscategory)
                .HasMaxLength(100)
                .HasColumnName("NIMSCategory");
            entity.Property(e => e.Nimskind)
                .HasMaxLength(100)
                .HasColumnName("NIMSKind");
            entity.Property(e => e.NimsminCapability)
                .HasMaxLength(100)
                .HasColumnName("NIMSMinCapability");
            entity.Property(e => e.Nimsresource)
                .HasMaxLength(100)
                .HasColumnName("NIMSResource");
            entity.Property(e => e.PhoneNumber).HasMaxLength(100);
            entity.Property(e => e.Simipaddress)
                .HasMaxLength(100)
                .HasColumnName("SIMIPAddress");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.VehicleComputerName).HasMaxLength(100);
            entity.Property(e => e.VehicleName).HasMaxLength(100);
            entity.Property(e => e.VehicleType).HasMaxLength(100);
            entity.Property(e => e.Vin)
                .HasMaxLength(20)
                .HasColumnName("VIN");

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentVehicles)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME10");

            entity.HasOne(d => d.DepartmentOrg).WithMany(p => p.DepartmentVehicles)
                .HasForeignKey(d => d.DepartmentOrgId)
                .HasConstraintName("FK_DEPARTME_REFERENCE_DEPARTME11");
        });

        modelBuilder.Entity<DirectoryContact>(entity =>
        {
            entity.HasKey(e => e.DirectoryContactId).HasName("PK_DIRECTORYCONTACTS");

            entity.HasIndex(e => e.AddressDirecctoryId, "IX_DirectoryContacts_AddressDirecctoryID");

            entity.Property(e => e.DirectoryContactId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DirectoryContactID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AddressDirecctoryId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AddressDirecctoryID");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.ContactSeq).HasColumnName("ContactSEQ");
            entity.Property(e => e.ContactTitle).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.Notes).HasColumnType("ntext");

            entity.HasOne(d => d.AddressDirecctory).WithMany(p => p.DirectoryContacts)
                .HasForeignKey(d => d.AddressDirecctoryId)
                .HasConstraintName("FK_DIRECTOR_REFERENCE_ADDRESSD");
        });

        modelBuilder.Entity<DispositionSpecialProcess>(entity =>
        {
            entity.ToTable("DispositionSpecialProcess");

            entity.Property(e => e.DispositionSpecialProcessId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DispositionSpecialProcessID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Department).WithMany(p => p.DispositionSpecialProcesses)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DispositionSpecialProcess_Departments");
        });

        modelBuilder.Entity<DispositionSpecialProcessOnStatute>(entity =>
        {
            entity.HasKey(e => e.DispositionSpecialProcessOnStatutesId);

            entity.Property(e => e.DispositionSpecialProcessOnStatutesId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DispositionSpecialProcessOnStatutesID");
            entity.Property(e => e.DispositionSpecialProcessId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DispositionSpecialProcessID");
            entity.Property(e => e.RefStatutedefinitionId).HasColumnName("RefStatutedefinitionID");

            entity.HasOne(d => d.DispositionSpecialProcess).WithMany(p => p.DispositionSpecialProcessOnStatutes)
                .HasForeignKey(d => d.DispositionSpecialProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DispositionSpecialProcessOnStatutes_DispositionSpecialProcess");

            entity.HasOne(d => d.RefStatutedefinition).WithMany(p => p.DispositionSpecialProcessOnStatutes)
                .HasForeignKey(d => d.RefStatutedefinitionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DispositionSpecialProcessOnStatutes_RefStatuteDefinition");
        });

        modelBuilder.Entity<DispositionsChargesImport>(entity =>
        {
            entity.HasKey(e => e.DispositionsChargesImportId).HasName("PK_DispositionsImportCharges");

            entity.ToTable("DispositionsChargesImport");

            entity.Property(e => e.DispositionsChargesImportId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DispositionsChargesImportID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.Ccswitch)
                .HasMaxLength(2)
                .HasColumnName("CCSwitch");
            entity.Property(e => e.ConditionalDischargeTerm).HasColumnType("numeric(4, 0)");
            entity.Property(e => e.ConditionalDischargeType).HasMaxLength(1);
            entity.Property(e => e.DefendantName).HasMaxLength(30);
            entity.Property(e => e.DispositionsImportId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DispositionsImportID");
            entity.Property(e => e.DocketNumber).HasMaxLength(16);
            entity.Property(e => e.Dvindicator)
                .HasMaxLength(1)
                .HasColumnName("DVIndicator");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.FineAmount).HasColumnType("numeric(7, 0)");
            entity.Property(e => e.FineRemitted).HasColumnType("numeric(7, 0)");
            entity.Property(e => e.JailTerm).HasColumnType("numeric(4, 0)");
            entity.Property(e => e.JailType).HasMaxLength(1);
            entity.Property(e => e.OffenseId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OffenseID");
            entity.Property(e => e.OriginalStatuteCax)
                .HasMaxLength(1)
                .HasColumnName("OriginalStatuteCAX");
            entity.Property(e => e.OriginalStatuteClass).HasMaxLength(1);
            entity.Property(e => e.OriginalStatuteCode).HasMaxLength(13);
            entity.Property(e => e.OriginalStatuteDescription).HasMaxLength(15);
            entity.Property(e => e.OriginalStatuteType).HasMaxLength(1);
            entity.Property(e => e.OtherFeesAmount).HasColumnType("numeric(7, 0)");
            entity.Property(e => e.Plea).HasMaxLength(2);
            entity.Property(e => e.PoliceCode).HasMaxLength(4);
            entity.Property(e => e.ProbationTerm).HasColumnType("numeric(4, 0)");
            entity.Property(e => e.ProbationType).HasMaxLength(1);
            entity.Property(e => e.SortSwitch).HasMaxLength(1);
            entity.Property(e => e.SpecialParoleTerm).HasColumnType("numeric(4, 0)");
            entity.Property(e => e.SpecialParoleType).HasMaxLength(1);
            entity.Property(e => e.StatuteCax)
                .HasMaxLength(1)
                .HasColumnName("StatuteCAX");
            entity.Property(e => e.StatuteClass).HasMaxLength(1);
            entity.Property(e => e.StatuteCode).HasMaxLength(13);
            entity.Property(e => e.StatuteDescription).HasMaxLength(15);
            entity.Property(e => e.StatuteType).HasMaxLength(1);
            entity.Property(e => e.SuspendedJailTerm).HasColumnType("numeric(4, 0)");
            entity.Property(e => e.SuspendedJailType).HasMaxLength(1);
            entity.Property(e => e.SysApplicationStatusId).HasColumnName("SysApplicationStatusID");
            entity.Property(e => e.TimeServed).HasMaxLength(1);
            entity.Property(e => e.TrafficStopViolationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopViolationID");
            entity.Property(e => e.VerdictFinding).HasMaxLength(2);

            entity.HasOne(d => d.DispositionsImport).WithMany(p => p.DispositionsChargesImports)
                .HasForeignKey(d => d.DispositionsImportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DispositionsImportCharges_DispositionsImport");

            entity.HasOne(d => d.Offense).WithMany(p => p.DispositionsChargesImports)
                .HasForeignKey(d => d.OffenseId)
                .HasConstraintName("FK_DispositionsChargesImport_Offense");

            entity.HasOne(d => d.SysApplicationStatus).WithMany(p => p.DispositionsChargesImports)
                .HasForeignKey(d => d.SysApplicationStatusId)
                .HasConstraintName("FK_DispositionsChargesImport_SysApplicationStatus");

            entity.HasOne(d => d.TrafficStopViolation).WithMany(p => p.DispositionsChargesImports)
                .HasForeignKey(d => d.TrafficStopViolationId)
                .HasConstraintName("FK_DispositionsChargesImport_TrafficStopViolations");
        });

        modelBuilder.Entity<DispositionsImport>(entity =>
        {
            entity.ToTable("DispositionsImport");

            entity.Property(e => e.DispositionsImportId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DispositionsImportID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AdditionalPdcaseNumbers1)
                .HasMaxLength(18)
                .HasColumnName("AdditionalPDCaseNumbers1");
            entity.Property(e => e.AdditionalPdcaseNumbers2)
                .HasMaxLength(18)
                .HasColumnName("AdditionalPDCaseNumbers2");
            entity.Property(e => e.AdditionalPdcaseNumbers3)
                .HasMaxLength(18)
                .HasColumnName("AdditionalPDCaseNumbers3");
            entity.Property(e => e.AdditionalTicketNumber1).HasMaxLength(8);
            entity.Property(e => e.AdditionalTicketNumber2).HasMaxLength(8);
            entity.Property(e => e.AdditionalTicketNumber3).HasMaxLength(8);
            entity.Property(e => e.AdditionalTicketNumber4).HasMaxLength(8);
            entity.Property(e => e.AddressCity).HasMaxLength(16);
            entity.Property(e => e.AddressLine1).HasMaxLength(24);
            entity.Property(e => e.AddressLine2).HasMaxLength(24);
            entity.Property(e => e.AddressState).HasMaxLength(2);
            entity.Property(e => e.AddressZipCode).HasMaxLength(5);
            entity.Property(e => e.AliasName1).HasMaxLength(30);
            entity.Property(e => e.AliasName2).HasMaxLength(30);
            entity.Property(e => e.AliasName3).HasMaxLength(30);
            entity.Property(e => e.AppealDecidedDate).HasColumnType("date");
            entity.Property(e => e.AppealFiledDate).HasColumnType("date");
            entity.Property(e => e.ArrestDate).HasColumnType("date");
            entity.Property(e => e.Birthdate).HasColumnType("date");
            entity.Property(e => e.BondForfeitureAmount).HasColumnType("numeric(7, 0)");
            entity.Property(e => e.Cibindicator)
                .HasMaxLength(1)
                .HasColumnName("CIBIndicator");
            entity.Property(e => e.CostAmount).HasColumnType("numeric(5, 0)");
            entity.Property(e => e.CostIndicator).HasMaxLength(1);
            entity.Property(e => e.Csindicator)
                .HasMaxLength(1)
                .HasColumnName("CSIndicator");
            entity.Property(e => e.DefendantName).HasMaxLength(30);
            entity.Property(e => e.DispositionDate).HasColumnType("date");
            entity.Property(e => e.DispositionMessage).HasMaxLength(25);
            entity.Property(e => e.DocketNumber).HasMaxLength(16);
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.ErasureDate).HasColumnType("date");
            entity.Property(e => e.ErrorType).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.LicenseNumber).HasMaxLength(20);
            entity.Property(e => e.LicenseState).HasMaxLength(2);
            entity.Property(e => e.OffenseTown).HasMaxLength(3);
            entity.Property(e => e.PdcaseNumber)
                .HasMaxLength(14)
                .HasColumnName("PDCaseNumber");
            entity.Property(e => e.PoliceCode).HasMaxLength(4);
            entity.Property(e => e.RearrestIndicator).HasMaxLength(1);
            entity.Property(e => e.RegistrationNumber).HasMaxLength(10);
            entity.Property(e => e.RegistrationState).HasMaxLength(2);
            entity.Property(e => e.RevisedIndicator).HasMaxLength(1);
            entity.Property(e => e.RmsimportLogId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSImportLogID");
            entity.Property(e => e.Sex).HasMaxLength(1);
            entity.Property(e => e.ShieldNumber).HasMaxLength(4);
            entity.Property(e => e.SortSwitch).HasMaxLength(1);
            entity.Property(e => e.SysApplicationStatusId).HasColumnName("SysApplicationStatusID");
            entity.Property(e => e.TrafficStopId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopID");
            entity.Property(e => e.Yoswitch)
                .HasMaxLength(1)
                .HasColumnName("YOSwitch");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.DispositionsImports)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_DispositionsImport_Incident_PersonInvolvement");

            entity.HasOne(d => d.RmsimportLog).WithMany(p => p.DispositionsImports)
                .HasForeignKey(d => d.RmsimportLogId)
                .HasConstraintName("FK_DispositionsImport_RMSImportLog");

            entity.HasOne(d => d.SysApplicationStatus).WithMany(p => p.DispositionsImports)
                .HasForeignKey(d => d.SysApplicationStatusId)
                .HasConstraintName("FK_DispositionsImport_SysApplicationStatus");

            entity.HasOne(d => d.TrafficStop).WithMany(p => p.DispositionsImports)
                .HasForeignKey(d => d.TrafficStopId)
                .HasConstraintName("FK_DispositionsImport_TrafficStop");
        });

        modelBuilder.Entity<EmployeeEquipment>(entity =>
        {
            entity.HasKey(e => e.EmployeeEquipmentId).HasName("PK_EMPLOYEEEQUIPMENT");

            entity.ToTable("EmployeeEquipment");

            entity.Property(e => e.EmployeeEquipmentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("EmployeeEquipmentID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateAssigned).HasColumnType("datetime");
            entity.Property(e => e.DateReturned).HasColumnType("datetime");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InventoryNum).HasMaxLength(100);
            entity.Property(e => e.SerialNum).HasMaxLength(100);

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.EmployeeEquipments)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK_EMPLOYEE_REFERENCE_DEPARTME5");

            entity.HasOne(d => d.EquipmentConditionCodeNavigation).WithMany(p => p.EmployeeEquipmentEquipmentConditionCodeNavigations)
                .HasForeignKey(d => d.EquipmentConditionCode)
                .HasConstraintName("FK_EMPLOYEE_REFERENCE_REFMISCR");

            entity.HasOne(d => d.EquipmentTypeCodeNavigation).WithMany(p => p.EmployeeEquipmentEquipmentTypeCodeNavigations)
                .HasForeignKey(d => d.EquipmentTypeCode)
                .HasConstraintName("FK_EMPLOYEE_REFERENCE_REFMISCR4");
        });

        modelBuilder.Entity<EmployeeHistory>(entity =>
        {
            entity.HasKey(e => e.EmployeeHistoryId).HasName("PK__Employee__A359D25468E4E722");

            entity.ToTable("EmployeeHistory");

            entity.Property(e => e.EmployeeHistoryId).HasColumnName("EmployeeHistoryID");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TransferReason).IsUnicode(false);

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.EmployeeHistories)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK__EmployeeH__Depar__46934FA8");

            entity.HasOne(d => d.Department).WithMany(p => p.EmployeeHistories)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__EmployeeH__Depar__478773E1");
        });

        modelBuilder.Entity<EmployeeNote>(entity =>
        {
            entity.HasKey(e => e.EmployeeNoteId).HasName("PK_EMPLOYEENOTES");

            entity.Property(e => e.EmployeeNoteId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("EmployeeNoteID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Subject).HasMaxLength(100);

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.EmployeeNotes)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK_EMPLOYEE_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<EmployeePhoto>(entity =>
        {
            entity.HasKey(e => e.DepartmentEmployeePhotoId).HasName("PK_EMPLOYEEPHOTO");

            entity.ToTable("EmployeePhoto");

            entity.Property(e => e.DepartmentEmployeePhotoId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentEmployeePhotoID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Image).HasColumnType("image");
            entity.Property(e => e.PictureTakenDate).HasColumnType("datetime");

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.EmployeePhotos)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK_EMPLOYEE_REFERENCE_DEPARTME4");
        });

        modelBuilder.Entity<EmployeeWorkingLog>(entity =>
        {
            entity.HasKey(e => e.EmployeeWorkingLogId).HasName("PK_EMPLOYEEWORKINGLOG");

            entity.ToTable("EmployeeWorkingLog");

            entity.Property(e => e.EmployeeWorkingLogId)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("EmployeeWorkingLogID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.WorkingApplicationPkid)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("WorkingApplicationPKID");
            entity.Property(e => e.WorkingStatus).HasMaxLength(100);

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.EmployeeWorkingLogs)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK_EMPLOYEE_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.Department).WithMany(p => p.EmployeeWorkingLogs)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_EMPLOYEE_REFERENCE_DEPARTME3");

            entity.HasOne(d => d.WorkingApplicationTypeNavigation).WithMany(p => p.EmployeeWorkingLogs)
                .HasForeignKey(d => d.WorkingApplicationType)
                .HasConstraintName("FK_EMPLOYEE_REFERENCE_SYSRMSAP");
        });

        modelBuilder.Entity<EmployeesCourseSkill>(entity =>
        {
            entity.HasKey(e => e.EmployeesCourseSkillId).HasName("PK_EMPLOYEESCOURSESKILL");

            entity.ToTable("EmployeesCourseSkill");

            entity.Property(e => e.EmployeesCourseSkillId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("EmployeesCourseSkillID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CourseDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Expires).HasColumnType("datetime");
            entity.Property(e => e.Hours).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Instructor).HasMaxLength(200);
            entity.Property(e => e.Location).HasMaxLength(200);
            entity.Property(e => e.ReceivedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Score).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StatusDataTime).HasColumnType("datetime");

            entity.HasOne(d => d.CourseCodeNavigation).WithMany(p => p.EmployeesCourseSkillCourseCodeNavigations)
                .HasForeignKey(d => d.CourseCode)
                .HasConstraintName("FK_EMPLOYEE_REFERENCE_REFMISCR2");

            entity.HasOne(d => d.CourseStatusCodeNavigation).WithMany(p => p.EmployeesCourseSkillCourseStatusCodeNavigations)
                .HasForeignKey(d => d.CourseStatusCode)
                .HasConstraintName("FK_EMPLOYEE_REFERENCE_REFMISCR3");
        });

        modelBuilder.Entity<EnfieldDatacPendingIncidentRemoveRmsuserQueryResult>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EnfieldDatac_PendingIncidentRemoveRMSUserQueryResults");

            entity.Property(e => e.IncidentId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("IncidentID");
        });

        modelBuilder.Entity<EnfieldImportArrestHisotry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Enfield_ImportArrestHisotry");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ArrestBookingId).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IncidentId).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Inum)
                .HasMaxLength(100)
                .HasColumnName("INUM");
            entity.Property(e => e.InvolvementString).HasMaxLength(100);
            entity.Property(e => e.Mpid)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.PersonInvolvementId).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<EnfieldImportedInacivePersonSupplementHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Enfield_ImportedInacivePersonSupplementHistory");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.InvolvementString).HasMaxLength(100);
            entity.Property(e => e.Mpid)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.OriginalIncidentId).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PersonInvolvementId).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SupplementId).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<EnfieldImportedSupplementHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Enfield_ImportedSupplementHistory");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.InvolvementString).HasMaxLength(100);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.Mpid)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.OriginalIncidentId).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PersonInvolvementId).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SupplementId).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<EnforcementOfficialUnit>(entity =>
        {
            entity.HasKey(e => e.EnforcementOfficialUnitId)
                .HasName("PK_ENFORCEMENTOFFICIALUNIT")
                .IsClustered(false);

            entity.ToTable("EnforcementOfficialUnit");

            entity.HasIndex(e => e.ServiceCallId, "ServiceCallIDINX");

            entity.Property(e => e.EnforcementOfficialUnitId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("EnforcementOfficialUnitID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CadunitOnlineId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CADUnitOnlineID");
            entity.Property(e => e.ClearanceCode).HasMaxLength(100);
            entity.Property(e => e.DateActive).HasColumnType("datetime");
            entity.Property(e => e.DateAssigned).HasColumnType("datetime");
            entity.Property(e => e.DateClear).HasColumnType("datetime");
            entity.Property(e => e.DateClosed).HasColumnType("datetime");
            entity.Property(e => e.Dispatcher).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.OfflineTime).HasColumnType("datetime");
            entity.Property(e => e.OnlineTime).HasColumnType("datetime");
            entity.Property(e => e.ResourceType).HasMaxLength(20);
            entity.Property(e => e.SchOfflineTime).HasColumnType("datetime");
            entity.Property(e => e.SchOnlineTime).HasColumnType("datetime");
            entity.Property(e => e.ServiceCallId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ServiceCallID");
            entity.Property(e => e.Shift).HasMaxLength(100);
            entity.Property(e => e.UnitBeatAssignmentXml)
                .HasColumnType("xml")
                .HasColumnName("UnitBeatAssignmentXML");
            entity.Property(e => e.UnitName).HasMaxLength(100);
            entity.Property(e => e.UnitProvider).HasMaxLength(100);
            entity.Property(e => e.UnitReportingArea).HasMaxLength(100);
            entity.Property(e => e.UnitType).HasMaxLength(100);
            entity.Property(e => e.VehicleId)
                .HasMaxLength(100)
                .HasColumnName("VehicleID");

            entity.HasOne(d => d.ServiceCall).WithMany(p => p.EnforcementOfficialUnits)
                .HasForeignKey(d => d.ServiceCallId)
                .HasConstraintName("FK_ENFORCEM_REFERENCE_SERVICEC");
        });

        modelBuilder.Entity<EnforcementOfficialUnitStatusDetail>(entity =>
        {
            entity.HasKey(e => e.EnforcementOfficialUnitStatusDetailId).HasName("PK_ENFORCEMENTOFFICIALUNITSTAT");

            entity.ToTable("EnforcementOfficialUnitStatusDetail");

            entity.HasIndex(e => e.EnforcementOfficialUnitId, "IX_EnforcementOfficialUnitStatusDetail_EnforcementOfficialUnitID");

            entity.Property(e => e.EnforcementOfficialUnitStatusDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("EnforcementOfficialUnitStatusDetailID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CadeventUnitActionId).HasColumnName("CADEventUnitActionID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EnforcementOfficialUnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("EnforcementOfficialUnitID");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.StatusDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.EnforcementOfficialUnit).WithMany(p => p.EnforcementOfficialUnitStatusDetails)
                .HasForeignKey(d => d.EnforcementOfficialUnitId)
                .HasConstraintName("FK_ENFORCEM_REFERENCE_ENFORCEM");
        });

        modelBuilder.Entity<EvidenceDataExport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EvidenceDataExport");

            entity.Property(e => e.AddedOn).HasColumnType("date");
            entity.Property(e => e.CaseNumber).HasMaxLength(100);
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Location).HasMaxLength(500);
            entity.Property(e => e.PropertyDescription).HasMaxLength(500);
        });

        modelBuilder.Entity<ExcelArresteeSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Excel_ArresteeSummary");

            entity.Property(e => e.AgeStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestNumber).HasMaxLength(50);
            entity.Property(e => e.ArrestStatus).HasMaxLength(100);
            entity.Property(e => e.ArrestType)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Ethnicity).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(206);
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.HitgeometryName)
                .HasMaxLength(50)
                .HasColumnName("HITGeometryName");
            entity.Property(e => e.HitgislayerName)
                .HasMaxLength(50)
                .HasColumnName("HITGISLayerName");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.Location).HasMaxLength(300);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.Race).HasMaxLength(100);
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
        });

        modelBuilder.Entity<ExcelCrashSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Excel_CrashSummary");

            entity.Property(e => e.AdminStatus).HasMaxLength(1000);
            entity.Property(e => e.Cadnumber)
                .HasMaxLength(1000)
                .HasColumnName("CADNumber");
            entity.Property(e => e.CrashNumber).HasMaxLength(100);
            entity.Property(e => e.CrashStatus).HasMaxLength(100);
            entity.Property(e => e.CrashTime).HasColumnType("datetime");
            entity.Property(e => e.CrashType).HasMaxLength(1000);
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Duicrash)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DUICrash");
            entity.Property(e => e.EventTypeCategory).HasMaxLength(50);
            entity.Property(e => e.HitgeometryName)
                .HasMaxLength(50)
                .HasColumnName("HITGeometryName");
            entity.Property(e => e.HitgislayerName)
                .HasMaxLength(50)
                .HasColumnName("HITGISLayerName");
            entity.Property(e => e.ReportedEmployee).HasMaxLength(154);
            entity.Property(e => e.ServiceCallType).HasMaxLength(100);
            entity.Property(e => e.StreetName).HasMaxLength(300);
        });

        modelBuilder.Entity<ExcelIncidentCrime>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Excel_IncidentCrime");

            entity.Property(e => e.Arrest)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Classification).HasMaxLength(100);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Location).HasMaxLength(300);
            entity.Property(e => e.LocationDetailDisplayString).HasMaxLength(800);
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
        });

        modelBuilder.Entity<ExcelIncidentSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Excel_IncidentSummary");

            entity.Property(e => e.Cadnumber).HasColumnName("CADNumber");
            entity.Property(e => e.CallPriority).HasMaxLength(30);
            entity.Property(e => e.DepartmentName).HasMaxLength(50);
            entity.Property(e => e.HbfinialCallType).HasColumnName("HBFinialCallType");
            entity.Property(e => e.HitgeometryName)
                .HasMaxLength(50)
                .HasColumnName("HITGeometryName");
            entity.Property(e => e.HitgislayerName)
                .HasMaxLength(50)
                .HasColumnName("HITGISLayerName");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentReportType).HasMaxLength(300);
            entity.Property(e => e.IncidentStatus).HasMaxLength(100);
            entity.Property(e => e.PickUpCategoryGroup).HasMaxLength(100);
            entity.Property(e => e.ReportStatus).HasMaxLength(100);
            entity.Property(e => e.ReportedEmployee).HasMaxLength(154);
            entity.Property(e => e.StreetName).HasMaxLength(300);
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
        });

        modelBuilder.Entity<ExcelTssummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Excel_TSSummary");

            entity.Property(e => e.CitationTicketNumber).HasMaxLength(20);
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.EventTypeCategory).HasMaxLength(50);
            entity.Property(e => e.HitgeometryName)
                .HasMaxLength(50)
                .HasColumnName("HITGeometryName");
            entity.Property(e => e.HitgislayerName)
                .HasMaxLength(50)
                .HasColumnName("HITGISLayerName");
            entity.Property(e => e.ReportedEmployee).HasMaxLength(154);
            entity.Property(e => e.ResultofStop).HasMaxLength(100);
            entity.Property(e => e.ServiceCallType).HasMaxLength(100);
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
            entity.Property(e => e.StreetName).HasMaxLength(300);
            entity.Property(e => e.TrafficStopDateTime).HasColumnType("datetime");
            entity.Property(e => e.TrafficStopNumber).HasMaxLength(50);
            entity.Property(e => e.TrafficStopStatus).HasMaxLength(100);
        });

        modelBuilder.Entity<ExportPropertyEvidenceRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ExportPr__3214EC27AC50423A");

            entity.ToTable("ExportPropertyEvidenceRecord");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.Case)
                .HasMaxLength(255)
                .HasColumnName("CASE #");
            entity.Property(e => e.Date)
                .HasMaxLength(255)
                .HasColumnName("DATE");
            entity.Property(e => e.FelMisd)
                .HasMaxLength(255)
                .HasColumnName("FEL / MISD");
            entity.Property(e => e.FoundSeized)
                .HasMaxLength(255)
                .HasColumnName("FOUND/SEIZED");
            entity.Property(e => e.IncidentPropertyInvolvementId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Incident_PropertyInvolvementID");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Mppid)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MPPID");
            entity.Property(e => e.PropertyDescription)
                .HasMaxLength(255)
                .HasColumnName("PROPERTY DESCRIPTION");
            entity.Property(e => e.SeizedReport)
                .HasMaxLength(255)
                .HasColumnName("SEIZED REPORT");
            entity.Property(e => e.Seq)
                .HasMaxLength(255)
                .HasColumnName("SEQ");
            entity.Property(e => e.Status).HasMaxLength(100);
        });

        modelBuilder.Entity<FieldInterview>(entity =>
        {
            entity.HasKey(e => e.FieldInterviewId).HasName("PK_FIELDINTERVIEWS");

            entity.HasIndex(e => e.DataEntryEmployeeId, "IX_FieldInterviews_DataEntryEmployeeID");

            entity.HasIndex(e => e.DepartmentId, "IX_FieldInterviews_DepartmentID");

            entity.HasIndex(e => e.FistatusId, "IX_FieldInterviews_FIStatusID");

            entity.HasIndex(e => e.InterviewOfficerId, "IX_FieldInterviews_InterviewOfficerID");

            entity.HasIndex(e => e.LocationId, "IX_FieldInterviews_LocationID");

            entity.HasIndex(e => e.SuppressedById, "IX_FieldInterviews_SuppressedByID");

            entity.Property(e => e.FieldInterviewId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("FieldInterviewID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Cadnumber)
                .HasMaxLength(1000)
                .HasColumnName("CADNumber");
            entity.Property(e => e.DataEntryEmployeeId).HasColumnName("DataEntryEmployeeID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FieldInterviewNumber).HasMaxLength(25);
            entity.Property(e => e.FistatusId).HasColumnName("FIStatusID");
            entity.Property(e => e.InterviewDatetime).HasColumnType("datetime");
            entity.Property(e => e.InterviewOfficerId).HasColumnName("InterviewOfficerID");
            entity.Property(e => e.LocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LocationID");
            entity.Property(e => e.ReportingUnit).HasMaxLength(50);
            entity.Property(e => e.ReportingUnitArea).HasMaxLength(50);
            entity.Property(e => e.ReportingUnitProvider).HasMaxLength(50);
            entity.Property(e => e.ReportingUnitShift).HasMaxLength(50);
            entity.Property(e => e.SuppressedById).HasColumnName("SuppressedByID");
            entity.Property(e => e.SuppressedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.DataEntryEmployee).WithMany(p => p.FieldInterviewDataEntryEmployees)
                .HasForeignKey(d => d.DataEntryEmployeeId)
                .HasConstraintName("FK_FIELDINT_REFERENCE_DEPARTME3");

            entity.HasOne(d => d.Department).WithMany(p => p.FieldInterviews)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_FIELDINT_REFERENCE_DEPARTME4");

            entity.HasOne(d => d.Fistatus).WithMany(p => p.FieldInterviews)
                .HasForeignKey(d => d.FistatusId)
                .HasConstraintName("FK_FIELDINT_REFERENCE_SYSAPPLI");

            entity.HasOne(d => d.InterviewOfficer).WithMany(p => p.FieldInterviewInterviewOfficers)
                .HasForeignKey(d => d.InterviewOfficerId)
                .HasConstraintName("FK_FIELDINT_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.Location).WithMany(p => p.FieldInterviews)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_FIELDINT_REFERENCE_MSTRLOCA");

            entity.HasOne(d => d.SuppressedBy).WithMany(p => p.FieldInterviewSuppressedBies)
                .HasForeignKey(d => d.SuppressedById)
                .HasConstraintName("FK_FIELDINT_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<FieldInterviewPersonInvolvment>(entity =>
        {
            entity.HasKey(e => e.FieldInterviewPersonInvolvmentId).HasName("PK_FIELDINTERVIEWPERSONINVOLVM");

            entity.ToTable("FieldInterviewPersonInvolvment");

            entity.HasIndex(e => e.FieldInterviewId, "IX_FieldInterviewPersonInvolvment_FieldInterviewID");

            entity.HasIndex(e => e.Mpid, "IX_FieldInterviewPersonInvolvment_MPID");

            entity.HasIndex(e => e.RelatedVehicleInvolvmentId, "IX_FieldInterviewPersonInvolvment_RelatedVehicleInvolvmentID");

            entity.Property(e => e.FieldInterviewPersonInvolvmentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("FieldInterviewPersonInvolvmentID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FieldInterviewId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("FieldInterviewID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.RelatedVehicleInvolvmentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RelatedVehicleInvolvmentID");

            entity.HasOne(d => d.FieldInterview).WithMany(p => p.FieldInterviewPersonInvolvments)
                .HasForeignKey(d => d.FieldInterviewId)
                .HasConstraintName("FK_FIELDINT_REFERENCE_FIELDINT2");

            entity.HasOne(d => d.Mp).WithMany(p => p.FieldInterviewPersonInvolvments)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_FIELDINT_REFERENCE_MSTRPERS");

            entity.HasOne(d => d.PersonInvolvementCodeNavigation).WithMany(p => p.FieldInterviewPersonInvolvments)
                .HasForeignKey(d => d.PersonInvolvementCode)
                .HasConstraintName("FK_FIELDINT_REFERENCE_REFMISCR2");

            entity.HasOne(d => d.RelatedVehicleInvolvment).WithMany(p => p.FieldInterviewPersonInvolvments)
                .HasForeignKey(d => d.RelatedVehicleInvolvmentId)
                .HasConstraintName("FK_FIELDINT_REFERENCE_FIELDINT3");
        });

        modelBuilder.Entity<FieldInterviewVehicleInvolvment>(entity =>
        {
            entity.HasKey(e => e.FieldInterviewVehicleInvolvmentId).HasName("PK_FIELDINTERVIEWVEHICLEINVOLV");

            entity.ToTable("FieldInterviewVehicleInvolvment");

            entity.HasIndex(e => e.FieldInterviewId, "IX_FieldInterviewVehicleInvolvment_FieldInterviewID");

            entity.HasIndex(e => e.Mvid, "IX_FieldInterviewVehicleInvolvment_MVID");

            entity.HasIndex(e => e.TowRequestId, "IX_FieldInterviewVehicleInvolvment_TowRequestID");

            entity.Property(e => e.FieldInterviewVehicleInvolvmentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("FieldInterviewVehicleInvolvmentID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FieldInterviewId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("FieldInterviewID");
            entity.Property(e => e.Mvid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MVID");
            entity.Property(e => e.TowRequestId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TowRequestID");

            entity.HasOne(d => d.FieldInterview).WithMany(p => p.FieldInterviewVehicleInvolvments)
                .HasForeignKey(d => d.FieldInterviewId)
                .HasConstraintName("FK_FIELDINT_REFERENCE_FIELDINT");

            entity.HasOne(d => d.Mv).WithMany(p => p.FieldInterviewVehicleInvolvments)
                .HasForeignKey(d => d.Mvid)
                .HasConstraintName("FK_FIELDINT_REFERENCE_MSTRVEHI");

            entity.HasOne(d => d.TowRequest).WithMany(p => p.FieldInterviewVehicleInvolvments)
                .HasForeignKey(d => d.TowRequestId)
                .HasConstraintName("FK_FIELDINT_REFERENCE_TOWREQUE");

            entity.HasOne(d => d.VehicleInvolvementCodeNavigation).WithMany(p => p.FieldInterviewVehicleInvolvments)
                .HasForeignKey(d => d.VehicleInvolvementCode)
                .HasConstraintName("FK_FIELDINT_REFERENCE_REFMISCR");
        });

        modelBuilder.Entity<GetIncidentUcr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetIncidentUCR");

            entity.Property(e => e.CategoryGroup).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentReportType).HasMaxLength(300);
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");
            entity.Property(e => e.UcrmajorCode)
                .HasMaxLength(2)
                .HasColumnName("UCRMajorCode");
        });

        modelBuilder.Entity<HelpQueryLocationInvolvement>(entity =>
        {
            entity.HasKey(e => e.HelpQueryLocationInvolvementId).HasName("PK_HELPQUERYLOCATIONINVOLVEMEN");

            entity.HasIndex(e => e.ApplicationType, "HelpQueryLocation_ApplicationType");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "IX_HelpQueryLocationInvolvements_ApplicationType_ApplicationTypePK");

            entity.HasIndex(e => e.LocationId, "Index-2");

            entity.Property(e => e.HelpQueryLocationInvolvementId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("HelpQueryLocationInvolvementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationInvolvementID");
            entity.Property(e => e.ApplicationInvolvementTable).HasMaxLength(100);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.InvolvementCode).HasMaxLength(150);
            entity.Property(e => e.InvolvementRefCodeId).HasColumnName("InvolvementRefCodeID");
            entity.Property(e => e.InvolvementRefCodeTable).HasMaxLength(100);
            entity.Property(e => e.LocationDirectoryName).HasMaxLength(200);
            entity.Property(e => e.LocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LocationID");
            entity.Property(e => e.MasterIndexId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MasterIndexID");
            entity.Property(e => e.MasterIndexTable).HasMaxLength(100);

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.HelpQueryLocationInvolvements)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_HELPQUER_REFERENCE_SYSRMSAP5");

            entity.HasOne(d => d.Location).WithMany(p => p.HelpQueryLocationInvolvements)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_HELPQUER_REFERENCE_MSTRLOCA");
        });

        modelBuilder.Entity<HelpQueryOrganizationInvolvement>(entity =>
        {
            entity.HasKey(e => e.HelpQueryOrganizationInvolvementId).HasName("PK_HELPQUERYORGANIZATIONINVOLV");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "IX_HelpQueryOrganizationInvolvements_ApplicationType_ApplicationTypePK");

            entity.HasIndex(e => e.IncidentOrganizationInvolvementId, "IX_HelpQueryOrganizationInvolvements_Incident_OrganizationInvolvementID");

            entity.HasIndex(e => e.Moid, "IX_HelpQueryOrganizationInvolvements_MOID");

            entity.Property(e => e.HelpQueryOrganizationInvolvementId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("HelpQueryOrganizationInvolvementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(100);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.IncidentOrganizationInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Incident_OrganizationInvolvementID");
            entity.Property(e => e.InvolvementCode).HasMaxLength(150);
            entity.Property(e => e.InvolvementRefCodeId).HasColumnName("InvolvementRefCodeID");
            entity.Property(e => e.InvolvementRefCodeTable).HasMaxLength(100);
            entity.Property(e => e.MasterIndexId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MasterIndexID");
            entity.Property(e => e.MasterIndexTable).HasMaxLength(100);
            entity.Property(e => e.Moid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MOID");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.HelpQueryOrganizationInvolvements)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_HELPQUER_REFERENCE_SYSRMSAP4");

            entity.HasOne(d => d.IncidentOrganizationInvolvement).WithMany(p => p.HelpQueryOrganizationInvolvements)
                .HasForeignKey(d => d.IncidentOrganizationInvolvementId)
                .HasConstraintName("FK_HELPQUER_REFERENCE_INCIDENT4");

            entity.HasOne(d => d.Mo).WithMany(p => p.HelpQueryOrganizationInvolvements)
                .HasForeignKey(d => d.Moid)
                .HasConstraintName("FK_HELPQUER_REFERENCE_MSTRORGA");
        });

        modelBuilder.Entity<HelpQueryPersonInvolvement>(entity =>
        {
            entity.HasKey(e => e.MstrpersonApplictionInvolvementId).HasName("PK_HELPQUERYPERSONINVOLVEMENTS");

            entity.HasIndex(e => e.CrashPersonInvolvementId, "IX_HelpQueryPersonInvolvements_Crash_PersonInvolvementID");

            entity.HasIndex(e => e.FieldInterviewPersonInvolvmentId, "IX_HelpQueryPersonInvolvements_FieldInterviewPersonInvolvmentID");

            entity.HasIndex(e => e.IncidentPersonInvolvementId, "IX_HelpQueryPersonInvolvements_IncidentPersonInvolvementID");

            entity.HasIndex(e => e.TrafficStopId, "IX_HelpQueryPersonInvolvements_TrafficStopID");

            entity.HasIndex(e => new { e.Mpid, e.ApplicationType, e.ApplicationTypePk }, "NonClusteredIndex-20150519-183110");

            entity.HasIndex(e => e.ApplicationType, "NonClusteredIndex-20150519-183151");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "NonClusteredIndex-20150519-183219");

            entity.Property(e => e.MstrpersonApplictionInvolvementId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRPersonApplictionInvolvementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(100);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.CrashPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_PersonInvolvementID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FieldInterviewPersonInvolvmentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("FieldInterviewPersonInvolvmentID");
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.InvolvementCode).HasMaxLength(150);
            entity.Property(e => e.InvolvementRefCodeId).HasColumnName("InvolvementRefCodeID");
            entity.Property(e => e.InvolvementRefCodeTable).HasMaxLength(100);
            entity.Property(e => e.MasterIndexId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MasterIndexID");
            entity.Property(e => e.MasterIndexTable).HasMaxLength(100);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.TrafficStopId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopID");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.HelpQueryPersonInvolvements)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_HELPQUER_REFERENCE_SYSRMSAP2");

            entity.HasOne(d => d.CrashPersonInvolvement).WithMany(p => p.HelpQueryPersonInvolvements)
                .HasForeignKey(d => d.CrashPersonInvolvementId)
                .HasConstraintName("FK_HELPQUER_REFERENCE_CRASH_PE");

            entity.HasOne(d => d.FieldInterviewPersonInvolvment).WithMany(p => p.HelpQueryPersonInvolvements)
                .HasForeignKey(d => d.FieldInterviewPersonInvolvmentId)
                .HasConstraintName("FK_HELPQUER_REFERENCE_FIELDINT2");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.HelpQueryPersonInvolvements)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_HELPQUER_REFERENCE_INCIDENT2");

            entity.HasOne(d => d.Mp).WithMany(p => p.HelpQueryPersonInvolvements)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_HELPQUER_REFERENCE_MSTRPERS");

            entity.HasOne(d => d.TrafficStop).WithMany(p => p.HelpQueryPersonInvolvements)
                .HasForeignKey(d => d.TrafficStopId)
                .HasConstraintName("FK_HELPQUER_REFERENCE_TRAFFICS2");
        });

        modelBuilder.Entity<HelpQueryPropertyInvolvement>(entity =>
        {
            entity.HasKey(e => e.HelpQueryPropertyInvolvementId).HasName("PK_HELPQUERYPROPERTYINVOLVEMEN");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "IX_HelpQueryPropertyInvolvements_ApplicationType_ApplicationTypePK");

            entity.HasIndex(e => e.CrashPropertyInvolvementId, "IX_HelpQueryPropertyInvolvements_Crash_PropertyInvolvementID");

            entity.HasIndex(e => e.IncidentPropertyInvolvementId, "IX_HelpQueryPropertyInvolvements_Incident_PropertyInvolvementID");

            entity.HasIndex(e => e.Mppid, "IX_HelpQueryPropertyInvolvements_MPPID");

            entity.Property(e => e.HelpQueryPropertyInvolvementId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("HelpQueryPropertyInvolvementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(100);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.CrashPropertyInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_PropertyInvolvementID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentPropertyInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Incident_PropertyInvolvementID");
            entity.Property(e => e.InvolvementCode).HasMaxLength(150);
            entity.Property(e => e.InvolvementRefCodeId).HasColumnName("InvolvementRefCodeID");
            entity.Property(e => e.InvolvementRefCodeTable).HasMaxLength(100);
            entity.Property(e => e.Mppid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPID");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.HelpQueryPropertyInvolvements)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_HELPQUER_REFERENCE_SYSRMSAP");

            entity.HasOne(d => d.CrashPropertyInvolvement).WithMany(p => p.HelpQueryPropertyInvolvements)
                .HasForeignKey(d => d.CrashPropertyInvolvementId)
                .HasConstraintName("FK_HELPQUER_REFERENCE_CRASH_PR");

            entity.HasOne(d => d.IncidentPropertyInvolvement).WithMany(p => p.HelpQueryPropertyInvolvements)
                .HasForeignKey(d => d.IncidentPropertyInvolvementId)
                .HasConstraintName("FK_HELPQUER_REFERENCE_INCIDENT");

            entity.HasOne(d => d.Mpp).WithMany(p => p.HelpQueryPropertyInvolvements)
                .HasForeignKey(d => d.Mppid)
                .HasConstraintName("FK_HELPQUER_REFERENCE_MSTRPROP");
        });

        modelBuilder.Entity<HelpQueryVehicleInvolvement>(entity =>
        {
            entity.HasKey(e => e.HelpQueryVehicleInvolvementId).HasName("PK_HELPQUERYVEHICLEINVOLVEMENT");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "IX_HelpQueryVehicleInvolvements_ApplicationType_ApplicationTypePK");

            entity.HasIndex(e => e.CrashVehicleInvolvementId, "IX_HelpQueryVehicleInvolvements_Crash_VehicleInvolvementID");

            entity.HasIndex(e => e.FieldInterviewVehicleInvolvmentId, "IX_HelpQueryVehicleInvolvements_FieldInterviewVehicleInvolvmentID");

            entity.HasIndex(e => e.IncidentVehicleInvolvementId, "IX_HelpQueryVehicleInvolvements_Incident_VehicleInvolvementID");

            entity.HasIndex(e => e.TrafficStopId, "IX_HelpQueryVehicleInvolvements_TrafficStopID");

            entity.HasIndex(e => new { e.Mvid, e.ApplicationType }, "NonClusteredIndex-20150519-175054");

            entity.Property(e => e.HelpQueryVehicleInvolvementId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("HelpQueryVehicleInvolvementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(100);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.CrashVehicleInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_VehicleInvolvementID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FieldInterviewVehicleInvolvmentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("FieldInterviewVehicleInvolvmentID");
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.IncidentVehicleInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Incident_VehicleInvolvementID");
            entity.Property(e => e.InvolvementCode).HasMaxLength(150);
            entity.Property(e => e.InvolvementRefCodeId).HasColumnName("InvolvementRefCodeID");
            entity.Property(e => e.InvolvementRefCodeTable).HasMaxLength(100);
            entity.Property(e => e.MasterIndexId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MasterIndexID");
            entity.Property(e => e.MasterIndexTable).HasMaxLength(100);
            entity.Property(e => e.Mvid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MVID");
            entity.Property(e => e.TrafficStopId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopID");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.HelpQueryVehicleInvolvements)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_HELPQUER_REFERENCE_SYSRMSAP3");

            entity.HasOne(d => d.CrashVehicleInvolvement).WithMany(p => p.HelpQueryVehicleInvolvements)
                .HasForeignKey(d => d.CrashVehicleInvolvementId)
                .HasConstraintName("FK_HELPQUER_REFERENCE_CRASH_VE");

            entity.HasOne(d => d.FieldInterviewVehicleInvolvment).WithMany(p => p.HelpQueryVehicleInvolvements)
                .HasForeignKey(d => d.FieldInterviewVehicleInvolvmentId)
                .HasConstraintName("FK_HELPQUER_REFERENCE_FIELDINT");

            entity.HasOne(d => d.IncidentVehicleInvolvement).WithMany(p => p.HelpQueryVehicleInvolvements)
                .HasForeignKey(d => d.IncidentVehicleInvolvementId)
                .HasConstraintName("FK_HELPQUER_REFERENCE_INCIDENT3");

            entity.HasOne(d => d.Mv).WithMany(p => p.HelpQueryVehicleInvolvements)
                .HasForeignKey(d => d.Mvid)
                .HasConstraintName("FK_HELPQUER_REFERENCE_MSTRVEHI");

            entity.HasOne(d => d.TrafficStop).WithMany(p => p.HelpQueryVehicleInvolvements)
                .HasForeignKey(d => d.TrafficStopId)
                .HasConstraintName("FK_HELPQUER_REFERENCE_TRAFFICS");
        });

        modelBuilder.Entity<ImportEmployeePostrecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ExportEmployeePOSTRecords");

            entity.ToTable("ImportEmployeePOSTRecords");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CertificationDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.Employee).HasMaxLength(1000);
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.PostId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("PostID");
            entity.Property(e => e.Rank).HasMaxLength(100);
        });

        modelBuilder.Entity<ImportInstructor>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AreaCode).HasMaxLength(100);
            entity.Property(e => e.AreaDescription).HasMaxLength(100);
            entity.Property(e => e.CertificationType).HasMaxLength(100);
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.InstructorExpiration).HasColumnType("datetime");
            entity.Property(e => e.InstructorIdnumber).HasColumnName("InstructorIDNumber");
            entity.Property(e => e.InstructorName).HasMaxLength(200);
        });

        modelBuilder.Entity<ImportPostcourse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Import_POSTCourses");

            entity.Property(e => e.CourseName)
                .HasMaxLength(200)
                .HasColumnName("Course Name");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasColumnName("First Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasColumnName("Last Name");
            entity.Property(e => e.PrimaryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Primary ID");
        });

        modelBuilder.Entity<ImportedIncident>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ApproverEmployeeId).HasColumnName("ApproverEmployeeID");
            entity.Property(e => e.CadreprotedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("CADReprotedDateTime");
            entity.Property(e => e.Classification).HasMaxLength(100);
            entity.Property(e => e.ClassificationType).HasMaxLength(100);
            entity.Property(e => e.DataEntryEmployeeId).HasColumnName("DataEntryEmployeeID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtend)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTEnd");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.NarrativeEditedOn).HasColumnType("datetime");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.PrimaryLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryLocationID");
            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
            entity.Property(e => e.ReportedEmployeeId).HasColumnName("ReportedEmployeeID");
            entity.Property(e => e.UserAccessId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("UserAccessID");

            entity.HasOne(d => d.UserAccess).WithMany()
                .HasForeignKey(d => d.UserAccessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportedIncidents_RMSUserAccessTrace");
        });

        modelBuilder.Entity<Incident>(entity =>
        {
            entity.HasKey(e => e.IncidentId).HasName("PK_INCIDENT");

            entity.ToTable("Incident");

            entity.HasIndex(e => e.CloneFromIncidentId, "IX_Incident_CloneFromIncidentID");

            entity.HasIndex(e => e.DataEntryEmployeeId, "IX_Incident_DataEntryEmployeeID");

            entity.HasIndex(e => e.DispositionCodeId, "IX_Incident_DispositionCodeID");

            entity.HasIndex(e => e.IncidentStatusId, "IX_Incident_IncidentStatusID");

            entity.HasIndex(e => e.SkeletonApprovedById, "IX_Incident_SkeletonApprovedByID");

            entity.HasIndex(e => e.SuppressedById, "IX_Incident_SuppressedByID");

            entity.HasIndex(e => e.UcrcaseClearanceCodeId, "IX_Incident_UCRCaseClearanceCodeID");

            entity.HasIndex(e => e.DepartmentId, "Incident_DepartmentID_IPPRIRDIISIC");

            entity.HasIndex(e => e.IncidentOccuredDtstart, "Incident_IncidentOccuredDTStart_IPRIISC");

            entity.HasIndex(e => e.IsSuppressed, "Incident_IsSuppressed");

            entity.HasIndex(e => e.PrimaryIncidentId, "Incident_PrimaryIncidentID");

            entity.HasIndex(e => new { e.ReportedEmployeeId, e.DepartmentId, e.IncidentOccuredDtstart }, "Incident_RDI_IPIISC");

            entity.HasIndex(e => e.ReportStatusId, "Incident_ReportStatusId");

            entity.Property(e => e.IncidentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Barcode).HasMaxLength(100);
            entity.Property(e => e.Cadnumber)
                .HasMaxLength(1000)
                .HasColumnName("CADNumber");
            entity.Property(e => e.CadreprotedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("CADReprotedDateTime");
            entity.Property(e => e.CloneFromIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CloneFromIncidentID");
            entity.Property(e => e.DataEntryEmployeeId).HasColumnName("DataEntryEmployeeID");
            entity.Property(e => e.DateClosed).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DispositionCodeId).HasColumnName("DispositionCodeID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HideLocationOnPdf).HasColumnName("HideLocationOnPDF");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtend)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTEnd");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.NarrativeEditedOn).HasColumnType("datetime");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.PrimaryLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryLocationID");
            entity.Property(e => e.ReportStatusDataTime).HasColumnType("datetime");
            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
            entity.Property(e => e.ReportedEmployeeId).HasColumnName("ReportedEmployeeID");
            entity.Property(e => e.ReportingUnit).HasMaxLength(50);
            entity.Property(e => e.ReportingUnitArea).HasMaxLength(100);
            entity.Property(e => e.ReportingUnitProvider).HasMaxLength(50);
            entity.Property(e => e.ReportingUnitShift).HasMaxLength(50);
            entity.Property(e => e.SkeletonApprovedById).HasColumnName("SkeletonApprovedByID");
            entity.Property(e => e.SkeletonSubmitDateTime).HasColumnType("datetime");
            entity.Property(e => e.SupplementSeq).HasColumnName("SupplementSEQ");
            entity.Property(e => e.SuppressedById).HasColumnName("SuppressedByID");
            entity.Property(e => e.SuppressedDt)
                .HasColumnType("datetime")
                .HasColumnName("SuppressedDT");
            entity.Property(e => e.UcrcaseClearanceCodeId).HasColumnName("UCRCaseClearanceCodeID");
            entity.Property(e => e.Uiaction)
                .HasMaxLength(100)
                .HasColumnName("UIAction");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.UsedNarrativeTemplateId).HasColumnName("UsedNarrativeTemplateID");

            entity.HasOne(d => d.CloneFromIncident).WithMany(p => p.InverseCloneFromIncident)
                .HasForeignKey(d => d.CloneFromIncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT31");

            entity.HasOne(d => d.DataEntryEmployee).WithMany(p => p.IncidentDataEntryEmployees)
                .HasForeignKey(d => d.DataEntryEmployeeId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_DEPARTME13");

            entity.HasOne(d => d.Department).WithMany(p => p.Incidents)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_DEPARTME5");

            entity.HasOne(d => d.DispositionCode).WithMany(p => p.Incidents)
                .HasForeignKey(d => d.DispositionCodeId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFDISPO");

            entity.HasOne(d => d.IncidentStatus).WithMany(p => p.IncidentIncidentStatuses)
                .HasForeignKey(d => d.IncidentStatusId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_SYSAPPLI2");

            entity.HasOne(d => d.PrimaryIncident).WithMany(p => p.InversePrimaryIncident)
                .HasForeignKey(d => d.PrimaryIncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT5");

            entity.HasOne(d => d.ReportStatus).WithMany(p => p.IncidentReportStatuses)
                .HasForeignKey(d => d.ReportStatusId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_SYSAPPLI3");

            entity.HasOne(d => d.ReportedEmployee).WithMany(p => p.IncidentReportedEmployees)
                .HasForeignKey(d => d.ReportedEmployeeId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.SkeletonApprovedBy).WithMany(p => p.IncidentSkeletonApprovedBies)
                .HasForeignKey(d => d.SkeletonApprovedById)
                .HasConstraintName("FK_INCIDENT_REFERENCE_DEPARTME11");

            entity.HasOne(d => d.SuppressedBy).WithMany(p => p.IncidentSuppressedBies)
                .HasForeignKey(d => d.SuppressedById)
                .HasConstraintName("FK_INCIDENT_REFERENCE_DEPARTME6");

            entity.HasOne(d => d.UcrcaseClearanceCode).WithMany(p => p.Incidents)
                .HasForeignKey(d => d.UcrcaseClearanceCodeId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID62");

            entity.HasOne(d => d.UsedNarrativeTemplate).WithMany(p => p.Incidents)
                .HasForeignKey(d => d.UsedNarrativeTemplateId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFNARRA");
        });

        modelBuilder.Entity<IncidentBiasHateCrimeFactor>(entity =>
        {
            entity.HasKey(e => e.IncidentBiasHateCrimeFactorId).HasName("PK_INCIDENTBIASHATECRIMEFACTOR2");

            entity.HasIndex(e => e.IncidentId, "IX_IncidentBiasHateCrimeFactors_IncidentID");

            entity.Property(e => e.IncidentBiasHateCrimeFactorId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentBiasHateCrimeFactorID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IsCurrentIrrecord).HasColumnName("IsCurrentIRRecord");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentBiasHateCrimeFactors)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT24");

            entity.HasOne(d => d.OffenderEthnicityCodeNavigation).WithMany(p => p.IncidentBiasHateCrimeFactorOffenderEthnicityCodeNavigations)
                .HasForeignKey(d => d.OffenderEthnicityCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID27");

            entity.HasOne(d => d.OffenderRaceCodeNavigation).WithMany(p => p.IncidentBiasHateCrimeFactorOffenderRaceCodeNavigations)
                .HasForeignKey(d => d.OffenderRaceCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID30");
        });

        modelBuilder.Entity<IncidentBiasHateCrimeFactorsOffense>(entity =>
        {
            entity.HasKey(e => e.IncidentBiasHateCrimeFactorsOffensesId).HasName("PK_INCIDENTBIASHATECRIMEFACTOR");

            entity.ToTable("IncidentBiasHateCrimeFactors_Offenses");

            entity.Property(e => e.IncidentBiasHateCrimeFactorsOffensesId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentBiasHateCrimeFactors_OffensesID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.BiasMotivation).HasColumnType("xml");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.IncidentBiasHateCrimeFactorId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentBiasHateCrimeFactorID");
            entity.Property(e => e.VictimTypeCode).HasColumnType("xml");

            entity.HasOne(d => d.HateCrimeTypeCodeNavigation).WithMany(p => p.IncidentBiasHateCrimeFactorsOffenseHateCrimeTypeCodeNavigations)
                .HasForeignKey(d => d.HateCrimeTypeCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID19");

            entity.HasOne(d => d.IncidentBiasHateCrimeFactor).WithMany(p => p.IncidentBiasHateCrimeFactorsOffenses)
                .HasForeignKey(d => d.IncidentBiasHateCrimeFactorId)
                .HasConstraintName("FK_IncidentBiasHateCrimeFactors_Offenses_IncidentBiasHateCrimeFactors");

            entity.HasOne(d => d.PlaceofIncidentCodeNavigation).WithMany(p => p.IncidentBiasHateCrimeFactorsOffensePlaceofIncidentCodeNavigations)
                .HasForeignKey(d => d.PlaceofIncidentCode)
                .HasConstraintName("FK_IncidentBiasHateCrimeFactors_Offenses_RefIncidentReferenceData");
        });

        modelBuilder.Entity<IncidentCommentsInvolvement>(entity =>
        {
            entity.HasKey(e => e.CommentsInvolvement).HasName("PK_INCIDENT_COMMENTSINVOLVEMEN");

            entity.ToTable("Incident_CommentsInvolvement");

            entity.HasIndex(e => e.AddedById, "IX_Incident_CommentsInvolvement_AddedByID");

            entity.HasIndex(e => e.EditedById, "IX_Incident_CommentsInvolvement_EditedByID");

            entity.HasIndex(e => e.IncidentId, "IncidentINX");

            entity.Property(e => e.CommentsInvolvement)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AddedById).HasColumnName("AddedByID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CadcommentId).HasColumnName("CADCommentID");
            entity.Property(e => e.EditedById).HasColumnName("EditedByID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.InvolvementPkid).HasColumnName("InvolvementPKID");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");

            entity.HasOne(d => d.AddedBy).WithMany(p => p.IncidentCommentsInvolvementAddedBies)
                .HasForeignKey(d => d.AddedById)
                .HasConstraintName("FK_Incident_CommentsInvolvement_DepartmentEmployees");

            entity.HasOne(d => d.EditedBy).WithMany(p => p.IncidentCommentsInvolvementEditedBies)
                .HasForeignKey(d => d.EditedById)
                .HasConstraintName("FK_Incident_CommentsInvolvement_DepartmentEmployees1");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentCommentsInvolvements)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENTer");
        });

        modelBuilder.Entity<IncidentFamilyViolence>(entity =>
        {
            entity.HasKey(e => e.IncidentFamilyViolenceId).HasName("PK_INCIDENTFAMILYVIOLENCE");

            entity.ToTable("IncidentFamilyViolence");

            entity.HasIndex(e => e.IncidentId, "IX_IncidentFamilyViolence_IncidentID");

            entity.Property(e => e.IncidentFamilyViolenceId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentFamilyViolenceID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DomesticCourtOrderYncode).HasColumnName("DomesticCourtOrderYNCode");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IsCurrentIrrecord).HasColumnName("IsCurrentIRRecord");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.ZeroReportingPeriod).HasColumnType("date");

            entity.HasOne(d => d.ChildUnder18WasNavigation).WithMany(p => p.IncidentFamilyViolenceChildUnder18WasNavigations)
                .HasForeignKey(d => d.ChildUnder18Was)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID55");

            entity.HasOne(d => d.DomesticCourtOrderStatusCodeNavigation).WithMany(p => p.IncidentFamilyViolenceDomesticCourtOrderStatusCodeNavigations)
                .HasForeignKey(d => d.DomesticCourtOrderStatusCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID63");

            entity.HasOne(d => d.DomesticCourtOrderTypeCodeNavigation).WithMany(p => p.IncidentFamilyViolenceDomesticCourtOrderTypeCodeNavigations)
                .HasForeignKey(d => d.DomesticCourtOrderTypeCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID64");

            entity.HasOne(d => d.DomesticCourtOrderYncodeNavigation).WithMany(p => p.IncidentFamilyViolenceDomesticCourtOrderYncodeNavigations)
                .HasForeignKey(d => d.DomesticCourtOrderYncode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID50");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentFamilyViolences)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT19");

            entity.HasOne(d => d.LiguorDrugsInvolvedCodeNavigation).WithMany(p => p.IncidentFamilyViolenceLiguorDrugsInvolvedCodeNavigations)
                .HasForeignKey(d => d.LiguorDrugsInvolvedCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID56");
        });

        modelBuilder.Entity<IncidentForceInvolvement>(entity =>
        {
            entity.HasKey(e => e.ForceInvolvementId).HasName("PK_INCIDENT_FORCEINVOLVEMENT");

            entity.ToTable("Incident_ForceInvolvement");

            entity.HasIndex(e => e.PropertyId, "IX_Incident_ForceInvolvement_PropertyID");

            entity.HasIndex(e => e.IncidentId, "IncidentINX");

            entity.Property(e => e.ForceInvolvementId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ForceInvolvementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ForceWeaponUsedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.PropertyId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PropertyID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.ForceTypeCodeNavigation).WithMany(p => p.IncidentForceInvolvementForceTypeCodeNavigations)
                .HasForeignKey(d => d.ForceTypeCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID4");

            entity.HasOne(d => d.ForceWeaponUsedByNavigation).WithMany(p => p.IncidentForceInvolvements)
                .HasForeignKey(d => d.ForceWeaponUsedBy)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT4");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentForceInvolvements)
                .HasForeignKey(d => d.IncidentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENTww");

            entity.HasOne(d => d.Property).WithMany(p => p.IncidentForceInvolvements)
                .HasForeignKey(d => d.PropertyId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_MSTRPROP");

            entity.HasOne(d => d.WeaponTypeCodeNavigation).WithMany(p => p.IncidentForceInvolvementWeaponTypeCodeNavigations)
                .HasForeignKey(d => d.WeaponTypeCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID5");
        });

        modelBuilder.Entity<IncidentForceReport>(entity =>
        {
            entity.HasKey(e => e.IncidentForceReportId).HasName("PK_INCIDENTFORCEREPORTS");

            entity.HasIndex(e => e.IncidentId, "IX_IncidentForceReports_IncidentID");

            entity.HasIndex(e => e.IncidentPersonInvolvementId, "IX_IncidentForceReports_IncidentPersonInvolvementID");

            entity.Property(e => e.IncidentForceReportId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentForceReportID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AdditionalReasonsForForce).HasMaxLength(100);
            entity.Property(e => e.AppliedForceOfficerId).HasColumnName("AppliedForceOfficerID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HeartConditionType).HasMaxLength(100);
            entity.Property(e => e.Hospital).HasMaxLength(100);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.IsCurrentIrrecord).HasColumnName("IsCurrentIRRecord");
            entity.Property(e => e.MedicalTreatmentForTaser).HasMaxLength(300);
            entity.Property(e => e.OfficerConditionDesc).HasColumnType("xml");
            entity.Property(e => e.OleoresinCapsicumFirstAid).HasColumnType("xml");
            entity.Property(e => e.OleoresinCapsicumMedicalCond).HasColumnType("xml");
            entity.Property(e => e.OtherTypeOfForce).HasMaxLength(200);
            entity.Property(e => e.OtherWeapon).HasMaxLength(200);
            entity.Property(e => e.PoliceForceResultCode).HasColumnType("xml");
            entity.Property(e => e.PoliceForceTypeCode).HasColumnType("xml");
            entity.Property(e => e.PoliceForceWeaponTypeCode).HasColumnType("xml");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.RespiratoryProblemType).HasMaxLength(100);
            entity.Property(e => e.SubjecAttitudeDesc).HasColumnType("xml");
            entity.Property(e => e.SubjectConditionDesc).HasColumnType("xml");
            entity.Property(e => e.TaserDeploymentDateTime).HasColumnType("datetime");
            entity.Property(e => e.TaserUnitNumber).HasMaxLength(50);
            entity.Property(e => e.TreatingPhysician).HasMaxLength(100);

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentForceReports)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT28");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.IncidentForceReports)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT30");

            entity.HasOne(d => d.PoliceForceLocationCodeNavigation).WithMany(p => p.IncidentForceReportPoliceForceLocationCodeNavigations)
                .HasForeignKey(d => d.PoliceForceLocationCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID34");

            entity.HasOne(d => d.TaserTypeOfUseNavigation).WithMany(p => p.IncidentForceReportTaserTypeOfUseNavigations)
                .HasForeignKey(d => d.TaserTypeOfUse)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID53");
        });

        modelBuilder.Entity<IncidentGeneralCategory>(entity =>
        {
            entity.HasKey(e => e.IncidentGeneralCategoryId).HasName("PK_INCIDENT_GENERALCATEGORY");

            entity.ToTable("Incident_GeneralCategory");

            entity.HasIndex(e => e.IncidentPersonInvolvementId, "IX_Incident_GeneralCategory_IncidentPersonInvolvementID");

            entity.HasIndex(e => e.NibrscodeId, "IX_Incident_GeneralCategory_NIBRSCodeID");

            entity.HasIndex(e => e.PrimaryIncidentId, "IX_Incident_GeneralCategory_PrimaryIncidentID");

            entity.HasIndex(e => e.UcrcodeId, "IX_Incident_GeneralCategory_UCRCodeID");

            entity.HasIndex(e => e.IncidentId, "Incident_GeneralCategory_IncidentID");

            entity.HasIndex(e => e.IsPrimary, "Incident_GeneralCategory_IsPrimary");

            entity.HasIndex(e => new { e.IsPrimary, e.PrimaryIncidentId }, "Incident_GeneralCategory_IsPrimary_PrimaryIncidentID");

            entity.Property(e => e.IncidentGeneralCategoryId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Incident_GeneralCategoryID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ClearanceDate).HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.Nibrsclearance).HasColumnName("NIBRSClearance");
            entity.Property(e => e.NibrsclearanceDate)
                .HasColumnType("datetime")
                .HasColumnName("NIBRSClearanceDate");
            entity.Property(e => e.NibrscodeId).HasColumnName("NIBRSCodeID");
            entity.Property(e => e.PickUpCategoryGroup).HasMaxLength(100);
            entity.Property(e => e.PickUpClassification).HasMaxLength(100);
            entity.Property(e => e.PickUpStatuteCode).HasMaxLength(100);
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.Source).HasMaxLength(100);
            entity.Property(e => e.Ucrclearance).HasColumnName("UCRClearance");
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentGeneralCategories)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT6");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.IncidentGeneralCategories)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT8");

            entity.HasOne(d => d.NibrsclearanceNavigation).WithMany(p => p.IncidentGeneralCategories)
                .HasForeignKey(d => d.Nibrsclearance)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID71");

            entity.HasOne(d => d.Nibrscode).WithMany(p => p.IncidentGeneralCategories)
                .HasForeignKey(d => d.NibrscodeId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFNIBRS");

            entity.HasOne(d => d.UcrclearanceNavigation).WithMany(p => p.IncidentGeneralCategories)
                .HasForeignKey(d => d.Ucrclearance)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID70");

            entity.HasOne(d => d.Ucrcode).WithMany(p => p.IncidentGeneralCategories)
                .HasForeignKey(d => d.UcrcodeId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFUCRCO");
        });

        modelBuilder.Entity<IncidentGeneratedReport>(entity =>
        {
            entity.HasKey(e => e.IncidentGeneratedReportId).HasName("PK_INCIDENTGENERATEDREPORTS");

            entity.HasIndex(e => e.IncidentId, "IX_IncidentGeneratedReports_IncidentID");

            entity.HasIndex(e => e.IncidentStatus, "IX_IncidentGeneratedReports_IncidentStatus");

            entity.HasIndex(e => e.RmsworkFlowControllerId, "IX_IncidentGeneratedReports_RMSWorkFlowControllerID");

            entity.HasIndex(e => e.ReportStatus, "IX_IncidentGeneratedReports_ReportStatus");

            entity.Property(e => e.IncidentGeneratedReportId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentGeneratedReportID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.ReportContent).HasColumnType("image");
            entity.Property(e => e.RmsworkFlowControllerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSWorkFlowControllerID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentGeneratedReports)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT9");

            entity.HasOne(d => d.IncidentStatusNavigation).WithMany(p => p.IncidentGeneratedReportIncidentStatusNavigations)
                .HasForeignKey(d => d.IncidentStatus)
                .HasConstraintName("FK_INCIDENT_REFERENCE_SYSAPPLI4");

            entity.HasOne(d => d.ReportStatusNavigation).WithMany(p => p.IncidentGeneratedReportReportStatusNavigations)
                .HasForeignKey(d => d.ReportStatus)
                .HasConstraintName("FK_INCIDENT_REFERENCE_SYSAPPLI5");

            entity.HasOne(d => d.RmsworkFlowController).WithMany(p => p.IncidentGeneratedReports)
                .HasForeignKey(d => d.RmsworkFlowControllerId)
                .HasConstraintName("FK_IncidentGeneratedReports_RMSWorkFlowController");
        });

        modelBuilder.Entity<IncidentInvestigationManagement>(entity =>
        {
            entity.HasKey(e => e.IncidentInvestigationManagementId).HasName("PK_INCIDENT_INVESTIGATIONMANAG");

            entity.ToTable("Incident_InvestigationManagement");

            entity.HasIndex(e => new { e.IncidentId, e.IsCurrentIrrecord }, "Incident_InvestigationManagement_IncidentID_IsCurrentIRRecord");

            entity.HasIndex(e => e.PrimaryIncidentId, "NonClusteredIndex-20150519-200226");

            entity.Property(e => e.IncidentInvestigationManagementId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Incident_InvestigationManagementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.InvestigativeEmployeeId).HasColumnName("InvestigativeEmployeeID");
            entity.Property(e => e.InvestigativeGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("InvestigativeGroupID");
            entity.Property(e => e.InvestigativeStatusId).HasColumnName("InvestigativeStatusID");
            entity.Property(e => e.InvestigativeStatusReasonCodeId).HasColumnName("InvestigativeStatusReasonCodeID");
            entity.Property(e => e.InvestigativeSupervisorId).HasColumnName("InvestigativeSupervisorID");
            entity.Property(e => e.InvestigativeSupervisorOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("InvestigativeSupervisorOrgID");
            entity.Property(e => e.IsCurrentIrrecord).HasColumnName("IsCurrentIRRecord");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.ReviewedBy).HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentInvestigationManagements)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT20");

            entity.HasOne(d => d.InvestigativeEmployee).WithMany(p => p.IncidentInvestigationManagementInvestigativeEmployees)
                .HasForeignKey(d => d.InvestigativeEmployeeId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_DEPARTME18");

            entity.HasOne(d => d.InvestigativeGroup).WithMany(p => p.IncidentInvestigationManagementInvestigativeGroups)
                .HasForeignKey(d => d.InvestigativeGroupId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_DEPARTME16");

            entity.HasOne(d => d.InvestigativeStatus).WithMany(p => p.IncidentInvestigationManagements)
                .HasForeignKey(d => d.InvestigativeStatusId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_SYSAPPLI");

            entity.HasOne(d => d.InvestigativeStatusReasonCode).WithMany(p => p.IncidentInvestigationManagements)
                .HasForeignKey(d => d.InvestigativeStatusReasonCodeId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID52");

            entity.HasOne(d => d.InvestigativeSupervisor).WithMany(p => p.IncidentInvestigationManagementInvestigativeSupervisors)
                .HasForeignKey(d => d.InvestigativeSupervisorId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_DEPARTME");

            entity.HasOne(d => d.InvestigativeSupervisorOrg).WithMany(p => p.IncidentInvestigationManagementInvestigativeSupervisorOrgs)
                .HasForeignKey(d => d.InvestigativeSupervisorOrgId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_DEPARTME19");
        });

        modelBuilder.Entity<IncidentMissingPersonDetail>(entity =>
        {
            entity.HasKey(e => e.IncidentMissingPersonDetailId).HasName("PK_INCIDENTMISSINGPERSONDETAIL");

            entity.ToTable("IncidentMissingPersonDetail");

            entity.HasIndex(e => e.IncidentPersonInvolvementId, "IX_IncidentMissingPersonDetail_IncidentPersonInvolvementID");

            entity.Property(e => e.IncidentMissingPersonDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentMissingPersonDetailID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.BankCreditUnionNameBranch).HasMaxLength(300);
            entity.Property(e => e.CallAttempt).HasMaxLength(300);
            entity.Property(e => e.CourtOrders).HasMaxLength(300);
            entity.Property(e => e.DirectionOfTravel).HasMaxLength(200);
            entity.Property(e => e.Disabilities).HasMaxLength(200);
            entity.Property(e => e.Dnalocation)
                .HasMaxLength(300)
                .HasColumnName("DNALocation");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FormOfTransportation).HasMaxLength(200);
            entity.Property(e => e.HaveDna).HasColumnName("HaveDNA");
            entity.Property(e => e.HobbiesInterests).HasMaxLength(300);
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.ItemsTaken).HasMaxLength(300);
            entity.Property(e => e.KnownHangouts).HasMaxLength(300);
            entity.Property(e => e.KnownTravelPlans).HasMaxLength(300);
            entity.Property(e => e.Markings).HasMaxLength(300);
            entity.Property(e => e.MedicationDescription).HasMaxLength(200);
            entity.Property(e => e.MissingPersonActionTaken).HasColumnType("xml");
            entity.Property(e => e.MissingPersonActionTakenOtherTxt).HasColumnName("MissingPersonActionTakenOtherTXT");
            entity.Property(e => e.MissingPersonFactors).HasColumnType("xml");
            entity.Property(e => e.MissingPersonIncidenType).HasColumnType("xml");
            entity.Property(e => e.MissingPersonIncidentTypeOtherTxt).HasColumnName("MissingPersonIncidentTypeOtherTXT");
            entity.Property(e => e.MissingPersonPossibleType).HasColumnType("xml");
            entity.Property(e => e.OtherAgenciesK9assistance)
                .HasMaxLength(300)
                .HasColumnName("OtherAgenciesK9Assistance");
            entity.Property(e => e.RecentFinancialActivity).HasMaxLength(300);
            entity.Property(e => e.RiskExplain).HasMaxLength(300);
            entity.Property(e => e.SearchArea).HasMaxLength(300);
            entity.Property(e => e.SocialNetworkingSitesUserNames).HasMaxLength(300);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.IncidentMissingPersonDetails)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT29");
        });

        modelBuilder.Entity<IncidentMo>(entity =>
        {
            entity.HasKey(e => e.IncidentMoid).HasName("PK_INCIDENT_MO");

            entity.ToTable("Incident_MO");

            entity.HasIndex(e => e.IncidentId, "IX_Incident_MO_IncidentID");

            entity.Property(e => e.IncidentMoid)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Incident_MOID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.Mo)
                .HasColumnType("xml")
                .HasColumnName("MO");
            entity.Property(e => e.Modescription).HasColumnName("MODescription");
            entity.Property(e => e.Motype).HasColumnName("MOType");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentMos)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT17");

            entity.HasOne(d => d.MotypeNavigation).WithMany(p => p.IncidentMos)
                .HasForeignKey(d => d.Motype)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID21");
        });

        modelBuilder.Entity<IncidentNibrsoffenseBase>(entity =>
        {
            entity.HasKey(e => e.IncidentNibrsoffenseBaseId).HasName("PK_[IncidentNIBRSOffenseBase");

            entity.ToTable("IncidentNIBRSOffenseBase");

            entity.HasIndex(e => e.PrimaryIncidentId, "IX_IncidentNIBRSOffenseBase_PrimaryIncidentID");

            entity.Property(e => e.IncidentNibrsoffenseBaseId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentNIBRSOffenseBaseID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.BiasMotivationCode).HasColumnType("xml");
            entity.Property(e => e.CriminalActivity).HasColumnType("xml");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.IncidentGeneralCategoryId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Incident_GeneralCategoryID");
            entity.Property(e => e.OffenseAc).HasColumnName("OffenseAC");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.Source).HasMaxLength(100);
            entity.Property(e => e.SuspectedofUsing).HasColumnType("xml");
            entity.Property(e => e.WeaponForce).HasColumnType("xml");

            entity.HasOne(d => d.EntryMethodNavigation).WithMany(p => p.IncidentNibrsoffenseBaseEntryMethodNavigations)
                .HasForeignKey(d => d.EntryMethod)
                .HasConstraintName("FK_IncidentNIBRSOffenseBase_EntryMethod");

            entity.HasOne(d => d.IncidentGeneralCategory).WithMany(p => p.IncidentNibrsoffenseBases)
                .HasForeignKey(d => d.IncidentGeneralCategoryId)
                .HasConstraintName("FK__IncidentN__Incid__03DC550A");

            entity.HasOne(d => d.LocationTypeCodeNavigation).WithMany(p => p.IncidentNibrsoffenseBaseLocationTypeCodeNavigations)
                .HasForeignKey(d => d.LocationTypeCode)
                .HasConstraintName("FK_IncidentNIBRSOffenseBase_LocationTypeCode");

            entity.HasOne(d => d.OffenseAcNavigation).WithMany(p => p.IncidentNibrsoffenseBaseOffenseAcNavigations)
                .HasForeignKey(d => d.OffenseAc)
                .HasConstraintName("FK_IncidentNIBRSOffenseBase_OffenseAC");

            entity.HasOne(d => d.PrimaryIncident).WithMany(p => p.IncidentNibrsoffenseBases)
                .HasForeignKey(d => d.PrimaryIncidentId)
                .HasConstraintName("FK_IncidentNIBRSOffenseBase_PrimaryIncidentID");
        });

        modelBuilder.Entity<IncidentOfficialInvolvement>(entity =>
        {
            entity.HasKey(e => e.OfficialInvolvement).HasName("PK_INCIDENT_OFFICIALINVOLVEMEN");

            entity.ToTable("Incident_OfficialInvolvement");

            entity.HasIndex(e => e.IncidentId, "IncidentINX");

            entity.Property(e => e.OfficialInvolvement)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AssignedUnit).HasMaxLength(100);
            entity.Property(e => e.AssignedUnitShift).HasMaxLength(20);
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.OfficialInvolvementCode).HasMaxLength(100);
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.IncidentOfficialInvolvements)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_DEPARTME3");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentOfficialInvolvements)
                .HasForeignKey(d => d.IncidentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENTuu");
        });

        modelBuilder.Entity<IncidentOrganizationInvolvement>(entity =>
        {
            entity.HasKey(e => e.IncidentOrganizationInvolvementId).HasName("PK_INCIDENT_ORGANIZATIONINVOLV");

            entity.ToTable("Incident_OrganizationInvolvement");

            entity.HasIndex(e => e.IncidentId, "IX_Incident_OrganizationInvolvement_IncidentID");

            entity.HasIndex(e => e.Moid, "IX_Incident_OrganizationInvolvement_MOID");

            entity.Property(e => e.IncidentOrganizationInvolvementId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Incident_OrganizationInvolvementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExcludeForNibrsdetail).HasColumnName("ExcludeForNIBRSDetail");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IsConfidential).HasDefaultValueSql("((0))");
            entity.Property(e => e.Moid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MOID");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.Source).HasMaxLength(100);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentOrganizationInvolvements)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT22");

            entity.HasOne(d => d.Mo).WithMany(p => p.IncidentOrganizationInvolvements)
                .HasForeignKey(d => d.Moid)
                .HasConstraintName("FK_INCIDENT_REFERENCE_MSTRORGA");

            entity.HasOne(d => d.OrganizationInvolvementCodeNavigation).WithMany(p => p.IncidentOrganizationInvolvements)
                .HasForeignKey(d => d.OrganizationInvolvementCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID16");
        });

        modelBuilder.Entity<IncidentOtherFactor>(entity =>
        {
            entity.HasKey(e => e.IncidentOtherFactorsId).HasName("PK_INCIDENTOTHERFACTORS");

            entity.HasIndex(e => e.IncidentId, "IX_IncidentOtherFactors_IncidentID");

            entity.Property(e => e.IncidentOtherFactorsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentOtherFactorsID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ContributingFactorLst)
                .HasColumnType("xml")
                .HasColumnName("ContributingFactorLST");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IsCurrentIrrecord).HasColumnName("IsCurrentIRRecord");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.WeatherConditions).HasColumnType("xml");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentOtherFactors)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT16");
        });

        modelBuilder.Entity<IncidentOutOfTownWarrant>(entity =>
        {
            entity.HasKey(e => e.IncidentOutOfTownWarrantId).HasName("PK_INCIDENTOUTOFTOWNWARRANTS");

            entity.HasIndex(e => e.ArrestLocationId, "IX_IncidentOutOfTownWarrants_ArrestLocationID");

            entity.HasIndex(e => e.IncidentId, "IX_IncidentOutOfTownWarrants_IncidentID");

            entity.Property(e => e.IncidentOutOfTownWarrantId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentOutOfTownWarrantID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArrestLocationID");
            entity.Property(e => e.CustodialTransferDt)
                .HasColumnType("datetime")
                .HasColumnName("CustodialTransferDT");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IsCurrentIrrecord).HasColumnName("IsCurrentIRRecord");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.ArrestLocation).WithMany(p => p.IncidentOutOfTownWarrants)
                .HasForeignKey(d => d.ArrestLocationId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_MSTRLOCA");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentOutOfTownWarrants)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT27");

            entity.HasOne(d => d.ReasonForContactCodeNavigation).WithMany(p => p.IncidentOutOfTownWarrantReasonForContactCodeNavigations)
                .HasForeignKey(d => d.ReasonForContactCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID60");

            entity.HasOne(d => d.WantedAgencyNameCodeNavigation).WithMany(p => p.IncidentOutOfTownWarrantWantedAgencyNameCodeNavigations)
                .HasForeignKey(d => d.WantedAgencyNameCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID59");
        });

        modelBuilder.Entity<IncidentPersonFamilyViolence>(entity =>
        {
            entity.HasKey(e => e.IncidentPersonFamilyViolenceId).HasName("PK_INCIDENTPERSONFAMILYVIOLENC");

            entity.ToTable("IncidentPersonFamilyViolence");

            entity.HasIndex(e => e.IncidentPersonInvolvementId, "IncidentPersonFamilyViolence_IncidentPersonInvolvementID");

            entity.Property(e => e.IncidentPersonFamilyViolenceId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonFamilyViolenceID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.TransferOffenseCode).HasColumnType("xml");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.IncidentPersonFamilyViolences)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT");

            entity.HasOne(d => d.InjuryCodeNavigation).WithMany(p => p.IncidentPersonFamilyViolenceInjuryCodeNavigations)
                .HasForeignKey(d => d.InjuryCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID");

            entity.HasOne(d => d.LiquorDrugsInvolvedCodeNavigation).WithMany(p => p.IncidentPersonFamilyViolenceLiquorDrugsInvolvedCodeNavigations)
                .HasForeignKey(d => d.LiquorDrugsInvolvedCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID65");

            entity.HasOne(d => d.RelationshiptoVictimNavigation).WithMany(p => p.IncidentPersonFamilyViolenceRelationshiptoVictimNavigations)
                .HasForeignKey(d => d.RelationshiptoVictim)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID61");

            entity.HasOne(d => d.ViolenceStatusCodeNavigation).WithMany(p => p.IncidentPersonFamilyViolenceViolenceStatusCodeNavigations)
                .HasForeignKey(d => d.ViolenceStatusCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID57");
        });

        modelBuilder.Entity<IncidentPersonInjuryDetail>(entity =>
        {
            entity.HasKey(e => e.IncidentPersonInjuryDetailId).HasName("PK_INCIDENTPERSONINJURYDETAIL");

            entity.ToTable("IncidentPersonInjuryDetail");

            entity.HasIndex(e => e.IncidentPersonInvolvementId, "IX_IncidentPersonInjuryDetail_IncidentPersonInvolvementID");

            entity.Property(e => e.IncidentPersonInjuryDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInjuryDetailID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Emsname)
                .HasMaxLength(100)
                .HasColumnName("EMSName");
            entity.Property(e => e.EmsrunNumber)
                .HasMaxLength(100)
                .HasColumnName("EMSRunNumber");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.InjuryCategory).HasMaxLength(100);
            entity.Property(e => e.InjuryDate).HasColumnType("datetime");
            entity.Property(e => e.InjuryLocation).HasMaxLength(100);
            entity.Property(e => e.InjuryServerity).HasMaxLength(100);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.IncidentPersonInjuryDetails)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT7");

            entity.HasOne(d => d.InjuredTransportationSourceCodeNavigation).WithMany(p => p.IncidentPersonInjuryDetailInjuredTransportationSourceCodeNavigations)
                .HasForeignKey(d => d.InjuredTransportationSourceCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID7");

            entity.HasOne(d => d.InjuryStatusCodeNavigation).WithMany(p => p.IncidentPersonInjuryDetailInjuryStatusCodeNavigations)
                .HasForeignKey(d => d.InjuryStatusCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID44");

            entity.HasOne(d => d.InjuryTypeCodeNavigation).WithMany(p => p.IncidentPersonInjuryDetailInjuryTypeCodeNavigations)
                .HasForeignKey(d => d.InjuryTypeCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID6");
        });

        modelBuilder.Entity<IncidentPersonInvolvement>(entity =>
        {
            entity.HasKey(e => e.IncidentPersonInvolvementId).HasName("PK_INCIDENT_PERSONINVOLVEMENT");

            entity.ToTable("Incident_PersonInvolvement");

            entity.HasIndex(e => e.JuvenileBookingId, "IX_Incident_PersonInvolvement_JuvenileBookingID");

            entity.HasIndex(e => e.NonVerifiedPersonId, "IX_Incident_PersonInvolvement_NonVerifiedPersonID");

            entity.HasIndex(e => e.RelatedVehicleInvolvementId, "IX_Incident_PersonInvolvement_RelatedVehicleInvolvementID");

            entity.HasIndex(e => e.IncidentId, "IncidentINX");

            entity.HasIndex(e => e.Mpid, "Incident_PersonInvolvement_MPID");

            entity.HasIndex(e => e.PersonInvolvementCode, "Incident_PersonInvolvement_PersonInvolvementCode_IIM");

            entity.HasIndex(e => e.PrimaryIncidentId, "Incident_PersonInvolvement_PrimaryIncidentId");

            entity.Property(e => e.IncidentPersonInvolvementId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CollectMessageNumber).HasMaxLength(20);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExcludeForNibrsdetail).HasColumnName("ExcludeForNIBRSDetail");
            entity.Property(e => e.HidePersonNameOnPdf).HasColumnName("HidePersonNameOnPDF");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.InvolvementDateTime).HasColumnType("datetime");
            entity.Property(e => e.InvolvementDateTo).HasColumnType("datetime");
            entity.Property(e => e.InvolvementLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("InvolvementLocationID");
            entity.Property(e => e.IsConfidential).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsLeofromOtherJurisdiction).HasColumnName("IsLEOfromOtherJurisdiction");
            entity.Property(e => e.IsLeoka).HasColumnName("IsLEOKA");
            entity.Property(e => e.JuvenileBookingId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("JuvenileBookingID");
            entity.Property(e => e.Leojurisdiction)
                .HasMaxLength(9)
                .HasColumnName("LEOJurisdiction");
            entity.Property(e => e.Leokaactivity).HasColumnName("LEOKAActivity");
            entity.Property(e => e.Leokaassignment).HasColumnName("LEOKAAssignment");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.NcicmessageNumber)
                .HasMaxLength(20)
                .HasColumnName("NCICMessageNumber");
            entity.Property(e => e.NonVerifiedPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NonVerifiedPersonID");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.RelatedVehicleInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RelatedVehicleInvolvementID");
            entity.Property(e => e.Source).HasMaxLength(100);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentPersonInvolvements)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENTj");

            entity.HasOne(d => d.JuvenileBooking).WithMany(p => p.IncidentPersonInvolvements)
                .HasForeignKey(d => d.JuvenileBookingId)
                .HasConstraintName("FK_JuvenileBookingDetail_REFERENCE");

            entity.HasOne(d => d.LeokaactivityNavigation).WithMany(p => p.IncidentPersonInvolvementLeokaactivityNavigations)
                .HasForeignKey(d => d.Leokaactivity)
                .HasConstraintName("fk_LEOKAActivity_NIBRSReferenceData");

            entity.HasOne(d => d.LeokaassignmentNavigation).WithMany(p => p.IncidentPersonInvolvementLeokaassignmentNavigations)
                .HasForeignKey(d => d.Leokaassignment)
                .HasConstraintName("fk_LEOKAAssignment_NIBRSReferenceData");

            entity.HasOne(d => d.Mp).WithMany(p => p.IncidentPersonInvolvements)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_INCIDENT_REFERENCE_MSTRPERS2");

            entity.HasOne(d => d.NonVerifiedPerson).WithMany(p => p.IncidentPersonInvolvements)
                .HasForeignKey(d => d.NonVerifiedPersonId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_NONVERIF");

            entity.HasOne(d => d.PersonInvolvementCodeNavigation).WithMany(p => p.IncidentPersonInvolvements)
                .HasForeignKey(d => d.PersonInvolvementCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID10");

            entity.HasOne(d => d.RelatedVehicleInvolvement).WithMany(p => p.IncidentPersonInvolvements)
                .HasForeignKey(d => d.RelatedVehicleInvolvementId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT32");
        });

        modelBuilder.Entity<IncidentPersonVictimDetail>(entity =>
        {
            entity.HasKey(e => e.IncidentPersonVictimDetailId).HasName("PK_INCIDENTPERSONVICTIMDETAIL");

            entity.ToTable("IncidentPersonVictimDetail");

            entity.HasIndex(e => e.IncidentPersonInvolvementId, "IX_IncidentPersonVictimDetail_IncidentPersonInvolvementID");

            entity.HasIndex(e => e.PerpetratorId, "IX_IncidentPersonVictimDetail_PerpetratorID");

            entity.Property(e => e.IncidentPersonVictimDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonVictimDetailID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.PerpetratorId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PerpetratorID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.IncidentPersonVictimDetailIncidentPersonInvolvements)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT10");

            entity.HasOne(d => d.PenetrationMethodCodeNavigation).WithMany(p => p.IncidentPersonVictimDetailPenetrationMethodCodeNavigations)
                .HasForeignKey(d => d.PenetrationMethodCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID24");

            entity.HasOne(d => d.Perpetrator).WithMany(p => p.IncidentPersonVictimDetailPerpetrators)
                .HasForeignKey(d => d.PerpetratorId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT12");

            entity.HasOne(d => d.SexAssaultVictimPenetraTypeNavigation).WithMany(p => p.IncidentPersonVictimDetailSexAssaultVictimPenetraTypeNavigations)
                .HasForeignKey(d => d.SexAssaultVictimPenetraType)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID23");
        });

        modelBuilder.Entity<IncidentPersonWitnessDetail>(entity =>
        {
            entity.HasKey(e => e.IncidentPersonWitnessDetailId).HasName("PK_INCIDENTPERSONWITNESSDETAIL");

            entity.ToTable("IncidentPersonWitnessDetail");

            entity.HasIndex(e => e.IncidentPersonInvolvementId, "IX_IncidentPersonWitnessDetail_IncidentPersonInvolvementID");

            entity.Property(e => e.IncidentPersonWitnessDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonWitnessDetailID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.WitnessDate).HasColumnType("datetime");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.IncidentPersonWitnessDetails)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT11");
        });

        modelBuilder.Entity<IncidentPropertyDrugDetail>(entity =>
        {
            entity.HasKey(e => e.IncidentPropertyDrugDetailId).HasName("PK_INCIDENTPROPERTYDRUGDETAIL");

            entity.ToTable("IncidentPropertyDrugDetail");

            entity.HasIndex(e => e.IncidentPropertyInvolvementId, "IX_IncidentPropertyDrugDetail_Incident_PropertyInvolvementID");

            entity.Property(e => e.IncidentPropertyDrugDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPropertyDrugDetailID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.BrandStampMarking).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(300);
            entity.Property(e => e.DrugInvolvementCode).HasColumnType("xml");
            entity.Property(e => e.DrugNameId).HasColumnName("DrugNameID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentPropertyInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Incident_PropertyInvolvementID");
            entity.Property(e => e.Manufacture).HasMaxLength(100);
            entity.Property(e => e.NibrsdrugMeasure).HasColumnName("NIBRSDrugMeasure");
            entity.Property(e => e.NibrsdrugQuantity)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("NIBRSDrugQuantity");
            entity.Property(e => e.NibrsdrugTypeCode).HasColumnName("NIBRSDrugTypeCode");
            entity.Property(e => e.Quantity).HasMaxLength(100);
            entity.Property(e => e.SuspectArsonByUcr).HasColumnName("SuspectArsonByUCR");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.Weight).HasMaxLength(100);

            entity.HasOne(d => d.ContainersCodeNavigation).WithMany(p => p.IncidentPropertyDrugDetailContainersCodeNavigations)
                .HasForeignKey(d => d.ContainersCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID66");

            entity.HasOne(d => d.DrugName).WithMany(p => p.IncidentPropertyDrugDetailDrugNames)
                .HasForeignKey(d => d.DrugNameId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFDRUGD");

            entity.HasOne(d => d.DrugWeightUnitsCodeNavigation).WithMany(p => p.IncidentPropertyDrugDetailDrugWeightUnitsCodeNavigations)
                .HasForeignKey(d => d.DrugWeightUnitsCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID54");

            entity.HasOne(d => d.IncidentPropertyInvolvement).WithMany(p => p.IncidentPropertyDrugDetails)
                .HasForeignKey(d => d.IncidentPropertyInvolvementId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT21");

            entity.HasOne(d => d.NibrsdrugMeasureNavigation).WithMany(p => p.IncidentPropertyDrugDetailNibrsdrugMeasureNavigations).HasForeignKey(d => d.NibrsdrugMeasure);

            entity.HasOne(d => d.NibrsdrugTypeCodeNavigation).WithMany(p => p.IncidentPropertyDrugDetailNibrsdrugTypeCodeNavigations).HasForeignKey(d => d.NibrsdrugTypeCode);

            entity.HasOne(d => d.SuspectArsonByUcrNavigation).WithMany(p => p.IncidentPropertyDrugDetailSuspectArsonByUcrNavigations)
                .HasForeignKey(d => d.SuspectArsonByUcr)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID49");

            entity.HasOne(d => d.TypeOfDrugCodeNavigation).WithMany(p => p.IncidentPropertyDrugDetailTypeOfDrugCodeNavigations)
                .HasForeignKey(d => d.TypeOfDrugCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID58");
        });

        modelBuilder.Entity<IncidentPropertyInvolvement>(entity =>
        {
            entity.HasKey(e => e.IncidentPropertyInvolvementId).HasName("PK_INCIDENT_PROPERTYINVOLVEMEN2");

            entity.ToTable("Incident_PropertyInvolvement");

            entity.HasIndex(e => e.CustodyReason, "IX_Incident_PropertyInvolvement_CustodyReason");

            entity.HasIndex(e => e.IncidentId, "IX_Incident_PropertyInvolvement_IncidentID");

            entity.HasIndex(e => e.InvolvemenLocationId, "IX_Incident_PropertyInvolvement_InvolvemenLocationID");

            entity.HasIndex(e => e.NibrslossType, "IX_Incident_PropertyInvolvement_NIBRSLossType");

            entity.HasIndex(e => e.OwnerOrgId, "IX_Incident_PropertyInvolvement_OwnerOrgID");

            entity.HasIndex(e => e.OwnerPersonId, "IX_Incident_PropertyInvolvement_OwnerPersonID");

            entity.HasIndex(e => e.PrimaryIncidentId, "IX_Incident_PropertyInvolvement_PrimaryIncidentID");

            entity.HasIndex(e => e.PropertyLocker, "IX_Incident_PropertyInvolvement_PropertyLocker");

            entity.HasIndex(e => e.RecoveredFromPersonId, "IX_Incident_PropertyInvolvement_RecoveredFromPersonID");

            entity.HasIndex(e => e.RelatedPersonInvolvementId, "IX_Incident_PropertyInvolvement_RelatedPersonInvolvementID");

            entity.HasIndex(e => e.RelatedVehicleInvolvementId, "IX_Incident_PropertyInvolvement_RelatedVehicleInvolvementID");

            entity.HasIndex(e => e.ReturnedToPersonId, "IX_Incident_PropertyInvolvement_ReturnedToPersonID");

            entity.HasIndex(e => e.StolenRecoveredWhere, "IX_Incident_PropertyInvolvement_StolenRecoveredWhere");

            entity.HasIndex(e => e.Mppid, "Incident_PropertyInvolvement_MPPID");

            entity.Property(e => e.IncidentPropertyInvolvementId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Incident_PropertyInvolvementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CurrencyType).HasMaxLength(100);
            entity.Property(e => e.DamageDescription).HasMaxLength(300);
            entity.Property(e => e.DamagedValue).HasColumnType("money");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.InvolvemenLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("InvolvemenLocationID");
            entity.Property(e => e.InvolvementDateTime).HasColumnType("datetime");
            entity.Property(e => e.InvolvementDateTo).HasColumnType("datetime");
            entity.Property(e => e.IsAddedByQa).HasColumnName("IsAddedByQA");
            entity.Property(e => e.IsConfidential).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsJdc18required).HasColumnName("IsJDC18Required");
            entity.Property(e => e.Mppid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPID");
            entity.Property(e => e.NibrslossType).HasColumnName("NIBRSLossType");
            entity.Property(e => e.OwnerOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OwnerOrgID");
            entity.Property(e => e.OwnerPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OwnerPersonID");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.ReasonForNotTakenIntoCustody).HasMaxLength(500);
            entity.Property(e => e.RecoveredFromPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecoveredFromPersonID");
            entity.Property(e => e.RecoveredValue).HasColumnType("money");
            entity.Property(e => e.RecoveredataPawnShop).HasMaxLength(100);
            entity.Property(e => e.RelatedPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RelatedPersonInvolvementID");
            entity.Property(e => e.RelatedVehicleInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RelatedVehicleInvolvementID");
            entity.Property(e => e.ReturnedToPersonDateTime).HasColumnType("datetime");
            entity.Property(e => e.ReturnedToPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ReturnedToPersonID");
            entity.Property(e => e.Source).HasMaxLength(100);
            entity.Property(e => e.SuspectArsonByUcrdefinition).HasColumnName("SuspectArsonByUCRDefinition");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.TotalAmountofCash).HasColumnType("money");
            entity.Property(e => e.TotalValueOfItems).HasColumnType("money");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.CustodyReasonNavigation).WithMany(p => p.IncidentPropertyInvolvementCustodyReasonNavigations)
                .HasForeignKey(d => d.CustodyReason)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID69");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentPropertyInvolvements)
                .HasForeignKey(d => d.IncidentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENTn");

            entity.HasOne(d => d.InvolvemenLocation).WithMany(p => p.IncidentPropertyInvolvements)
                .HasForeignKey(d => d.InvolvemenLocationId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_MSTRLOCA4");

            entity.HasOne(d => d.Mpp).WithMany(p => p.IncidentPropertyInvolvements)
                .HasForeignKey(d => d.Mppid)
                .HasConstraintName("FK_INCIDENT_REFERENCE_MSTRPROP2");

            entity.HasOne(d => d.NibrslossTypeNavigation).WithMany(p => p.IncidentPropertyInvolvements)
                .HasForeignKey(d => d.NibrslossType)
                .HasConstraintName("FK_Incident_PropertyInvolvement_NIBRSReferenceData");

            entity.HasOne(d => d.OwnerOrg).WithMany(p => p.IncidentPropertyInvolvements)
                .HasForeignKey(d => d.OwnerOrgId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_MSTRORGA2");

            entity.HasOne(d => d.OwnerPerson).WithMany(p => p.IncidentPropertyInvolvementOwnerPeople)
                .HasForeignKey(d => d.OwnerPersonId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_MSTRPERS3");

            entity.HasOne(d => d.PropertyInvolvementCodeNavigation).WithMany(p => p.IncidentPropertyInvolvementPropertyInvolvementCodeNavigations)
                .HasForeignKey(d => d.PropertyInvolvementCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID9");

            entity.HasOne(d => d.PropertyLockerNavigation).WithMany(p => p.IncidentPropertyInvolvementPropertyLockerNavigations)
                .HasForeignKey(d => d.PropertyLocker)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID68");

            entity.HasOne(d => d.RecoveredFromPerson).WithMany(p => p.IncidentPropertyInvolvementRecoveredFromPeople)
                .HasForeignKey(d => d.RecoveredFromPersonId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_MSTRPERS5");

            entity.HasOne(d => d.RelatedPersonInvolvement).WithMany(p => p.IncidentPropertyInvolvements)
                .HasForeignKey(d => d.RelatedPersonInvolvementId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT2");

            entity.HasOne(d => d.RelatedVehicleInvolvement).WithMany(p => p.IncidentPropertyInvolvements)
                .HasForeignKey(d => d.RelatedVehicleInvolvementId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT3");

            entity.HasOne(d => d.ReturnedToPerson).WithMany(p => p.IncidentPropertyInvolvementReturnedToPeople)
                .HasForeignKey(d => d.ReturnedToPersonId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_MSTRPERS");

            entity.HasOne(d => d.SecuredLocationNavigation).WithMany(p => p.IncidentPropertyInvolvementSecuredLocationNavigations)
                .HasForeignKey(d => d.SecuredLocation)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID51");

            entity.HasOne(d => d.StolenRecoveredWhereNavigation).WithMany(p => p.IncidentPropertyInvolvementStolenRecoveredWhereNavigations)
                .HasForeignKey(d => d.StolenRecoveredWhere)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID73");
        });

        modelBuilder.Entity<IncidentRelatedAttachment>(entity =>
        {
            entity.HasKey(e => e.IncidentRelatedAttachmentId).HasName("PK_INCIDENTRELATEDATTACHMENTS");

            entity.HasIndex(e => e.IncidentId, "IX_IncidentRelatedAttachments_IncidentID");

            entity.HasIndex(e => e.IncidentPersonInvolvementId, "IX_IncidentRelatedAttachments_IncidentPersonInvolvementID");

            entity.HasIndex(e => e.IncidentPropertyInvolvementId, "IX_IncidentRelatedAttachments_Incident_PropertyInvolvementID");

            entity.HasIndex(e => e.IncidentVehicleInvolvementId, "IX_IncidentRelatedAttachments_Incident_VehicleInvolvementID");

            entity.Property(e => e.IncidentRelatedAttachmentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentRelatedAttachmentID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AttachmentContent).HasColumnType("image");
            entity.Property(e => e.AttachmentType).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.IncidentPropertyInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Incident_PropertyInvolvementID");
            entity.Property(e => e.IncidentVehicleInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Incident_VehicleInvolvementID");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentRelatedAttachments)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT13");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.IncidentRelatedAttachments)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT23");

            entity.HasOne(d => d.IncidentPropertyInvolvement).WithMany(p => p.IncidentRelatedAttachments)
                .HasForeignKey(d => d.IncidentPropertyInvolvementId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT26");

            entity.HasOne(d => d.IncidentVehicleInvolvement).WithMany(p => p.IncidentRelatedAttachments)
                .HasForeignKey(d => d.IncidentVehicleInvolvementId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT25");
        });

        modelBuilder.Entity<IncidentReportDistribution>(entity =>
        {
            entity.HasKey(e => e.IncidentReportDistributionId).HasName("PK_INCIDENTREPORTDISTRIBUTION");

            entity.ToTable("IncidentReportDistribution");

            entity.HasIndex(e => e.DistributedBy, "IX_IncidentReportDistribution_DistributedBy");

            entity.HasIndex(e => e.DistributedToDepartmentEmployeeId, "IX_IncidentReportDistribution_DistributedToDepartmentEmployeeID");

            entity.HasIndex(e => e.DistributedToDepartmentOrgId, "IX_IncidentReportDistribution_DistributedToDepartmentOrgID");

            entity.HasIndex(e => e.IncidentId, "IX_IncidentReportDistribution_IncidentID");

            entity.Property(e => e.IncidentReportDistributionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentReportDistributionID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DistributedToDepartmentEmployeeId).HasColumnName("DistributedToDepartmentEmployeeID");
            entity.Property(e => e.DistributedToDepartmentOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DistributedToDepartmentOrgID");
            entity.Property(e => e.DistributionDt)
                .HasColumnType("datetime")
                .HasColumnName("DistributionDT");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");

            entity.HasOne(d => d.DistributedByNavigation).WithMany(p => p.IncidentReportDistributionDistributedByNavigations)
                .HasForeignKey(d => d.DistributedBy)
                .HasConstraintName("FK_INCIDENT_REFERENCE_DEPARTME15");

            entity.HasOne(d => d.DistributedToDepartmentEmployee).WithMany(p => p.IncidentReportDistributionDistributedToDepartmentEmployees)
                .HasForeignKey(d => d.DistributedToDepartmentEmployeeId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_DEPARTME10");

            entity.HasOne(d => d.DistributedToDepartmentOrg).WithMany(p => p.IncidentReportDistributions)
                .HasForeignKey(d => d.DistributedToDepartmentOrgId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_DEPARTME9");

            entity.HasOne(d => d.DistributionTypeCodeNavigation).WithMany(p => p.IncidentReportDistributions)
                .HasForeignKey(d => d.DistributionTypeCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID48");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentReportDistributions)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT15");
        });

        modelBuilder.Entity<IncidentReportTypeDetail>(entity =>
        {
            entity.HasKey(e => e.IncidentReportTypeDetailId).HasName("PK_INCIDENTREPORTTYPEDETAIL");

            entity.ToTable("IncidentReportTypeDetail");

            entity.HasIndex(e => e.IncidentId, "IX_IncidentReportTypeDetail_IncidentID");

            entity.HasIndex(e => e.OfficerUsingForceId, "IX_IncidentReportTypeDetail_OfficerUsingForceID");

            entity.Property(e => e.IncidentReportTypeDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentReportTypeDetailID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AdditionalReasons).HasMaxLength(200);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ForceApplicationResult).HasColumnType("xml");
            entity.Property(e => e.HeartConditions).HasMaxLength(200);
            entity.Property(e => e.Hosptial).HasMaxLength(200);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IsCurrentIrrecord).HasColumnName("IsCurrentIRRecord");
            entity.Property(e => e.IsVictimPef).HasColumnName("IsVictimPEF");
            entity.Property(e => e.LocationOfIntendedProperty).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MethodofPenetrationCode).HasColumnType("xml");
            entity.Property(e => e.OfficerUsingForceId).HasColumnName("OfficerUsingForceID");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.RespiratoryProblems).HasMaxLength(200);
            entity.Property(e => e.TreatingPhysician).HasMaxLength(200);
            entity.Property(e => e.Value).HasMaxLength(100);
            entity.Property(e => e.WeaponMethodCode).HasColumnType("xml");

            entity.HasOne(d => d.ActualAttemptedCodeNavigation).WithMany(p => p.IncidentReportTypeDetailActualAttemptedCodeNavigations)
                .HasForeignKey(d => d.ActualAttemptedCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID12");

            entity.HasOne(d => d.DayNightCodeNavigation).WithMany(p => p.IncidentReportTypeDetailDayNightCodeNavigations)
                .HasForeignKey(d => d.DayNightCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID35");

            entity.HasOne(d => d.FireTypeCodeNavigation).WithMany(p => p.IncidentReportTypeDetailFireTypeCodeNavigations)
                .HasForeignKey(d => d.FireTypeCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID3");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentReportTypeDetails)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENT18");

            entity.HasOne(d => d.LocationOfIntendedPropertyNavigation).WithMany(p => p.IncidentReportTypeDetails)
                .HasForeignKey(d => d.LocationOfIntendedProperty)
                .HasConstraintName("FK_INCIDENT_REFERENCE_MSTRLOCA7");

            entity.HasOne(d => d.LocationTypeCodeNavigation).WithMany(p => p.IncidentReportTypeDetailLocationTypeCodeNavigations)
                .HasForeignKey(d => d.LocationTypeCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID13");

            entity.HasOne(d => d.MostSeriousIncidentInjuryCodeNavigation).WithMany(p => p.IncidentReportTypeDetailMostSeriousIncidentInjuryCodeNavigations)
                .HasForeignKey(d => d.MostSeriousIncidentInjuryCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID2");

            entity.HasOne(d => d.ObjectofTheftCodeNavigation).WithMany(p => p.IncidentReportTypeDetailObjectofTheftCodeNavigations)
                .HasForeignKey(d => d.ObjectofTheftCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID25");

            entity.HasOne(d => d.OfficerUsingForce).WithMany(p => p.IncidentReportTypeDetails)
                .HasForeignKey(d => d.OfficerUsingForceId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_DEPARTME8");

            entity.HasOne(d => d.PenetrationCodeNavigation).WithMany(p => p.IncidentReportTypeDetailPenetrationCodeNavigations)
                .HasForeignKey(d => d.PenetrationCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID45");

            entity.HasOne(d => d.PerpetratorSexCodeNavigation).WithMany(p => p.IncidentReportTypeDetailPerpetratorSexCodeNavigations)
                .HasForeignKey(d => d.PerpetratorSexCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFMSTRI3");

            entity.HasOne(d => d.TypeofForgeryCodeNavigation).WithMany(p => p.IncidentReportTypeDetailTypeofForgeryCodeNavigations)
                .HasForeignKey(d => d.TypeofForgeryCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID41");

            entity.HasOne(d => d.TypeofIdentityTheftCodeNavigation).WithMany(p => p.IncidentReportTypeDetailTypeofIdentityTheftCodeNavigations)
                .HasForeignKey(d => d.TypeofIdentityTheftCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID40");

            entity.HasOne(d => d.TypeofLarcenyCodeNavigation).WithMany(p => p.IncidentReportTypeDetailTypeofLarcenyCodeNavigations)
                .HasForeignKey(d => d.TypeofLarcenyCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID39");

            entity.HasOne(d => d.TypeofRobberyCodeNavigation).WithMany(p => p.IncidentReportTypeDetailTypeofRobberyCodeNavigations)
                .HasForeignKey(d => d.TypeofRobberyCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID38");

            entity.HasOne(d => d.ValueRangeCodeNavigation).WithMany(p => p.IncidentReportTypeDetailValueRangeCodeNavigations)
                .HasForeignKey(d => d.ValueRangeCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID42");

            entity.HasOne(d => d.VictimSexCodeNavigation).WithMany(p => p.IncidentReportTypeDetailVictimSexCodeNavigations)
                .HasForeignKey(d => d.VictimSexCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFMSTRI");
        });

        modelBuilder.Entity<IncidentUseOfForce>(entity =>
        {
            entity.HasKey(e => e.IncidentUseOfForceId).HasName("PK_INCIDENTUSEOFFORCE");

            entity.ToTable("IncidentUseOfForce");

            entity.HasIndex(e => e.IncidentId, "IX_IncidentUseOfForce_IncidentID");

            entity.HasIndex(e => e.IncidentPersonInvolvementId, "IX_IncidentUseOfForce_IncidentPersonInvolvementID");

            entity.HasIndex(e => e.SupervisorEmployeeId, "IX_IncidentUseOfForce_SupervisorEmployeeID");

            entity.Property(e => e.IncidentUseOfForceId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentUseOfForceID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.CommercialEstablishmentDesc).HasMaxLength(100);
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.EducationalFacilityDesc).HasMaxLength(100);
            entity.Property(e => e.EmployeeWitnessesIdlst)
                .HasColumnType("xml")
                .HasColumnName("EmployeeWitnessesIDLst");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.IndoorsPrivatePropertyDesc).HasMaxLength(100);
            entity.Property(e => e.IndoorsPublicBuildingDesc).HasMaxLength(100);
            entity.Property(e => e.NotifiedTime).HasColumnType("datetime");
            entity.Property(e => e.PoliceForceLocationCode).HasColumnType("xml");
            entity.Property(e => e.SubjectArmedAssaultDesc).HasMaxLength(100);
            entity.Property(e => e.SubjectOtherResistenceDesc).HasMaxLength(100);
            entity.Property(e => e.SubjectResistanceCode).HasColumnType("xml");
            entity.Property(e => e.SupervisorEmployeeId).HasColumnName("SupervisorEmployeeID");
            entity.Property(e => e.WitnessesIdlst)
                .HasColumnType("xml")
                .HasColumnName("WitnessesIDLst");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentUseOfForces)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_INCIDENTUSEOFFORCE_REFERENCE_INCIDENT");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.IncidentUseOfForces)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_INCIDENTUSEOFFORCE_REFERENCE_INCIDENTPERSONIVOLVEMENT");

            entity.HasOne(d => d.SupervisorEmployee).WithMany(p => p.IncidentUseOfForces)
                .HasForeignKey(d => d.SupervisorEmployeeId)
                .HasConstraintName("FK_INCIDENTUSEOFFORCE_REFERENCE_DEPARTMENTEMPLOYEE");

            entity.HasOne(d => d.SupervisorReviewClassificationCodeNavigation).WithMany(p => p.IncidentUseOfForces)
                .HasForeignKey(d => d.SupervisorReviewClassificationCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID15");
        });

        modelBuilder.Entity<IncidentUseOfForceEquipment>(entity =>
        {
            entity.HasKey(e => e.IncidentUseOfForceEquipmentId).HasName("PK_INCIDENTUSEOFFORCE_EQUIPMEN");

            entity.ToTable("IncidentUseOfForce_Equipment");

            entity.HasIndex(e => e.IncidentUseOfForceId, "IX_IncidentUseOfForce_Equipment_IncidentUseOfForceID");

            entity.Property(e => e.IncidentUseOfForceEquipmentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentUseOfForce_EquipmentID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ChemicalMunitionsFired).HasMaxLength(200);
            entity.Property(e => e.ChemicalMunitionsHit).HasMaxLength(200);
            entity.Property(e => e.ChemicalMunitionsNa).HasColumnName("ChemicalMunitionsNA");
            entity.Property(e => e.ChemicalMunitionsType).HasMaxLength(200);
            entity.Property(e => e.DischargeFirearmNa).HasColumnName("DischargeFirearmNA");
            entity.Property(e => e.DischargeFirearmResult).HasColumnType("xml");
            entity.Property(e => e.DischargeFirearmSubject).HasColumnType("xml");
            entity.Property(e => e.DischargeFirearmWeapon).HasColumnType("xml");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.EdwcartridgesDeployedSerialNum)
                .HasMaxLength(200)
                .HasColumnName("EDWCartridgesDeployedSerialNum");
            entity.Property(e => e.EdwcartridgesMissedImpactLoc)
                .HasMaxLength(200)
                .HasColumnName("EDWCartridgesMissedImpactLoc");
            entity.Property(e => e.EdwcontactPoints)
                .HasColumnType("xml")
                .HasColumnName("EDWContactPoints");
            entity.Property(e => e.EdwdeadlyForceJustified).HasColumnName("EDWDeadlyForceJustified");
            entity.Property(e => e.EdwdeployedSerialNum)
                .HasMaxLength(200)
                .HasColumnName("EDWDeployedSerialNum");
            entity.Property(e => e.EdwdeploymentType)
                .HasColumnType("xml")
                .HasColumnName("EDWDeploymentType");
            entity.Property(e => e.EdwdownloadedBy)
                .HasMaxLength(200)
                .HasColumnName("EDWDownloadedBy");
            entity.Property(e => e.EdwlengthDactivationsAfterProbe)
                .HasMaxLength(200)
                .HasColumnName("EDWLengthDActivationsAfterProbe");
            entity.Property(e => e.EdwlengthDisplayOrArcs)
                .HasMaxLength(200)
                .HasColumnName("EDWLengthDisplayOrArcs");
            entity.Property(e => e.EdwlengthDriveStun)
                .HasMaxLength(200)
                .HasColumnName("EDWLengthDriveStun");
            entity.Property(e => e.Edwna).HasColumnName("EDWNA");
            entity.Property(e => e.EdwtimeElapsedBetween)
                .HasMaxLength(200)
                .HasColumnName("EDWTimeElapsedBetween");
            entity.Property(e => e.EdwtypeCartridge)
                .HasMaxLength(200)
                .HasColumnName("EDWTypeCartridge");
            entity.Property(e => e.EdwtypeofForceAfter)
                .HasMaxLength(200)
                .HasColumnName("EDWTypeofForceAfter");
            entity.Property(e => e.EdwtypeofForcePrior)
                .HasMaxLength(200)
                .HasColumnName("EDWTypeofForcePrior");
            entity.Property(e => e.EquipmentContactPoints).HasColumnType("xml");
            entity.Property(e => e.ImpactMunitionsFired).HasMaxLength(200);
            entity.Property(e => e.ImpactMunitionsHit).HasMaxLength(200);
            entity.Property(e => e.ImpactMunitionsNa).HasColumnName("ImpactMunitionsNA");
            entity.Property(e => e.ImpactMunitionsType).HasMaxLength(200);
            entity.Property(e => e.ImpactWeaponNa).HasColumnName("ImpactWeaponNA");
            entity.Property(e => e.ImpactWeaponNumOfStrikes).HasMaxLength(200);
            entity.Property(e => e.ImpactWeaponType).HasMaxLength(200);
            entity.Property(e => e.IncidentUseOfForceId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentUseOfForceID");
            entity.Property(e => e.OcsprayDecont).HasColumnName("OCSprayDecont");
            entity.Property(e => e.OcsprayEffective).HasColumnName("OCSprayEffective");
            entity.Property(e => e.OcsprayMedTreatment).HasColumnName("OCSprayMedTreatment");
            entity.Property(e => e.OcsprayNa).HasColumnName("OCSprayNA");
            entity.Property(e => e.OcsprayNumApplications)
                .HasMaxLength(200)
                .HasColumnName("OCSprayNumApplications");

            entity.HasOne(d => d.IncidentUseOfForce).WithMany(p => p.IncidentUseOfForceEquipments)
                .HasForeignKey(d => d.IncidentUseOfForceId)
                .HasConstraintName("FK_IncidentUseOfForce_Equipment_IncidentUseOfForce");
        });

        modelBuilder.Entity<IncidentUseOfForceInjuryDetail>(entity =>
        {
            entity.HasKey(e => e.IncidentUseOfForceInjuryDetailId).HasName("PK_INCIDENTUSEOFFORCE_INJURYDE");

            entity.ToTable("IncidentUseOfForce_InjuryDetail");

            entity.HasIndex(e => e.IncidentUseOfForceId, "IX_IncidentUseOfForce_InjuryDetail_IncidentUseOfForceID");

            entity.Property(e => e.IncidentUseOfForceInjuryDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentUseOfForce_InjuryDetailID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.IncidentUseOfForceId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentUseOfForceID");
            entity.Property(e => e.OfficerHospital).HasMaxLength(200);
            entity.Property(e => e.OfficerType).HasColumnType("xml");
            entity.Property(e => e.OfficerTypeOtherDesc).HasMaxLength(200);
            entity.Property(e => e.SubjectHospital).HasMaxLength(200);
            entity.Property(e => e.SubjectType).HasColumnType("xml");
            entity.Property(e => e.SubjectTypeOtherDesc).HasMaxLength(200);

            entity.HasOne(d => d.IncidentUseOfForce).WithMany(p => p.IncidentUseOfForceInjuryDetails)
                .HasForeignKey(d => d.IncidentUseOfForceId)
                .HasConstraintName("FK_IncidentUseOfForce_InjuryDetail_IncidentUseOfForce");

            entity.HasOne(d => d.OfficerCheckedByMedicalCodeNavigation).WithMany(p => p.IncidentUseOfForceInjuryDetailOfficerCheckedByMedicalCodeNavigations)
                .HasForeignKey(d => d.OfficerCheckedByMedicalCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID17");

            entity.HasOne(d => d.SubjectCheckedByMedicalCodeNavigation).WithMany(p => p.IncidentUseOfForceInjuryDetailSubjectCheckedByMedicalCodeNavigations)
                .HasForeignKey(d => d.SubjectCheckedByMedicalCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID18");
        });

        modelBuilder.Entity<IncidentUseOfForceOfficerDetail>(entity =>
        {
            entity.HasKey(e => e.IncidentUseOfForceOfficerDetailId).HasName("PK_INCIDENTUSEOFFORCE_OFFICERD");

            entity.ToTable("IncidentUseOfForce_OfficerDetail");

            entity.HasIndex(e => e.IncidentUseOfForceId, "IX_IncidentUseOfForce_OfficerDetail_IncidentUseOfForceID");

            entity.HasIndex(e => e.InvolvedEmployee1, "IX_IncidentUseOfForce_OfficerDetail_InvolvedEmployee1");

            entity.HasIndex(e => e.InvolvedEmployee2, "IX_IncidentUseOfForce_OfficerDetail_InvolvedEmployee2");

            entity.HasIndex(e => e.InvolvedEmployee3, "IX_IncidentUseOfForce_OfficerDetail_InvolvedEmployee3");

            entity.Property(e => e.IncidentUseOfForceOfficerDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentUseOfForce_OfficerDetailID");
            entity.Property(e => e.ActionsLeadToIncident).HasColumnType("xml");
            entity.Property(e => e.ActionsLeadToIncidentOtherDesc).HasMaxLength(100);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ArrivalMethodOtherDesc).HasMaxLength(100);
            entity.Property(e => e.ArrivalMethods).HasColumnType("xml");
            entity.Property(e => e.CanineHandlerEmployeeId).HasColumnName("CanineHandlerEmployeeID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.IncidentUseOfForceId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentUseOfForceID");
            entity.Property(e => e.InitialPerception).HasColumnType("xml");
            entity.Property(e => e.InitialPerceptionArmedDesc)
                .HasMaxLength(100)
                .HasColumnName("InitialPerception_ArmedDesc");
            entity.Property(e => e.InitialPerceptionOtherDesc)
                .HasMaxLength(100)
                .HasColumnName("InitialPerception_OtherDesc");
            entity.Property(e => e.InvolvedEmployee1ControlMethods).HasColumnType("xml");
            entity.Property(e => e.InvolvedEmployee1ControlMethodsOtherDesc).HasMaxLength(100);
            entity.Property(e => e.InvolvedEmployee2ControlMethods).HasColumnType("xml");
            entity.Property(e => e.InvolvedEmployee2ControlMethodsOtherDesc).HasMaxLength(100);
            entity.Property(e => e.InvolvedEmployee3ControlMethods).HasColumnType("xml");
            entity.Property(e => e.InvolvedEmployee3ControlMethodsOtherDesc).HasMaxLength(100);

            entity.HasOne(d => d.CanineHandlerEmployee).WithMany(p => p.IncidentUseOfForceOfficerDetailCanineHandlerEmployees)
                .HasForeignKey(d => d.CanineHandlerEmployeeId)
                .HasConstraintName("FK_IncidentUseOfForce_OfficerDetail_DepartmentEmployees");

            entity.HasOne(d => d.IncidentUseOfForce).WithMany(p => p.IncidentUseOfForceOfficerDetails)
                .HasForeignKey(d => d.IncidentUseOfForceId)
                .HasConstraintName("FK_IncidentUseOfForce_OfficerDetail_IncidentUseOfForce");

            entity.HasOne(d => d.InvolvedEmployee1Navigation).WithMany(p => p.IncidentUseOfForceOfficerDetailInvolvedEmployee1Navigations)
                .HasForeignKey(d => d.InvolvedEmployee1)
                .HasConstraintName("FK_IncidentUseOfForce_OfficerDetail_DepartmentEmployees1");

            entity.HasOne(d => d.InvolvedEmployee2Navigation).WithMany(p => p.IncidentUseOfForceOfficerDetailInvolvedEmployee2Navigations)
                .HasForeignKey(d => d.InvolvedEmployee2)
                .HasConstraintName("FK_IncidentUseOfForce_OfficerDetail_DepartmentEmployees2");

            entity.HasOne(d => d.InvolvedEmployee3Navigation).WithMany(p => p.IncidentUseOfForceOfficerDetailInvolvedEmployee3Navigations)
                .HasForeignKey(d => d.InvolvedEmployee3)
                .HasConstraintName("FK_IncidentUseOfForce_OfficerDetail_DepartmentEmployees3");
        });

        modelBuilder.Entity<IncidentVehicleInvolvement>(entity =>
        {
            entity.HasKey(e => e.IncidentVehicleInvolvementId).HasName("PK_INCIDENT_VEHICLEINVOLVEMENT2");

            entity.ToTable("Incident_VehicleInvolvement");

            entity.HasIndex(e => e.IncidentId, "IX_Incident_VehicleInvolvement_IncidentID");

            entity.HasIndex(e => e.InvolvementLocationId, "IX_Incident_VehicleInvolvement_InvolvementLocationID");

            entity.HasIndex(e => e.LocationOfEvidence, "IX_Incident_VehicleInvolvement_LocationOfEvidence");

            entity.HasIndex(e => e.Mvid, "IX_Incident_VehicleInvolvement_MVID");

            entity.HasIndex(e => e.NibrslossType, "IX_Incident_VehicleInvolvement_NIBRSLossType");

            entity.HasIndex(e => e.NonVerifiedVehicleId, "IX_Incident_VehicleInvolvement_NonVerifiedVehicleID");

            entity.HasIndex(e => e.OwnerNotifiedBy, "IX_Incident_VehicleInvolvement_OwnerNotifiedBy");

            entity.HasIndex(e => e.PersonClaimingVehicle, "IX_Incident_VehicleInvolvement_PersonClaimingVehicle");

            entity.HasIndex(e => e.RecoveredFromPersonId, "IX_Incident_VehicleInvolvement_RecoveredFromPersonID");

            entity.HasIndex(e => e.StolenRecoveredWhere, "IX_Incident_VehicleInvolvement_StolenRecoveredWhere");

            entity.HasIndex(e => e.TowRequestId, "IX_Incident_VehicleInvolvement_TowRequestID");

            entity.HasIndex(e => e.TypeofStolenVehicle, "IX_Incident_VehicleInvolvement_TypeofStolenVehicle");

            entity.Property(e => e.IncidentVehicleInvolvementId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Incident_VehicleInvolvementID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CollectCancellationNum).HasMaxLength(20);
            entity.Property(e => e.CollectLocateMsgnum)
                .HasMaxLength(20)
                .HasColumnName("CollectLocateMSGNum");
            entity.Property(e => e.CollectNumber).HasMaxLength(100);
            entity.Property(e => e.DamagedValue).HasColumnType("money");
            entity.Property(e => e.DateNciccancelled)
                .HasColumnType("datetime")
                .HasColumnName("DateNCICCancelled");
            entity.Property(e => e.DateNcicentered)
                .HasColumnType("datetime")
                .HasColumnName("DateNCICEntered");
            entity.Property(e => e.DateOwnerNotified).HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EstimatedVehicleValue).HasColumnType("money");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.InsuranceCompanyName).HasMaxLength(100);
            entity.Property(e => e.InvolvementDateTime).HasColumnType("datetime");
            entity.Property(e => e.InvolvementDateTo).HasColumnType("datetime");
            entity.Property(e => e.InvolvementLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("InvolvementLocationID");
            entity.Property(e => e.IsAddedByQa).HasColumnName("IsAddedByQA");
            entity.Property(e => e.IsConfidential).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsJdc18required).HasColumnName("IsJDC18Required");
            entity.Property(e => e.Mvid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MVID");
            entity.Property(e => e.Nciccancelled).HasColumnName("NCICCancelled");
            entity.Property(e => e.NciccancelledOperator)
                .HasMaxLength(100)
                .HasColumnName("NCICCancelledOperator");
            entity.Property(e => e.NcicenteredOperator)
                .HasMaxLength(100)
                .HasColumnName("NCICEnteredOperator");
            entity.Property(e => e.Ncicnumber)
                .HasMaxLength(100)
                .HasColumnName("NCICNumber");
            entity.Property(e => e.NibrslossType).HasColumnName("NIBRSLossType");
            entity.Property(e => e.NonVerifiedVehicleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NonVerifiedVehicleID");
            entity.Property(e => e.OutofTownCaseNumber).HasMaxLength(20);
            entity.Property(e => e.PersonClaimingVehicle).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.RecoveredFromPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RecoveredFromPersonID");
            entity.Property(e => e.RecoveredataPawnShop).HasMaxLength(100);
            entity.Property(e => e.RecoveryOfficer).HasMaxLength(100);
            entity.Property(e => e.Source).HasMaxLength(100);
            entity.Property(e => e.TowRequestId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TowRequestID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.AutoTheftCodeNavigation).WithMany(p => p.IncidentVehicleInvolvementAutoTheftCodeNavigations)
                .HasForeignKey(d => d.AutoTheftCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID20");

            entity.HasOne(d => d.Incident).WithMany(p => p.IncidentVehicleInvolvements)
                .HasForeignKey(d => d.IncidentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INCIDENT_REFERENCE_INCIDENTb");

            entity.HasOne(d => d.InvolvementLocation).WithMany(p => p.IncidentVehicleInvolvements)
                .HasForeignKey(d => d.InvolvementLocationId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_MSTRLOCA3");

            entity.HasOne(d => d.LocationOfEvidenceNavigation).WithMany(p => p.IncidentVehicleInvolvementLocationOfEvidenceNavigations)
                .HasForeignKey(d => d.LocationOfEvidence)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID67");

            entity.HasOne(d => d.Mv).WithMany(p => p.IncidentVehicleInvolvements)
                .HasForeignKey(d => d.Mvid)
                .HasConstraintName("FK_INCIDENT_REFERENCE_MSTRVEHI");

            entity.HasOne(d => d.NibrslossTypeNavigation).WithMany(p => p.IncidentVehicleInvolvements).HasForeignKey(d => d.NibrslossType);

            entity.HasOne(d => d.NonVerifiedVehicle).WithMany(p => p.IncidentVehicleInvolvements)
                .HasForeignKey(d => d.NonVerifiedVehicleId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_NONVERIF2");

            entity.HasOne(d => d.OwnerNotifiedByNavigation).WithMany(p => p.IncidentVehicleInvolvements)
                .HasForeignKey(d => d.OwnerNotifiedBy)
                .HasConstraintName("FK_INCIDENT_REFERENCE_DEPARTME14");

            entity.HasOne(d => d.PersonClaimingVehicleNavigation).WithMany(p => p.IncidentVehicleInvolvementPersonClaimingVehicleNavigations)
                .HasForeignKey(d => d.PersonClaimingVehicle)
                .HasConstraintName("FK_INCIDENT_REFERENCE_MSTRPERS4");

            entity.HasOne(d => d.ReasonNotTowedCodeNavigation).WithMany(p => p.IncidentVehicleInvolvementReasonNotTowedCodeNavigations)
                .HasForeignKey(d => d.ReasonNotTowedCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID43");

            entity.HasOne(d => d.RecoveredFromPerson).WithMany(p => p.IncidentVehicleInvolvementRecoveredFromPeople)
                .HasForeignKey(d => d.RecoveredFromPersonId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_MSTRPERS6");

            entity.HasOne(d => d.StolenRecoveredWhereNavigation).WithMany(p => p.IncidentVehicleInvolvementStolenRecoveredWhereNavigations)
                .HasForeignKey(d => d.StolenRecoveredWhere)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID72");

            entity.HasOne(d => d.TowRequest).WithMany(p => p.IncidentVehicleInvolvements)
                .HasForeignKey(d => d.TowRequestId)
                .HasConstraintName("FK_INCIDENT_REFERENCE_TOWREQUE");

            entity.HasOne(d => d.TypeofStolenVehicleNavigation).WithMany(p => p.IncidentVehicleInvolvementTypeofStolenVehicleNavigations)
                .HasForeignKey(d => d.TypeofStolenVehicle)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID11");

            entity.HasOne(d => d.VehicleInvolvementCodeNavigation).WithMany(p => p.IncidentVehicleInvolvementVehicleInvolvementCodeNavigations)
                .HasForeignKey(d => d.VehicleInvolvementCode)
                .HasConstraintName("FK_INCIDENT_REFERENCE_REFINCID8");
        });

        modelBuilder.Entity<IndividualSecurityToUser>(entity =>
        {
            entity.HasKey(e => e.IndividualSecurityToUserId).HasName("PK_INDIVIDUALSECURITYTOUSERS");

            entity.HasIndex(e => e.AllowedEmployeeId, "IX_IndividualSecurityToUsers_AllowedEmployeeID");

            entity.HasIndex(e => e.CrashPersonInvolvementId, "IX_IndividualSecurityToUsers_Crash_PersonInvolvementID");

            entity.HasIndex(e => e.GrantedByEmployeeId, "IX_IndividualSecurityToUsers_GrantedByEmployeeID");

            entity.HasIndex(e => e.IncidentPersonInvolvementId, "IX_IndividualSecurityToUsers_IncidentPersonInvolvementID");

            entity.HasIndex(e => new { e.SysrmsapplicationTypeId, e.ApplicationTypePk }, "IX_IndividualSecurityToUsers_SYSRMSApplicationTypeID_ApplicationTypePK");

            entity.HasIndex(e => e.SecurityRoleId, "IX_IndividualSecurityToUsers_SecurityRoleID");

            entity.HasIndex(e => new { e.DepartmentOrgId, e.AllowedEmployeeId }, "IndividualSecurityToUsers_DepartmentOrgID_AllowedEmployeeID");

            entity.Property(e => e.IndividualSecurityToUserId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IndividualSecurityToUserID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AllowedEmployeeId).HasColumnName("AllowedEmployeeID");
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.CrashPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_PersonInvolvementID");
            entity.Property(e => e.DepartmentOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentOrgID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GrantedByEmployeeId).HasColumnName("GrantedByEmployeeID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.SecurityRoleId).HasColumnName("SecurityRoleID");
            entity.Property(e => e.SysrmsapplicationTypeId).HasColumnName("SYSRMSApplicationTypeID");

            entity.HasOne(d => d.AllowedEmployee).WithMany(p => p.IndividualSecurityToUserAllowedEmployees)
                .HasForeignKey(d => d.AllowedEmployeeId)
                .HasConstraintName("FK_INDIVIDU_REFERENCE_DEPARTME");

            entity.HasOne(d => d.CrashPersonInvolvement).WithMany(p => p.IndividualSecurityToUsers)
                .HasForeignKey(d => d.CrashPersonInvolvementId)
                .HasConstraintName("FK_INDIVIDU_REFERENCE_CRASH_PE");

            entity.HasOne(d => d.DepartmentOrg).WithMany(p => p.IndividualSecurityToUsers)
                .HasForeignKey(d => d.DepartmentOrgId)
                .HasConstraintName("FK_INDIVIDU_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.GrantedByEmployee).WithMany(p => p.IndividualSecurityToUserGrantedByEmployees)
                .HasForeignKey(d => d.GrantedByEmployeeId)
                .HasConstraintName("FK_INDIVIDU_REFERENCE_DEPARTME3");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.IndividualSecurityToUsers)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_INDIVIDU_REFERENCE_INCIDENT");

            entity.HasOne(d => d.SecurityRole).WithMany(p => p.IndividualSecurityToUsers)
                .HasForeignKey(d => d.SecurityRoleId)
                .HasConstraintName("FK_INDIVIDU_REFERENCE_SECURITY");

            entity.HasOne(d => d.SysrmsapplicationType).WithMany(p => p.IndividualSecurityToUsers)
                .HasForeignKey(d => d.SysrmsapplicationTypeId)
                .HasConstraintName("FK_INDIVIDU_REFERENCE_SYSRMSAP");
        });

        modelBuilder.Entity<IrcodeGenerator>(entity =>
        {
            entity.HasKey(e => e.IrcodeGeneratorId).HasName("PK_IRCODEGENERATOR");

            entity.ToTable("IRCodeGenerator");

            entity.Property(e => e.IrcodeGeneratorId).HasColumnName("IRCodeGeneratorID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<IrcodeGeneratorRule>(entity =>
        {
            entity.HasKey(e => e.IrcodeGeneratorRuleId).HasName("PK_IRCODEGENERATORRULE");

            entity.ToTable("IRCodeGeneratorRule");

            entity.HasIndex(e => e.GeneratedNibrscodeId, "IX_IRCodeGeneratorRule_GeneratedNIBRSCodeID");

            entity.HasIndex(e => e.GeneratedUcrcodeId, "IX_IRCodeGeneratorRule_GeneratedUCRCodeID");

            entity.HasIndex(e => e.IrcodeGeneratorId, "IX_IRCodeGeneratorRule_IRCodeGeneratorID");

            entity.Property(e => e.IrcodeGeneratorRuleId).HasColumnName("IRCodeGeneratorRuleID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GeneratedNibrscodeId).HasColumnName("GeneratedNIBRSCodeID");
            entity.Property(e => e.GeneratedUcrcodeId).HasColumnName("GeneratedUCRCodeID");
            entity.Property(e => e.IrcodeGeneratorId).HasColumnName("IRCodeGeneratorID");
            entity.Property(e => e.RuleName).HasMaxLength(100);
            entity.Property(e => e.RuleSeq).HasColumnName("RuleSEQ");

            entity.HasOne(d => d.GeneratedNibrscode).WithMany(p => p.IrcodeGeneratorRules)
                .HasForeignKey(d => d.GeneratedNibrscodeId)
                .HasConstraintName("FK_IRCODEGE_REFERENCE_REFNIBRS");

            entity.HasOne(d => d.GeneratedUcrcode).WithMany(p => p.IrcodeGeneratorRules)
                .HasForeignKey(d => d.GeneratedUcrcodeId)
                .HasConstraintName("FK_IRCODEGE_REFERENCE_REFUCRCO");

            entity.HasOne(d => d.IrcodeGenerator).WithMany(p => p.IrcodeGeneratorRules)
                .HasForeignKey(d => d.IrcodeGeneratorId)
                .HasConstraintName("FK_IRCODEGE_REFERENCE_IRCODEGE2");
        });

        modelBuilder.Entity<IrcodeGeneratorRuleCondition>(entity =>
        {
            entity.HasKey(e => e.IrcodeGeneratorRuleConditionId).HasName("PK_IRCODEGENERATORRULECONDITIO");

            entity.ToTable("IRCodeGeneratorRuleCondition");

            entity.HasIndex(e => e.IrcodeGeneratorRuleId, "IX_IRCodeGeneratorRuleCondition_IRCodeGeneratorRuleID");

            entity.Property(e => e.IrcodeGeneratorRuleConditionId).HasColumnName("IRCodeGeneratorRuleConditionID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CoditionSql).HasColumnName("CoditionSQL");
            entity.Property(e => e.ConditionName).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IrcodeGeneratorRuleId).HasColumnName("IRCodeGeneratorRuleID");

            entity.HasOne(d => d.IrcodeGeneratorRule).WithMany(p => p.IrcodeGeneratorRuleConditions)
                .HasForeignKey(d => d.IrcodeGeneratorRuleId)
                .HasConstraintName("FK_IRCODEGE_REFERENCE_IRCODEGE");
        });

        modelBuilder.Entity<JuvenileBookingDetail>(entity =>
        {
            entity.HasKey(e => e.JuvenileBookingId).HasName("PK_JUVENILEBOOKINGDETAIL");

            entity.ToTable("JuvenileBookingDetail");

            entity.Property(e => e.JuvenileBookingId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("JuvenileBookingID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CommServiceCompletedDt)
                .HasColumnType("datetime")
                .HasColumnName("CommServiceCompletedDT");
            entity.Property(e => e.CommServiceDesc).HasMaxLength(100);
            entity.Property(e => e.CounselingDesc).HasMaxLength(100);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ErasedDt)
                .HasColumnType("datetime")
                .HasColumnName("ErasedDT");
            entity.Property(e => e.IsLetterNfa).HasColumnName("IsLetterNFA");
            entity.Property(e => e.Jrbdate)
                .HasColumnType("datetime")
                .HasColumnName("JRBDate");
            entity.Property(e => e.JuvCourtDesc).HasMaxLength(100);
            entity.Property(e => e.OutofTownParticipatingJrb).HasColumnName("OutofTownParticipatingJRB");
            entity.Property(e => e.RestitutionCompletedDate).HasColumnType("datetime");
            entity.Property(e => e.School).HasMaxLength(100);
            entity.Property(e => e.SchoolGrade).HasMaxLength(20);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.YouthServiceCompletedDt)
                .HasColumnType("datetime")
                .HasColumnName("YouthServiceCompletedDT");
            entity.Property(e => e.YouthServiceDesc).HasMaxLength(100);

            entity.HasOne(d => d.Department).WithMany(p => p.JuvenileBookingDetails)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_JUVENILE_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<LnkaddressDirectoryToCategory>(entity =>
        {
            entity.HasKey(e => e.LnkaddressDirectoryToCategoryId).HasName("PK_LNKADDRESSDIRECTORYTOCATEGO");

            entity.ToTable("LNKAddressDirectoryToCategory");

            entity.HasIndex(e => e.AddressDirecctoryId, "IX_LNKAddressDirectoryToCategory_AddressDirecctoryID");

            entity.HasIndex(e => e.CategoryId, "IX_LNKAddressDirectoryToCategory_CategoryID");

            entity.Property(e => e.LnkaddressDirectoryToCategoryId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LNKAddressDirectoryToCategoryID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AddressDirecctoryId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AddressDirecctoryID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.AddressDirecctory).WithMany(p => p.LnkaddressDirectoryToCategories)
                .HasForeignKey(d => d.AddressDirecctoryId)
                .HasConstraintName("FK_LNKADDRE_REFERENCE_ADDRESSD");

            entity.HasOne(d => d.Category).WithMany(p => p.LnkaddressDirectoryToCategories)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_LNKADDRE_REFERENCE_REFDIREC");
        });

        modelBuilder.Entity<LnkdrugStatute>(entity =>
        {
            entity.HasKey(e => e.LnkdrugStatuteId).HasName("PK_LNKDRUGSTATUTE");

            entity.ToTable("LNKDrugStatute");

            entity.HasIndex(e => e.RefDrugDataId, "IX_LNKDrugStatute_RefDrugDataID");

            entity.Property(e => e.LnkdrugStatuteId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LNKDrugStatuteID");
            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PersonDrugDepOrNon).HasMaxLength(100);
            entity.Property(e => e.Quantity).HasMaxLength(50);
            entity.Property(e => e.RefDrugDataId).HasColumnName("RefDrugDataID");
            entity.Property(e => e.RefstatuteDefinition).HasColumnName("REFStatuteDefinition");

            entity.HasOne(d => d.RefDrugData).WithMany(p => p.LnkdrugStatutes)
                .HasForeignKey(d => d.RefDrugDataId)
                .HasConstraintName("FK_LNKDRUGS_REFERENCE_REFDRUGD");

            entity.HasOne(d => d.RefstatuteDefinitionNavigation).WithMany(p => p.LnkdrugStatutes)
                .HasForeignKey(d => d.RefstatuteDefinition)
                .HasConstraintName("FK_LNKDRUGS_REFERENCE_REFSTATU");
        });

        modelBuilder.Entity<LocationGisinformation>(entity =>
        {
            entity.HasKey(e => e.LocationGisinformationId).HasName("PK_LOCATIONGISINFORMATION");

            entity.ToTable("LocationGISInformation");

            entity.HasIndex(e => e.HitgislayerId, "IX_LocationGISInformation_HITGISLayerID");

            entity.HasIndex(e => e.HitgeometryId, "IX_LocationGISInformation_HITGeometryID");

            entity.HasIndex(e => e.LocationId, "IX_LocationGISInformation_LocationID");

            entity.Property(e => e.LocationGisinformationId).HasColumnName("LocationGISInformationID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HitgeometryId).HasColumnName("HITGeometryID");
            entity.Property(e => e.HitgeometryName)
                .HasMaxLength(50)
                .HasColumnName("HITGeometryName");
            entity.Property(e => e.HitgislayerId).HasColumnName("HITGISLayerID");
            entity.Property(e => e.HitgislayerName)
                .HasMaxLength(50)
                .HasColumnName("HITGISLayerName");
            entity.Property(e => e.LocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LocationID");

            entity.HasOne(d => d.Hitgeometry).WithMany(p => p.LocationGisinformations)
                .HasForeignKey(d => d.HitgeometryId)
                .HasConstraintName("FK_LOCATION_REFERENCE_DEPARTME");

            entity.HasOne(d => d.Hitgislayer).WithMany(p => p.LocationGisinformations)
                .HasForeignKey(d => d.HitgislayerId)
                .HasConstraintName("FK_LOCATION_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.Location).WithMany(p => p.LocationGisinformations)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_LOCATION_REFERENCE_MSTRLOCA");
        });

        modelBuilder.Entity<MergePersonApplicationWiseMasterHistory>(entity =>
        {
            entity.ToTable("MergePersonApplicationWise_Master_History");

            entity.Property(e => e.MergePersonApplicationWiseMasterHistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MergePersonApplicationWise_Master_HistoryID");
            entity.Property(e => e.CopiedProcessDateTime).HasColumnType("datetime");
            entity.Property(e => e.CopiedProcessUniqueId).HasColumnName("CopiedProcessUniqueID");
            entity.Property(e => e.Pkmpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PKMPID");
            entity.Property(e => e.Prmpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PRMPID");
        });

        modelBuilder.Entity<MergePersonApplicationWiseRecordsHistory>(entity =>
        {
            entity.ToTable("MergePersonApplicationWise_Records_History");

            entity.Property(e => e.MergePersonApplicationWiseRecordsHistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MergePersonApplicationWise_Records_HistoryID");
            entity.Property(e => e.CopiedStatus).HasColumnName("Copied_Status");
            entity.Property(e => e.MergePersonApplicationWiseMasterHistoryId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MergePersonApplicationWise_Master_HistoryID");
            entity.Property(e => e.TablePkid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TablePKID");
        });

        modelBuilder.Entity<MergedPersonsHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MergedPersonsHistory");

            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.MergedAtTime).HasColumnType("datetime");
            entity.Property(e => e.PrpersonMpid).HasColumnName("PRPersonMPID");
            entity.Property(e => e.RelatedPkpersonMpid).HasColumnName("RelatedPKPersonMPID");
        });

        modelBuilder.Entity<MissingPersonApplicationWiseRecordsHistory>(entity =>
        {
            entity.ToTable("MissingPersonApplicationWise_Records_History");

            entity.Property(e => e.MissingPersonApplicationWiseRecordsHistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MissingPersonApplicationWise_Records_HistoryID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.CopiedStatus).HasColumnName("Copied_Status");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.TablePkid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TablePKID");
        });

        modelBuilder.Entity<Mstrlocation>(entity =>
        {
            entity.HasKey(e => e.LocationId)
                .HasName("PK_MSTRLOCATION")
                .IsClustered(false);

            entity.ToTable("MSTRLocation");

            entity.HasIndex(e => e.AgencyId, "Index-3");

            entity.Property(e => e.LocationId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LocationID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.AliasName).HasMaxLength(300);
            entity.Property(e => e.Apartment).HasMaxLength(50);
            entity.Property(e => e.Building).HasMaxLength(50);
            entity.Property(e => e.CadimportDepartmentId).HasColumnName("CADImportDepartmentID");
            entity.Property(e => e.CadlocationId).HasColumnName("CADLocationID");
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.ClosestStreet).HasMaxLength(500);
            entity.Property(e => e.CopiedFromLocationId)
                .HasMaxLength(50)
                .HasColumnName("CopiedFromLocationID");
            entity.Property(e => e.CopiedFromSource).HasMaxLength(50);
            entity.Property(e => e.CopiedOn).HasColumnType("datetime");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.County).HasMaxLength(50);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Floor).HasMaxLength(10);
            entity.Property(e => e.GeoCoderInfo).HasMaxLength(50);
            entity.Property(e => e.HouseNumber).HasMaxLength(50);
            entity.Property(e => e.HouseNumberInt).HasColumnName("HouseNumberINT");
            entity.Property(e => e.KtpsAgencyId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("KTPS_AgencyID");
            entity.Property(e => e.Location).HasMaxLength(300);
            entity.Property(e => e.LocationCode).HasMaxLength(10);
            entity.Property(e => e.LocationDetailDisplayString).HasMaxLength(800);
            entity.Property(e => e.LocationShortDisplayString).HasMaxLength(300);
            entity.Property(e => e.LocationType).HasMaxLength(50);
            entity.Property(e => e.MstrlocationPointId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MSTRLocationPointID");
            entity.Property(e => e.MstrstreetSegmentId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MSTRStreetSegmentID");
            entity.Property(e => e.NewDetailDisplystring)
                .HasMaxLength(776)
                .HasComputedColumnSql("(rtrim(ltrim((((((((((case when [HouseNumber] IS NULL OR len([HouseNumber])=(0) then '' else [HouseNumber] end+case when [HouseNumber] IS NOT NULL AND len([HouseNumber])>(0) AND [Location] IS NOT NULL AND len([Location])>(0) then ' '+[Location] when [Location] IS NOT NULL AND len([Location])>(0) then [Location] else '' end)+case when [Apartment] IS NULL OR len([Apartment])=(0) then '' else ' APT:'+[Apartment] end)+case when [Suite] IS NULL OR len([Suite])=(0) then '' else ' SUITE:'+[Suite] end)+case when [Floor] IS NULL OR len([Floor])=(0) then '' else ' FLR:'+[Floor] end)+case when [Building] IS NULL OR len([Building])=(0) then '' else ' BLD:'+[Building] end)+case when [Unit] IS NULL OR len([Unit])=(0) then '' else ' Unit:'+[Unit] end)+case when [City] IS NULL OR len([City])=(0) then '' else ', '+[City] end)+case when [State] IS NULL OR len([State])=(0) then '' else ', '+[State] end)+case when [ZIP] IS NULL OR len([ZIP])=(0) then '' else ', '+[ZIP] end)+case when [Country] IS NULL OR len([Country])=(0) then '' else ' '+[Country] end)))", false);
            entity.Property(e => e.NewShortDetailDisplaystring)
                .HasMaxLength(351)
                .HasComputedColumnSql("(case when [HouseNumber] IS NULL OR len([HouseNumber])=(0) then '' else [HouseNumber] end+case when [HouseNumber] IS NOT NULL AND len([HouseNumber])>(0) AND [Location] IS NOT NULL AND len([Location])>(0) then ' '+[Location] when [Location] IS NOT NULL AND len([Location])>(0) then [Location] else '' end)", false);
            entity.Property(e => e.Pobox)
                .HasMaxLength(50)
                .HasColumnName("POBox");
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.StreetId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("StreetID");
            entity.Property(e => e.Suite).HasMaxLength(10);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.Unit).HasMaxLength(10);
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .HasColumnName("ZIP");

            entity.HasOne(d => d.Agency).WithMany(p => p.Mstrlocations)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_MSTRLOCA_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.CadimportDepartment).WithMany(p => p.Mstrlocations)
                .HasForeignKey(d => d.CadimportDepartmentId)
                .HasConstraintName("FK_MSTRLOCA_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<MstrlocationAlert>(entity =>
        {
            entity.HasKey(e => e.MstrlocationAlertId).HasName("PK_MSTRLOCATIONALERTS");

            entity.ToTable("MSTRLocationAlerts");

            entity.HasIndex(e => e.AlertTypeCode, "IX_MSTRLocationAlerts_AlertTypeCode");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "IX_MSTRLocationAlerts_ApplicationType_ApplicationTypePK");

            entity.HasIndex(e => e.LocationId, "IX_MSTRLocationAlerts_LocationID");

            entity.Property(e => e.MstrlocationAlertId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRLocationAlertID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpirationDate).HasColumnType("date");
            entity.Property(e => e.LocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LocationID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.AlertTypeCodeNavigation).WithMany(p => p.MstrlocationAlerts)
                .HasForeignKey(d => d.AlertTypeCode)
                .HasConstraintName("FK_MSTRLOCA_REFERENCE_REFMSTRI");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.MstrlocationAlerts)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_MSTRLOCA_REFERENCE_SYSRMSAP");

            entity.HasOne(d => d.Location).WithMany(p => p.MstrlocationAlerts)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_MSTRLOCA_REFERENCE_MSTRLOCA");
        });

        modelBuilder.Entity<MstrlocationImage>(entity =>
        {
            entity.HasKey(e => e.MstrlocationImageId).HasName("PK_MSTRLOCATIONIMAGES");

            entity.ToTable("MSTRLocationImages");

            entity.HasIndex(e => e.LocationId, "IX_MSTRLocationImages_LocationID");

            entity.HasIndex(e => new { e.SysrmsapplicationTypeId, e.ApplicationTypePk }, "IX_MSTRLocationImages_SYSRMSApplicationTypeID_ApplicationTypePK");

            entity.Property(e => e.MstrlocationImageId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRLocationImageID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ImageContent).HasColumnType("image");
            entity.Property(e => e.LocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LocationID");
            entity.Property(e => e.SysrmsapplicationTypeId).HasColumnName("SYSRMSApplicationTypeID");

            entity.HasOne(d => d.Location).WithMany(p => p.MstrlocationImages)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_MSTRLOCA_REFERENCE_MSTRLOCA3");

            entity.HasOne(d => d.SysrmsapplicationType).WithMany(p => p.MstrlocationImages)
                .HasForeignKey(d => d.SysrmsapplicationTypeId)
                .HasConstraintName("FK_MSTRLOCA_REFERENCE_SYSRMSAP2");
        });

        modelBuilder.Entity<MstrlocationRelatedMedium>(entity =>
        {
            entity.HasKey(e => e.MlrelatedMediaId).HasName("PK_MSTRLOCATIONRELATEDMEDIA");

            entity.ToTable("MSTRLocationRelatedMedia");

            entity.HasIndex(e => e.LocationId, "IX_MSTRLocationRelatedMedia_LocationID");

            entity.HasIndex(e => e.MmediaInfoId, "IX_MSTRLocationRelatedMedia_MMediaInfoID");

            entity.Property(e => e.MlrelatedMediaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MLRelatedMediaID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EntityCommentsXml)
                .HasColumnType("xml")
                .HasColumnName("EntityCommentsXML");
            entity.Property(e => e.LocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LocationID");
            entity.Property(e => e.MmediaInfoId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MMediaInfoID");
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Location).WithMany(p => p.MstrlocationRelatedMedia)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_MSTRLOCA_REFERENCE_MSTRLOCA2");

            entity.HasOne(d => d.MmediaInfo).WithMany(p => p.MstrlocationRelatedMedia)
                .HasForeignKey(d => d.MmediaInfoId)
                .HasConstraintName("FK_MSTRLOCA_REFERENCE_MSTRMEDI");
        });

        modelBuilder.Entity<MstrmediaContentInfo>(entity =>
        {
            entity.HasKey(e => e.MmediaInfoId).HasName("PK_MSTRMEDIACONTENTINFO");

            entity.ToTable("MSTRMediaContentInfo");

            entity.Property(e => e.MmediaInfoId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MMediaInfoID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsConfidential).HasDefaultValueSql("((0))");
            entity.Property(e => e.MediaName).HasMaxLength(100);
            entity.Property(e => e.MediaPhysicalPath).HasMaxLength(200);
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.MediaCategoryNavigation).WithMany(p => p.MstrmediaContentInfoMediaCategoryNavigations)
                .HasForeignKey(d => d.MediaCategory)
                .HasConstraintName("FK_MSTRMEDI_REFERENCE_REFMSTRI");

            entity.HasOne(d => d.MediaTypeNavigation).WithMany(p => p.MstrmediaContentInfoMediaTypeNavigations)
                .HasForeignKey(d => d.MediaType)
                .HasConstraintName("FK_MSTRMEDI_REFERENCE_REFMSTRI2");
        });

        modelBuilder.Entity<Mstrorganization>(entity =>
        {
            entity.HasKey(e => e.Moid)
                .HasName("PK_MSTR_ORGANIZATION")
                .IsClustered(false);

            entity.ToTable("MSTROrganization");

            entity.HasIndex(e => e.AgencyId, "IX_MSTROrganization_AgencyID");

            entity.HasIndex(e => e.PrimaryLocationId, "IX_MSTROrganization_PrimaryLocationID");

            entity.HasIndex(e => e.PrimaryOrganizationId, "IX_MSTROrganization_PrimaryOrganizationID");

            entity.HasIndex(e => e.SecondaryLocationId, "IX_MSTROrganization_SecondaryLocationID");

            entity.Property(e => e.Moid)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MOID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.ContactEmail).HasMaxLength(100);
            entity.Property(e => e.ContactPersonName).HasMaxLength(100);
            entity.Property(e => e.CopiedFromOrganizationId)
                .HasMaxLength(50)
                .HasColumnName("CopiedFromOrganizationID");
            entity.Property(e => e.CopiedFromSource).HasMaxLength(50);
            entity.Property(e => e.CopiedOn).HasColumnType("datetime");
            entity.Property(e => e.DayPhoneNumber).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmergencyPhoneNumber).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NightPhoneNumber).HasMaxLength(100);
            entity.Property(e => e.OrganizationDetailXml)
                .HasColumnType("xml")
                .HasColumnName("OrganizationDetailXML");
            entity.Property(e => e.PrimaryLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryLocationID");
            entity.Property(e => e.PrimaryOrganizationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryOrganizationID");
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.SecondaryLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SecondaryLocationID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Agency).WithMany(p => p.Mstrorganizations)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_MSTRORGA_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.OrganizationTypeCodeNavigation).WithMany(p => p.Mstrorganizations)
                .HasForeignKey(d => d.OrganizationTypeCode)
                .HasConstraintName("FK_MSTRORGA_REFERENCE_REFMSTRI2");

            entity.HasOne(d => d.PrimaryLocation).WithMany(p => p.MstrorganizationPrimaryLocations)
                .HasForeignKey(d => d.PrimaryLocationId)
                .HasConstraintName("FK_MSTRORGA_REFERENCE_MSTRLOCA2");

            entity.HasOne(d => d.PrimaryOrganization).WithMany(p => p.InversePrimaryOrganization)
                .HasForeignKey(d => d.PrimaryOrganizationId)
                .HasConstraintName("FK_MSTRORGA_REFERENCE_MSTRORGA3");

            entity.HasOne(d => d.SecondaryLocation).WithMany(p => p.MstrorganizationSecondaryLocations)
                .HasForeignKey(d => d.SecondaryLocationId)
                .HasConstraintName("FK_MSTRORGA_REFERENCE_MSTRLOCA");
        });

        modelBuilder.Entity<MstrorganizationImage>(entity =>
        {
            entity.HasKey(e => e.MstrorganizationImageId).HasName("PK_MSTRORGANIZATIONIMAGES");

            entity.ToTable("MSTROrganizationImages");

            entity.HasIndex(e => e.Moid, "IX_MSTROrganizationImages_MOID");

            entity.HasIndex(e => new { e.SysrmsapplicationTypeId, e.ApplicationTypePk }, "IX_MSTROrganizationImages_SYSRMSApplicationTypeID_ApplicationTypePK");

            entity.Property(e => e.MstrorganizationImageId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTROrganizationImageID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ImageContent).HasColumnType("image");
            entity.Property(e => e.Moid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MOID");
            entity.Property(e => e.SysrmsapplicationTypeId).HasColumnName("SYSRMSApplicationTypeID");

            entity.HasOne(d => d.Mo).WithMany(p => p.MstrorganizationImages)
                .HasForeignKey(d => d.Moid)
                .HasConstraintName("FK_MSTRORGA_REFERENCE_MSTRORGA");

            entity.HasOne(d => d.SysrmsapplicationType).WithMany(p => p.MstrorganizationImages)
                .HasForeignKey(d => d.SysrmsapplicationTypeId)
                .HasConstraintName("FK_MSTRORGA_REFERENCE_SYSRMSAP");
        });

        modelBuilder.Entity<MstrorganizationRelatedIndex>(entity =>
        {
            entity.HasKey(e => e.MorelatedIndexId).HasName("PK_MSTRORGANIZATIONRELATEDINDE");

            entity.ToTable("MSTROrganizationRelatedIndex");

            entity.HasIndex(e => e.Moid, "IX_MSTROrganizationRelatedIndex_MOID");

            entity.HasIndex(e => e.RelatedPerson, "IX_MSTROrganizationRelatedIndex_RelatedPerson");

            entity.HasIndex(e => e.RelatedVehicle, "IX_MSTROrganizationRelatedIndex_RelatedVehicle");

            entity.Property(e => e.MorelatedIndexId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MORelatedIndexID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CopiedFromPrpersonMorelatedIndexId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CopiedFromPRPersonMORelatedIndexID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LinkedCentralOn).HasColumnType("datetime");
            entity.Property(e => e.LnkcentralMstrorelatedIndex)
                .HasMaxLength(50)
                .HasColumnName("LNKCentralMSTRORelatedIndex");
            entity.Property(e => e.Moid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MOID");
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.RelatedPerson).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RelatedVehicle).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Mo).WithMany(p => p.MstrorganizationRelatedIndices)
                .HasForeignKey(d => d.Moid)
                .HasConstraintName("FK_MSTRORGA_REFERENCE_MSTRORGA2");

            entity.HasOne(d => d.RelatedPersonNavigation).WithMany(p => p.MstrorganizationRelatedIndices)
                .HasForeignKey(d => d.RelatedPerson)
                .HasConstraintName("FK_MSTRORGA_REFERENCE_MSTRPERS");

            entity.HasOne(d => d.RelatedTypeCodeNavigation).WithMany(p => p.MstrorganizationRelatedIndices)
                .HasForeignKey(d => d.RelatedTypeCode)
                .HasConstraintName("FK_MSTRORGA_REFERENCE_REFMSTRI");

            entity.HasOne(d => d.RelatedVehicleNavigation).WithMany(p => p.MstrorganizationRelatedIndices)
                .HasForeignKey(d => d.RelatedVehicle)
                .HasConstraintName("FK_MSTRORGA_REFERENCE_MSTRVEHI");
        });

        modelBuilder.Entity<MstrorganizationRelatedMedium>(entity =>
        {
            entity.HasKey(e => e.MorelatedMediaId).HasName("PK_CENTRALMSTRORGANIZATIONRELA2");

            entity.ToTable("MSTROrganizationRelatedMedia");

            entity.HasIndex(e => e.Moid, "IX_MSTROrganizationRelatedMedia_MOID");

            entity.Property(e => e.MorelatedMediaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MORelatedMediaID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EntityCommentsXml)
                .HasColumnType("xml")
                .HasColumnName("EntityCommentsXML");
            entity.Property(e => e.MmediaInfoId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MMediaInfoID");
            entity.Property(e => e.Moid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MOID");
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.MmediaInfo).WithMany(p => p.MstrorganizationRelatedMedia)
                .HasForeignKey(d => d.MmediaInfoId)
                .HasConstraintName("FK_MSTRORGA_REFERENCE_MSTRMEDI");

            entity.HasOne(d => d.Mo).WithMany(p => p.MstrorganizationRelatedMedia)
                .HasForeignKey(d => d.Moid)
                .HasConstraintName("FK_CENTRALM_REFERENCE_CENTRALM21");
        });

        modelBuilder.Entity<Mstrperson>(entity =>
        {
            entity.HasKey(e => e.Mpid)
                .HasName("PK_MSTR_NAME")
                .IsClustered(false);

            entity.ToTable("MSTRPerson");

            entity.HasIndex(e => e.PersonBloodTypeCode, "IX_MSTRPerson_PersonBloodTypeCode");

            entity.HasIndex(e => e.PersonEthnicityCode, "IX_MSTRPerson_PersonEthnicityCode");

            entity.HasIndex(e => e.PersonRaceCode, "IX_MSTRPerson_PersonRaceCode");

            entity.HasIndex(e => e.IsActive, "MSTRPErsonWithISActive");

            entity.Property(e => e.Mpid)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.CopiedFromPersonId)
                .HasMaxLength(50)
                .HasColumnName("CopiedFromPersonID");
            entity.Property(e => e.CopiedFromSource).HasMaxLength(50);
            entity.Property(e => e.CopiedOn).HasColumnType("datetime");
            entity.Property(e => e.Dmvtraces).HasColumnName("DMVTraces");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.LatestBackgroundCheckId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LatestBackgroundCheckID");
            entity.Property(e => e.PersonDeathDate).HasColumnType("datetime");
            entity.Property(e => e.PersonDetailXml)
                .HasColumnType("xml")
                .HasColumnName("PersonDetailXML");
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.Ssnidentification)
                .HasMaxLength(20)
                .HasColumnName("SSNIdentification");
            entity.Property(e => e.TaxIdentification).HasMaxLength(20);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Agency).WithMany(p => p.Mstrpeople)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.LatestBackgroundCheck).WithMany(p => p.Mstrpeople)
                .HasForeignKey(d => d.LatestBackgroundCheckId)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_TRXBACKG");

            entity.HasOne(d => d.PersonBloodTypeCodeNavigation).WithMany(p => p.MstrpersonPersonBloodTypeCodeNavigations)
                .HasForeignKey(d => d.PersonBloodTypeCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI2");

            entity.HasOne(d => d.PersonEthnicityCodeNavigation).WithMany(p => p.MstrpersonPersonEthnicityCodeNavigations)
                .HasForeignKey(d => d.PersonEthnicityCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI3");

            entity.HasOne(d => d.PersonRaceCodeNavigation).WithMany(p => p.MstrpersonPersonRaceCodeNavigations)
                .HasForeignKey(d => d.PersonRaceCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI6");
        });

        modelBuilder.Entity<MstrpersonAlert>(entity =>
        {
            entity.HasKey(e => e.MstrpersonAlertId).HasName("PK_MSTRPERSONALERTS");

            entity.ToTable("MSTRPersonAlerts");

            entity.HasIndex(e => e.AlertTypeCode, "IX_MSTRPersonAlerts_AlertTypeCode");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "IX_MSTRPersonAlerts_ApplicationType_ApplicationTypePK");

            entity.HasIndex(e => e.Mpid, "IX_MSTRPersonAlerts_MPID");

            entity.HasIndex(e => new { e.Mpid, e.IsActive }, "IX_MSTRPersonAlerts_MPID_IsActive");

            entity.Property(e => e.MstrpersonAlertId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRPersonAlertID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.CopiedFromPrpersonMstrpersonAlertId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CopiedFromPRPersonMSTRPersonAlertID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpirationDate).HasColumnType("date");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.AlertTypeCodeNavigation).WithMany(p => p.MstrpersonAlerts)
                .HasForeignKey(d => d.AlertTypeCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.MstrpersonAlerts)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_SYSRMSAP");

            entity.HasOne(d => d.Mp).WithMany(p => p.MstrpersonAlerts)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_MSTRPERS");
        });

        modelBuilder.Entity<MstrpersonCharacteristic>(entity =>
        {
            entity.HasKey(e => e.MstrpersonCharacteristicId).HasName("PK_MSTRPERSONCHARACTERISTICS");

            entity.ToTable("MSTRPersonCharacteristics");

            entity.HasIndex(e => e.BuildCode, "IX_MSTRPersonCharacteristics_BuildCode");

            entity.HasIndex(e => e.ComplexionCode, "IX_MSTRPersonCharacteristics_ComplexionCode");

            entity.HasIndex(e => e.DexterityCode, "IX_MSTRPersonCharacteristics_DexterityCode");

            entity.HasIndex(e => e.DrugInvolveCode, "IX_MSTRPersonCharacteristics_DrugInvolveCode");

            entity.HasIndex(e => e.EducationCode, "IX_MSTRPersonCharacteristics_EducationCode");

            entity.HasIndex(e => e.EyeColorCode, "IX_MSTRPersonCharacteristics_EyeColorCode");

            entity.HasIndex(e => e.EyewearDescriptionCode, "IX_MSTRPersonCharacteristics_EyewearDescriptionCode");

            entity.HasIndex(e => e.FacialHairCode, "IX_MSTRPersonCharacteristics_FacialHairCode");

            entity.HasIndex(e => e.HairColorCode, "IX_MSTRPersonCharacteristics_HairColorCode");

            entity.HasIndex(e => e.HairLengthCode, "IX_MSTRPersonCharacteristics_HairLengthCode");

            entity.HasIndex(e => e.HairStyleCode, "IX_MSTRPersonCharacteristics_HairStyleCode");

            entity.HasIndex(e => e.IsAlcoholProblemPresent, "IX_MSTRPersonCharacteristics_IsAlcoholProblemPresent");

            entity.HasIndex(e => e.IsNarcoticsProblemPresent, "IX_MSTRPersonCharacteristics_IsNarcoticsProblemPresent");

            entity.HasIndex(e => e.MaritalStatusCode, "IX_MSTRPersonCharacteristics_MaritalStatusCode");

            entity.HasIndex(e => e.MobilityDisabilityCode, "IX_MSTRPersonCharacteristics_MobilityDisabilityCode");

            entity.HasIndex(e => e.NoseCode, "IX_MSTRPersonCharacteristics_NoseCode");

            entity.HasIndex(e => e.OccupationCode, "IX_MSTRPersonCharacteristics_OccupationCode");

            entity.HasIndex(e => e.PersonBirthCountryCode, "IX_MSTRPersonCharacteristics_PersonBirthCountryCode");

            entity.HasIndex(e => e.PersonBirthStateCode, "IX_MSTRPersonCharacteristics_PersonBirthStateCode");

            entity.HasIndex(e => e.PersonNationalityCode, "IX_MSTRPersonCharacteristics_PersonNationalityCode");

            entity.HasIndex(e => e.PrimaryLanguage, "IX_MSTRPersonCharacteristics_PrimaryLanguage");

            entity.HasIndex(e => new { e.SysrmsapplicationTypeId, e.ApplicationTypePk }, "IX_MSTRPersonCharacteristics_SYSRMSApplicationTypeID_ApplicationTypePK");

            entity.HasIndex(e => e.ScarMarkTattooCode, "IX_MSTRPersonCharacteristics_ScarMarkTattooCode");

            entity.HasIndex(e => e.SkinToneCode, "IX_MSTRPersonCharacteristics_SkinToneCode");

            entity.HasIndex(e => e.SpeechDescriptionCode, "IX_MSTRPersonCharacteristics_SpeechDescriptionCode");

            entity.HasIndex(e => e.TeethCode, "IX_MSTRPersonCharacteristics_TeethCode");

            entity.HasIndex(e => e.IsCurrentRecord, "MSTRPersonCharacteristics_IsCurrentRecord");

            entity.HasIndex(e => e.Mpid, "MSTRPersonCharacteristics_MPID");

            entity.HasIndex(e => new { e.Mpid, e.IsCurrentRecord }, "MSTRPersonCharacteristics_MPID_IsCurrentRecord");

            entity.Property(e => e.MstrpersonCharacteristicId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRPersonCharacteristicID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.ClothDesc).HasMaxLength(200);
            entity.Property(e => e.CopiedFromPersonId)
                .HasMaxLength(50)
                .HasColumnName("CopiedFromPersonID");
            entity.Property(e => e.CopiedFromPrpersonMstrpersonCharacteristicId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CopiedFromPRPersonMSTRPersonCharacteristicID");
            entity.Property(e => e.CopiedFromSource).HasMaxLength(50);
            entity.Property(e => e.CopiedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnglishSpeaking).HasDefaultValueSql("((1))");
            entity.Property(e => e.IsFamilyViolencePresent).HasDefaultValueSql("((0))");
            entity.Property(e => e.MotherMaidenName).HasMaxLength(200);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.PersonBirthTown).HasMaxLength(50);
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.SysrmsapplicationTypeId).HasColumnName("SYSRMSApplicationTypeID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.BuildCodeNavigation).WithMany(p => p.MstrpersonCharacteristicBuildCodeNavigations)
                .HasForeignKey(d => d.BuildCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI29");

            entity.HasOne(d => d.ComplexionCodeNavigation).WithMany(p => p.MstrpersonCharacteristicComplexionCodeNavigations)
                .HasForeignKey(d => d.ComplexionCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI36");

            entity.HasOne(d => d.DexterityCodeNavigation).WithMany(p => p.MstrpersonCharacteristicDexterityCodeNavigations)
                .HasForeignKey(d => d.DexterityCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI38");

            entity.HasOne(d => d.DrugInvolveCodeNavigation).WithMany(p => p.MstrpersonCharacteristicDrugInvolveCodeNavigations)
                .HasForeignKey(d => d.DrugInvolveCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI35");

            entity.HasOne(d => d.EducationCodeNavigation).WithMany(p => p.MstrpersonCharacteristicEducationCodeNavigations)
                .HasForeignKey(d => d.EducationCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI32");

            entity.HasOne(d => d.EyeColorCodeNavigation).WithMany(p => p.MstrpersonCharacteristicEyeColorCodeNavigations)
                .HasForeignKey(d => d.EyeColorCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI20");

            entity.HasOne(d => d.EyewearDescriptionCodeNavigation).WithMany(p => p.MstrpersonCharacteristicEyewearDescriptionCodeNavigations)
                .HasForeignKey(d => d.EyewearDescriptionCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI25");

            entity.HasOne(d => d.FacialHairCodeNavigation).WithMany(p => p.MstrpersonCharacteristicFacialHairCodeNavigations)
                .HasForeignKey(d => d.FacialHairCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI24");

            entity.HasOne(d => d.HairColorCodeNavigation).WithMany(p => p.MstrpersonCharacteristicHairColorCodeNavigations)
                .HasForeignKey(d => d.HairColorCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI21");

            entity.HasOne(d => d.HairLengthCodeNavigation).WithMany(p => p.MstrpersonCharacteristicHairLengthCodeNavigations)
                .HasForeignKey(d => d.HairLengthCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI42");

            entity.HasOne(d => d.HairStyleCodeNavigation).WithMany(p => p.MstrpersonCharacteristicHairStyleCodeNavigations)
                .HasForeignKey(d => d.HairStyleCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI19");

            entity.HasOne(d => d.IsAlcoholProblemPresentNavigation).WithMany(p => p.MstrpersonCharacteristicIsAlcoholProblemPresentNavigations)
                .HasForeignKey(d => d.IsAlcoholProblemPresent)
                .HasConstraintName("FK_MSTRPersonCharacteristics_RefMSTRINXReferenceData1");

            entity.HasOne(d => d.IsNarcoticsProblemPresentNavigation).WithMany(p => p.MstrpersonCharacteristicIsNarcoticsProblemPresentNavigations)
                .HasForeignKey(d => d.IsNarcoticsProblemPresent)
                .HasConstraintName("FK_MSTRPersonCharacteristics_RefMSTRINXReferenceData2");

            entity.HasOne(d => d.MaritalStatusCodeNavigation).WithMany(p => p.MstrpersonCharacteristicMaritalStatusCodeNavigations)
                .HasForeignKey(d => d.MaritalStatusCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI23");

            entity.HasOne(d => d.MobilityDisabilityCodeNavigation).WithMany(p => p.MstrpersonCharacteristicMobilityDisabilityCodeNavigations)
                .HasForeignKey(d => d.MobilityDisabilityCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI27");

            entity.HasOne(d => d.Mp).WithMany(p => p.MstrpersonCharacteristics)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_MSTRPERS3");

            entity.HasOne(d => d.NoseCodeNavigation).WithMany(p => p.MstrpersonCharacteristicNoseCodeNavigations)
                .HasForeignKey(d => d.NoseCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI34");

            entity.HasOne(d => d.OccupationCodeNavigation).WithMany(p => p.MstrpersonCharacteristicOccupationCodeNavigations)
                .HasForeignKey(d => d.OccupationCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI41");

            entity.HasOne(d => d.PersonBirthCountryCodeNavigation).WithMany(p => p.MstrpersonCharacteristicPersonBirthCountryCodeNavigations)
                .HasForeignKey(d => d.PersonBirthCountryCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI33");

            entity.HasOne(d => d.PersonBirthStateCodeNavigation).WithMany(p => p.MstrpersonCharacteristicPersonBirthStateCodeNavigations)
                .HasForeignKey(d => d.PersonBirthStateCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI28");

            entity.HasOne(d => d.PersonNationalityCodeNavigation).WithMany(p => p.MstrpersonCharacteristicPersonNationalityCodeNavigations)
                .HasForeignKey(d => d.PersonNationalityCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI39");

            entity.HasOne(d => d.PrimaryLanguageNavigation).WithMany(p => p.MstrpersonCharacteristicPrimaryLanguageNavigations)
                .HasForeignKey(d => d.PrimaryLanguage)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI5");

            entity.HasOne(d => d.ScarMarkTattooCodeNavigation).WithMany(p => p.MstrpersonCharacteristicScarMarkTattooCodeNavigations)
                .HasForeignKey(d => d.ScarMarkTattooCode)
                .HasConstraintName("FK_MSTRPersonCharacteristics_RefMSTRINXReferenceData");

            entity.HasOne(d => d.SkinToneCodeNavigation).WithMany(p => p.MstrpersonCharacteristicSkinToneCodeNavigations)
                .HasForeignKey(d => d.SkinToneCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI22");

            entity.HasOne(d => d.SpeechDescriptionCodeNavigation).WithMany(p => p.MstrpersonCharacteristicSpeechDescriptionCodeNavigations)
                .HasForeignKey(d => d.SpeechDescriptionCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI31");

            entity.HasOne(d => d.SysrmsapplicationType).WithMany(p => p.MstrpersonCharacteristics)
                .HasForeignKey(d => d.SysrmsapplicationTypeId)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_SYSRMSAP7");

            entity.HasOne(d => d.TeethCodeNavigation).WithMany(p => p.MstrpersonCharacteristicTeethCodeNavigations)
                .HasForeignKey(d => d.TeethCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI30");
        });

        modelBuilder.Entity<MstrpersonContactDetail>(entity =>
        {
            entity.HasKey(e => e.MstrcontactId).HasName("PK_MSTRPERSONCONTACTDETAIL");

            entity.ToTable("MSTRPersonContactDetail", tb => tb.HasTrigger("TRG_UpdateMSTRPersonContactInfo"));

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "IX_MSTRPersonContactDetail_ApplicationType_ApplicationTypePK");

            entity.HasIndex(e => e.Mpid, "MSTRPersonContactDetail_MPID");

            entity.HasIndex(e => new { e.Mpid, e.IsCurrentContact }, "MSTRPersonContactDetail_MPID_IsCurrentContact");

            entity.Property(e => e.MstrcontactId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRContactID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.ContactDetailXml)
                .HasColumnType("xml")
                .HasColumnName("ContactDetailXML");
            entity.Property(e => e.CopiedFromPrpersonMstrcontactId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CopiedFromPRPersonMSTRContactID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LinkedCentralOn).HasColumnType("datetime");
            entity.Property(e => e.LnkcentralMstrpersonContactDetail)
                .HasMaxLength(50)
                .HasColumnName("LNKCentralMSTRPersonContactDetail");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.MstrpersonContactDetails)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_SYSRMSAP5");

            entity.HasOne(d => d.Mp).WithMany(p => p.MstrpersonContactDetails)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_CENTRALM_REFERENCE_CENTRALM13");
        });

        modelBuilder.Entity<MstrpersonContactInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MSTRPersonContactInfo");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "IX_MSTRPersonContactInfo_ApplicationType_ApplicationTypePK");

            entity.HasIndex(e => e.ContactData, "IX_MSTRPersonContactInfo_ContactData");

            entity.HasIndex(e => e.ContactDataDigitsOnly, "IX_MSTRPersonContactInfo_ContactDataDigitsOnly");

            entity.HasIndex(e => new { e.Mpid, e.IsCurrentContact }, "IX_MSTRPersonContactInfo_MPID_IsCurrentContact");

            entity.HasIndex(e => e.TypeOfContact, "IX_MSTRPersonContactInfo_TypeOfContact");

            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.ContactData).HasMaxLength(400);
            entity.Property(e => e.ContactDataDigitsOnly).HasMaxLength(200);
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOnString).HasMaxLength(100);
            entity.Property(e => e.Extension).HasMaxLength(50);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.MstrcontactId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRContactID");
            entity.Property(e => e.TenDigitPhone).HasMaxLength(10);
            entity.Property(e => e.TypeOfContactString).HasMaxLength(50);
            entity.Property(e => e.UpToExt)
                .HasMaxLength(400)
                .HasColumnName("UpToEXT");
        });

        modelBuilder.Entity<MstrpersonFingerprintSet>(entity =>
        {
            entity.HasKey(e => e.MpfingerprintSetId).HasName("PK_MSTRPERSONFINGERPRINTSET");

            entity.ToTable("MSTRPersonFingerprintSet");

            entity.HasIndex(e => e.Mpid, "IX_MSTRPersonFingerprintSet_MPID");

            entity.Property(e => e.MpfingerprintSetId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPFingerprintSetID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FingerprintSetData).HasMaxLength(50);
            entity.Property(e => e.IsConfidential).HasDefaultValueSql("((0))");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.FingerPositionCodeNavigation).WithMany(p => p.MstrpersonFingerprintSetFingerPositionCodeNavigations)
                .HasForeignKey(d => d.FingerPositionCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI10");

            entity.HasOne(d => d.FingerPositionIndicatorCodeNavigation).WithMany(p => p.MstrpersonFingerprintSetFingerPositionIndicatorCodeNavigations)
                .HasForeignKey(d => d.FingerPositionIndicatorCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI11");

            entity.HasOne(d => d.Mp).WithMany(p => p.MstrpersonFingerprintSets)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_CENTRALM_REFERENCE_CENTRALM8");
        });

        modelBuilder.Entity<MstrpersonIdentification>(entity =>
        {
            entity.HasKey(e => e.MpidentificationId)
                .HasName("PK_NAMEIDNUMBER")
                .IsClustered(false);

            entity.ToTable("MSTRPersonIdentification");

            entity.HasIndex(e => e.Mpid, "MSTRPersonIdentification_MPID");

            entity.Property(e => e.MpidentificationId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPIdentificationID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CopiedFromPrpersonMpidentificationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CopiedFromPRPersonMPIdentificationID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.IdcategoryCode).HasColumnName("IDCategoryCode");
            entity.Property(e => e.Iddata)
                .HasMaxLength(50)
                .HasColumnName("IDData");
            entity.Property(e => e.IdentificationEffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.IdentificationExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.IdcategoryCodeNavigation).WithMany(p => p.MstrpersonIdentifications)
                .HasForeignKey(d => d.IdcategoryCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI8");

            entity.HasOne(d => d.Mp).WithMany(p => p.MstrpersonIdentifications)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_CENTRALM_REFERENCE_CENTRALM5");
        });

        modelBuilder.Entity<MstrpersonLocation>(entity =>
        {
            entity.HasKey(e => e.MstrpersonLocationId).HasName("PK_MSTRPERSONLOCATION");

            entity.ToTable("MSTRPersonLocation");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "IX_MSTRPersonLocation_ApplicationType_ApplicationTypePK");

            entity.HasIndex(e => e.MailLocationId, "IX_MSTRPersonLocation_MailLocationID");

            entity.HasIndex(e => e.ResidenceLocId, "IX_MSTRPersonLocation_ResidenceLocID");

            entity.HasIndex(e => e.SecondaryResidenceLocId, "IX_MSTRPersonLocation_SecondaryResidenceLocID");

            entity.HasIndex(e => e.IsCurrentLocation, "MSTRPersonLocation_IsCurrentLocation");

            entity.HasIndex(e => new { e.Mpid, e.IsCurrentLocation }, "MSTRPersonLocation_MPID_IsCurrentLocation");

            entity.Property(e => e.MstrpersonLocationId)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MSTRPersonLocationID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.CopiedFromPersonId)
                .HasMaxLength(50)
                .HasColumnName("CopiedFromPersonID");
            entity.Property(e => e.CopiedFromPrpersonMstrpersonLocationId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CopiedFromPRPersonMSTRPersonLocationID");
            entity.Property(e => e.CopiedFromSource).HasMaxLength(50);
            entity.Property(e => e.CopiedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MailLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MailLocationID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.ResidenceLocId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ResidenceLocID");
            entity.Property(e => e.SecondaryResidenceLocId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SecondaryResidenceLocID");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.MstrpersonLocations)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_SYSRMSAP8");

            entity.HasOne(d => d.MailLocation).WithMany(p => p.MstrpersonLocationMailLocations)
                .HasForeignKey(d => d.MailLocationId)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_MSTRLOCA3");

            entity.HasOne(d => d.Mp).WithMany(p => p.MstrpersonLocations)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_MSTRPERS4");

            entity.HasOne(d => d.ResidenceLoc).WithMany(p => p.MstrpersonLocationResidenceLocs)
                .HasForeignKey(d => d.ResidenceLocId)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_MSTRLOCA2");

            entity.HasOne(d => d.SecondaryResidenceLoc).WithMany(p => p.MstrpersonLocationSecondaryResidenceLocs)
                .HasForeignKey(d => d.SecondaryResidenceLocId)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_MSTRLOCA");
        });

        modelBuilder.Entity<MstrpersonMedicalCondition>(entity =>
        {
            entity.HasKey(e => e.MstrpersonMedicalConditionId).HasName("PK_MSTRPERSONMEDICALCONDITION");

            entity.ToTable("MSTRPersonMedicalCondition");

            entity.HasIndex(e => e.Mpid, "IX_MSTRPersonMedicalCondition_MPID");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk, e.Mpid }, "MSTRPersonMedicalCondition_AppType_PKID_MPID");

            entity.Property(e => e.MstrpersonMedicalConditionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRPersonMedicalConditionID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.Conditions).HasColumnType("xml");
            entity.Property(e => e.CopiedFromPrpersonMstrpersonMedicalConditionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CopiedFromPRPersonMSTRPersonMedicalConditionID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.MstrpersonMedicalConditions)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_SYSRMSAP10");

            entity.HasOne(d => d.Mp).WithMany(p => p.MstrpersonMedicalConditions)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_MSTRPERS7");
        });

        modelBuilder.Entity<MstrpersonMugShot>(entity =>
        {
            entity.HasKey(e => e.MstrpersonMugShotId).HasName("PK_MSTRPERSONMUGSHOTS");

            entity.ToTable("MSTRPersonMugShots");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "IX_MSTRPersonMugShots_ApplicationType_ApplicationTypePK");

            entity.HasIndex(e => e.Mpid, "IX_MSTRPersonMugShots_MPID");

            entity.Property(e => e.MstrpersonMugShotId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRPersonMugShotID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.CopiedFromPrpersonMstrpersonMugShotId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CopiedFromPRPersonMSTRPersonMugShotID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.MstrpersonMugShots)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_SYSRMSAP9");

            entity.HasOne(d => d.Mp).WithMany(p => p.MstrpersonMugShots)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_MSTRPERS5");
        });

        modelBuilder.Entity<MstrpersonMugShotImage>(entity =>
        {
            entity.HasKey(e => e.MstrpersonMugShotImageId).HasName("PK_MSTRPERSONMUGSHOTIMAGES");

            entity.ToTable("MSTRPersonMugShotImages");

            entity.HasIndex(e => e.MstrpersonMugShotId, "IX_MSTRPersonMugShotImages_MSTRPersonMugShotID");

            entity.Property(e => e.MstrpersonMugShotImageId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRPersonMugShotImageID");
            entity.Property(e => e.ActualIncidentIdforArrest)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ActualIncidentIDForArrest");
            entity.Property(e => e.ActualIncidentIdforArrestBeforeCorrection)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ActualIncidentIDForArrestBeforeCorrection");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AddedonBeforeCorrection).HasColumnType("datetime");
            entity.Property(e => e.CopiedFromPrpersonMstrpersonMugShotImageId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CopiedFromPRPersonMSTRPersonMugShotImageID");
            entity.Property(e => e.CopiedOn).HasColumnType("datetime");
            entity.Property(e => e.ImageContent).HasColumnType("image");
            entity.Property(e => e.ImageContentPath).HasMaxLength(300);
            entity.Property(e => e.MstrpersonMugShotId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRPersonMugShotID");

            entity.HasOne(d => d.MstrpersonMugShot).WithMany(p => p.MstrpersonMugShotImages)
                .HasForeignKey(d => d.MstrpersonMugShotId)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_MSTRPERS6");

            entity.HasOne(d => d.MugShotImageTypeCodeNavigation).WithMany(p => p.MstrpersonMugShotImages)
                .HasForeignKey(d => d.MugShotImageTypeCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI26");
        });

        modelBuilder.Entity<MstrpersonMugShotImagesHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MSTRPersonMugShotImagesHistory");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ImageContent).HasColumnType("image");
            entity.Property(e => e.ImageContentPath).HasMaxLength(300);
            entity.Property(e => e.MstrpersonMugShotId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRPersonMugShotID");
            entity.Property(e => e.MstrpersonMugShotImageId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRPersonMugShotImageID");
            entity.Property(e => e.OperationPerformedTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<MstrpersonMugShotsHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MSTRPersonMugShotsHistory");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.CopiedFromPrpersonMstrpersonMugShotId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CopiedFromPRPersonMSTRPersonMugShotID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.MstrpersonMugShotId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRPersonMugShotID");
            entity.Property(e => e.OperationPerformedTime).HasColumnType("datetime");
            entity.Property(e => e.UpdatedWithMstrpersonMugShotId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("UpdatedWithMSTRPersonMugShotID");
        });

        modelBuilder.Entity<MstrpersonName>(entity =>
        {
            entity.HasKey(e => e.Mpnid).HasName("PK_MSTRPERSONNAME");

            entity.ToTable("MSTRPersonName");

            entity.HasIndex(e => new { e.IsApplicationMasterEntry, e.ApplicationType }, "<Name of Missing Index, sysname,>");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "IX_MSTRPersonName_ApplicationType_ApplicationTypePK");

            entity.HasIndex(e => e.PersonSexCode, "IX_MSTRPersonName_PersonSexCode");

            entity.HasIndex(e => new { e.Mpid, e.IsMasterName }, "NonClusteredIndex-20150519-183710");

            entity.HasIndex(e => new { e.Mpid, e.IsApplicationMasterEntry, e.ApplicationType, e.ApplicationTypePk }, "NonClusteredIndexApplicationWise-20150519-183710");

            entity.HasIndex(e => new { e.IsApplicationMasterEntry, e.ApplicationType, e.ApplicationTypePk, e.GivenName, e.SurName, e.Dob }, "PersonCombinationApplicationWiseWithMPID");

            entity.HasIndex(e => new { e.IsMasterName, e.GivenName, e.SurName, e.Dob }, "PersonCombinationWithMPID");

            entity.Property(e => e.Mpnid)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPNID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.CopiedFromPersonId)
                .HasMaxLength(50)
                .HasColumnName("CopiedFromPersonID");
            entity.Property(e => e.CopiedFromPrpersonMpnid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CopiedFromPRPersonMPNID");
            entity.Property(e => e.CopiedFromSource).HasMaxLength(50);
            entity.Property(e => e.CopiedOn).HasColumnType("datetime");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.DobyearFrom).HasColumnName("DOBYearFrom");
            entity.Property(e => e.DobyearTo).HasColumnName("DOBYearTo");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FullName)
                .HasMaxLength(206)
                .HasComputedColumnSql("(((case when [SurName] IS NULL OR len([SurName])=(0) then '' else [SurName] end+case when [SurName] IS NOT NULL AND len([SurName])>(0) AND [GivenName] IS NOT NULL AND len([GivenName])>(0) then ', '+[GivenName] when [GivenName] IS NOT NULL AND len([GivenName])>(0) then [GivenName] else '' end)+case when [MiddleName] IS NOT NULL AND len([MiddleName])>(0) AND ([GivenName] IS NOT NULL AND len([GivenName])>(0) OR [SurName] IS NOT NULL AND len([SurName])>(0)) then ', '+[MiddleName] when [MiddleName] IS NOT NULL then [MiddleName] else '' end)+case when [NameSuffixText] IS NOT NULL AND len([NameSuffixText])>(0) AND ([GivenName] IS NOT NULL AND len([GivenName])>(0) OR [SurName] IS NOT NULL AND len([SurName])>(0) OR [MiddleName] IS NOT NULL AND len([MiddleName])>(0)) then ', '+[NameSuffixText] when [NameSuffixText] IS NOT NULL then [NameSuffixText] else '' end)", false);
            entity.Property(e => e.GivenName).HasMaxLength(50);
            entity.Property(e => e.IsUscitizen).HasColumnName("IsUSCitizen");
            entity.Property(e => e.MaidenName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.NameInitialsText)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NamePrefixText).HasMaxLength(50);
            entity.Property(e => e.NameSuffixText).HasMaxLength(50);
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.SearchName)
                .HasMaxLength(153)
                .HasComputedColumnSql("((case when [SurName] IS NULL then '' else [SurName]+', ' end+case when [GivenName] IS NULL then '' else [GivenName]+' ' end)+case when [MiddleName] IS NULL then '' else [MiddleName] end)", false);
            entity.Property(e => e.Ssnidentification)
                .HasMaxLength(20)
                .HasColumnName("SSNIdentification");
            entity.Property(e => e.SurName).HasMaxLength(50);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.MstrpersonNames)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_SYSRMSAP2");

            entity.HasOne(d => d.Mp).WithMany(p => p.MstrpersonNames)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_CENTRALM_REFERENCE_CENTRALM4");

            entity.HasOne(d => d.NameCategoryCodeNavigation).WithMany(p => p.MstrpersonNameNameCategoryCodeNavigations)
                .HasForeignKey(d => d.NameCategoryCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI7");

            entity.HasOne(d => d.PersonSexCodeNavigation).WithMany(p => p.MstrpersonNamePersonSexCodeNavigations)
                .HasForeignKey(d => d.PersonSexCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI17");
        });

        modelBuilder.Entity<MstrpersonOperatorLicense>(entity =>
        {
            entity.HasKey(e => e.MpoperatorLicenseId).HasName("PK_MSTRPERSONOPERATORLICENSE");

            entity.ToTable("MSTRPersonOperatorLicense");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "IX_MSTRPersonOperatorLicense_ApplicationType_ApplicationTypePK");

            entity.HasIndex(e => e.IsCommericalLicense, "NonClusteredIndex-20150519-183554");

            entity.HasIndex(e => new { e.Mpid, e.IsCurrentLicense }, "NonClusteredIndex-20150519-183626");

            entity.Property(e => e.MpoperatorLicenseId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPOperatorLicenseID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.CancelDate).HasColumnType("date");
            entity.Property(e => e.CancelState).HasMaxLength(50);
            entity.Property(e => e.Cdl)
                .HasMaxLength(50)
                .HasColumnName("CDL");
            entity.Property(e => e.CopiedFromPersonId)
                .HasMaxLength(50)
                .HasColumnName("CopiedFromPersonID");
            entity.Property(e => e.CopiedFromPrpersonMpoperatorLicenseId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CopiedFromPRPersonMPOperatorLicenseID");
            entity.Property(e => e.CopiedFromSource).HasMaxLength(50);
            entity.Property(e => e.CopiedOn).HasColumnType("datetime");
            entity.Property(e => e.DriverLicenseEndorsementCodeLst)
                .HasColumnType("xml")
                .HasColumnName("DriverLicenseEndorsementCodeLST");
            entity.Property(e => e.DriverLicenseExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.DriverLicenseIssueDate).HasColumnType("datetime");
            entity.Property(e => e.DriverLicenseNumber).HasMaxLength(50);
            entity.Property(e => e.DrivingRestrictionEndDate).HasColumnType("datetime");
            entity.Property(e => e.Dups).HasMaxLength(50);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpDate).HasColumnType("date");
            entity.Property(e => e.Idcard)
                .HasMaxLength(50)
                .HasColumnName("IDCard");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.OrganDonor).HasMaxLength(50);
            entity.Property(e => e.Pptp)
                .HasMaxLength(50)
                .HasColumnName("PPTP");
            entity.Property(e => e.RenewDate).HasColumnType("date");
            entity.Property(e => e.Restrictions).HasMaxLength(50);
            entity.Property(e => e.SuspDate).HasColumnType("date");
            entity.Property(e => e.Suspended).HasMaxLength(50);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.WithPend).HasMaxLength(50);

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.MstrpersonOperatorLicenses)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_SYSRMSAP4");

            entity.HasOne(d => d.DriverLicenseClassificationCodeNavigation).WithMany(p => p.MstrpersonOperatorLicenseDriverLicenseClassificationCodeNavigations)
                .HasForeignKey(d => d.DriverLicenseClassificationCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI13");

            entity.HasOne(d => d.DriverLicenseJurisdictionCodeNavigation).WithMany(p => p.MstrpersonOperatorLicenseDriverLicenseJurisdictionCodeNavigations)
                .HasForeignKey(d => d.DriverLicenseJurisdictionCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI4");

            entity.HasOne(d => d.DriverLicenseStateNavigation).WithMany(p => p.MstrpersonOperatorLicenseDriverLicenseStateNavigations)
                .HasForeignKey(d => d.DriverLicenseState)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI16");

            entity.HasOne(d => d.DriverLicenseStatusCodeNavigation).WithMany(p => p.MstrpersonOperatorLicenseDriverLicenseStatusCodeNavigations)
                .HasForeignKey(d => d.DriverLicenseStatusCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI14");

            entity.HasOne(d => d.DrivingRestrictionCodeNavigation).WithMany(p => p.MstrpersonOperatorLicenseDrivingRestrictionCodeNavigations)
                .HasForeignKey(d => d.DrivingRestrictionCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI15");

            entity.HasOne(d => d.Mp).WithMany(p => p.MstrpersonOperatorLicenses)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_CENTRALM_REFERENCE_CENTRALM9");
        });

        modelBuilder.Entity<MstrpersonPhysicalFeature>(entity =>
        {
            entity.HasKey(e => e.MpphysicalFeatureId).HasName("PK_MSTRPERSONPHYSICALFEATURE");

            entity.ToTable("MSTRPersonPhysicalFeature");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "IX_MSTRPersonPhysicalFeature_ApplicationType_ApplicationTypePK");

            entity.HasIndex(e => e.Mpid, "IX_MSTRPersonPhysicalFeature_MPID");

            entity.Property(e => e.MpphysicalFeatureId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPhysicalFeatureID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.CopiedFromPrpersonMpphysicalFeatureId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CopiedFromPRPersonMPPhysicalFeatureID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FeatureImage).HasColumnType("image");
            entity.Property(e => e.FeatureMediaId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("FeatureMediaID");
            entity.Property(e => e.ImageContentPath).HasMaxLength(300);
            entity.Property(e => e.IsConfidential).HasDefaultValueSql("((0))");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.PhysicalFeatureDescription).HasMaxLength(100);
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.MstrpersonPhysicalFeatures)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_SYSRMSAP3");

            entity.HasOne(d => d.FeatureCodeNavigation).WithMany(p => p.MstrpersonPhysicalFeatureFeatureCodeNavigations)
                .HasForeignKey(d => d.FeatureCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI9");

            entity.HasOne(d => d.FeatureLocationCodeNavigation).WithMany(p => p.MstrpersonPhysicalFeatureFeatureLocationCodeNavigations)
                .HasForeignKey(d => d.FeatureLocationCode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI40");

            entity.HasOne(d => d.FeatureMedia).WithMany(p => p.MstrpersonPhysicalFeatures)
                .HasForeignKey(d => d.FeatureMediaId)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_MSTRMEDI5");

            entity.HasOne(d => d.Mp).WithMany(p => p.MstrpersonPhysicalFeatures)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_CENTRALM_REFERENCE_CENTRALM7");
        });

        modelBuilder.Entity<MstrpersonRelatedMedium>(entity =>
        {
            entity.HasKey(e => e.MprelatedMediaId).HasName("PK_MSTRPERSONRELATEDMEDIA");

            entity.ToTable("MSTRPersonRelatedMedia");

            entity.HasIndex(e => e.Mpid, "IX_MSTRPersonRelatedMedia_MPID");

            entity.Property(e => e.MprelatedMediaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPRelatedMediaID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MediaContentPath).HasMaxLength(300);
            entity.Property(e => e.MmediaInfoId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MMediaInfoID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.MstrpersonRelatedMedia)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_SYSRMSAP6");

            entity.HasOne(d => d.MmediaInfo).WithMany(p => p.MstrpersonRelatedMedia)
                .HasForeignKey(d => d.MmediaInfoId)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_MSTRMEDI");

            entity.HasOne(d => d.Mp).WithMany(p => p.MstrpersonRelatedMedia)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_MSTRPERS2");
        });

        modelBuilder.Entity<MstrpersonRelation>(entity =>
        {
            entity.HasKey(e => e.MprelationId).HasName("PK_MSTRPERSONRELATION");

            entity.ToTable("MSTRPersonRelation");

            entity.HasIndex(e => e.LinkedPersonId, "IX_MSTRPersonRelation_LinkedPersonID");

            entity.HasIndex(e => e.PrimaryPersonId, "MSTRPersonRelation_PrimaryPersonID");

            entity.Property(e => e.MprelationId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPRelationID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CopiedFromPrpersonMprelationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CopiedFromPRPersonMPRelationID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LinkedPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LinkedPersonID");
            entity.Property(e => e.PersonRelationLnkcode).HasColumnName("PersonRelationLNKCode");
            entity.Property(e => e.PrimaryPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryPersonID");
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.LinkedPerson).WithMany(p => p.MstrpersonRelationLinkedPeople)
                .HasForeignKey(d => d.LinkedPersonId)
                .HasConstraintName("FK_CENTRALM_REFERENCE_CENTRALM15");

            entity.HasOne(d => d.PersonRelationLnkcodeNavigation).WithMany(p => p.MstrpersonRelations)
                .HasForeignKey(d => d.PersonRelationLnkcode)
                .HasConstraintName("FK_MSTRPERS_REFERENCE_REFMSTRI18");

            entity.HasOne(d => d.PrimaryPerson).WithMany(p => p.MstrpersonRelationPrimaryPeople)
                .HasForeignKey(d => d.PrimaryPersonId)
                .HasConstraintName("FK_CENTRALM_REFERENCE_CENTRALM14");
        });

        modelBuilder.Entity<MstrpersonsSetActive>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MSTRPersonsSetActive");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
        });

        modelBuilder.Entity<Mstrproperty>(entity =>
        {
            entity.HasKey(e => e.Mppid).HasName("PK_MSTRPROPERTY");

            entity.ToTable("MSTRProperty");

            entity.HasIndex(e => e.PropertyNameId, "IX_MSTRProperty_PropertyNameID");

            entity.Property(e => e.Mppid)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.BrandName).HasMaxLength(100);
            entity.Property(e => e.CollectMessageNumber).HasMaxLength(100);
            entity.Property(e => e.CopiedFromPropertyId)
                .HasMaxLength(50)
                .HasColumnName("CopiedFromPropertyID");
            entity.Property(e => e.CopiedFromSource).HasMaxLength(50);
            entity.Property(e => e.CopiedOn).HasColumnType("datetime");
            entity.Property(e => e.DrugDataId).HasColumnName("DrugDataID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MakerName).HasMaxLength(100);
            entity.Property(e => e.Measurement).HasMaxLength(100);
            entity.Property(e => e.MeasurementUnit).HasMaxLength(100);
            entity.Property(e => e.ModelName).HasMaxLength(100);
            entity.Property(e => e.PrimaryColor).HasMaxLength(100);
            entity.Property(e => e.PropertyBarCode).HasMaxLength(100);
            entity.Property(e => e.PropertyCategoryId).HasColumnName("PropertyCategoryID");
            entity.Property(e => e.PropertyDetailXml)
                .HasColumnType("xml")
                .HasColumnName("PropertyDetailXML");
            entity.Property(e => e.PropertyFederalIdentification).HasMaxLength(100);
            entity.Property(e => e.PropertyNameId).HasColumnName("PropertyNameID");
            entity.Property(e => e.PropertyNcicidentification)
                .HasMaxLength(100)
                .HasColumnName("PropertyNCICIdentification");
            entity.Property(e => e.PropertySerialId)
                .HasMaxLength(100)
                .HasColumnName("PropertySerialID");
            entity.Property(e => e.PropertyValue).HasColumnType("money");
            entity.Property(e => e.QuantityUnit).HasMaxLength(100);
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Style).HasMaxLength(100);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Agency).WithMany(p => p.Mstrproperties)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.DrugData).WithMany(p => p.Mstrproperties)
                .HasForeignKey(d => d.DrugDataId)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_REFDRUGD");

            entity.HasOne(d => d.PropertyCategory).WithMany(p => p.MstrpropertyPropertyCategories)
                .HasForeignKey(d => d.PropertyCategoryId)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_REFPROPE2");

            entity.HasOne(d => d.PropertyName).WithMany(p => p.MstrpropertyPropertyNames)
                .HasForeignKey(d => d.PropertyNameId)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_REFPROPE");
        });

        modelBuilder.Entity<MstrpropertyDetail>(entity =>
        {
            entity.HasKey(e => e.MstrpropertyDetailId).HasName("PK_MSTRPROPERTYDETAIL");

            entity.ToTable("MSTRPropertyDetail");

            entity.HasIndex(e => e.Mppid, "IX_MSTRPropertyDetail_MPPID");

            entity.Property(e => e.MstrpropertyDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRPropertyDetailID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FirearmBarrelLength).HasMaxLength(100);
            entity.Property(e => e.Mppid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPID");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PlateRegistrationNumber).HasMaxLength(10);

            entity.HasOne(d => d.FirearmAutomaticIndicatorCodeNavigation).WithMany(p => p.MstrpropertyDetailFirearmAutomaticIndicatorCodeNavigations)
                .HasForeignKey(d => d.FirearmAutomaticIndicatorCode)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_REFMSTRI6");

            entity.HasOne(d => d.FirearmCaliberCodeNavigation).WithMany(p => p.MstrpropertyDetailFirearmCaliberCodeNavigations)
                .HasForeignKey(d => d.FirearmCaliberCode)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_REFMSTRI4");

            entity.HasOne(d => d.FirearmCategoryCodeNavigation).WithMany(p => p.MstrpropertyDetailFirearmCategoryCodeNavigations)
                .HasForeignKey(d => d.FirearmCategoryCode)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_REFMSTRI2");

            entity.HasOne(d => d.FirearmDestroyedIndicatorCodeNavigation).WithMany(p => p.MstrpropertyDetailFirearmDestroyedIndicatorCodeNavigations)
                .HasForeignKey(d => d.FirearmDestroyedIndicatorCode)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_REFMSTRI7");

            entity.HasOne(d => d.FirearmFinishCodeNavigation).WithMany(p => p.MstrpropertyDetailFirearmFinishCodeNavigations)
                .HasForeignKey(d => d.FirearmFinishCode)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_REFMSTRI5");

            entity.HasOne(d => d.FirearmMakeCodeNavigation).WithMany(p => p.MstrpropertyDetailFirearmMakeCodeNavigations)
                .HasForeignKey(d => d.FirearmMakeCode)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_REFMSTRI3");

            entity.HasOne(d => d.Mpp).WithMany(p => p.MstrpropertyDetails)
                .HasForeignKey(d => d.Mppid)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_MSTRPROP4");

            entity.HasOne(d => d.PlateRegistrationStateNavigation).WithMany(p => p.MstrpropertyDetailPlateRegistrationStateNavigations)
                .HasForeignKey(d => d.PlateRegistrationState)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_REFMSTRI8");

            entity.HasOne(d => d.PlateRegistrationTypeNavigation).WithMany(p => p.MstrpropertyDetailPlateRegistrationTypeNavigations)
                .HasForeignKey(d => d.PlateRegistrationType)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_REFMSTRI");
        });

        modelBuilder.Entity<MstrpropertyImage>(entity =>
        {
            entity.HasKey(e => e.MstrpropertyImageId).HasName("PK_MSTRPROPERTYIMAGES");

            entity.ToTable("MSTRPropertyImages");

            entity.HasIndex(e => e.Mppid, "IX_MSTRPropertyImages_MPPID");

            entity.HasIndex(e => new { e.SysrmsapplicationTypeId, e.ApplicationTypePk }, "IX_MSTRPropertyImages_SYSRMSApplicationTypeID_ApplicationTypePK");

            entity.Property(e => e.MstrpropertyImageId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRPropertyImageID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ImageContent).HasColumnType("image");
            entity.Property(e => e.ImageContentPath).HasMaxLength(300);
            entity.Property(e => e.Mppid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPID");
            entity.Property(e => e.SysrmsapplicationTypeId).HasColumnName("SYSRMSApplicationTypeID");

            entity.HasOne(d => d.Mpp).WithMany(p => p.MstrpropertyImages)
                .HasForeignKey(d => d.Mppid)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_MSTRPROP3");

            entity.HasOne(d => d.SysrmsapplicationType).WithMany(p => p.MstrpropertyImages)
                .HasForeignKey(d => d.SysrmsapplicationTypeId)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_SYSRMSAP");
        });

        modelBuilder.Entity<MstrpropertyOwner>(entity =>
        {
            entity.HasKey(e => e.MstrpropertyOwnerId).HasName("PK_MSTRPROPERTYOWNER");

            entity.ToTable("MSTRPropertyOwner");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "IX_MSTRPropertyOwner_ApplicationType_ApplicationTypePK");

            entity.HasIndex(e => e.Mppid, "IX_MSTRPropertyOwner_MPPID");

            entity.HasIndex(e => e.PropertyOwnerId, "IX_MSTRPropertyOwner_PropertyOwnerID");

            entity.Property(e => e.MstrpropertyOwnerId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRPropertyOwnerID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Mppid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPID");
            entity.Property(e => e.PropertyOrgOwnerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PropertyOrgOwnerID");
            entity.Property(e => e.PropertyOwnerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PropertyOwnerID");

            entity.HasOne(d => d.Mpp).WithMany(p => p.MstrpropertyOwners)
                .HasForeignKey(d => d.Mppid)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_MSTRPROP");

            entity.HasOne(d => d.PropertyOrgOwner).WithMany(p => p.MstrpropertyOwners)
                .HasForeignKey(d => d.PropertyOrgOwnerId)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_MSTRORGA");

            entity.HasOne(d => d.PropertyOwner).WithMany(p => p.MstrpropertyOwners)
                .HasForeignKey(d => d.PropertyOwnerId)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_MSTRPERS");
        });

        modelBuilder.Entity<MstrpropertyRelatedMedium>(entity =>
        {
            entity.HasKey(e => e.MpprelatedMediaId).HasName("PK_MSTRPROPERTYRELATEDMEDIA");

            entity.ToTable("MSTRPropertyRelatedMedia");

            entity.HasIndex(e => e.Mppid, "IX_MSTRPropertyRelatedMedia_MPPID");

            entity.Property(e => e.MpprelatedMediaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPRelatedMediaID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AddedOnCity).HasMaxLength(100);
            entity.Property(e => e.AddedOnState).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOnCity).HasMaxLength(100);
            entity.Property(e => e.EditedOnState).HasMaxLength(100);
            entity.Property(e => e.LinkedCentralOn).HasColumnType("datetime");
            entity.Property(e => e.LnkcentralMstrpropertyRelatedMedia)
                .HasMaxLength(50)
                .HasColumnName("LNKCentralMSTRPropertyRelatedMedia");
            entity.Property(e => e.MmediaInfoId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MMediaInfoID");
            entity.Property(e => e.Mppid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPID");
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.MmediaInfo).WithMany(p => p.MstrpropertyRelatedMedia)
                .HasForeignKey(d => d.MmediaInfoId)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_MSTRMEDI");

            entity.HasOne(d => d.Mpp).WithMany(p => p.MstrpropertyRelatedMedia)
                .HasForeignKey(d => d.Mppid)
                .HasConstraintName("FK_MSTRPROP_REFERENCE_MSTRPROP2");
        });

        modelBuilder.Entity<Mstrvehicle>(entity =>
        {
            entity.HasKey(e => e.Mvid)
                .HasName("PK_MSTR_VEHICLE")
                .IsClustered(false);

            entity.ToTable("MSTRVehicle");

            entity.Property(e => e.Mvid)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MVID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.CopiedFromSource).HasMaxLength(50);
            entity.Property(e => e.CopiedFromVehicleId)
                .HasMaxLength(50)
                .HasColumnName("CopiedFromVehicleID");
            entity.Property(e => e.CopiedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.LatestBackgroundCheckId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LatestBackgroundCheckID");
            entity.Property(e => e.NibrsdescriptionCode).HasColumnName("NIBRSDescriptionCode");
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.VehicleColorCode).HasMaxLength(50);
            entity.Property(e => e.VehicleDetailXml)
                .HasColumnType("xml")
                .HasColumnName("VehicleDetailXML");
            entity.Property(e => e.VehicleMakeCode).HasMaxLength(100);
            entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            entity.Property(e => e.VehicleStyleCode).HasMaxLength(50);
            entity.Property(e => e.VehicleUseCode).HasMaxLength(50);
            entity.Property(e => e.Vinnum)
                .HasMaxLength(50)
                .HasColumnName("VINNum");

            entity.HasOne(d => d.Agency).WithMany(p => p.Mstrvehicles)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_MSTRVEHI_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.LatestBackgroundCheck).WithMany(p => p.Mstrvehicles)
                .HasForeignKey(d => d.LatestBackgroundCheckId)
                .HasConstraintName("FK_MSTRVEHI_REFERENCE_TRXBACKG");

            entity.HasOne(d => d.NibrsdescriptionCodeNavigation).WithMany(p => p.Mstrvehicles)
                .HasForeignKey(d => d.NibrsdescriptionCode)
                .HasConstraintName("FK_MSTRVehicle_NIBRSReferenceData");

            entity.HasOne(d => d.VehicleBodyCategoryCodeNavigation).WithMany(p => p.Mstrvehicles)
                .HasForeignKey(d => d.VehicleBodyCategoryCode)
                .HasConstraintName("FK_MSTRVEHI_REFERENCE_REFMSTRI2");
        });

        modelBuilder.Entity<MstrvehicleRegOwner>(entity =>
        {
            entity.HasKey(e => e.MstrvehicleRegOwnerId).HasName("PK_MSTRVEHICLEREGOWNER");

            entity.ToTable("MSTRVehicleRegOwner");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "IX_MSTRVehicleRegOwner_ApplicationType_ApplicationTypePK");

            entity.HasIndex(e => e.VehicleOrgId, "IX_MSTRVehicleRegOwner_VehicleOrgID");

            entity.HasIndex(e => e.VehicleOwnerId, "IX_MSTRVehicleRegOwner_VehicleOwnerID");

            entity.HasIndex(e => new { e.Mvid, e.IsCurrentOwner }, "MSTRVehicleRegOwner_MI_R");

            entity.HasIndex(e => e.IsCurrentOwner, "NonClusteredIndex-20150519-182857");

            entity.Property(e => e.MstrvehicleRegOwnerId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRVehicleRegOwnerID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.CopiedFromSource).HasMaxLength(50);
            entity.Property(e => e.CopiedFromVehicleId)
                .HasMaxLength(50)
                .HasColumnName("CopiedFromVehicleID");
            entity.Property(e => e.CopiedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GeneratedByRmsuserQueryResultId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("GeneratedByRMSUserQueryResultID");
            entity.Property(e => e.Mvid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MVID");
            entity.Property(e => e.NonVerifiedOwnerPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NonVerifiedOwnerPersonID");
            entity.Property(e => e.RegExpire).HasColumnType("date");
            entity.Property(e => e.RegNum).HasMaxLength(50);
            entity.Property(e => e.VehicleOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("VehicleOrgID");
            entity.Property(e => e.VehicleOwnerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("VehicleOwnerID");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.MstrvehicleRegOwners)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_MSTRVEHI_REFERENCE_SYSRMSAP");

            entity.HasOne(d => d.Mv).WithMany(p => p.MstrvehicleRegOwners)
                .HasForeignKey(d => d.Mvid)
                .HasConstraintName("FK_MSTRVEHI_REFERENCE_MSTRVEHI");

            entity.HasOne(d => d.NonVerifiedOwnerPerson).WithMany(p => p.MstrvehicleRegOwners)
                .HasForeignKey(d => d.NonVerifiedOwnerPersonId)
                .HasConstraintName("FK_MSTRVEHI_REFERENCE_NONVERIF");

            entity.HasOne(d => d.RegStateNavigation).WithMany(p => p.MstrvehicleRegOwnerRegStateNavigations)
                .HasForeignKey(d => d.RegState)
                .HasConstraintName("FK_MSTRVEHI_REFERENCE_REFMSTRI3");

            entity.HasOne(d => d.RegTypeNavigation).WithMany(p => p.MstrvehicleRegOwnerRegTypeNavigations)
                .HasForeignKey(d => d.RegType)
                .HasConstraintName("FK_MSTRVEHI_REFERENCE_REFMSTRI");

            entity.HasOne(d => d.VehicleOrg).WithMany(p => p.MstrvehicleRegOwners)
                .HasForeignKey(d => d.VehicleOrgId)
                .HasConstraintName("FK_MSTRVEHI_REFERENCE_MSTRORGA");

            entity.HasOne(d => d.VehicleOwner).WithMany(p => p.MstrvehicleRegOwners)
                .HasForeignKey(d => d.VehicleOwnerId)
                .HasConstraintName("FK_MSTRVEHI_REFERENCE_MSTRPERS");
        });

        modelBuilder.Entity<MstrvehicleRelatedMedium>(entity =>
        {
            entity.HasKey(e => e.MvrelatedMediaId).HasName("PK_MSTRVEHICLERELATEDMEDIA");

            entity.ToTable("MSTRVehicleRelatedMedia");

            entity.HasIndex(e => e.Mvid, "IX_MSTRVehicleRelatedMedia_MVID");

            entity.Property(e => e.MvrelatedMediaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MVRelatedMediaID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AddedOnCity).HasMaxLength(100);
            entity.Property(e => e.AddedOnState).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOnCity).HasMaxLength(100);
            entity.Property(e => e.EditedOnState).HasMaxLength(100);
            entity.Property(e => e.LinkedCentralOn).HasColumnType("datetime");
            entity.Property(e => e.LnkmstrvehicleRelatedMedia)
                .HasMaxLength(50)
                .HasColumnName("LNKMSTRVehicleRelatedMedia");
            entity.Property(e => e.MmediaInfoId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MMediaInfoID");
            entity.Property(e => e.Mvid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MVID");
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.MmediaInfo).WithMany(p => p.MstrvehicleRelatedMedia)
                .HasForeignKey(d => d.MmediaInfoId)
                .HasConstraintName("FK_MSTRVEHI_REFERENCE_MSTRMEDI");

            entity.HasOne(d => d.Mv).WithMany(p => p.MstrvehicleRelatedMedia)
                .HasForeignKey(d => d.Mvid)
                .HasConstraintName("FK_CENTRALM_REFERENCE_CENTRALM23");
        });

        modelBuilder.Entity<MstrvehicleStatus>(entity =>
        {
            entity.HasKey(e => e.MstrvehicleStatusId).HasName("PK_MSTRVEHICLESTATUS");

            entity.ToTable("MSTRVehicleStatus");

            entity.HasIndex(e => e.Mvid, "IX_MSTRVehicleStatus_MVID");

            entity.HasIndex(e => e.StatusLocationId, "IX_MSTRVehicleStatus_StatusLocationID");

            entity.Property(e => e.MstrvehicleStatusId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRVehicleStatusID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Mvid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MVID");
            entity.Property(e => e.StatusLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("StatusLocationID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Mv).WithMany(p => p.MstrvehicleStatuses)
                .HasForeignKey(d => d.Mvid)
                .HasConstraintName("FK_MSTRVEHI_REFERENCE_MSTRVEHI2");

            entity.HasOne(d => d.StatusLocation).WithMany(p => p.MstrvehicleStatuses)
                .HasForeignKey(d => d.StatusLocationId)
                .HasConstraintName("FK_MSTRVEHI_REFERENCE_MSTRLOCA");

            entity.HasOne(d => d.VehicleStatusCodeNavigation).WithMany(p => p.MstrvehicleStatuses)
                .HasForeignKey(d => d.VehicleStatusCode)
                .HasConstraintName("FK_MSTRVEHI_REFERENCE_REFMSTRI4");
        });

        modelBuilder.Entity<NibrsexportHistory>(entity =>
        {
            entity.ToTable("NIBRSExportHistory");

            entity.Property(e => e.NibrsexportHistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NIBRSExportHistoryID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Department).WithMany(p => p.NibrsexportHistories)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_Departments_NIBRSExportHistory");
        });

        modelBuilder.Entity<NibrsreferenceDatum>(entity =>
        {
            entity.HasKey(e => e.NibrsreferenceDataId);

            entity.ToTable("NIBRSReferenceData");

            entity.Property(e => e.NibrsreferenceDataId).HasColumnName("NIBRSReferenceDataID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.DataElement).HasMaxLength(10);
            entity.Property(e => e.DataValue).HasMaxLength(10);
            entity.Property(e => e.DisplayString).HasMaxLength(500);
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.RefCategory).HasMaxLength(100);
            entity.Property(e => e.Segment).HasMaxLength(100);
            entity.Property(e => e.SubCategory).HasMaxLength(100);
        });

        modelBuilder.Entity<NibrsreportAdmin>(entity =>
        {
            entity.ToTable("NIBRSReportAdmin");

            entity.HasIndex(e => e.IncidentId, "IX_NIBRSReportAdmin_IncidentId");

            entity.HasIndex(e => e.PrimaryIncidentId, "IX_NIBRSReportAdmin_PrimaryIncidentId");

            entity.Property(e => e.NibrsreportAdminId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NIBRSReportAdminID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ClearanceDate).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.ExportDate).HasColumnType("datetime");
            entity.Property(e => e.IncidentId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastExportDate).HasColumnType("datetime");
            entity.Property(e => e.PrimaryIncidentId).HasColumnType("numeric(18, 0)");

            entity.HasOne(d => d.ClearanceCodeNavigation).WithMany(p => p.NibrsreportAdmins)
                .HasForeignKey(d => d.ClearanceCode)
                .HasConstraintName("FK_NIBRSReportAdmin_NIBRSReferenceData");

            entity.HasOne(d => d.Incident).WithMany(p => p.NibrsreportAdminIncidents)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_NIBRSReportAdmin_IncidentId");

            entity.HasOne(d => d.PrimaryIncident).WithMany(p => p.NibrsreportAdminPrimaryIncidents)
                .HasForeignKey(d => d.PrimaryIncidentId)
                .HasConstraintName("FK_NIBRSReportAdmin_PrimaryIncidentId");
        });

        modelBuilder.Entity<NibrsreportOffense>(entity =>
        {
            entity.ToTable("NIBRSReportOffense", tb => tb.HasTrigger("trg_NIBRSReportOffense_IUD"));

            entity.HasIndex(e => e.Nibrscode, "IX_NIBRSReportOffense_NIBRSCode");

            entity.HasIndex(e => e.NibrsreportAdminId, "IX_NIBRSReportOffense_NIBRSReportAdminID");

            entity.Property(e => e.NibrsreportOffenseId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NIBRSReportOffenseID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.BiasMotivationCode).HasColumnType("xml");
            entity.Property(e => e.CriminalActivity).HasColumnType("xml");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.Nibrscode).HasColumnName("NIBRSCode");
            entity.Property(e => e.NibrsreportAdminId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NIBRSReportAdminID");
            entity.Property(e => e.OffenseAc).HasColumnName("OffenseAC");
            entity.Property(e => e.SuspectedofUsing).HasColumnType("xml");
            entity.Property(e => e.WeaponForce).HasColumnType("xml");

            entity.HasOne(d => d.EntryMethodNavigation).WithMany(p => p.NibrsreportOffenseEntryMethodNavigations)
                .HasForeignKey(d => d.EntryMethod)
                .HasConstraintName("FK_NIBRSReportOffense_EntryMethod");

            entity.HasOne(d => d.LocationTypeCodeNavigation).WithMany(p => p.NibrsreportOffenseLocationTypeCodeNavigations)
                .HasForeignKey(d => d.LocationTypeCode)
                .HasConstraintName("FK_NIBRSReportOffense_LocationTypeCode");

            entity.HasOne(d => d.NibrscodeNavigation).WithMany(p => p.NibrsreportOffenses)
                .HasForeignKey(d => d.Nibrscode)
                .HasConstraintName("FK_NIBRSReportOffense_NIBRSCode");

            entity.HasOne(d => d.NibrsreportAdmin).WithMany(p => p.NibrsreportOffenses)
                .HasForeignKey(d => d.NibrsreportAdminId)
                .HasConstraintName("FK_NIBRSReportOffense_NIBRSReportAdminID");

            entity.HasOne(d => d.OffenseAcNavigation).WithMany(p => p.NibrsreportOffenseOffenseAcNavigations)
                .HasForeignKey(d => d.OffenseAc)
                .HasConstraintName("FK_NIBRSReportOffense_OffenseAC");
        });

        modelBuilder.Entity<NibrsreportPerson>(entity =>
        {
            entity.HasKey(e => e.NibrsreportPersonsId);

            entity.ToTable("NIBRSReportPersons", tb => tb.HasTrigger("VerifyArresteeOnInsertUpdate"));

            entity.HasIndex(e => e.IncidentPersonInvolvementId, "IX_NIBRSReportPersons_IncidentPersonInvolvementID");

            entity.HasIndex(e => e.IncidentOrganizationInvolvementId, "IX_NIBRSReportPersons_Incident_OrganizationInvolvementID");

            entity.HasIndex(e => e.Moid, "IX_NIBRSReportPersons_MOID");

            entity.HasIndex(e => e.Mpid, "IX_NIBRSReportPersons_MPID");

            entity.HasIndex(e => e.NibrsreportAdminId, "IX_NIBRSReportPersons_NIBRSReportAdminID");

            entity.Property(e => e.NibrsreportPersonsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NIBRSReportPersonsID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.Adisposition).HasColumnName("ADisposition");
            entity.Property(e => e.AmultipleArrest).HasColumnName("AMultipleArrest");
            entity.Property(e => e.AoffenseCode).HasColumnName("AOffenseCode");
            entity.Property(e => e.Atype).HasColumnName("AType");
            entity.Property(e => e.Aweapon)
                .HasColumnType("xml")
                .HasColumnName("AWeapon");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.IncidentOrganizationInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Incident_OrganizationInvolvementID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.IsInvolvementAddedByQa).HasColumnName("IsInvolvementAddedByQA");
            entity.Property(e => e.IsLeofromOtherJurisdiction).HasColumnName("IsLEOfromOtherJurisdiction");
            entity.Property(e => e.Moid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MOID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.NibrsreportAdminId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NIBRSReportAdminID");
            entity.Property(e => e.UnknownPersonAge).HasColumnType("xml");
            entity.Property(e => e.Vcircumstances)
                .HasColumnType("xml")
                .HasColumnName("VCircumstances");
            entity.Property(e => e.VcircumstancesAdditional).HasColumnName("VCircumstancesAdditional");
            entity.Property(e => e.VinjuryCode)
                .HasColumnType("xml")
                .HasColumnName("VInjuryCode");
            entity.Property(e => e.VofficerActivity).HasColumnName("VOfficerActivity");
            entity.Property(e => e.VofficerAssignment).HasColumnName("VOfficerAssignment");
            entity.Property(e => e.VotherOfficerOri)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("VOtherOfficerORI");
            entity.Property(e => e.VrelatedOffender)
                .HasColumnType("xml")
                .HasColumnName("VRelatedOffender");
            entity.Property(e => e.VrelatedOffenseCode)
                .HasColumnType("xml")
                .HasColumnName("VRelatedOffenseCode");
            entity.Property(e => e.Vtype).HasColumnName("VType");

            entity.HasOne(d => d.AdispositionNavigation).WithMany(p => p.NibrsreportPersonAdispositionNavigations)
                .HasForeignKey(d => d.Adisposition)
                .HasConstraintName("FK_NIBRSReportPersons_ADisposition");

            entity.HasOne(d => d.AmultipleArrestNavigation).WithMany(p => p.NibrsreportPersonAmultipleArrestNavigations)
                .HasForeignKey(d => d.AmultipleArrest)
                .HasConstraintName("FK_NIBRSReportPersons_AMultipleArrest");

            entity.HasOne(d => d.AtypeNavigation).WithMany(p => p.NibrsreportPersonAtypeNavigations)
                .HasForeignKey(d => d.Atype)
                .HasConstraintName("FK_NIBRSReportPersons_AType");

            entity.HasOne(d => d.EthnicityCodeNavigation).WithMany(p => p.NibrsreportPersonEthnicityCodeNavigations)
                .HasForeignKey(d => d.EthnicityCode)
                .HasConstraintName("FK_NIBRSReportPersons_EthnicityCode");

            entity.HasOne(d => d.IncidentOrganizationInvolvement).WithMany(p => p.NibrsreportPeople)
                .HasForeignKey(d => d.IncidentOrganizationInvolvementId)
                .HasConstraintName("FK_NIBRSReportPersons_Incident_OrganizationInvolvement");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.NibrsreportPeople)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_NIBRSReportPersons_IncidentPersonInvolvement");

            entity.HasOne(d => d.Mo).WithMany(p => p.NibrsreportPeople)
                .HasForeignKey(d => d.Moid)
                .HasConstraintName("FK_NIBRSReportPersons_MSTROrganization");

            entity.HasOne(d => d.Mp).WithMany(p => p.NibrsreportPeople)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_NIBRSReportPersons_MSTRPerson");

            entity.HasOne(d => d.NibrsreportAdmin).WithMany(p => p.NibrsreportPeople)
                .HasForeignKey(d => d.NibrsreportAdminId)
                .HasConstraintName("FK_NIBRSReportPersons_NIBRSReportAdminID");

            entity.HasOne(d => d.RaceCodeNavigation).WithMany(p => p.NibrsreportPersonRaceCodeNavigations)
                .HasForeignKey(d => d.RaceCode)
                .HasConstraintName("FK_NIBRSReportPersons_RaceCode");

            entity.HasOne(d => d.ResidentStatusCodeNavigation).WithMany(p => p.NibrsreportPersonResidentStatusCodeNavigations)
                .HasForeignKey(d => d.ResidentStatusCode)
                .HasConstraintName("FK_NIBRSReportPersons_ResidentStatusCode");

            entity.HasOne(d => d.SexCodeNavigation).WithMany(p => p.NibrsreportPersonSexCodeNavigations)
                .HasForeignKey(d => d.SexCode)
                .HasConstraintName("FK_NIBRSReportPersons_SexCode");

            entity.HasOne(d => d.VcircumstancesAdditionalNavigation).WithMany(p => p.NibrsreportPersonVcircumstancesAdditionalNavigations)
                .HasForeignKey(d => d.VcircumstancesAdditional)
                .HasConstraintName("FK_NIBRSReportPersons_VCircumstancesAdditional");

            entity.HasOne(d => d.VofficerActivityNavigation).WithMany(p => p.NibrsreportPersonVofficerActivityNavigations)
                .HasForeignKey(d => d.VofficerActivity)
                .HasConstraintName("FK_NIBRSReportPersons_VOfficerActivity");

            entity.HasOne(d => d.VofficerAssignmentNavigation).WithMany(p => p.NibrsreportPersonVofficerAssignmentNavigations)
                .HasForeignKey(d => d.VofficerAssignment)
                .HasConstraintName("FK_NIBRSReportPersons_VOfficerAssignment");

            entity.HasOne(d => d.VtypeNavigation).WithMany(p => p.NibrsreportPersonVtypeNavigations)
                .HasForeignKey(d => d.Vtype)
                .HasConstraintName("FK_NIBRSReportPersons_VType");
        });

        modelBuilder.Entity<NibrsreportProperty>(entity =>
        {
            entity.ToTable("NIBRSReportProperty");

            entity.HasIndex(e => e.NibrsreportAdminId, "IX_NIBRSReportProperty_NIBRSReportAdminID");

            entity.Property(e => e.NibrsreportPropertyId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NIBRSReportPropertyID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.NibrsreportAdminId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NIBRSReportAdminID");

            entity.HasOne(d => d.NibrsreportAdmin).WithMany(p => p.NibrsreportProperties)
                .HasForeignKey(d => d.NibrsreportAdminId)
                .HasConstraintName("FK_NIBRSReportProperty_NIBRSReportAdminID");

            entity.HasOne(d => d.PropertyLossCodeNavigation).WithMany(p => p.NibrsreportProperties)
                .HasForeignKey(d => d.PropertyLossCode)
                .HasConstraintName("FK_NIBRSReportProperty_PropertyLossCode");
        });

        modelBuilder.Entity<NibrsreportPropertyDetail>(entity =>
        {
            entity.ToTable("NIBRSReportPropertyDetail");

            entity.HasIndex(e => e.NibrsreportPropertyId, "IX_NIBRSReportPropertyDetail_NIBRSReportPropertyID");

            entity.Property(e => e.NibrsreportPropertyDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NIBRSReportPropertyDetailID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.DrugCode).HasColumnType("xml");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.NibrsreportPropertyId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NIBRSReportPropertyID");
            entity.Property(e => e.NumRecoveredMv).HasColumnName("NumRecoveredMV");
            entity.Property(e => e.NumStolenMv).HasColumnName("NumStolenMV");
            entity.Property(e => e.PropertyValue).HasColumnType("money");
            entity.Property(e => e.RecoveredDate).HasColumnType("datetime");

            entity.HasOne(d => d.NibrsreportProperty).WithMany(p => p.NibrsreportPropertyDetails)
                .HasForeignKey(d => d.NibrsreportPropertyId)
                .HasConstraintName("FK_NIBRSReportPropertyDetail_NIBRSReportPropertyID");

            entity.HasOne(d => d.PropertyDescriptionCodeNavigation).WithMany(p => p.NibrsreportPropertyDetails)
                .HasForeignKey(d => d.PropertyDescriptionCode)
                .HasConstraintName("FK_NIBRSReportPropertyDetail_PropertyDescriptionCode");
        });

        modelBuilder.Entity<NonVerifiedCallPerson>(entity =>
        {
            entity.HasKey(e => e.ServiceCallPersonId).HasName("PK_NONVERIFIEDCALLPERSON");

            entity.ToTable("NonVerifiedCallPerson");

            entity.HasIndex(e => e.LinkedMpid, "IX_NonVerifiedCallPerson_LinkedMPID");

            entity.HasIndex(e => e.ResidentialAddress, "IX_NonVerifiedCallPerson_ResidentialAddress");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationTypePk }, "NonClusteredIndex-20150519-183310");

            entity.HasIndex(e => e.ServiceCallId, "ServiceCallIDINX");

            entity.Property(e => e.ServiceCallPersonId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ServiceCallPersonID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.CadpersonId).HasColumnName("CADPersonID");
            entity.Property(e => e.CallBackPhoneNumber).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.GeneratedByRmsuserQueryResultId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("GeneratedByRMSUserQueryResultID");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LinkedMpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LinkedMPID");
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Oln)
                .HasMaxLength(50)
                .HasColumnName("OLN");
            entity.Property(e => e.Olnstate)
                .HasMaxLength(50)
                .HasColumnName("OLNState");
            entity.Property(e => e.PersonType).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.ResidentialAddress).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ServiceCallId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ServiceCallID");
            entity.Property(e => e.SexCodeId).HasColumnName("SexCodeID");
            entity.Property(e => e.Source).HasMaxLength(50);

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.NonVerifiedCallPeople)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_NonVerifiedCallPerson_RMSApplication");

            entity.HasOne(d => d.LinkedMp).WithMany(p => p.NonVerifiedCallPeople)
                .HasForeignKey(d => d.LinkedMpid)
                .HasConstraintName("FK_NONVERIF_REFERENCE_MSTRPERS");

            entity.HasOne(d => d.ResidentialAddressNavigation).WithMany(p => p.NonVerifiedCallPeople)
                .HasForeignKey(d => d.ResidentialAddress)
                .HasConstraintName("FK_NONVERIF_REFERENCE_MSTRLOCA");

            entity.HasOne(d => d.ServiceCall).WithMany(p => p.NonVerifiedCallPeople)
                .HasForeignKey(d => d.ServiceCallId)
                .HasConstraintName("FK_SERVICEC_REFERENCE_SERVICECee");

            entity.HasOne(d => d.SexCode).WithMany(p => p.NonVerifiedCallPeople)
                .HasForeignKey(d => d.SexCodeId)
                .HasConstraintName("FK_NONVERIF_REFERENCE_REFMSTRI");
        });

        modelBuilder.Entity<NonVerifiedCallVehicle>(entity =>
        {
            entity.HasKey(e => e.ServiceCallVehicleId).HasName("PK_NONVERIFIEDCALLVEHICLE");

            entity.ToTable("NonVerifiedCallVehicle");

            entity.HasIndex(e => e.ServiceCallId, "ServiceCallIDINX");

            entity.Property(e => e.ServiceCallVehicleId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ServiceCallVehicleID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CadvehicleId).HasColumnName("CADVehicleID");
            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.Make).HasMaxLength(100);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.Regnum)
                .HasMaxLength(100)
                .HasColumnName("REGNum");
            entity.Property(e => e.Regstate)
                .HasMaxLength(50)
                .HasColumnName("REGState");
            entity.Property(e => e.Regtype)
                .HasMaxLength(50)
                .HasColumnName("REGType");
            entity.Property(e => e.Regyear).HasColumnName("REGYear");
            entity.Property(e => e.ServiceCallId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ServiceCallID");
            entity.Property(e => e.Source).HasMaxLength(50);
            entity.Property(e => e.Style).HasMaxLength(50);
            entity.Property(e => e.Vinnum)
                .HasMaxLength(50)
                .HasColumnName("VINNum");

            entity.HasOne(d => d.ServiceCall).WithMany(p => p.NonVerifiedCallVehicles)
                .HasForeignKey(d => d.ServiceCallId)
                .HasConstraintName("FK_SERVICEC_REFERENCE_SERVICECtt");
        });

        modelBuilder.Entity<NotificationMethod>(entity =>
        {
            entity.HasKey(e => e.NotificationMethodId).HasName("PK_NOTIFICATIONMETHODS");

            entity.HasIndex(e => e.DepartmentEmployeeId, "IX_NotificationMethods_DepartmentEmployeeID");

            entity.HasIndex(e => e.DirectoryContactId, "IX_NotificationMethods_DirectoryContactID");

            entity.Property(e => e.NotificationMethodId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NotificationMethodID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.DirectoryContactId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DirectoryContactID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.TypeData).HasMaxLength(50);

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.NotificationMethods)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK_NOTIFICA_REFERENCE_DEPARTME");

            entity.HasOne(d => d.DirectoryContact).WithMany(p => p.NotificationMethods)
                .HasForeignKey(d => d.DirectoryContactId)
                .HasConstraintName("FK_NOTIFICA_REFERENCE_DIRECTOR");

            entity.HasOne(d => d.NotificationTypeCodeNavigation).WithMany(p => p.NotificationMethods)
                .HasForeignKey(d => d.NotificationTypeCode)
                .HasConstraintName("FK_NOTIFICA_REFERENCE_REFMSTRI");
        });

        modelBuilder.Entity<Offense>(entity =>
        {
            entity.HasKey(e => e.OffenseId).HasName("PK_OFFENSE");

            entity.ToTable("Offense");

            entity.HasIndex(e => e.ArrestBookingId, "Offense_ArrestBookingID");

            entity.HasIndex(e => e.SummonsInfractionId, "Offense_SummonsInfractionID_U");

            entity.HasIndex(e => e.Uarnumber, "Offense_UARNumber_A");

            entity.Property(e => e.OffenseId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OffenseID");
            entity.Property(e => e.AclflagCode).HasColumnName("ACLFlagCode");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ArrestBookingId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArrestBookingID");
            entity.Property(e => e.CdCcswitch).HasColumnName("cdCCSwitch");
            entity.Property(e => e.CdChargeNumber).HasColumnName("cdChargeNumber");
            entity.Property(e => e.CdConditionalDischargeTerm).HasColumnName("cdConditionalDischargeTerm");
            entity.Property(e => e.CdConditionalDischargeType).HasColumnName("cdConditionalDischargeType");
            entity.Property(e => e.CdDocketNumber)
                .HasMaxLength(20)
                .HasColumnName("cdDocketNumber");
            entity.Property(e => e.CdDvindicator)
                .HasMaxLength(10)
                .HasColumnName("cdDVIndicator");
            entity.Property(e => e.CdFineAmount)
                .HasColumnType("money")
                .HasColumnName("cdFineAmount");
            entity.Property(e => e.CdFineRemitted)
                .HasColumnType("money")
                .HasColumnName("cdFineRemitted");
            entity.Property(e => e.CdJailTerm).HasColumnName("cdJailTerm");
            entity.Property(e => e.CdJailType).HasColumnName("cdJailType");
            entity.Property(e => e.CdOtherFeesAmount)
                .HasColumnType("money")
                .HasColumnName("cdOtherFeesAmount");
            entity.Property(e => e.CdPlea).HasColumnName("cdPlea");
            entity.Property(e => e.CdProbationTerm).HasColumnName("cdProbationTerm");
            entity.Property(e => e.CdProbationType).HasColumnName("cdProbationType");
            entity.Property(e => e.CdRecordNumber).HasColumnName("cdRecordNumber");
            entity.Property(e => e.CdRefstatuteDefinition).HasColumnName("cdREFStatuteDefinition");
            entity.Property(e => e.CdSpecialParoleTerm).HasColumnName("cdSpecialParoleTerm");
            entity.Property(e => e.CdSpecialParoleType).HasColumnName("cdSpecialParoleType");
            entity.Property(e => e.CdStatuteCax)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteCAX");
            entity.Property(e => e.CdStatuteClass)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteClass");
            entity.Property(e => e.CdStatuteCode)
                .HasMaxLength(200)
                .HasColumnName("cdStatuteCode");
            entity.Property(e => e.CdStatuteCount).HasColumnName("cdStatuteCount");
            entity.Property(e => e.CdStatuteDescription).HasColumnName("cdStatuteDescription");
            entity.Property(e => e.CdStatuteType)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteType");
            entity.Property(e => e.CdSuspendedJailTerm).HasColumnName("cdSuspendedJailTerm");
            entity.Property(e => e.CdSuspendedJailType).HasColumnName("cdSuspendedJailType");
            entity.Property(e => e.CdTimeServed)
                .HasMaxLength(10)
                .HasColumnName("cdTimeServed");
            entity.Property(e => e.CdVerdictFinding).HasColumnName("cdVerdictFinding");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NibrscodeId).HasColumnName("NIBRSCodeID");
            entity.Property(e => e.RefstatuteDefinition).HasColumnName("REFStatuteDefinition");
            entity.Property(e => e.SummonsInfractionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SummonsInfractionID");
            entity.Property(e => e.Uarnumber)
                .HasMaxLength(20)
                .HasColumnName("UARNumber");
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.AclflagCodeNavigation).WithMany(p => p.OffenseAclflagCodeNavigations)
                .HasForeignKey(d => d.AclflagCode)
                .HasConstraintName("FK_OFFENSE_REFERENCE_REFINCID2");

            entity.HasOne(d => d.ArrestBooking).WithMany(p => p.Offenses)
                .HasForeignKey(d => d.ArrestBookingId)
                .HasConstraintName("FK_OFFENSE_REFERENCE_ARRESTBO");

            entity.HasOne(d => d.CdCcswitchNavigation).WithMany(p => p.OffenseCdCcswitchNavigations)
                .HasForeignKey(d => d.CdCcswitch)
                .HasConstraintName("FK_OFFENSE_REFERENCE_REFINCID");

            entity.HasOne(d => d.CdConditionalDischargeTypeNavigation).WithMany(p => p.OffenseCdConditionalDischargeTypeNavigations)
                .HasForeignKey(d => d.CdConditionalDischargeType)
                .HasConstraintName("FK_OFFENSE_REFERENCE_REFINCID9");

            entity.HasOne(d => d.CdJailTypeNavigation).WithMany(p => p.OffenseCdJailTypeNavigations)
                .HasForeignKey(d => d.CdJailType)
                .HasConstraintName("FK_OFFENSE_REFERENCE_REFINCID5");

            entity.HasOne(d => d.CdPleaNavigation).WithMany(p => p.OffenseCdPleaNavigations)
                .HasForeignKey(d => d.CdPlea)
                .HasConstraintName("FK_OFFENSE_REFERENCE_REFINCID3");

            entity.HasOne(d => d.CdProbationTypeNavigation).WithMany(p => p.OffenseCdProbationTypeNavigations)
                .HasForeignKey(d => d.CdProbationType)
                .HasConstraintName("FK_OFFENSE_REFERENCE_REFINCID7");

            entity.HasOne(d => d.CdRefstatuteDefinitionNavigation).WithMany(p => p.OffenseCdRefstatuteDefinitionNavigations)
                .HasForeignKey(d => d.CdRefstatuteDefinition)
                .HasConstraintName("FK_OFFENSE_REFERENCE_REFSTATU");

            entity.HasOne(d => d.CdSpecialParoleTypeNavigation).WithMany(p => p.OffenseCdSpecialParoleTypeNavigations)
                .HasForeignKey(d => d.CdSpecialParoleType)
                .HasConstraintName("FK_OFFENSE_REFERENCE_REFINCID8");

            entity.HasOne(d => d.CdSuspendedJailTypeNavigation).WithMany(p => p.OffenseCdSuspendedJailTypeNavigations)
                .HasForeignKey(d => d.CdSuspendedJailType)
                .HasConstraintName("FK_OFFENSE_REFERENCE_REFINCID6");

            entity.HasOne(d => d.CdVerdictFindingNavigation).WithMany(p => p.OffenseCdVerdictFindingNavigations)
                .HasForeignKey(d => d.CdVerdictFinding)
                .HasConstraintName("FK_OFFENSE_REFERENCE_REFINCID4");

            entity.HasOne(d => d.Department).WithMany(p => p.Offenses)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_OFFENSE_REFERENCE_DEPARTME");

            entity.HasOne(d => d.Nibrscode).WithMany(p => p.Offenses)
                .HasForeignKey(d => d.NibrscodeId)
                .HasConstraintName("FK_Offense_RefNIBRSCodeDefinition");

            entity.HasOne(d => d.RefstatuteDefinitionNavigation).WithMany(p => p.OffenseRefstatuteDefinitionNavigations)
                .HasForeignKey(d => d.RefstatuteDefinition)
                .HasConstraintName("FK_OFFENSE_REFERENCE_REFSTATU2");

            entity.HasOne(d => d.SummonsInfraction).WithMany(p => p.Offenses)
                .HasForeignKey(d => d.SummonsInfractionId)
                .HasConstraintName("FK_OFFENSE_REFERENCE_SUMMONSI");

            entity.HasOne(d => d.Ucrcode).WithMany(p => p.Offenses)
                .HasForeignKey(d => d.UcrcodeId)
                .HasConstraintName("FK_Offense_RefUCRCodeDefinition");
        });

        modelBuilder.Entity<OldcgsmappingtoNibr>(entity =>
        {
            entity.HasKey(e => e.CgsmappingtoNibrsid).HasName("PK_CGSMappingToNIBRS");

            entity.ToTable("OLDCGSMappingtoNIBRS");

            entity.Property(e => e.CgsmappingtoNibrsid)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CGSMappingtoNIBRSID");
            entity.Property(e => e.EffectiveDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GrName).HasMaxLength(50);
            entity.Property(e => e.MultiNibrs).HasColumnName("MultiNIBRS");
            entity.Property(e => e.MultiUcr).HasColumnName("MultiUCR");
            entity.Property(e => e.Nibrscode)
                .HasMaxLength(10)
                .HasColumnName("NIBRSCode");
            entity.Property(e => e.OffenseClass).HasMaxLength(100);
            entity.Property(e => e.OffenseType).HasMaxLength(100);
            entity.Property(e => e.RepealDate).HasColumnType("datetime");
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(10)
                .HasColumnName("UCRCode");
        });

        modelBuilder.Entity<PhotoLineup>(entity =>
        {
            entity.ToTable("PhotoLineup");

            entity.HasIndex(e => e.IncidentId, "IX_PhotoLineup_IncidentID");

            entity.HasIndex(e => e.IncidentPersonInvolvementId, "IX_PhotoLineup_IncidentPersonInvolvementID");

            entity.HasIndex(e => e.PrimaryIncidentId, "IX_PhotoLineup_PrimaryIncidentID");

            entity.Property(e => e.PhotoLineupId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PhotoLineupID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.PhotoLineupNumber).HasMaxLength(50);
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");

            entity.HasOne(d => d.Incident).WithMany(p => p.PhotoLineupIncidents)
                .HasForeignKey(d => d.IncidentId)
                .HasConstraintName("FK_PhotoLineup_Incident");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.PhotoLineups)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_PhotoLineup_Incident_PersonInvolvement");

            entity.HasOne(d => d.PrimaryIncident).WithMany(p => p.PhotoLineupPrimaryIncidents)
                .HasForeignKey(d => d.PrimaryIncidentId)
                .HasConstraintName("FK_PhotoLineup_Incident1");

            entity.HasOne(d => d.Status).WithMany(p => p.PhotoLineups)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_PhotoLineup_SysApplicationStatus");
        });

        modelBuilder.Entity<PhotoLineupPhoto>(entity =>
        {
            entity.HasKey(e => e.PhotoLineupPhotoId).HasName("PK_PhotoLineup_Photos");

            entity.HasIndex(e => e.PhotoLineupId, "IX_PhotoLineupPhotos_PhotoLineupID");

            entity.Property(e => e.PhotoLineupPhotoId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PhotoLineupPhotoID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.CaseNumber).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.PersonName).HasMaxLength(100);
            entity.Property(e => e.PhotoLineupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PhotoLineupID");
            entity.Property(e => e.Source).HasMaxLength(50);

            entity.HasOne(d => d.Department).WithMany(p => p.PhotoLineupPhotos)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_PhotoLineupPhotos_Departments");

            entity.HasOne(d => d.PhotoLineup).WithMany(p => p.PhotoLineupPhotos)
                .HasForeignKey(d => d.PhotoLineupId)
                .HasConstraintName("FK_PhotoLineupPhotos_PhotoLineup");
        });

        modelBuilder.Entity<PhotoLineupSequence>(entity =>
        {
            entity.ToTable("PhotoLineupSequence");

            entity.HasIndex(e => e.PhotoLineupPhotoId, "IX_PhotoLineupSequence_PhotoLineupPhotoID");

            entity.HasIndex(e => e.PhotoLineupViewerId, "IX_PhotoLineupSequence_PhotoLineupViewerID");

            entity.Property(e => e.PhotoLineupSequenceId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PhotoLineupSequenceID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.PhotoLineupPhotoId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PhotoLineupPhotoID");
            entity.Property(e => e.PhotoLineupViewerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PhotoLineupViewerID");

            entity.HasOne(d => d.PhotoLineupPhoto).WithMany(p => p.PhotoLineupSequences)
                .HasForeignKey(d => d.PhotoLineupPhotoId)
                .HasConstraintName("FK_PhotoLineupSequence_PhotoLineupPhotos");

            entity.HasOne(d => d.PhotoLineupViewer).WithMany(p => p.PhotoLineupSequences)
                .HasForeignKey(d => d.PhotoLineupViewerId)
                .HasConstraintName("FK_PhotoLineupSequence_PhotoLineupViewer");
        });

        modelBuilder.Entity<PhotoLineupViewer>(entity =>
        {
            entity.ToTable("PhotoLineupViewer");

            entity.HasIndex(e => e.IncidentPersonInvolvementId, "IX_PhotoLineupViewer_IncidentPersonInvolvementID");

            entity.HasIndex(e => e.PhotoLineupId, "IX_PhotoLineupViewer_PhotoLineupID");

            entity.HasIndex(e => e.PhotoLineupSequenceId, "IX_PhotoLineupViewer_PhotoLineupSequenceID");

            entity.HasIndex(e => e.SelectedPhotoId, "IX_PhotoLineupViewer_SelectedPhotoID");

            entity.Property(e => e.PhotoLineupViewerId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PhotoLineupViewerID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.PhotoLineupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PhotoLineupID");
            entity.Property(e => e.PhotoLineupSequenceId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PhotoLineupSequenceID");
            entity.Property(e => e.SelectedPhotoId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SelectedPhotoID");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.PhotoLineupViewers)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_PhotoLineupViewer_Incident_PersonInvolvement");

            entity.HasOne(d => d.PhotoLineup).WithMany(p => p.PhotoLineupViewers)
                .HasForeignKey(d => d.PhotoLineupId)
                .HasConstraintName("FK_PhotoLineupViewer_PhotoLineup");

            entity.HasOne(d => d.PhotoLineupSequence).WithMany(p => p.PhotoLineupViewers)
                .HasForeignKey(d => d.PhotoLineupSequenceId)
                .HasConstraintName("FK_PhotoLineupViewer_PhotoLineupSequence");

            entity.HasOne(d => d.SelectedPhoto).WithMany(p => p.PhotoLineupViewers)
                .HasForeignKey(d => d.SelectedPhotoId)
                .HasConstraintName("FK_PhotoLineupViewer_PhotoLineupPhotos");
        });

        modelBuilder.Entity<PistolPermit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PistolPermit");

            entity.Property(e => e.Comment)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.DateIssued).HasMaxLength(255);
            entity.Property(e => e.DateSent).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.IncidentDate).HasColumnType("datetime");
            entity.Property(e => e.IncidentNumber).HasMaxLength(255);
            entity.Property(e => e.IsImported)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.OtherDate).HasMaxLength(255);
            entity.Property(e => e.Permit).HasColumnName("Permit#");
            entity.Property(e => e.ResponseDate1).HasMaxLength(255);
            entity.Property(e => e.ResponseDate2).HasMaxLength(255);
            entity.Property(e => e.TempPermit).HasColumnName("TempPermit#");
        });

        modelBuilder.Entity<Postarea>(entity =>
        {
            entity.ToTable("POSTArea");

            entity.HasIndex(e => e.PostareaId, "IX_POSTArea");

            entity.HasIndex(e => e.PostcurriculumAreaId, "IX_POSTArea_POSTCurriculumAreaID");

            entity.Property(e => e.PostareaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTAreaID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.Area).HasMaxLength(500);
            entity.Property(e => e.AreaDescription).HasMaxLength(500);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.PostcurriculumAreaId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTCurriculumAreaID");

            entity.HasOne(d => d.Department).WithMany(p => p.Postareas)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_POSTArea_Departments");

            entity.HasOne(d => d.PostcurriculumArea).WithMany(p => p.Postareas)
                .HasForeignKey(d => d.PostcurriculumAreaId)
                .HasConstraintName("FK_POSTArea_POSTCurriculumArea");
        });

        modelBuilder.Entity<PostcostPeriod>(entity =>
        {
            entity.ToTable("POSTCostPeriod");

            entity.Property(e => e.PostcostPeriodId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTCostPeriodID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.PostendDate)
                .HasColumnType("datetime")
                .HasColumnName("POSTEndDate");
            entity.Property(e => e.PoststartDate)
                .HasColumnType("datetime")
                .HasColumnName("POSTStartDate");
        });

        modelBuilder.Entity<PostcostRank>(entity =>
        {
            entity.ToTable("POSTCostRank");

            entity.Property(e => e.PostcostRankId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTCostRankID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.HourlyRate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.PostcostPeriodId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTCostPeriodID");
            entity.Property(e => e.RankName).HasMaxLength(200);

            entity.HasOne(d => d.PostcostPeriod).WithMany(p => p.PostcostRanks)
                .HasForeignKey(d => d.PostcostPeriodId)
                .HasConstraintName("FK_POSTCostRank_POSTCostPeriod");
        });

        modelBuilder.Entity<Postcourse>(entity =>
        {
            entity.ToTable("POSTCourses");

            entity.HasIndex(e => e.DepartmentId, "IX_POSTCourses_DepartmentID");

            entity.HasIndex(e => e.PostcostPeriodId, "IX_POSTCourses_POSTCostPeriodID");

            entity.Property(e => e.PostcourseId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTCourseID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AddressName).HasMaxLength(200);
            entity.Property(e => e.AttendenceHours).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.City).HasMaxLength(200);
            entity.Property(e => e.CourseEndDate).HasColumnType("datetime");
            entity.Property(e => e.CourseFee).HasColumnType("money");
            entity.Property(e => e.CourseHours).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CourseStartDate).HasColumnType("datetime");
            entity.Property(e => e.CourseTitle).HasMaxLength(200);
            entity.Property(e => e.DepartmentEmployeeXml)
                .HasColumnType("xml")
                .HasColumnName("DepartmentEmployeeXML");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.PostcostPeriodId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTCostPeriodID");
            entity.Property(e => e.Sponsor).HasMaxLength(200);
            entity.Property(e => e.State).HasMaxLength(200);
            entity.Property(e => e.Street).HasMaxLength(200);
            entity.Property(e => e.Zip).HasMaxLength(100);

            entity.HasOne(d => d.Department).WithMany(p => p.Postcourses)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_POSTCourses_Departments");

            entity.HasOne(d => d.PostcostPeriod).WithMany(p => p.Postcourses)
                .HasForeignKey(d => d.PostcostPeriodId)
                .HasConstraintName("FK_POSTCourses_POSTCostPeriod");
        });

        modelBuilder.Entity<PostcourseArea>(entity =>
        {
            entity.ToTable("POSTCourseAreas");

            entity.HasIndex(e => e.PostareaId, "IX_POSTCourseAreas_POSTAreaID");

            entity.HasIndex(e => e.PostcourseId, "IX_POSTCourseAreas_POSTCourseID");

            entity.Property(e => e.PostcourseAreaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTCourseAreaID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AreaCredits).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.PostareaId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTAreaID");
            entity.Property(e => e.PostcourseId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTCourseID");
            entity.Property(e => e.PostinstructorDetail)
                .HasColumnType("xml")
                .HasColumnName("POSTInstructorDetail");
            entity.Property(e => e.PostoutSideInstructorDetail)
                .HasColumnType("xml")
                .HasColumnName("POSTOutSideInstructorDetail");

            entity.HasOne(d => d.Postarea).WithMany(p => p.PostcourseAreas)
                .HasForeignKey(d => d.PostareaId)
                .HasConstraintName("FK_POSTCourseAreas_POSTArea");

            entity.HasOne(d => d.Postcourse).WithMany(p => p.PostcourseAreas)
                .HasForeignKey(d => d.PostcourseId)
                .HasConstraintName("FK_POSTCourseAreas_POSTCourses");
        });

        modelBuilder.Entity<PostcourseAttachment>(entity =>
        {
            entity.HasKey(e => e.PostCourseAttachmentId).HasName("PK__POSTCour__90B4DADE3BC060DE");

            entity.ToTable("POSTCourseAttachments");

            entity.Property(e => e.PostCourseAttachmentId).HasColumnName("PostCourseAttachmentID");
            entity.Property(e => e.AddedName).IsUnicode(false);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AttachmentDescription).IsUnicode(false);
            entity.Property(e => e.AttachmentName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AttachmentPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AttachmentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.EditedName).IsUnicode(false);
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.PostcourseId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTCourseID");

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.PostcourseAttachments)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK__POSTCours__Depar__6458BCB9");

            entity.HasOne(d => d.Postcourse).WithMany(p => p.PostcourseAttachments)
                .HasForeignKey(d => d.PostcourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__POSTCours__POSTC__686944BF");
        });

        modelBuilder.Entity<PostcurriculumArea>(entity =>
        {
            entity.HasKey(e => e.PostcurriculumAreaId).HasName("PK_POSTGeneralArea");

            entity.ToTable("POSTCurriculumArea");

            entity.Property(e => e.PostcurriculumAreaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTCurriculumAreaID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Postemployee>(entity =>
        {
            entity.ToTable("POSTEmployee");

            entity.HasIndex(e => e.DepartmentEmployeeId, "IX_POSTEmployee_DepartmentEmployeeID");

            entity.Property(e => e.PostemployeeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTEmployeeID");
            entity.Property(e => e.AddedName).HasMaxLength(200);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.EditedName).HasMaxLength(200);
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.OriginalCertifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PostexpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("POSTExpirationDate");
            entity.Property(e => e.Postidnumber).HasColumnName("POSTIDNumber");

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.Postemployees)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK_POSTEmployee_DepartmentEmployees");
        });

        modelBuilder.Entity<PostemployeeCourse>(entity =>
        {
            entity.ToTable("POSTEmployeeCourse");

            entity.HasIndex(e => e.DepartmentEmployeeId, "IX_POSTEmployeeCourse_DepartmentEmployeeID");

            entity.HasIndex(e => e.PostcourseId, "IX_POSTEmployeeCourse_POSTCourseID");

            entity.Property(e => e.PostemployeeCourseId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTEmployeeCourseId");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AttendenceHours).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.PostcourseId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTCourseID");

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.PostemployeeCourses)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK_POSTEmployeeCourse_DepartmentEmployees");

            entity.HasOne(d => d.Postcourse).WithMany(p => p.PostemployeeCourses)
                .HasForeignKey(d => d.PostcourseId)
                .HasConstraintName("FK_POSTEmployeeCourse_POSTCourses");
        });

        modelBuilder.Entity<PostemployeeCourseArea>(entity =>
        {
            entity.ToTable("POSTEmployeeCourseArea");

            entity.HasIndex(e => e.PostareaId, "IX_POSTEmployeeCourseArea_POSTAreaID");

            entity.HasIndex(e => e.PostemployeeCourseId, "IX_POSTEmployeeCourseArea_POSTEmployeeCourseId");

            entity.Property(e => e.PostemployeeCourseAreaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTEmployeeCourseAreaId");
            entity.Property(e => e.AddedName).HasMaxLength(200);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditEarned).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EditedName).HasMaxLength(200);
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.PostareaId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTAreaID");
            entity.Property(e => e.PostemployeeCourseId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTEmployeeCourseId");

            entity.HasOne(d => d.Postarea).WithMany(p => p.PostemployeeCourseAreas)
                .HasForeignKey(d => d.PostareaId)
                .HasConstraintName("FK_POSTEmployeeCourseArea_POSTArea");

            entity.HasOne(d => d.PostemployeeCourse).WithMany(p => p.PostemployeeCourseAreas)
                .HasForeignKey(d => d.PostemployeeCourseId)
                .HasConstraintName("FK_POSTEmployeeCourseArea_POSTEmployeeCourse");
        });

        modelBuilder.Entity<PostimportEmployee>(entity =>
        {
            entity.HasKey(e => e.PostimportEmployeesId).HasName("PK__POSTImpo__B5209350F7EFBF31");

            entity.ToTable("POSTImportEmployees");

            entity.Property(e => e.PostimportEmployeesId).HasColumnName("POSTImportEmployeesID");
            entity.Property(e => e.BadgeNumber).HasMaxLength(50);
            entity.Property(e => e.DateOfHiring).HasColumnType("date");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.ImportDateTime).HasColumnType("datetime");
            entity.Property(e => e.ImportEmployeeId).HasColumnName("ImportEmployeeID");
            entity.Property(e => e.ImportOk).HasColumnName("ImportOK");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.PostexpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("POSTExpirationDate");
            entity.Property(e => e.Postidnumber).HasColumnName("POSTIDNumber");
            entity.Property(e => e.Rank).HasMaxLength(50);
            entity.Property(e => e.Suffix)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PostimportInstructor>(entity =>
        {
            entity.HasKey(e => e.PostimportInstructorsId).HasName("PK__POSTImpo__7BB88CC3E9CECA31");

            entity.ToTable("POSTImportInstructors");

            entity.HasIndex(e => e.EmployeeId, "IX_POSTImportInstructors_EmployeeID");

            entity.HasIndex(e => e.InstructorNumber, "IX_POSTImportInstructors_InstructorNumber").IsUnique();

            entity.Property(e => e.PostimportInstructorsId).HasColumnName("POSTImportInstructorsID");
            entity.Property(e => e.CertificationType).IsUnicode(false);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName).IsUnicode(false);
            entity.Property(e => e.ImportDate).HasColumnType("datetime");
            entity.Property(e => e.ImportFirstName).IsUnicode(false);
            entity.Property(e => e.ImportLastName).IsUnicode(false);
            entity.Property(e => e.LastInstructorChange).IsUnicode(false);
            entity.Property(e => e.LastName).IsUnicode(false);
            entity.Property(e => e.MiddleName).IsUnicode(false);
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.ProcessError).IsUnicode(false);
            entity.Property(e => e.ProcessStatus).IsUnicode(false);
            entity.Property(e => e.Rank).IsUnicode(false);
            entity.Property(e => e.SponsorName).IsUnicode(false);
            entity.Property(e => e.Suffix).IsUnicode(false);
        });

        modelBuilder.Entity<PostimportInstructorArea>(entity =>
        {
            entity.HasKey(e => e.PostimportInstructorAreasId).HasName("PK__POSTImpo__5C308A6FE8F2F1AA");

            entity.ToTable("POSTImportInstructorAreas");

            entity.HasIndex(e => e.InstructorNumber, "IX_POSTImportInstructorAreas_InstructorNumber");

            entity.HasIndex(e => e.PostimportInstructorsId, "IX_POSTImportInstructorAreas_POSTImportInstructorsID");

            entity.Property(e => e.PostimportInstructorAreasId).HasColumnName("POSTImportInstructorAreasID");
            entity.Property(e => e.Area).IsUnicode(false);
            entity.Property(e => e.PostareaId).HasColumnName("POSTAreaID");
            entity.Property(e => e.PostimportInstructorsId).HasColumnName("POSTImportInstructorsID");
            entity.Property(e => e.PostinstructorCertifiedAreaId).HasColumnName("POSTInstructorCertifiedAreaID");
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.ProcessError).IsUnicode(false);
            entity.Property(e => e.ProcessStatus).IsUnicode(false);

            entity.HasOne(d => d.PostimportInstructors).WithMany(p => p.PostimportInstructorAreas)
                .HasForeignKey(d => d.PostimportInstructorsId)
                .HasConstraintName("FK__POSTImpor__POSTI__26E59A25");
        });

        modelBuilder.Entity<PostimportInstuctorAudit>(entity =>
        {
            entity.HasKey(e => e.PostimportInstuctorAuditId).HasName("PK__POSTImpo__72A8214EF04FAEDF");

            entity.ToTable("POSTImportInstuctorAudit");

            entity.Property(e => e.PostimportInstuctorAuditId).HasColumnName("POSTImportInstuctorAuditID");
            entity.Property(e => e.Action).IsUnicode(false);
            entity.Property(e => e.AuditDateTime).HasColumnType("datetime");
            entity.Property(e => e.Details).IsUnicode(false);
            entity.Property(e => e.PostimportInstrcutorAreaId).HasColumnName("POSTImportInstrcutorAreaID");
            entity.Property(e => e.PostimportInstructorId).HasColumnName("POSTImportInstructorID");
            entity.Property(e => e.PostinstructorCertifiedAreaId).HasColumnName("POSTInstructorCertifiedAreaID");
            entity.Property(e => e.PostinstructorId).HasColumnName("POSTInstructorID");
        });

        modelBuilder.Entity<Postinstructor>(entity =>
        {
            entity.ToTable("POSTInstructors");

            entity.HasIndex(e => e.DepartmentEmployeeId, "IX_POSTInstructors_DepartmentEmployeeID");

            entity.HasIndex(e => e.InstructorIdnumber, "IX_POSTInstructors_InstructorIDNumber");

            entity.Property(e => e.PostinstructorId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTInstructorID");
            entity.Property(e => e.AddedName).HasMaxLength(100);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.CertifiedExpDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.EditedName).HasMaxLength(100);
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.InstructorIdnumber).HasColumnName("InstructorIDNumber");

            entity.HasOne(d => d.CertificationTypeNavigation).WithMany(p => p.Postinstructors)
                .HasForeignKey(d => d.CertificationType)
                .HasConstraintName("FK_POSTInstructors_RefMiscReferenceData");

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.Postinstructors)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK_POSTInstructors_DepartmentEmployees");
        });

        modelBuilder.Entity<PostinstructorCertifiedArea>(entity =>
        {
            entity.ToTable("POSTInstructorCertifiedArea");

            entity.HasIndex(e => e.PostareaId, "IX_POSTInstructorCertifiedArea_POSTAreaID");

            entity.HasIndex(e => e.PostinstructorId, "IX_POSTInstructorCertifiedArea_POSTInstructorID");

            entity.HasIndex(e => e.PostoutSideInstructorId, "IX_POSTInstructorCertifiedArea_POSTOutSideInstructorID");

            entity.Property(e => e.PostinstructorCertifiedAreaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTInstructorCertifiedAreaID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.DateOfIssue).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.PostareaId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTAreaID");
            entity.Property(e => e.PostinstructorId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTInstructorID");
            entity.Property(e => e.PostoutSideInstructorId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTOutSideInstructorID");

            entity.HasOne(d => d.Postarea).WithMany(p => p.PostinstructorCertifiedAreas)
                .HasForeignKey(d => d.PostareaId)
                .HasConstraintName("FK_POSTInstructorCertifiedArea_POSTArea");

            entity.HasOne(d => d.Postinstructor).WithMany(p => p.PostinstructorCertifiedAreas)
                .HasForeignKey(d => d.PostinstructorId)
                .HasConstraintName("FK_POSTInstructorCertifiedArea_POSTInstructors");

            entity.HasOne(d => d.PostoutSideInstructor).WithMany(p => p.PostinstructorCertifiedAreas)
                .HasForeignKey(d => d.PostoutSideInstructorId)
                .HasConstraintName("FK_POSTInstructorCertifiedArea_POSTOutSideInstructor");
        });

        modelBuilder.Entity<PostinstructorHour>(entity =>
        {
            entity.HasKey(e => e.PostinstructorHoursId);

            entity.ToTable("POSTInstructorHours");

            entity.Property(e => e.PostinstructorHoursId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTInstructorHoursID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.City).HasMaxLength(200);
            entity.Property(e => e.CompletedDate).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.PostcourseId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTCourseID");
            entity.Property(e => e.PostinstructorCertifiedAreaId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTInstructorCertifiedAreaID");
            entity.Property(e => e.State).HasMaxLength(200);
            entity.Property(e => e.Street).HasMaxLength(500);
            entity.Property(e => e.Zip).HasMaxLength(200);

            entity.HasOne(d => d.Postcourse).WithMany(p => p.PostinstructorHours)
                .HasForeignKey(d => d.PostcourseId)
                .HasConstraintName("FK__POSTInstr__POSTC__7CEF6059");
        });

        modelBuilder.Entity<PostoutSideInstructor>(entity =>
        {
            entity.ToTable("POSTOutSideInstructor");

            entity.Property(e => e.PostoutSideInstructorId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTOutSideInstructorID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.InstructorCertificationExpireDate).HasColumnType("datetime");
            entity.Property(e => e.InstructorIdnumber)
                .HasMaxLength(100)
                .HasColumnName("InstructorIDNumber");
            entity.Property(e => e.InstructorName).HasMaxLength(200);

            entity.HasOne(d => d.CertificationTypeNavigation).WithMany(p => p.PostoutSideInstructors)
                .HasForeignKey(d => d.CertificationType)
                .HasConstraintName("FK_POSTOutSideInstructor_RefMiscReferenceData");

            entity.HasOne(d => d.Department).WithMany(p => p.PostoutSideInstructors)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_POSTOutSideInstructor_Departments");
        });

        modelBuilder.Entity<Postrenewal>(entity =>
        {
            entity.ToTable("POSTRenewal");

            entity.HasIndex(e => e.DepartmentEmployeeId, "IX_POSTRenewal_DepartmentEmployeeID");

            entity.Property(e => e.PostrenewalId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POSTRenewalID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.RenewalDate).HasColumnType("datetime");

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.Postrenewals)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK_POSTRenewal_DepartmentEmployees");
        });

        modelBuilder.Entity<PropertyCustodyTracking>(entity =>
        {
            entity.HasKey(e => e.PropertyCustodyTrackingId).HasName("PK_PROPERTYCUSTODYTRACKING");

            entity.ToTable("PropertyCustodyTracking");

            entity.HasIndex(e => e.ActionDoneBy, "IX_PropertyCustodyTracking_ActionDoneBy");

            entity.HasIndex(e => e.PropertyRoomItemId, "IX_PropertyCustodyTracking_PropertyRoomItemID");

            entity.HasIndex(e => e.Status, "IX_PropertyCustodyTracking_Status");

            entity.Property(e => e.PropertyCustodyTrackingId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PropertyCustodyTrackingID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CheckOutSignatureOk).HasColumnName("CheckOutSignatureOK");
            entity.Property(e => e.CheckOutToName).HasMaxLength(200);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PropertyRoomItemId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PropertyRoomItemID");
            entity.Property(e => e.ReceivedFromName).HasMaxLength(200);
            entity.Property(e => e.StatusDateTime).HasColumnType("datetime");
            entity.Property(e => e.StorageBin).HasMaxLength(200);

            entity.HasOne(d => d.ActionDoneByNavigation).WithMany(p => p.PropertyCustodyTrackings)
                .HasForeignKey(d => d.ActionDoneBy)
                .HasConstraintName("FK_PROPERTY_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.CheckOutReasonNavigation).WithMany(p => p.PropertyCustodyTrackingCheckOutReasonNavigations)
                .HasForeignKey(d => d.CheckOutReason)
                .HasConstraintName("FK_PROPERTY_REFERENCE_REFINCID6");

            entity.HasOne(d => d.PropertyRoomItem).WithMany(p => p.PropertyCustodyTrackings)
                .HasForeignKey(d => d.PropertyRoomItemId)
                .HasConstraintName("FK_PROPERTY_REFERENCE_PROPERTY2");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.PropertyCustodyTrackings)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK_PROPERTY_REFERENCE_SYSAPPLI2");

            entity.HasOne(d => d.StorageAisleNavigation).WithMany(p => p.PropertyCustodyTrackingStorageAisleNavigations)
                .HasForeignKey(d => d.StorageAisle)
                .HasConstraintName("FK_PROPERTY_REFERENCE_REFINCID3");

            entity.HasOne(d => d.StorageRoomNavigation).WithMany(p => p.PropertyCustodyTrackingStorageRoomNavigations)
                .HasForeignKey(d => d.StorageRoom)
                .HasConstraintName("FK_PROPERTY_REFERENCE_REFINCID2");

            entity.HasOne(d => d.StorageShelfNavigation).WithMany(p => p.PropertyCustodyTrackingStorageShelfNavigations)
                .HasForeignKey(d => d.StorageShelf)
                .HasConstraintName("FK_PROPERTY_REFERENCE_REFINCID4");
        });

        modelBuilder.Entity<PropertyRoomItem>(entity =>
        {
            entity.HasKey(e => e.PropertyRoomItemId).HasName("PK_PROPERTYROOMITEM");

            entity.ToTable("PropertyRoomItem");

            entity.HasIndex(e => e.ItemStatus, "IX_PropertyRoomItem_ItemStatus");

            entity.HasIndex(e => e.Mppid, "IX_PropertyRoomItem_MPPID");

            entity.HasIndex(e => e.Mvid, "IX_PropertyRoomItem_MVID");

            entity.HasIndex(e => e.PrimaryIncidentId, "IX_PropertyRoomItem_PrimaryIncidentID");

            entity.HasIndex(e => e.ReportStatus, "IX_PropertyRoomItem_ReportStatus");

            entity.Property(e => e.PropertyRoomItemId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PropertyRoomItemID");
            entity.Property(e => e.ActualPurgeDate).HasColumnType("datetime");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Barcode).HasMaxLength(100);
            entity.Property(e => e.CourtInventoryNumber).HasMaxLength(300);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DisposalMethod).HasMaxLength(300);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastInventoryDate).HasColumnType("datetime");
            entity.Property(e => e.Mppid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPID");
            entity.Property(e => e.Mvid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MVID");
            entity.Property(e => e.PotentialPurgeDate).HasColumnType("date");
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Department).WithMany(p => p.PropertyRoomItems)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_PROPERTY_REFERENCE_DEPARTME");

            entity.HasOne(d => d.FinalDispositionNavigation).WithMany(p => p.PropertyRoomItems)
                .HasForeignKey(d => d.FinalDisposition)
                .HasConstraintName("FK_PROPERTY_REFERENCE_REFINCID7");

            entity.HasOne(d => d.ItemStatusNavigation).WithMany(p => p.PropertyRoomItemItemStatusNavigations)
                .HasForeignKey(d => d.ItemStatus)
                .HasConstraintName("FK_PROPERTY_REFERENCE_SYSAPPLI3");

            entity.HasOne(d => d.Mpp).WithMany(p => p.PropertyRoomItems)
                .HasForeignKey(d => d.Mppid)
                .HasConstraintName("FK_PROPERTY_REFERENCE_MSTRPROP");

            entity.HasOne(d => d.Mv).WithMany(p => p.PropertyRoomItems)
                .HasForeignKey(d => d.Mvid)
                .HasConstraintName("FK_PROPERTY_REFERENCE_MSTRVEHI");

            entity.HasOne(d => d.PrimaryIncident).WithMany(p => p.PropertyRoomItems)
                .HasForeignKey(d => d.PrimaryIncidentId)
                .HasConstraintName("FK_PROPERTY_REFERENCE_INCIDENT");

            entity.HasOne(d => d.ReportStatusNavigation).WithMany(p => p.PropertyRoomItemReportStatusNavigations)
                .HasForeignKey(d => d.ReportStatus)
                .HasConstraintName("FK_PROPERTY_REFERENCE_SYSAPPLI");
        });

        modelBuilder.Entity<PrtPropertyReceipt1property>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Prt_PropertyReceipt_1Property");

            entity.Property(e => e.BrandStampMarking).HasMaxLength(100);
            entity.Property(e => e.CashValue).HasColumnType("money");
            entity.Property(e => e.ContainerType).HasMaxLength(100);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DrugCategory).HasMaxLength(100);
            entity.Property(e => e.DrugDataId).HasColumnName("DrugDataID");
            entity.Property(e => e.DrugDesc).HasMaxLength(1028);
            entity.Property(e => e.DrugDescription).HasMaxLength(300);
            entity.Property(e => e.DrugManuf).HasMaxLength(100);
            entity.Property(e => e.DrugName).HasMaxLength(100);
            entity.Property(e => e.DrugNameId).HasColumnName("DrugNameID");
            entity.Property(e => e.DrugQuantity).HasMaxLength(100);
            entity.Property(e => e.DrugType).HasMaxLength(100);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentLocation).HasMaxLength(800);
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.MakerName).HasMaxLength(100);
            entity.Property(e => e.ModelName).HasMaxLength(100);
            entity.Property(e => e.Mppid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPID");
            entity.Property(e => e.PropertyBarCode).HasMaxLength(100);
            entity.Property(e => e.PropertyCategory).HasMaxLength(100);
            entity.Property(e => e.PropertyCategoryId).HasColumnName("PropertyCategoryID");
            entity.Property(e => e.PropertyName).HasMaxLength(100);
            entity.Property(e => e.PropertyNameId).HasColumnName("PropertyNameID");
            entity.Property(e => e.PropertySerialId)
                .HasMaxLength(100)
                .HasColumnName("PropertySerialID");
            entity.Property(e => e.PropertyValue).HasColumnType("money");
            entity.Property(e => e.ReportCategory).HasMaxLength(300);
            entity.Property(e => e.ReportDefinitionId).HasColumnName("ReportDefinitionID");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");
            entity.Property(e => e.Weight).HasMaxLength(100);
            entity.Property(e => e.WeightUnit).HasMaxLength(100);
        });

        modelBuilder.Entity<PrtPropertyReceipt2propertyInvolvement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Prt_PropertyReceipt_2PropertyInvolvement");

            entity.Property(e => e.AbandonedLoc).HasMaxLength(800);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.FoundLoc).HasMaxLength(800);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.Involvement).HasMaxLength(100);
            entity.Property(e => e.LocationDetailDisplayString).HasMaxLength(800);
            entity.Property(e => e.Mppid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPID");
            entity.Property(e => e.OwnerOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OwnerOrgID");
            entity.Property(e => e.OwnerPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OwnerPersonID");
            entity.Property(e => e.RecovFrom).HasMaxLength(102);
            entity.Property(e => e.RecoveredLoc).HasMaxLength(800);
            entity.Property(e => e.SeizedDateTime).HasColumnType("datetime");
            entity.Property(e => e.SeizedLoc).HasMaxLength(800);
        });

        modelBuilder.Entity<PrtPropertyReceipt3groupInvolvement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Prt_PropertyReceipt_3GroupInvolvement");

            entity.Property(e => e.AbandonedLoc).HasMaxLength(800);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.FoundLoc).HasMaxLength(800);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.Mppid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPID");
            entity.Property(e => e.OwnerOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OwnerOrgID");
            entity.Property(e => e.OwnerPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OwnerPersonID");
            entity.Property(e => e.RecovFrom).HasMaxLength(102);
            entity.Property(e => e.RecoveredLoc).HasMaxLength(800);
            entity.Property(e => e.SeizedDateTime).HasColumnType("datetime");
            entity.Property(e => e.SeizedLoc).HasMaxLength(800);
        });

        modelBuilder.Entity<PrtPropertyReceipt4custody>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Prt_PropertyReceipt_4Custody");

            entity.Property(e => e.CustodyActionBy).HasMaxLength(154);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.Mppid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPID");
            entity.Property(e => e.ReceivedFromName).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.StatusDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<PrtPropertyReceiptOp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Prt_PropertyReceipt_OP");

            entity.Property(e => e.AbandonedLoc).HasMaxLength(800);
            entity.Property(e => e.BrandStampMarking).HasMaxLength(100);
            entity.Property(e => e.CashValue).HasColumnType("money");
            entity.Property(e => e.ContainerType).HasMaxLength(100);
            entity.Property(e => e.CustodyActionBy).HasMaxLength(154);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DrugCategory).HasMaxLength(100);
            entity.Property(e => e.DrugDataId).HasColumnName("DrugDataID");
            entity.Property(e => e.DrugDesc).HasMaxLength(1028);
            entity.Property(e => e.DrugDescription).HasMaxLength(300);
            entity.Property(e => e.DrugManuf).HasMaxLength(100);
            entity.Property(e => e.DrugName).HasMaxLength(100);
            entity.Property(e => e.DrugNameId).HasColumnName("DrugNameID");
            entity.Property(e => e.DrugQuantity).HasMaxLength(100);
            entity.Property(e => e.DrugType).HasMaxLength(100);
            entity.Property(e => e.FoundLoc).HasMaxLength(800);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentLocation).HasMaxLength(800);
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.MakerName).HasMaxLength(100);
            entity.Property(e => e.ModelName).HasMaxLength(100);
            entity.Property(e => e.Mppid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPID");
            entity.Property(e => e.OwnerOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OwnerOrgID");
            entity.Property(e => e.OwnerPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OwnerPersonID");
            entity.Property(e => e.PropertyBarCode).HasMaxLength(100);
            entity.Property(e => e.PropertyCategory).HasMaxLength(100);
            entity.Property(e => e.PropertyCategoryId).HasColumnName("PropertyCategoryID");
            entity.Property(e => e.PropertyName).HasMaxLength(100);
            entity.Property(e => e.PropertyNameId).HasColumnName("PropertyNameID");
            entity.Property(e => e.PropertySerialId)
                .HasMaxLength(100)
                .HasColumnName("PropertySerialID");
            entity.Property(e => e.PropertyValue).HasColumnType("money");
            entity.Property(e => e.ReceivedFromName).HasMaxLength(200);
            entity.Property(e => e.RecovFrom).HasMaxLength(102);
            entity.Property(e => e.RecoveredLoc).HasMaxLength(800);
            entity.Property(e => e.ReportCategory).HasMaxLength(300);
            entity.Property(e => e.ReportDefinitionId).HasColumnName("ReportDefinitionID");
            entity.Property(e => e.SeizedDateTime).HasColumnType("datetime");
            entity.Property(e => e.SeizedLoc).HasMaxLength(800);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.StatusDateTime).HasColumnType("datetime");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");
            entity.Property(e => e.Weight).HasMaxLength(100);
            entity.Property(e => e.WeightUnit).HasMaxLength(100);
        });

        modelBuilder.Entity<RacialProfiling>(entity =>
        {
            entity.HasKey(e => e.RacialProfilingId).HasName("PK_RACIALPROFILING");

            entity.ToTable("RacialProfiling");

            entity.HasIndex(e => e.TrafficStopId, "IX_RacialProfiling_TrafficStopID");

            entity.Property(e => e.RacialProfilingId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RacialProfilingID");
            entity.Property(e => e.IsCtresident).HasColumnName("IsCTResident");
            entity.Property(e => e.StatutoryViolationCharged).HasColumnType("xml");
            entity.Property(e => e.TrafficStopId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopID");

            entity.HasOne(d => d.AuthorityforSearchCodeNavigation).WithMany(p => p.RacialProfilingAuthorityforSearchCodeNavigations)
                .HasForeignKey(d => d.AuthorityforSearchCode)
                .HasConstraintName("FK_RACIALPR_REFERENCE_REFCITAT5");

            entity.HasOne(d => d.DurationofStopCodeNavigation).WithMany(p => p.RacialProfilingDurationofStopCodeNavigations)
                .HasForeignKey(d => d.DurationofStopCode)
                .HasConstraintName("FK_RACIALPR_REFERENCE_REFTRAFF2");

            entity.HasOne(d => d.EnforcementCategoryCodeNavigation).WithMany(p => p.RacialProfilingEnforcementCategoryCodeNavigations)
                .HasForeignKey(d => d.EnforcementCategoryCode)
                .HasConstraintName("FK_RACIALPR_REFERENCE_REFCITAT4");

            entity.HasOne(d => d.NatureofstopCodeNavigation).WithMany(p => p.RacialProfilingNatureofstopCodeNavigations)
                .HasForeignKey(d => d.NatureofstopCode)
                .HasConstraintName("FK_RACIALPR_REFERENCE_REFCITAT2");

            entity.HasOne(d => d.SearchDispositionCodeNavigation).WithMany(p => p.RacialProfilingSearchDispositionCodeNavigations)
                .HasForeignKey(d => d.SearchDispositionCode)
                .HasConstraintName("FK_RACIALPR_REFERENCE_REFTRAFF");

            entity.HasOne(d => d.StatutoryCitationofAllegedViolationCodeNavigation).WithMany(p => p.RacialProfilingStatutoryCitationofAllegedViolationCodeNavigations)
                .HasForeignKey(d => d.StatutoryCitationofAllegedViolationCode)
                .HasConstraintName("FK_RACIALPR_REFERENCE_REFCITAT3");

            entity.HasOne(d => d.TrafficStop).WithMany(p => p.RacialProfilings)
                .HasForeignKey(d => d.TrafficStopId)
                .HasConstraintName("FK_RACIALPR_REFERENCE_TRAFFICS");
        });

        modelBuilder.Entity<RefCallForServiceDefinition>(entity =>
        {
            entity.HasKey(e => e.CfsdefinitionId)
                .HasName("PK_REFCALLFORSERVICEDEFINITION")
                .IsClustered(false);

            entity.ToTable("RefCallForServiceDefinition");

            entity.Property(e => e.CfsdefinitionId).HasColumnName("CFSDefinitionID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.AutoClearMinutes).HasDefaultValueSql("((0))");
            entity.Property(e => e.CadeventDefinitionId).HasColumnName("CADEventDefinitionID");
            entity.Property(e => e.CallForServiceCode)
                .HasMaxLength(50)
                .HasColumnName("CallForServiceCODE");
            entity.Property(e => e.CallForServiceType).HasMaxLength(100);
            entity.Property(e => e.CallHandlerCode).HasMaxLength(50);
            entity.Property(e => e.DefaultPriorityName).HasMaxLength(20);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DisplaySeq).HasColumnName("DisplaySEQ");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EventTypeCategory).HasMaxLength(50);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Agency).WithMany(p => p.RefCallForServiceDefinitions)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_REFCALLF_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.Department).WithMany(p => p.RefCallForServiceDefinitions)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REFCALLF_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<RefCallPriority>(entity =>
        {
            entity.HasKey(e => e.CfspriorityId)
                .HasName("PK_REFCALLPRIORITY")
                .IsClustered(false);

            entity.ToTable("RefCallPriority");

            entity.Property(e => e.CfspriorityId).HasColumnName("CFSPriorityID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.CadeventPriorityId).HasColumnName("CADEventPriorityID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PriorityName).HasMaxLength(50);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.UnitEligibleTimeRemain).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Agency).WithMany(p => p.RefCallPriorities)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_REFCALLP_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.Department).WithMany(p => p.RefCallPriorities)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REFCALLP_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<RefCrashReferenceDatum>(entity =>
        {
            entity.HasKey(e => e.RefCrashReferenceDataId).HasName("PK_REFCRASHREFERENCEDATA");

            entity.Property(e => e.RefCrashReferenceDataId).HasColumnName("RefCrashReferenceDataID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.DataValue).HasMaxLength(100);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DisplaySeq).HasColumnName("DisplaySEQ");
            entity.Property(e => e.DisplayString).HasMaxLength(1000);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.RefCategory).HasMaxLength(100);
            entity.Property(e => e.Rptcode)
                .HasColumnType("xml")
                .HasColumnName("RPTCode");
            entity.Property(e => e.SubRefCategory).HasMaxLength(100);

            entity.HasOne(d => d.Agency).WithMany(p => p.RefCrashReferenceData)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_REFCRASH_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.Department).WithMany(p => p.RefCrashReferenceData)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REFCRASH_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<RefDirectoryCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK_REFDIRECTORYCATEGORIES");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.CategoryName).HasMaxLength(200);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<RefDispositionCode>(entity =>
        {
            entity.HasKey(e => e.DispositionCodeId).HasName("PK_REFDISPOSITIONCODE");

            entity.ToTable("RefDispositionCode");

            entity.Property(e => e.DispositionCodeId).HasColumnName("DispositionCodeID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.DisplaySeq).HasColumnName("DisplaySEQ");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Agency).WithMany(p => p.RefDispositionCodes)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_REFDISPO_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.Department).WithMany(p => p.RefDispositionCodes)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REFDISPO_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<RefDrugDataAlternative>(entity =>
        {
            entity.HasKey(e => e.RefDrugDataAlternativeId).HasName("PK_REFDRUGDATAALTERNATIVE");

            entity.ToTable("RefDrugDataAlternative");

            entity.HasIndex(e => e.AltDrugDataId, "IX_RefDrugDataAlternative_AltDrugDataID");

            entity.HasIndex(e => e.DrugDataId, "IX_RefDrugDataAlternative_DrugDataID");

            entity.Property(e => e.RefDrugDataAlternativeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RefDrugDataAlternativeID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AltDrugDataId).HasColumnName("AltDrugDataID");
            entity.Property(e => e.DrugDataId).HasColumnName("DrugDataID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.AltDrugData).WithMany(p => p.RefDrugDataAlternativeAltDrugData)
                .HasForeignKey(d => d.AltDrugDataId)
                .HasConstraintName("FK_REFDRUGD_REFERENCE_REFDRUGD");

            entity.HasOne(d => d.DrugData).WithMany(p => p.RefDrugDataAlternativeDrugData)
                .HasForeignKey(d => d.DrugDataId)
                .HasConstraintName("FK_REFDRUGD_REFERENCE_REFDRUGD2");
        });

        modelBuilder.Entity<RefDrugDatum>(entity =>
        {
            entity.HasKey(e => e.RefDrugDataId).HasName("PK_REFDRUGDATA");

            entity.Property(e => e.RefDrugDataId).HasColumnName("RefDrugDataID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataValue).HasMaxLength(100);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DisplaySeq).HasColumnName("DisplaySEQ");
            entity.Property(e => e.DisplayString).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.RefCategory).HasMaxLength(100);
            entity.Property(e => e.Rptcategory)
                .HasMaxLength(100)
                .HasColumnName("RPTCategory");
            entity.Property(e => e.Rptcode)
                .HasColumnType("xml")
                .HasColumnName("RPTCode");
            entity.Property(e => e.SubRefCategory).HasMaxLength(100);

            entity.HasOne(d => d.Department).WithMany(p => p.RefDrugData)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REFDRUGD_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<RefIncidentReferenceDatum>(entity =>
        {
            entity.HasKey(e => e.RefIncidentReferenceDataId).HasName("PK_REFINCIDENTREFERENCEDATA");

            entity.Property(e => e.RefIncidentReferenceDataId).HasColumnName("RefIncidentReferenceDataID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.DataValue).HasMaxLength(100);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DisplaySeq).HasColumnName("DisplaySEQ");
            entity.Property(e => e.DisplayString).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.RefCategory).HasMaxLength(100);
            entity.Property(e => e.Rptcode)
                .HasColumnType("xml")
                .HasColumnName("RPTCode");
            entity.Property(e => e.SubRefCategory).HasMaxLength(100);

            entity.HasOne(d => d.Agency).WithMany(p => p.RefIncidentReferenceData)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_REFINCID_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.Department).WithMany(p => p.RefIncidentReferenceData)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REFINCID_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<RefMiscReferenceDatum>(entity =>
        {
            entity.HasKey(e => e.RefMiscReferenceDataId).HasName("PK_REFMISCREFERENCEDATA");

            entity.Property(e => e.RefMiscReferenceDataId).HasColumnName("RefMiscReferenceDataID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.DataValue).HasMaxLength(100);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DisplaySeq).HasColumnName("DisplaySEQ");
            entity.Property(e => e.DisplayString).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.RefCategory).HasMaxLength(100);
            entity.Property(e => e.Rptcode)
                .HasColumnType("xml")
                .HasColumnName("RPTCode");
            entity.Property(e => e.SubRefCategory).HasMaxLength(100);

            entity.HasOne(d => d.Agency).WithMany(p => p.RefMiscReferenceData)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_REFMISCR_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.Department).WithMany(p => p.RefMiscReferenceData)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REFMISCR_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<RefMstrinxreferenceDatum>(entity =>
        {
            entity.HasKey(e => e.MstrinxreferenceDataId).HasName("PK_REFMSTRINXREFERENCEDATA");

            entity.ToTable("RefMSTRINXReferenceData");

            entity.HasIndex(e => new { e.RefCategory, e.IsActive, e.DataValue }, "RefMSTRINXReferenceData_RefCategory_IsActive_DataValue");

            entity.Property(e => e.MstrinxreferenceDataId).HasColumnName("MSTRINXReferenceDataID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.DataValue).HasMaxLength(100);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DisplaySeq).HasColumnName("DisplaySEQ");
            entity.Property(e => e.DisplayString).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.RefCategory).HasMaxLength(100);
            entity.Property(e => e.Rptcode)
                .HasColumnType("xml")
                .HasColumnName("RPTCode");
            entity.Property(e => e.SubRefCategory).HasMaxLength(100);

            entity.HasOne(d => d.Agency).WithMany(p => p.RefMstrinxreferenceData)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_REFMSTRI_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.Department).WithMany(p => p.RefMstrinxreferenceData)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REFMSTRI_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<RefNarrativeTemplate>(entity =>
        {
            entity.HasKey(e => e.MstrnarrativeTemplateId).HasName("PK_REFNARRATIVETEMPLATE");

            entity.ToTable("RefNarrativeTemplate");

            entity.HasIndex(e => e.SysrmsapplicationTypeId, "IX_RefNarrativeTemplate_SYSRMSApplicationTypeID");

            entity.Property(e => e.MstrnarrativeTemplateId).HasColumnName("MSTRNarrativeTemplateID");
            entity.Property(e => e.AddedById).HasColumnName("AddedByID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedById).HasColumnName("EditedByID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SysrmsapplicationTypeId).HasColumnName("SYSRMSApplicationTypeID");
            entity.Property(e => e.TemplateName).HasMaxLength(50);

            entity.HasOne(d => d.AddedBy).WithMany(p => p.RefNarrativeTemplateAddedBies)
                .HasForeignKey(d => d.AddedById)
                .HasConstraintName("FK_RefNarrativeTemplate_DepartmentEmployees");

            entity.HasOne(d => d.Agency).WithMany(p => p.RefNarrativeTemplates)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_REFNARRA_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.Department).WithMany(p => p.RefNarrativeTemplates)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REFNARRA_REFERENCE_DEPARTME");

            entity.HasOne(d => d.EditedBy).WithMany(p => p.RefNarrativeTemplateEditedBies)
                .HasForeignKey(d => d.EditedById)
                .HasConstraintName("FK_RefNarrativeTemplate_DepartmentEmployees1");

            entity.HasOne(d => d.EmployeeSpecifyNavigation).WithMany(p => p.RefNarrativeTemplateEmployeeSpecifyNavigations)
                .HasForeignKey(d => d.EmployeeSpecify)
                .HasConstraintName("FK_REFNARRA_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.SysrmsapplicationType).WithMany(p => p.RefNarrativeTemplates)
                .HasForeignKey(d => d.SysrmsapplicationTypeId)
                .HasConstraintName("FK_REFNARRA_REFERENCE_SYSRMSAP");

            entity.HasOne(d => d.TemplateTypeCodeNavigation).WithMany(p => p.RefNarrativeTemplates)
                .HasForeignKey(d => d.TemplateTypeCode)
                .HasConstraintName("FK_REFNARRA_REFERENCE_REFMISCR");
        });

        modelBuilder.Entity<RefNibrscodeDefinition>(entity =>
        {
            entity.HasKey(e => e.NibrscodeId).HasName("PK_REFNIBRSCODEDEFINITION");

            entity.ToTable("RefNIBRSCodeDefinition");

            entity.Property(e => e.NibrscodeId).HasColumnName("NIBRSCodeID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OffenseCategory).HasMaxLength(100);
            entity.Property(e => e.OffenseCode).HasMaxLength(10);
            entity.Property(e => e.OffenseGroup).HasMaxLength(1);
            entity.Property(e => e.OffenseName).HasMaxLength(100);
            entity.Property(e => e.OffenseSubCode).HasMaxLength(10);
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.Survey).HasMaxLength(100);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Agency).WithMany(p => p.RefNibrscodeDefinitions)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_REFNIBRS_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.Department).WithMany(p => p.RefNibrscodeDefinitions)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REFNIBRS_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<RefOffenseCodeDefinition>(entity =>
        {
            entity.HasKey(e => e.OffenseCodeDefinitionId).HasName("PK_REFOFFENSECODEDEFINITION");

            entity.ToTable("RefOffenseCodeDefinition");

            entity.Property(e => e.OffenseCodeDefinitionId).HasColumnName("OffenseCodeDefinitionID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OffenseName).HasMaxLength(100);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Agency).WithMany(p => p.RefOffenseCodeDefinitions)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_REFOFFEN_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.Department).WithMany(p => p.RefOffenseCodeDefinitions)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REFOFFEN_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<RefPropertyDatum>(entity =>
        {
            entity.HasKey(e => e.RefPropertyDataId).HasName("PK_REFPROPERTYDATA");

            entity.Property(e => e.RefPropertyDataId).HasColumnName("RefPropertyDataID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataValue).HasMaxLength(100);
            entity.Property(e => e.DefaultDollarValue).HasColumnType("money");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DisplaySeq).HasColumnName("DisplaySEQ");
            entity.Property(e => e.DisplayString).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.NibrsdescriptionCode).HasColumnName("NIBRSDescriptionCode");
            entity.Property(e => e.RefCategory).HasMaxLength(100);
            entity.Property(e => e.Rptcategory)
                .HasMaxLength(100)
                .HasColumnName("RPTCategory");
            entity.Property(e => e.Rptcode)
                .HasColumnType("xml")
                .HasColumnName("RPTCode");
            entity.Property(e => e.SubRefCategory).HasMaxLength(100);

            entity.HasOne(d => d.Department).WithMany(p => p.RefPropertyData)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REFPROPE_REFERENCE_DEPARTME");

            entity.HasOne(d => d.NibrsdescriptionCodeNavigation).WithMany(p => p.RefPropertyData)
                .HasForeignKey(d => d.NibrsdescriptionCode)
                .HasConstraintName("FK_RefPropertyData_NIBRSReferenceData");
        });

        modelBuilder.Entity<RefStatuteDefinition>(entity =>
        {
            entity.HasKey(e => e.RefstatuteDefinitionId).HasName("PK_REFSTATUTEDEFINITION");

            entity.ToTable("RefStatuteDefinition");

            entity.Property(e => e.RefstatuteDefinitionId).HasColumnName("REFStatuteDefinitionID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.Appendix).HasMaxLength(100);
            entity.Property(e => e.CashEffectDate).HasColumnType("date");
            entity.Property(e => e.CashFeeAmt)
                .HasColumnType("money")
                .HasColumnName("Cash_Fee_amt");
            entity.Property(e => e.CashFineAmt)
                .HasColumnType("money")
                .HasColumnName("Cash_Fine_amt");
            entity.Property(e => e.CashMunicipalFee)
                .HasColumnType("money")
                .HasColumnName("Cash_Municipal_Fee");
            entity.Property(e => e.CashPlusAmt)
                .HasColumnType("money")
                .HasColumnName("Cash_PLUS_amt");
            entity.Property(e => e.CashRepealDate).HasColumnType("date");
            entity.Property(e => e.CashStfAmt)
                .HasColumnType("money")
                .HasColumnName("Cash_STF_amt");
            entity.Property(e => e.CashSurchargeAmt)
                .HasColumnType("money")
                .HasColumnName("Cash_Surcharge_amt");
            entity.Property(e => e.CashTotalAmt)
                .HasColumnType("money")
                .HasColumnName("Cash_total_amt");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CissverifiedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("CISSVerifiedDateTime");
            entity.Property(e => e.CitationUpdateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CiteAs).HasMaxLength(100);
            entity.Property(e => e.Court).HasMaxLength(50);
            entity.Property(e => e.DataProcessId).HasColumnName("DataProcessID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ImportDateTime).HasColumnType("datetime");
            entity.Property(e => e.ImportSource).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.KeyGroupName).HasMaxLength(100);
            entity.Property(e => e.KeySort).HasMaxLength(100);
            entity.Property(e => e.NibrscodeId).HasColumnName("NIBRSCodeID");
            entity.Property(e => e.OffenseClass).HasMaxLength(100);
            entity.Property(e => e.OffenseType).HasMaxLength(100);
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.ShortName).HasMaxLength(100);
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.Zone).HasMaxLength(50);

            entity.HasOne(d => d.Agency).WithMany(p => p.RefStatuteDefinitions)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_REFSTATU_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.DataProcess).WithMany(p => p.RefStatuteDefinitions)
                .HasForeignKey(d => d.DataProcessId)
                .HasConstraintName("FK_REFSTATU_REFERENCE_DATAPROC");

            entity.HasOne(d => d.Department).WithMany(p => p.RefStatuteDefinitions)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REFSTATU_REFERENCE_DEPARTME");

            entity.HasOne(d => d.Nibrscode).WithMany(p => p.RefStatuteDefinitions)
                .HasForeignKey(d => d.NibrscodeId)
                .HasConstraintName("FK_REFSTATU_REFERENCE_REFNIBRS");

            entity.HasOne(d => d.Ucrcode).WithMany(p => p.RefStatuteDefinitions)
                .HasForeignKey(d => d.UcrcodeId)
                .HasConstraintName("FK_REFSTATU_REFERENCE_REFUCRCO");
        });

        modelBuilder.Entity<RefTrafficStopTicketReferenceDatum>(entity =>
        {
            entity.HasKey(e => e.RefTrafficStopTicketReferenceDataId).HasName("PK_REFTRAFFICSTOPTICKETREFEREN");

            entity.Property(e => e.RefTrafficStopTicketReferenceDataId).HasColumnName("RefTrafficStopTicketReferenceDataID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.DataValue).HasMaxLength(100);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DisplaySeq).HasColumnName("DisplaySEQ");
            entity.Property(e => e.DisplayString).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.RefCategory).HasMaxLength(100);
            entity.Property(e => e.Rptcode)
                .HasColumnType("xml")
                .HasColumnName("RPTCode");
            entity.Property(e => e.SubRefCategory).HasMaxLength(100);

            entity.HasOne(d => d.Agency).WithMany(p => p.RefTrafficStopTicketReferenceData)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_REFTRAFF_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.Department).WithMany(p => p.RefTrafficStopTicketReferenceData)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REFTRAFF_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<RefUcrcodeDefinition>(entity =>
        {
            entity.HasKey(e => e.UcrcodeId).HasName("PK_REFUCRCODEDEFINITION");

            entity.ToTable("RefUCRCodeDefinition");

            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.CategoryGroup).HasMaxLength(50);
            entity.Property(e => e.DataProcessId).HasColumnName("DataProcessID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentReportType).HasMaxLength(300);
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.IsRequiredQc).HasColumnName("IsRequiredQC");
            entity.Property(e => e.IsUcrcategoryCode).HasColumnName("IsUCRCategoryCode");
            entity.Property(e => e.NibrscodeId).HasColumnName("NIBRSCodeID");
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.UcrmajorCode)
                .HasMaxLength(2)
                .HasColumnName("UCRMajorCode");
            entity.Property(e => e.UcrsubCode)
                .HasMaxLength(2)
                .HasColumnName("UCRSubCode");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Agency).WithMany(p => p.RefUcrcodeDefinitions)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_REFUCRCO_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.DataProcess).WithMany(p => p.RefUcrcodeDefinitions)
                .HasForeignKey(d => d.DataProcessId)
                .HasConstraintName("FK_REFUCRCO_REFERENCE_DATAPROC");

            entity.HasOne(d => d.Department).WithMany(p => p.RefUcrcodeDefinitions)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REFUCRCO_REFERENCE_DEPARTME");

            entity.HasOne(d => d.Nibrscode).WithMany(p => p.RefUcrcodeDefinitions)
                .HasForeignKey(d => d.NibrscodeId)
                .HasConstraintName("FK_NIBRSUCRCode");
        });

        modelBuilder.Entity<RefViolation>(entity =>
        {
            entity.HasKey(e => e.ViolationId).HasName("PK_REFVIOLATION");

            entity.ToTable("RefViolation");

            entity.Property(e => e.ViolationId)
                .ValueGeneratedNever()
                .HasColumnName("ViolationID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FineAmount).HasColumnType("money");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.RecordEffectedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.RefstatuteDefinition).HasColumnName("REFStatuteDefinition");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.Agency).WithMany(p => p.RefViolations)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_REFVIOLA_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.Department).WithMany(p => p.RefViolations)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REFVIOLA_REFERENCE_DEPARTME");

            entity.HasOne(d => d.RefstatuteDefinitionNavigation).WithMany(p => p.RefViolations)
                .HasForeignKey(d => d.RefstatuteDefinition)
                .HasConstraintName("FK_REFVIOLA_REFERENCE_REFSTATU");
        });

        modelBuilder.Entity<ReportContainer>(entity =>
        {
            entity.HasKey(e => e.ReportContainerId).HasName("PK_REPORTCONTAINER");

            entity.ToTable("ReportContainer");

            entity.HasIndex(e => e.SecurityRoleRequired, "IX_ReportContainer_SecurityRoleRequired");

            entity.Property(e => e.ReportContainerId).HasColumnName("ReportContainerID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepApplicationUsageId).HasColumnName("DepApplicationUsageID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DisplaySeq).HasColumnName("DisplaySEQ");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.DepApplicationUsage).WithMany(p => p.ReportContainers)
                .HasForeignKey(d => d.DepApplicationUsageId)
                .HasConstraintName("FK_REPORTCO_REFERENCE_DEPAPPLI");

            entity.HasOne(d => d.Department).WithMany(p => p.ReportContainers)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_REPORTCO_REFERENCE_DEPARTME");

            entity.HasOne(d => d.SecurityRoleRequiredNavigation).WithMany(p => p.ReportContainers)
                .HasForeignKey(d => d.SecurityRoleRequired)
                .HasConstraintName("FK_REPORTCO_REFERENCE_SECURITY");
        });

        modelBuilder.Entity<ReportDefinition>(entity =>
        {
            entity.HasKey(e => e.ReportDefinitionId).HasName("PK_REPORTDEFINITION");

            entity.ToTable("ReportDefinition");

            entity.HasIndex(e => e.SecurityRoleRequired, "IX_ReportDefinition_SecurityRoleRequired");

            entity.Property(e => e.ReportDefinitionId).HasColumnName("ReportDefinitionID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExternalLinkPara).HasColumnType("xml");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.ReportContainerId).HasColumnName("ReportContainerID");
            entity.Property(e => e.ReportType).HasMaxLength(100);
            entity.Property(e => e.RptServicePara).HasColumnType("xml");
            entity.Property(e => e.RptdefintionName).HasColumnName("RPTDefintionName");
            entity.Property(e => e.RptserviceLink).HasColumnName("RPTServiceLink");

            entity.HasOne(d => d.ReportContainer).WithMany(p => p.ReportDefinitions)
                .HasForeignKey(d => d.ReportContainerId)
                .HasConstraintName("FK_REPORTDE_REFERENCE_REPORTCO");

            entity.HasOne(d => d.SecurityRoleRequiredNavigation).WithMany(p => p.ReportDefinitions)
                .HasForeignKey(d => d.SecurityRoleRequired)
                .HasConstraintName("FK_REPORTDE_REFERENCE_SECURITY");
        });

        modelBuilder.Entity<ReportHelper>(entity =>
        {
            entity.HasKey(e => e.ReportHelperId).HasName("PK_REPORTHELPER");

            entity.ToTable("ReportHelper");

            entity.HasIndex(e => e.ReportDefinitionId, "IX_ReportHelper_ReportDefinitionID");

            entity.Property(e => e.ReportHelperId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ReportHelperID");
            entity.Property(e => e.RefItemId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RefItemID");
            entity.Property(e => e.ReferenceTableName).HasMaxLength(300);
            entity.Property(e => e.ReportCategory).HasMaxLength(300);
            entity.Property(e => e.ReportDefinitionId).HasColumnName("ReportDefinitionID");
            entity.Property(e => e.ReportGroup).HasMaxLength(300);
            entity.Property(e => e.ReportName).HasMaxLength(300);

            entity.HasOne(d => d.ReportDefinition).WithMany(p => p.ReportHelpers)
                .HasForeignKey(d => d.ReportDefinitionId)
                .HasConstraintName("FK_REPORTHE_REFERENCE_REPORTDE");
        });

        modelBuilder.Entity<RestoreCancelledApplicationDatum>(entity =>
        {
            entity.HasKey(e => e.RestoreCancelledApplicationDataId).HasName("PK_RestoredCancelledApplicationData");

            entity.Property(e => e.RestoreCancelledApplicationDataId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RestoreCancelledApplicationDataID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ApplicationData).HasColumnType("xml");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(100);
            entity.Property(e => e.ApplicationPkid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationPKID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.RestoreCancelledApplicationData)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_RestoredCancelledApplicationData_SYSRMSApplicationType");

            entity.HasOne(d => d.Department).WithMany(p => p.RestoreCancelledApplicationData)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_RestoredCancelledApplicationData_Departments");
        });

        modelBuilder.Entity<RmsapplicationActionTrace>(entity =>
        {
            entity.HasKey(e => e.RmsapplicationActionTraceId).HasName("PK_RMSAPPLICATIONACTIONTRACE");

            entity.ToTable("RMSApplicationActionTrace");

            entity.HasIndex(e => e.ApplicationPkid, "NonClusteredIndex-20151014-094916");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationPkid }, "RMSApplicationActionTrace_ApplicationType_ApplicationPKID");

            entity.Property(e => e.RmsapplicationActionTraceId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSApplicationActionTraceID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationPkid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationPKID");
            entity.Property(e => e.ApplicationStatusId).HasColumnName("ApplicationStatusID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.InvestigativeStatusId).HasColumnName("InvestigativeStatusID");
            entity.Property(e => e.ReportStatusStatusId).HasColumnName("ReportStatusStatusID");
            entity.Property(e => e.RmsuserAccessId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSUserAccessID");
            entity.Property(e => e.RmsworkFlowDefId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSWorkFlowDefID");
            entity.Property(e => e.SysapplicationActionTraceTemplateId).HasColumnName("SYSApplicationActionTraceTemplateID");

            entity.HasOne(d => d.ApplicationStatus).WithMany(p => p.RmsapplicationActionTraceApplicationStatuses)
                .HasForeignKey(d => d.ApplicationStatusId)
                .HasConstraintName("FK_RMSAPPLI_REFERENCE_SYSAPPLI3");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.RmsapplicationActionTraces)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_RMSAPPLI_REFERENCE_SYSRMSAP2");

            entity.HasOne(d => d.InvestigativeStatus).WithMany(p => p.RmsapplicationActionTraceInvestigativeStatuses)
                .HasForeignKey(d => d.InvestigativeStatusId)
                .HasConstraintName("FK_RMSAPPLI_REFERENCE_SYSAPPLI");

            entity.HasOne(d => d.ReportStatusStatus).WithMany(p => p.RmsapplicationActionTraceReportStatusStatuses)
                .HasForeignKey(d => d.ReportStatusStatusId)
                .HasConstraintName("FK_RMSAPPLI_REFERENCE_SYSAPPLI4");

            entity.HasOne(d => d.RmsworkFlowDef).WithMany(p => p.RmsapplicationActionTraces)
                .HasForeignKey(d => d.RmsworkFlowDefId)
                .HasConstraintName("FK_RMSAPPLI_REFERENCE_RMSWORKF");

            entity.HasOne(d => d.SysapplicationActionTraceTemplate).WithMany(p => p.RmsapplicationActionTraces)
                .HasForeignKey(d => d.SysapplicationActionTraceTemplateId)
                .HasConstraintName("FK_RMSAPPLI_REFERENCE_SYSAPPLI2");
        });

        modelBuilder.Entity<RmsapplicationDataExportLog>(entity =>
        {
            entity.HasKey(e => e.RmsapplicationDataExportLogId).HasName("PK_RMSAPPLICATIONDATAEXPORTLOG");

            entity.ToTable("RMSApplicationDataExportLog");

            entity.HasIndex(e => new { e.ApplicationNumber, e.ExportStatus, e.RmsapplicationDataExportLogId }, "IX_RMSApplicationDataExportLog_ApplicationNumber_ExportStatus").IsUnique();

            entity.HasIndex(e => new { e.ApplicationPkid, e.SysrmsapplicationTypeId, e.ExportStatus, e.RmsapplicationDataExportLogId }, "IX_RMSApplicationDataExportLog_ApplicationPKID_SYSRMSApplicationTypeID_ExportStatus_RMSApplicationDataExportLogID").IsUnique();

            entity.HasIndex(e => new { e.ExportStatus, e.ApplicationNumber, e.RmsapplicationDataExportLogId }, "IX_RMSApplicationDataExportLog_ExportStatus_ApplicationNumber").IsUnique();

            entity.HasIndex(e => new { e.SysrmsapplicationTypeId, e.ApplicationPkid }, "IX_RMSApplicationDataExportLog_SYSRMSApplicationTypeID_ApplicationPKID");

            entity.Property(e => e.RmsapplicationDataExportLogId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSApplicationDataExportLogID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(100);
            entity.Property(e => e.ApplicationPkid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationPKID");
            entity.Property(e => e.CissrequestId)
                .HasMaxLength(20)
                .HasColumnName("CISSRequestId");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Environment).HasMaxLength(150);
            entity.Property(e => e.ExportStatus).HasMaxLength(100);
            entity.Property(e => e.ExportTrace).IsUnicode(false);
            entity.Property(e => e.SysrmsapplicationTypeId).HasColumnName("SYSRMSApplicationTypeID");

            entity.HasOne(d => d.Department).WithMany(p => p.RmsapplicationDataExportLogs)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_RMSAPPLI_REFERENCE_DEPARTME");

            entity.HasOne(d => d.SysrmsapplicationType).WithMany(p => p.RmsapplicationDataExportLogs)
                .HasForeignKey(d => d.SysrmsapplicationTypeId)
                .HasConstraintName("FK_RMSAPPLI_REFERENCE_SYSRMSAP");
        });

        modelBuilder.Entity<RmsdataChangeTrace>(entity =>
        {
            entity.HasKey(e => e.RmsdataChangeTraceId).HasName("PK_RMSDATACHANGETRACE");

            entity.ToTable("RMSDataChangeTrace");

            entity.Property(e => e.RmsdataChangeTraceId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSDataChangeTraceID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ChangeValueList).HasColumnType("xml");
            entity.Property(e => e.ChangedTableName).HasMaxLength(100);
            entity.Property(e => e.ChangedTablePkcolumnName)
                .HasMaxLength(100)
                .HasColumnName("ChangedTablePKColumnName");
            entity.Property(e => e.ChangedTablePkcolumnValue)
                .HasMaxLength(100)
                .HasColumnName("ChangedTablePKColumnValue");
            entity.Property(e => e.RmsuserAccessId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSUserAccessID");
        });

        modelBuilder.Entity<RmsdataDeleteTrace>(entity =>
        {
            entity.HasKey(e => e.RmsdataDeleteTraceId).HasName("PK_RMSDATADELETETRACE");

            entity.ToTable("RMSDataDeleteTrace");

            entity.Property(e => e.RmsdataDeleteTraceId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSDataDeleteTraceID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeleteValueList).HasColumnType("xml");
            entity.Property(e => e.DeletedRecordPkcolumnName)
                .HasMaxLength(100)
                .HasColumnName("DeletedRecordPKColumnName");
            entity.Property(e => e.DeletedRecordPkvalue)
                .HasMaxLength(100)
                .HasColumnName("DeletedRecordPKValue");
            entity.Property(e => e.DeletedRecordTableName).HasMaxLength(100);
            entity.Property(e => e.RmsuserAccessId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSUserAccessID");
        });

        modelBuilder.Entity<RmsdataProcessController>(entity =>
        {
            entity.HasKey(e => e.RmsdataProcessControllerId).HasName("PK_RMSDATAPROCESSCONTROLLER");

            entity.ToTable("RMSDataProcessController");

            entity.HasIndex(e => e.ProcessGeneratedByControllerId, "<Name of Missing Index, sysname,>");

            entity.HasIndex(e => e.ProcessGeneratedByControllerId, "INX_RMSDataprocessController");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationPkid, e.DataMappingObjectName }, "NonClusteredIndex-20161108-151836");

            entity.HasIndex(e => new { e.DataMappingObjectName, e.DataMappingObjectId }, "NonClusteredIndex-20161108-152053");

            entity.Property(e => e.RmsdataProcessControllerId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSDataProcessControllerID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationPkid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationPKID");
            entity.Property(e => e.CurrentProcessDataItemSeq).HasColumnName("CurrentProcessDataItemSEQ");
            entity.Property(e => e.CurrentProcessStepDetailId).HasColumnName("CurrentProcessStepDetailID");
            entity.Property(e => e.CurrentProcessStepId).HasColumnName("CurrentProcessStepID");
            entity.Property(e => e.DataMappingObjectId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DataMappingObjectID");
            entity.Property(e => e.DataMappingObjectName).HasMaxLength(100);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GeneratedByDataProcessRuleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("GeneratedByDataProcessRuleID");
            entity.Property(e => e.ProcessGeneratedByControllerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ProcessGeneratedByControllerID");
            entity.Property(e => e.ProcessRmsdataProcessId).HasColumnName("ProcessRMSDataProcessID");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.StatusDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.RmsdataProcessControllers)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_RMSDATAP_REFERENCE_SYSRMSAP");

            entity.HasOne(d => d.CurrentProcessStepDetail).WithMany(p => p.RmsdataProcessControllers)
                .HasForeignKey(d => d.CurrentProcessStepDetailId)
                .HasConstraintName("FK_RMSDATAP_REFERENCE_PROCESSS2");

            entity.HasOne(d => d.CurrentProcessStep).WithMany(p => p.RmsdataProcessControllers)
                .HasForeignKey(d => d.CurrentProcessStepId)
                .HasConstraintName("FK_RMSDATAP_REFERENCE_DATAPROC6");

            entity.HasOne(d => d.Department).WithMany(p => p.RmsdataProcessControllers)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_RMSDATAP_REFERENCE_DEPARTME");

            entity.HasOne(d => d.ProcessGeneratedByController).WithMany(p => p.InverseProcessGeneratedByController)
                .HasForeignKey(d => d.ProcessGeneratedByControllerId)
                .HasConstraintName("FK_RMSDATAP_REFERENCE_RMSDATAP2");

            entity.HasOne(d => d.ProcessRmsdataProcess).WithMany(p => p.RmsdataProcessControllers)
                .HasForeignKey(d => d.ProcessRmsdataProcessId)
                .HasConstraintName("FK_RMSDATAP_REFERENCE_DATAPROC2");
        });

        modelBuilder.Entity<RmsdataProcessDetailStep>(entity =>
        {
            entity.HasKey(e => e.RmsdataProcessControllerDetailId).HasName("PK_RMSDATAPROCESSDETAILSTEP");

            entity.ToTable("RMSDataProcessDetailStep");

            entity.HasIndex(e => new { e.RmsdataProcessControllerId, e.StepStatus }, "IX_RMSDataProcessDetailStep_RMSDataProcessControllerID_StepStatus");

            entity.HasIndex(e => e.UserProcessStepId, "IX_RMSDataProcessDetailStep_UserProcessStepID");

            entity.Property(e => e.RmsdataProcessControllerDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSDataProcessControllerDetailID");
            entity.Property(e => e.AddedName).HasMaxLength(100);
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataMappingObjectPropertyName).HasMaxLength(100);
            entity.Property(e => e.DataMappingSubObjectId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DataMappingSubObjectID");
            entity.Property(e => e.DataMappingSubObjectName).HasMaxLength(100);
            entity.Property(e => e.DataMappingSubObjectPropertyName).HasMaxLength(100);
            entity.Property(e => e.EditedName).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MappingTableColumn).HasMaxLength(100);
            entity.Property(e => e.MappingTableName).HasMaxLength(100);
            entity.Property(e => e.MappingTablePkvalue)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MappingTablePKValue");
            entity.Property(e => e.RefDataId).HasColumnName("RefDataID");
            entity.Property(e => e.RmsdataProcessControllerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSDataProcessControllerID");
            entity.Property(e => e.StepStatus).HasMaxLength(100);
            entity.Property(e => e.UserProcessDetailStepId).HasColumnName("UserProcessDetailStepID");
            entity.Property(e => e.UserProcessStepDataItemId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("UserProcessStepDataItemID");
            entity.Property(e => e.UserProcessStepId).HasColumnName("UserProcessStepID");

            entity.HasOne(d => d.RmsdataProcessController).WithMany(p => p.RmsdataProcessDetailSteps)
                .HasForeignKey(d => d.RmsdataProcessControllerId)
                .HasConstraintName("FK_RMSDATAP_REFERENCE_RMSDATAP3");

            entity.HasOne(d => d.UserProcessDetailStep).WithMany(p => p.RmsdataProcessDetailSteps)
                .HasForeignKey(d => d.UserProcessDetailStepId)
                .HasConstraintName("FK_RMSDATAP_REFERENCE_DATAPROC7");

            entity.HasOne(d => d.UserProcessStepDataItem).WithMany(p => p.RmsdataProcessDetailSteps)
                .HasForeignKey(d => d.UserProcessStepDataItemId)
                .HasConstraintName("FK_RMSDATAP_REFERENCE_DATAPROC5");

            entity.HasOne(d => d.UserProcessStep).WithMany(p => p.RmsdataProcessDetailSteps)
                .HasForeignKey(d => d.UserProcessStepId)
                .HasConstraintName("FK_RMSDATAP_REFERENCE_PROCESSS3");
        });

        modelBuilder.Entity<RmsdataProcessDetailStepRulesAction>(entity =>
        {
            entity.HasKey(e => e.RmsdataProcessDetailStepRulesActionId).HasName("PK_RMSDATAPROCESSDETAILSTEPRUL");

            entity.ToTable("RMSDataProcessDetailStepRulesActions");

            entity.HasIndex(e => e.DataProcessRuleActionId, "IX_RMSDataProcessDetailStepRulesActions_DataProcessRuleActionID");

            entity.HasIndex(e => e.DataProcessRuleId, "IX_RMSDataProcessDetailStepRulesActions_DataProcessRuleID");

            entity.HasIndex(e => e.RmsdataProcessControllerDetailId, "IX_RMSDataProcessDetailStepRulesActions_RMSDataProcessControllerDetailID");

            entity.Property(e => e.RmsdataProcessDetailStepRulesActionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSDataProcessDetailStepRulesActionID");
            entity.Property(e => e.AddedName).HasMaxLength(100);
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataProcessRuleActionId).HasColumnName("DataProcessRuleActionID");
            entity.Property(e => e.DataProcessRuleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DataProcessRuleID");
            entity.Property(e => e.RmsdataProcessControllerDetailId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSDataProcessControllerDetailID");

            entity.HasOne(d => d.DataProcessRuleAction).WithMany(p => p.RmsdataProcessDetailStepRulesActions)
                .HasForeignKey(d => d.DataProcessRuleActionId)
                .HasConstraintName("FK_RMSDATAP_REFERENCE_DATAPROC");

            entity.HasOne(d => d.DataProcessRule).WithMany(p => p.RmsdataProcessDetailStepRulesActions)
                .HasForeignKey(d => d.DataProcessRuleId)
                .HasConstraintName("FK_RMSDATAP_REFERENCE_DATAPROC3");

            entity.HasOne(d => d.RmsdataProcessControllerDetail).WithMany(p => p.RmsdataProcessDetailStepRulesActions)
                .HasForeignKey(d => d.RmsdataProcessControllerDetailId)
                .HasConstraintName("FK_RMSDATAP_REFERENCE_RMSDATAP");
        });

        modelBuilder.Entity<RmsdeptWorkFlow>(entity =>
        {
            entity.HasKey(e => e.RmsdeptWorkFlowId).HasName("PK_RMSDEPTWORKFLOW");

            entity.ToTable("RMSDeptWorkFlow");

            entity.HasIndex(e => new { e.RmsworkFlowPlanId, e.DepartmentId, e.IsActive }, "RMSDeptWorkFlow_RMSWorkFlowPlanID_DepartmentID_IsActive");

            entity.Property(e => e.RmsdeptWorkFlowId).HasColumnName("RMSDeptWorkFlowID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.RmsworkFlowPlanId).HasColumnName("RMSWorkFlowPlanID");
            entity.Property(e => e.SysrmsapplicationTypeId).HasColumnName("SYSRMSApplicationTypeID");

            entity.HasOne(d => d.Department).WithMany(p => p.RmsdeptWorkFlows)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_RMSDEPTW_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.RmsworkFlowPlan).WithMany(p => p.RmsdeptWorkFlows)
                .HasForeignKey(d => d.RmsworkFlowPlanId)
                .HasConstraintName("FK_RMSDEPTW_REFERENCE_RMSWORKF2");

            entity.HasOne(d => d.SysrmsapplicationType).WithMany(p => p.RmsdeptWorkFlows)
                .HasForeignKey(d => d.SysrmsapplicationTypeId)
                .HasConstraintName("FK_RMSDEPTW_REFERENCE_SYSRMSAP");
        });

        modelBuilder.Entity<RmsdeptWorkFlowReviewRequirement>(entity =>
        {
            entity.HasKey(e => e.RmsdeptWorkFlowReviewRequirementsId).HasName("PK_RMSDEPTWORKFLOWREVIEWREQUIR");

            entity.ToTable("RMSDeptWorkFlowReviewRequirements");

            entity.HasIndex(e => e.RmsdeptWorkFlowId, "IX_RMSDeptWorkFlowReviewRequirements_RMSDeptWorkFlowID");

            entity.HasIndex(e => e.RmsworkFlowDefId, "IX_RMSDeptWorkFlowReviewRequirements_RMSWorkFlowDefID");

            entity.HasIndex(e => e.ReqReviewEmployeeId, "IX_RMSDeptWorkFlowReviewRequirements_ReqReviewEmployeeID");

            entity.Property(e => e.RmsdeptWorkFlowReviewRequirementsId).HasColumnName("RMSDeptWorkFlowReviewRequirementsID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ReqReviewEmployeeId).HasColumnName("ReqReviewEmployeeID");
            entity.Property(e => e.ReqReviewOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ReqReviewOrgID");
            entity.Property(e => e.RmsdeptWorkFlowId).HasColumnName("RMSDeptWorkFlowID");
            entity.Property(e => e.RmsworkFlowDefId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSWorkFlowDefID");

            entity.HasOne(d => d.ReqReviewEmployee).WithMany(p => p.RmsdeptWorkFlowReviewRequirements)
                .HasForeignKey(d => d.ReqReviewEmployeeId)
                .HasConstraintName("FK_RMSDEPTW_REFERENCE_DEPARTME");

            entity.HasOne(d => d.ReqReviewOrg).WithMany(p => p.RmsdeptWorkFlowReviewRequirements)
                .HasForeignKey(d => d.ReqReviewOrgId)
                .HasConstraintName("FK_RMSDEPTW_REFERENCE_DEPARTME3");

            entity.HasOne(d => d.RmsdeptWorkFlow).WithMany(p => p.RmsdeptWorkFlowReviewRequirements)
                .HasForeignKey(d => d.RmsdeptWorkFlowId)
                .HasConstraintName("FK_RMSDEPTW_REFERENCE_RMSDEPTW");

            entity.HasOne(d => d.RmsworkFlowDef).WithMany(p => p.RmsdeptWorkFlowReviewRequirements)
                .HasForeignKey(d => d.RmsworkFlowDefId)
                .HasConstraintName("FK_RMSDEPTW_REFERENCE_RMSWORKF");
        });

        modelBuilder.Entity<RmsimportLog>(entity =>
        {
            entity.ToTable("RMSImportLog");

            entity.Property(e => e.RmsimportLogId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSImportLogID");
            entity.Property(e => e.Addedon).HasColumnType("datetime");
            entity.Property(e => e.Category).HasMaxLength(100);
            entity.Property(e => e.FileName).HasMaxLength(100);
            entity.Property(e => e.FileUploadedRaw).HasColumnName("FileUploadedRAW");
        });

        modelBuilder.Entity<RmsnotificationLog>(entity =>
        {
            entity.HasKey(e => e.SysNotificationLogId).HasName("PK_RMSNOTIFICATIONLOG");

            entity.ToTable("RMSNotificationLog");

            entity.HasIndex(e => new { e.SysrmsapplicationTypeId, e.ApplicationPkid }, "IX_RMSNotificationLog_SYSRMSApplicationTypeID_ApplicationPKID");

            entity.HasIndex(e => new { e.EmployeeNotifiedId, e.Unacknowledged, e.DateTimeCreated }, "RMSNotificationLog_EmployeeNotifiedID_Unacknowledged_DateTimeCreated").IsDescending(false, false, true);

            entity.Property(e => e.SysNotificationLogId).HasColumnName("SysNotificationLogID");
            entity.Property(e => e.AcknowledgedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(250);
            entity.Property(e => e.ApplicationPkid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationPKID");
            entity.Property(e => e.DateTimeCreated).HasColumnType("datetime");
            entity.Property(e => e.EmployeeCreatedId).HasColumnName("EmployeeCreatedID");
            entity.Property(e => e.EmployeeNotifiedId).HasColumnName("EmployeeNotifiedID");
            entity.Property(e => e.NotifcationCategory).HasMaxLength(250);
            entity.Property(e => e.SysNotificationConditionsId).HasColumnName("SysNotificationConditionsID");
            entity.Property(e => e.SysNotificationTemplateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SysNotificationTemplateID");
            entity.Property(e => e.SysrmsapplicationTypeId).HasColumnName("SYSRMSApplicationTypeID");

            entity.HasOne(d => d.EmployeeCreated).WithMany(p => p.RmsnotificationLogEmployeeCreateds)
                .HasForeignKey(d => d.EmployeeCreatedId)
                .HasConstraintName("FK_RMSNOTIF_REFERENCE_DEPARTME");

            entity.HasOne(d => d.EmployeeNotified).WithMany(p => p.RmsnotificationLogEmployeeNotifieds)
                .HasForeignKey(d => d.EmployeeNotifiedId)
                .HasConstraintName("FK_RMSNOTIF_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.SysNotificationConditions).WithMany(p => p.RmsnotificationLogs)
                .HasForeignKey(d => d.SysNotificationConditionsId)
                .HasConstraintName("FK_RMSNOTIF_REFERENCE_SYSNOTIF");

            entity.HasOne(d => d.SysNotificationTemplate).WithMany(p => p.RmsnotificationLogs)
                .HasForeignKey(d => d.SysNotificationTemplateId)
                .HasConstraintName("FK_RMSNOTIF_REFERENCE_SYSNOTIF2");

            entity.HasOne(d => d.SysrmsapplicationType).WithMany(p => p.RmsnotificationLogs)
                .HasForeignKey(d => d.SysrmsapplicationTypeId)
                .HasConstraintName("FK_RMSNOTIF_REFERENCE_SYSRMSAP");
        });

        modelBuilder.Entity<RmsuserAccessTrace>(entity =>
        {
            entity.HasKey(e => e.RmsuserAccessId).HasName("PK_RMSUSERACCESSTRACE");

            entity.ToTable("RMSUserAccessTrace");

            entity.Property(e => e.RmsuserAccessId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSUserAccessID");
            entity.Property(e => e.AccessToken).HasMaxLength(50);
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.BrowserInformation).HasMaxLength(200);
            entity.Property(e => e.CtcrmsloginFromCtcmobile).HasColumnName("CTCRMSLoginFromCTCMobile");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .HasColumnName("IP");
            entity.Property(e => e.IsCtcmobileLogin).HasColumnName("IsCTCMobileLogin");
            entity.Property(e => e.IsSystemLogoff).HasDefaultValueSql("((0))");
            entity.Property(e => e.LastIdleDateTime).HasColumnType("datetime");
            entity.Property(e => e.LoginDateTime).HasColumnType("datetime");
            entity.Property(e => e.LogoffDateTime).HasColumnType("datetime");
            entity.Property(e => e.MachineName).HasMaxLength(50);
            entity.Property(e => e.SessionTrace).HasColumnType("xml");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<RmsuserQueryResult>(entity =>
        {
            entity.HasKey(e => e.RmsuserQueryResultId).HasName("PK_RMSUSERQUERYRESULTS");

            entity.ToTable("RMSUserQueryResults");

            entity.HasIndex(e => e.GeneratedByRmsuserQueryResultId, "IX_RMSUserQueryResults_GeneratedByRMSUserqueryresultID ");

            entity.HasIndex(e => e.QueryType, "IX_RMSUserQueryResults_QueryType");

            entity.HasIndex(e => e.RequestedByDepartmentEmployeeId, "IX_RMSUserQueryResults_RequestedByDepartmentEmployeeID");

            entity.Property(e => e.RmsuserQueryResultId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSUserQueryResultID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CaptainCollectErrorText).HasMaxLength(500);
            entity.Property(e => e.CaptainCollectStatusId).HasColumnName("CaptainCollectStatusID");
            entity.Property(e => e.CaptainCtcollecScreenResult).HasColumnName("CaptainCTCollecScreenResult");
            entity.Property(e => e.CaptainCtcollectQueryResult)
                .HasColumnType("xml")
                .HasColumnName("CaptainCTCollectQueryResult");
            entity.Property(e => e.CollectQueryRequest).HasColumnType("xml");
            entity.Property(e => e.CollectQueryResult).HasColumnType("xml");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GeneratedByRmsuserQueryResultId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("GeneratedBy_RMSUserQueryResultID");
            entity.Property(e => e.LinkedMstrpersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LinkedMSTRPersonID");
            entity.Property(e => e.LinkedMstrpropertyId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LinkedMSTRPropertyID");
            entity.Property(e => e.LinkedMstrvehicleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LinkedMSTRVehicleID");
            entity.Property(e => e.QueryDuration).HasMaxLength(100);
            entity.Property(e => e.QueryRequest).HasColumnType("xml");
            entity.Property(e => e.QueryResult).HasColumnType("xml");
            entity.Property(e => e.QueryResultDateTime).HasColumnType("datetime");
            entity.Property(e => e.QuerySubmitDateTime).HasColumnType("datetime");
            entity.Property(e => e.QueryType).HasMaxLength(100);
            entity.Property(e => e.RequestedByDepartmentEmployeeId).HasColumnName("RequestedByDepartmentEmployeeID");
            entity.Property(e => e.RequestedByUserId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("RequestedByUserID");
            entity.Property(e => e.Source).HasMaxLength(20);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.CaptainCollectStatus).WithMany(p => p.RmsuserQueryResults)
                .HasForeignKey(d => d.CaptainCollectStatusId)
                .HasConstraintName("FK__RMSUserQu__Capta__6E8C3269");

            entity.HasOne(d => d.GeneratedByRmsuserQueryResult).WithMany(p => p.InverseGeneratedByRmsuserQueryResult)
                .HasForeignKey(d => d.GeneratedByRmsuserQueryResultId)
                .HasConstraintName("FK_RMSUSERQ_REFERENCE_RMSUSERQ");
        });

        modelBuilder.Entity<RmsworkFlowController>(entity =>
        {
            entity.HasKey(e => e.RmsworkFlowControllerId).HasName("PK_RMSWORKFLOWCONTROLLER");

            entity.ToTable("RMSWorkFlowController");

            entity.HasIndex(e => new { e.ApplicationId, e.IsWffinished, e.IsLastWorkFlowForApplication }, "RMSWorkFlowController_AppId_IsWFFinished_IsLastworkFlowForApplication");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationId }, "RMSWorkFlowController_ApplicationType_ApplicationID");

            entity.HasIndex(e => new { e.ApplicationType, e.IsWffinished }, "RMSWorkFlowController_ApplicationType_IsWFFinished");

            entity.HasIndex(e => new { e.IsWffinished, e.IsLastWorkFlowForApplication }, "RMSWorkFlowController_IsWFFinished_IsLastWorkFlowForApplication");

            entity.HasIndex(e => e.WfactionAssignedOrgId, "RMSWorkFlowController_Org");

            entity.HasIndex(e => new { e.RefWorkFlowDefId, e.ApplicationType, e.IsWffinished, e.IsLastWorkFlowForApplication }, "RMSWorkFlowController_RAII_WWAA");

            entity.Property(e => e.RmsworkFlowControllerId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSWorkFlowControllerID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationID");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsWffinished).HasColumnName("IsWFFinished");
            entity.Property(e => e.RefWorkFlowDefId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RefWorkFlowDefID");
            entity.Property(e => e.ReportWriterId).HasColumnName("ReportWriterID");
            entity.Property(e => e.WfactionAssignedEmpId).HasColumnName("WFActionAssignedEmpID");
            entity.Property(e => e.WfactionAssignedOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("WFActionAssignedOrgID");
            entity.Property(e => e.WffinishedDt)
                .HasColumnType("datetime")
                .HasColumnName("WFFinishedDT");
            entity.Property(e => e.WfstartDt)
                .HasColumnType("datetime")
                .HasColumnName("WFStartDT");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.RmsworkFlowControllers)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_RMSWORKF_REFERENCE_SYSRMSAP");

            entity.HasOne(d => d.Department).WithMany(p => p.RmsworkFlowControllers)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_RMSWORKF_REFERENCE_DEPARTME6");

            entity.HasOne(d => d.RefWorkFlowDef).WithMany(p => p.RmsworkFlowControllers)
                .HasForeignKey(d => d.RefWorkFlowDefId)
                .HasConstraintName("FK_RMSWORKF_REFERENCE_RMSWORKF2");

            entity.HasOne(d => d.ReportWriter).WithMany(p => p.RmsworkFlowControllerReportWriters)
                .HasForeignKey(d => d.ReportWriterId)
                .HasConstraintName("FK_RMSWORKF_REFERENCE_DEPARTME5");

            entity.HasOne(d => d.WfactionAssignedEmp).WithMany(p => p.RmsworkFlowControllerWfactionAssignedEmps)
                .HasForeignKey(d => d.WfactionAssignedEmpId)
                .HasConstraintName("FK_RMSWORKF_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.WfactionAssignedOrg).WithMany(p => p.RmsworkFlowControllers)
                .HasForeignKey(d => d.WfactionAssignedOrgId)
                .HasConstraintName("FK_RMSWORKF_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<RmsworkFlowDef>(entity =>
        {
            entity.HasKey(e => e.RmsworkFlowDefId).HasName("PK_RMSWORKFLOWDEF");

            entity.ToTable("RMSWorkFlowDef");

            entity.HasIndex(e => e.ApplicationType, "IX_RMSWorkFlowDef_ApplicationType");

            entity.HasIndex(e => e.RmsworkFlowPlanId, "IX_RMSWorkFlowDef_RMSWorkFlowPlanID");

            entity.Property(e => e.RmsworkFlowDefId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSWorkFlowDefID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsRequiredWfaction).HasColumnName("IsRequiredWFAction");
            entity.Property(e => e.PendingApplicationStatusId).HasColumnName("PendingApplicationStatusID");
            entity.Property(e => e.PendingReportStatusId).HasColumnName("PendingReportStatusID");
            entity.Property(e => e.ReviewingApplicationStatusId).HasColumnName("ReviewingApplicationStatusID");
            entity.Property(e => e.ReviewingReportStatusId).HasColumnName("ReviewingReportStatusID");
            entity.Property(e => e.RmsworkFlowPlanId).HasColumnName("RMSWorkFlowPlanID");
            entity.Property(e => e.WorkFlowName).HasMaxLength(100);

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.RmsworkFlowDefs)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_RMSWORKF_REFERENCE_SYSRMSAP2");

            entity.HasOne(d => d.PendingApplicationStatus).WithMany(p => p.RmsworkFlowDefPendingApplicationStatuses)
                .HasForeignKey(d => d.PendingApplicationStatusId)
                .HasConstraintName("FK_RMSWORKF_REFERENCE_SYSAPPLI5");

            entity.HasOne(d => d.PendingReportStatus).WithMany(p => p.RmsworkFlowDefPendingReportStatuses)
                .HasForeignKey(d => d.PendingReportStatusId)
                .HasConstraintName("FK_RMSWORKF_REFERENCE_SYSAPPLI2");

            entity.HasOne(d => d.ReviewingApplicationStatus).WithMany(p => p.RmsworkFlowDefReviewingApplicationStatuses)
                .HasForeignKey(d => d.ReviewingApplicationStatusId)
                .HasConstraintName("FK_RMSWORKF_REFERENCE_SYSAPPLI8");

            entity.HasOne(d => d.ReviewingReportStatus).WithMany(p => p.RmsworkFlowDefReviewingReportStatuses)
                .HasForeignKey(d => d.ReviewingReportStatusId)
                .HasConstraintName("FK_RMSWORKF_REFERENCE_SYSAPPLI");

            entity.HasOne(d => d.RmsworkFlowPlan).WithMany(p => p.RmsworkFlowDefs)
                .HasForeignKey(d => d.RmsworkFlowPlanId)
                .HasConstraintName("FK_RMSWORKF_REFERENCE_RMSWORKF");
        });

        modelBuilder.Entity<RmsworkFlowPlan>(entity =>
        {
            entity.HasKey(e => e.RmsworkFlowPlanId).HasName("PK_RMSWORKFLOWPLAN");

            entity.ToTable("RMSWorkFlowPlan");

            entity.Property(e => e.RmsworkFlowPlanId).HasColumnName("RMSWorkFlowPlanID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.WorkFlowPlanName).HasMaxLength(200);
        });

        modelBuilder.Entity<RptArrestByHour1getArrestTimeRange>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_ArrestByHour_1GetArrestTimeRange");

            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.ArrestbookingId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArrestbookingID");
            entity.Property(e => e.ArresttimeRange)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
        });

        modelBuilder.Entity<RptArrestByHour2allHour>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_ArrestByHour_2AllHour");

            entity.Property(e => e.ReportGroup).HasMaxLength(300);
        });

        modelBuilder.Entity<RptArrestByRaceSex>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_ArrestByRaceSex");

            entity.Property(e => e.ArrestBookingId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArrestBookingID");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.Race).HasMaxLength(100);
            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
        });

        modelBuilder.Entity<RptArrestCategoryFm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_ArrestCategoryFM");

            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestNumber).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.DriverLicenseNumber).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(206);
            entity.Property(e => e.GivenName).HasMaxLength(50);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.OffenseType).HasMaxLength(100);
            entity.Property(e => e.Otype).HasColumnName("OType");
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
            entity.Property(e => e.SurName).HasMaxLength(50);
        });

        modelBuilder.Entity<RptArrestCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_ArrestCounts");

            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.CustNonCust)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EntryNumberType).HasMaxLength(50);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.JuvOrAdult)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RptArrestDrugDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_ArrestDrugDetail");

            entity.Property(e => e.Description).HasMaxLength(300);
            entity.Property(e => e.DrugName).HasMaxLength(100);
            entity.Property(e => e.DrugType).HasMaxLength(100);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentPropertyInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Incident_PropertyInvolvementID");
            entity.Property(e => e.Involvement).HasMaxLength(100);
            entity.Property(e => e.PropertyName).HasMaxLength(100);
            entity.Property(e => e.Quantity).HasMaxLength(100);
            entity.Property(e => e.RefCategory).HasMaxLength(100);
            entity.Property(e => e.TotalValueOfItems).HasColumnType("money");
            entity.Property(e => e.Weight).HasMaxLength(100);
            entity.Property(e => e.WeightUnit).HasMaxLength(100);
        });

        modelBuilder.Entity<RptArrestee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_Arrestee");

            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Ethnicity).HasMaxLength(100);
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GivenName).HasMaxLength(50);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.LocationDetailDisplayString).HasMaxLength(800);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.Race).HasMaxLength(100);
            entity.Property(e => e.ReportDefinitionId).HasColumnName("ReportDefinitionID");
            entity.Property(e => e.ReportGroup).HasMaxLength(300);
            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
            entity.Property(e => e.SurName).HasMaxLength(50);
        });

        modelBuilder.Entity<RptArresteeListOp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_ArresteeList_OP");

            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.ArrestNumber).HasMaxLength(20);
            entity.Property(e => e.Block).HasMaxLength(100);
            entity.Property(e => e.Cell).HasMaxLength(100);
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Ethnicity).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(206);
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GivenName).HasMaxLength(50);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.PrimaryUcr)
                .HasMaxLength(50)
                .HasColumnName("PrimaryUCR");
            entity.Property(e => e.PrimaryUcrcode)
                .HasMaxLength(5)
                .HasColumnName("PrimaryUCRCode");
            entity.Property(e => e.Race).HasMaxLength(100);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
            entity.Property(e => e.SurName).HasMaxLength(50);
        });

        modelBuilder.Entity<RptArresteeListOp2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_ArresteeList_OP2");

            entity.Property(e => e.ArrestBookingId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArrestBookingID");
            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestNumber).HasMaxLength(20);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Ethnicity).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(206);
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.Race).HasMaxLength(100);
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
            entity.Property(e => e.SurName).HasMaxLength(50);
        });

        modelBuilder.Entity<RptArrestsUnder21School>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_ArrestsUnder21School");

            entity.Property(e => e.ArrestBookingId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArrestBookingID");
            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestNumber).HasMaxLength(20);
            entity.Property(e => e.ArrestOfficerId).HasColumnName("ArrestOfficerID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.FullName).HasMaxLength(206);
            entity.Property(e => e.GivenName).HasMaxLength(50);
            entity.Property(e => e.IncidentNumber).HasMaxLength(50);
            entity.Property(e => e.LocationDetailDisplayString).HasMaxLength(800);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.SchoolName).HasMaxLength(200);
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
            entity.Property(e => e.SurName).HasMaxLength(50);
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .HasColumnName("ZIP");
        });

        modelBuilder.Entity<RptArrestsUnder21SchoolCitation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_ArrestsUnder21SchoolCitation");

            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestNumber).HasMaxLength(20);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.FullName).HasMaxLength(206);
            entity.Property(e => e.IncidentNumber).HasMaxLength(50);
            entity.Property(e => e.LocationDetailDisplayString).HasMaxLength(800);
            entity.Property(e => e.SchoolName).HasMaxLength(200);
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
        });

        modelBuilder.Entity<RptArrestsUnder21SchoolIncident>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_ArrestsUnder21SchoolIncident");

            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestNumber).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.FullName).HasMaxLength(206);
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.LocationDetailDisplayString).HasMaxLength(800);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.SchoolName).HasMaxLength(200);
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .HasColumnName("ZIP");
        });

        modelBuilder.Entity<RptCaseSum1getClearanceDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CaseSum_1GetClearanceData");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ClearanceDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.Ucrclearance).HasColumnName("UCRClearance");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");
        });

        modelBuilder.Entity<RptCaseSum2getComplainant>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CaseSum_2GetComplainant");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.GivenName).HasMaxLength(50);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.SurName).HasMaxLength(50);
        });

        modelBuilder.Entity<RptCaseSum3defineUcrstatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CaseSum_3DefineUCRStatus");

            entity.Property(e => e.Clarr)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CLARR");
            entity.Property(e => e.Clarrj)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CLARRJ");
            entity.Property(e => e.Clexepa)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CLEXEPA");
            entity.Property(e => e.Clexepj)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CLEXEPJ");
            entity.Property(e => e.ComplainantFirstName).HasMaxLength(50);
            entity.Property(e => e.ComplainantLastName).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Expr1)
                .HasMaxLength(47)
                .IsUnicode(false);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.InvestigativeStatus).HasMaxLength(100);
            entity.Property(e => e.InvestigativeStatusId).HasColumnName("InvestigativeStatusID");
            entity.Property(e => e.Open)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("OPEN");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UcraddedOn)
                .HasColumnType("datetime")
                .HasColumnName("UCRAddedOn");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.Unfd)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("UNFD");
        });

        modelBuilder.Entity<RptCaseSumOp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CaseSum_OP");

            entity.Property(e => e.Clarr)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CLARR");
            entity.Property(e => e.Clarrj)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CLARRJ");
            entity.Property(e => e.Clexepa)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CLEXEPA");
            entity.Property(e => e.Clexepj)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CLEXEPJ");
            entity.Property(e => e.ComplainantFirstName).HasMaxLength(50);
            entity.Property(e => e.ComplainantLastName).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.InvestigativeStatus).HasMaxLength(100);
            entity.Property(e => e.InvestigativeStatusId).HasColumnName("InvestigativeStatusID");
            entity.Property(e => e.Open)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("OPEN");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UcraddedOn)
                .HasColumnType("datetime")
                .HasColumnName("UCRAddedOn");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.Ucrstatus)
                .HasMaxLength(33)
                .IsUnicode(false)
                .HasColumnName("UCRStatus");
            entity.Property(e => e.Unfd)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("UNFD");
        });

        modelBuilder.Entity<RptCaseSumOpx>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CaseSum_OPx");

            entity.Property(e => e.Clarr).HasColumnName("CLARR");
            entity.Property(e => e.Clarrj).HasColumnName("CLARRJ");
            entity.Property(e => e.Clexepa).HasColumnName("CLEXEPA");
            entity.Property(e => e.Clexepj).HasColumnName("CLEXEPJ");
            entity.Property(e => e.ComplainantFirstName).HasMaxLength(50);
            entity.Property(e => e.ComplainantLastName).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.InvestigativeStatus).HasMaxLength(100);
            entity.Property(e => e.InvestigativeStatusId).HasColumnName("InvestigativeStatusID");
            entity.Property(e => e.Open).HasColumnName("OPEN");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UcraddedOn)
                .HasColumnType("datetime")
                .HasColumnName("UCRAddedOn");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.Unfd).HasColumnName("UNFD");
        });

        modelBuilder.Entity<RptClassificationSearch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_ClassificationSearch");

            entity.Property(e => e.Classification).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Location).HasMaxLength(800);
            entity.Property(e => e.NibrsCode)
                .HasMaxLength(10)
                .HasColumnName("NIBRS Code");
            entity.Property(e => e.NibrscodeId).HasColumnName("NIBRSCodeID");
            entity.Property(e => e.OffenseName).HasMaxLength(100);
            entity.Property(e => e.ReportWriter).HasMaxLength(154);
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(132)
                .HasColumnName("UniqueID");
            entity.Property(e => e.ViewIncidentUrl).HasColumnName("ViewIncidentURL");
        });

        modelBuilder.Entity<RptCrashEnforcementWinjury>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_CrashEnforcementWInjury");

            entity.Property(e => e.ActionTaken).HasMaxLength(1000);
            entity.Property(e => e.CrashId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashID");
            entity.Property(e => e.CrashNumber).HasMaxLength(100);
            entity.Property(e => e.CrashOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("CrashOccuredDTStart");
            entity.Property(e => e.CrashPersonInvolvementCode).HasColumnName("Crash_PersonInvolvementCode");
            entity.Property(e => e.CrashPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_PersonInvolvementID");
            entity.Property(e => e.CrashStatusId).HasColumnName("CrashStatusID");
            entity.Property(e => e.CrashType).HasMaxLength(1000);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Injury).HasMaxLength(1000);
        });

        modelBuilder.Entity<RptCrashReportHfd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CrashReportHFD");

            entity.Property(e => e.Cadnumber)
                .HasMaxLength(1000)
                .HasColumnName("CADNumber");
            entity.Property(e => e.CrashNumber).HasMaxLength(100);
            entity.Property(e => e.CrashOn).HasColumnType("datetime");
            entity.Property(e => e.CrashStatusId).HasColumnName("CrashStatusID");
            entity.Property(e => e.CrashType)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Cstatus)
                .HasMaxLength(100)
                .HasColumnName("cstatus");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.InvestigativeStatus).HasMaxLength(1000);
            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
            entity.Property(e => e.Rstatus)
                .HasMaxLength(100)
                .HasColumnName("rstatus");
        });

        modelBuilder.Entity<RptCrashReportHfdActivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CrashReportHFD_Activity");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationPkid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationPKID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
        });

        modelBuilder.Entity<RptCrashRptInProgress>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_CrashRptInProgress");

            entity.Property(e => e.AppId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AppID");
            entity.Property(e => e.AppNumber).HasMaxLength(100);
            entity.Property(e => e.Cadnumber)
                .HasMaxLength(1000)
                .HasColumnName("CADNumber");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.Location).HasMaxLength(800);
            entity.Property(e => e.OccurredDate).HasColumnType("datetime");
            entity.Property(e => e.ReportCreated).HasColumnType("datetime");
            entity.Property(e => e.ReportType).HasMaxLength(1000);
            entity.Property(e => e.ReportWriter).HasMaxLength(154);
            entity.Property(e => e.ReportingUnit).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.WorkFlowName).HasMaxLength(100);
        });

        modelBuilder.Entity<RptCrashWmostSeriousInjury>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_CrashWMostSeriousInjury");

            entity.Property(e => e.CrashId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashID");
            entity.Property(e => e.CrashNumber).HasMaxLength(100);
            entity.Property(e => e.CrashOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("CrashOccuredDTStart");
            entity.Property(e => e.CrashStatusId).HasColumnName("CrashStatusID");
            entity.Property(e => e.CrashType).HasMaxLength(1000);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Injury).HasMaxLength(1000);
        });

        modelBuilder.Entity<RptCriminalHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CriminalHistory");

            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.ArrestNumber).HasMaxLength(20);
            entity.Property(e => e.ArrestingOfficer).HasMaxLength(154);
            entity.Property(e => e.CdCcswitch)
                .HasMaxLength(100)
                .HasColumnName("cdCCSwitch");
            entity.Property(e => e.CdClass)
                .HasMaxLength(10)
                .HasColumnName("cdClass");
            entity.Property(e => e.CdConditionalDischargeString)
                .HasMaxLength(100)
                .HasColumnName("cdConditionalDischargeString");
            entity.Property(e => e.CdConditionalDischargeTerm).HasColumnName("cdConditionalDischargeTerm");
            entity.Property(e => e.CdCount).HasColumnName("cdCount");
            entity.Property(e => e.CdDispositionDate)
                .HasColumnType("date")
                .HasColumnName("cdDispositionDate");
            entity.Property(e => e.CdErasureDate)
                .HasColumnType("date")
                .HasColumnName("cdErasureDate");
            entity.Property(e => e.CdFineAmount)
                .HasColumnType("money")
                .HasColumnName("cdFineAmount");
            entity.Property(e => e.CdFineRemitted)
                .HasColumnType("money")
                .HasColumnName("cdFineRemitted");
            entity.Property(e => e.CdJailTerm).HasColumnName("cdJailTerm");
            entity.Property(e => e.CdJailTypeString)
                .HasMaxLength(100)
                .HasColumnName("cdJailTypeString");
            entity.Property(e => e.CdOtherFeesAmount)
                .HasColumnType("money")
                .HasColumnName("cdOtherFeesAmount");
            entity.Property(e => e.CdProbationTerm).HasColumnName("cdProbationTerm");
            entity.Property(e => e.CdProbationTypeString)
                .HasMaxLength(100)
                .HasColumnName("cdProbationTypeString");
            entity.Property(e => e.CdSpecialParoleString)
                .HasMaxLength(100)
                .HasColumnName("cdSpecialParoleString");
            entity.Property(e => e.CdSpecialParoleTerm).HasColumnName("cdSpecialParoleTerm");
            entity.Property(e => e.CdStatuteCode)
                .HasMaxLength(200)
                .HasColumnName("cdStatuteCode");
            entity.Property(e => e.CdStatuteDescription).HasColumnName("cdStatuteDescription");
            entity.Property(e => e.CdSuspendedJailString)
                .HasMaxLength(100)
                .HasColumnName("cdSuspendedJailString");
            entity.Property(e => e.CdSuspendedJailTerm).HasColumnName("cdSuspendedJailTerm");
            entity.Property(e => e.CdType)
                .HasMaxLength(10)
                .HasColumnName("cdType");
            entity.Property(e => e.CdVerdict)
                .HasMaxLength(100)
                .HasColumnName("cdVerdict");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.ReportedOfficer).HasMaxLength(154);
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
        });

        modelBuilder.Entity<RptCriminalHistoryAdult>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CriminalHistory_Adult");

            entity.Property(e => e.Acl)
                .HasMaxLength(100)
                .HasColumnName("ACL");
            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestNumber).HasMaxLength(20);
            entity.Property(e => e.ArrestingFirstN).HasMaxLength(50);
            entity.Property(e => e.ArrestingFullN).HasMaxLength(154);
            entity.Property(e => e.ArrestingLastN).HasMaxLength(50);
            entity.Property(e => e.Cad)
                .HasMaxLength(1000)
                .HasColumnName("CAD");
            entity.Property(e => e.Cadnumber)
                .HasMaxLength(1000)
                .HasColumnName("CADNumber");
            entity.Property(e => e.Cax)
                .HasMaxLength(10)
                .HasColumnName("CAX");
            entity.Property(e => e.CdCcswitch).HasColumnName("cdCCSwitch");
            entity.Property(e => e.CdConditionalDischargeTerm).HasColumnName("cdConditionalDischargeTerm");
            entity.Property(e => e.CdConditionalDischargeTermString)
                .HasMaxLength(100)
                .HasColumnName("cdConditionalDischargeTermString");
            entity.Property(e => e.CdDispositionDate)
                .HasColumnType("date")
                .HasColumnName("cdDispositionDate");
            entity.Property(e => e.CdDocketNumber)
                .HasMaxLength(20)
                .HasColumnName("cdDocketNumber");
            entity.Property(e => e.CdErasureDate)
                .HasColumnType("date")
                .HasColumnName("cdErasureDate");
            entity.Property(e => e.CdFineAmount)
                .HasColumnType("money")
                .HasColumnName("cdFineAmount");
            entity.Property(e => e.CdFineRemitted)
                .HasColumnType("money")
                .HasColumnName("cdFineRemitted");
            entity.Property(e => e.CdJailTerm).HasColumnName("cdJailTerm");
            entity.Property(e => e.CdJailTermString)
                .HasMaxLength(100)
                .HasColumnName("cdJailTermString");
            entity.Property(e => e.CdOtherFeesAmount)
                .HasColumnType("money")
                .HasColumnName("cdOtherFeesAmount");
            entity.Property(e => e.CdProbationTerm).HasColumnName("cdProbationTerm");
            entity.Property(e => e.CdProbationTermString)
                .HasMaxLength(100)
                .HasColumnName("cdProbationTermString");
            entity.Property(e => e.CdRefStatuteCode)
                .HasMaxLength(100)
                .HasColumnName("cdRefStatuteCode");
            entity.Property(e => e.CdRefstatuteDefinition).HasColumnName("cdREFStatuteDefinition");
            entity.Property(e => e.CdSpecialParoleTerm).HasColumnName("cdSpecialParoleTerm");
            entity.Property(e => e.CdSpecialParoleTermString)
                .HasMaxLength(100)
                .HasColumnName("cdSpecialParoleTermString");
            entity.Property(e => e.CdStatuteClass)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteClass");
            entity.Property(e => e.CdStatuteCode)
                .HasMaxLength(200)
                .HasColumnName("cdStatuteCode");
            entity.Property(e => e.CdStatuteCount).HasColumnName("cdStatuteCount");
            entity.Property(e => e.CdStatuteDescription).HasColumnName("cdStatuteDescription");
            entity.Property(e => e.CdStatuteType)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteType");
            entity.Property(e => e.CdSuspendedJailTerm).HasColumnName("cdSuspendedJailTerm");
            entity.Property(e => e.CdSuspendedJailTermString)
                .HasMaxLength(100)
                .HasColumnName("cdSuspendedJailTermString");
            entity.Property(e => e.CdTimeServed)
                .HasMaxLength(10)
                .HasColumnName("cdTimeServed");
            entity.Property(e => e.CdVerdictCode).HasColumnName("cdVerdictCode");
            entity.Property(e => e.CdVerdictFinding)
                .HasMaxLength(100)
                .HasColumnName("cdVerdictFinding");
            entity.Property(e => e.CitationNumber).HasMaxLength(20);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.RefstatuteCode)
                .HasMaxLength(100)
                .HasColumnName("REFStatuteCode");
            entity.Property(e => e.RefstatuteDefinition).HasColumnName("REFStatuteDefinition");
            entity.Property(e => e.SummonsNumber).HasMaxLength(50);
            entity.Property(e => e.SupplementSeq).HasColumnName("SupplementSEQ");
            entity.Property(e => e.TrafficStopNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<RptCriminalHistoryAdultNolle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CriminalHistory_AdultNolle");

            entity.Property(e => e.Acl)
                .HasMaxLength(100)
                .HasColumnName("ACL");
            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestNumber).HasMaxLength(20);
            entity.Property(e => e.ArrestingFirstN).HasMaxLength(50);
            entity.Property(e => e.ArrestingFullN).HasMaxLength(154);
            entity.Property(e => e.ArrestingLastN).HasMaxLength(50);
            entity.Property(e => e.Cad)
                .HasMaxLength(1000)
                .HasColumnName("CAD");
            entity.Property(e => e.Cadnumber)
                .HasMaxLength(1000)
                .HasColumnName("CADNumber");
            entity.Property(e => e.Cax)
                .HasMaxLength(10)
                .HasColumnName("CAX");
            entity.Property(e => e.CdCcswitch).HasColumnName("cdCCSwitch");
            entity.Property(e => e.CdConditionalDischargeTerm).HasColumnName("cdConditionalDischargeTerm");
            entity.Property(e => e.CdConditionalDischargeTermString)
                .HasMaxLength(100)
                .HasColumnName("cdConditionalDischargeTermString");
            entity.Property(e => e.CdDispositionDate)
                .HasColumnType("date")
                .HasColumnName("cdDispositionDate");
            entity.Property(e => e.CdDocketNumber)
                .HasMaxLength(20)
                .HasColumnName("cdDocketNumber");
            entity.Property(e => e.CdErasureDate)
                .HasColumnType("date")
                .HasColumnName("cdErasureDate");
            entity.Property(e => e.CdFineAmount)
                .HasColumnType("money")
                .HasColumnName("cdFineAmount");
            entity.Property(e => e.CdFineRemitted)
                .HasColumnType("money")
                .HasColumnName("cdFineRemitted");
            entity.Property(e => e.CdJailTerm).HasColumnName("cdJailTerm");
            entity.Property(e => e.CdJailTermString)
                .HasMaxLength(100)
                .HasColumnName("cdJailTermString");
            entity.Property(e => e.CdOtherFeesAmount)
                .HasColumnType("money")
                .HasColumnName("cdOtherFeesAmount");
            entity.Property(e => e.CdProbationTerm).HasColumnName("cdProbationTerm");
            entity.Property(e => e.CdProbationTermString)
                .HasMaxLength(100)
                .HasColumnName("cdProbationTermString");
            entity.Property(e => e.CdRefStatuteCode)
                .HasMaxLength(100)
                .HasColumnName("cdRefStatuteCode");
            entity.Property(e => e.CdRefstatuteDefinition).HasColumnName("cdREFStatuteDefinition");
            entity.Property(e => e.CdSpecialParoleTerm).HasColumnName("cdSpecialParoleTerm");
            entity.Property(e => e.CdSpecialParoleTermString)
                .HasMaxLength(100)
                .HasColumnName("cdSpecialParoleTermString");
            entity.Property(e => e.CdStatuteClass)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteClass");
            entity.Property(e => e.CdStatuteCode)
                .HasMaxLength(200)
                .HasColumnName("cdStatuteCode");
            entity.Property(e => e.CdStatuteCount).HasColumnName("cdStatuteCount");
            entity.Property(e => e.CdStatuteDescription).HasColumnName("cdStatuteDescription");
            entity.Property(e => e.CdStatuteType)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteType");
            entity.Property(e => e.CdSuspendedJailTerm).HasColumnName("cdSuspendedJailTerm");
            entity.Property(e => e.CdSuspendedJailTermString)
                .HasMaxLength(100)
                .HasColumnName("cdSuspendedJailTermString");
            entity.Property(e => e.CdTimeServed)
                .HasMaxLength(10)
                .HasColumnName("cdTimeServed");
            entity.Property(e => e.CdVerdictCode).HasColumnName("cdVerdictCode");
            entity.Property(e => e.CdVerdictFinding)
                .HasMaxLength(100)
                .HasColumnName("cdVerdictFinding");
            entity.Property(e => e.CitationNumber).HasMaxLength(20);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.RefstatuteCode)
                .HasMaxLength(100)
                .HasColumnName("REFStatuteCode");
            entity.Property(e => e.RefstatuteDefinition).HasColumnName("REFStatuteDefinition");
            entity.Property(e => e.SummonsNumber).HasMaxLength(50);
            entity.Property(e => e.SupplementSeq).HasColumnName("SupplementSEQ");
            entity.Property(e => e.TrafficStopNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<RptCriminalHistoryJuvi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CriminalHistory_Juvi");

            entity.Property(e => e.Acl)
                .HasMaxLength(100)
                .HasColumnName("ACL");
            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestNumber).HasMaxLength(20);
            entity.Property(e => e.ArrestingOfficer).HasMaxLength(154);
            entity.Property(e => e.Cad)
                .HasMaxLength(1000)
                .HasColumnName("CAD");
            entity.Property(e => e.Cadnumber)
                .HasMaxLength(1000)
                .HasColumnName("CADNumber");
            entity.Property(e => e.CommServiceCompletedDt)
                .HasColumnType("datetime")
                .HasColumnName("CommServiceCompletedDT");
            entity.Property(e => e.ErasedDt)
                .HasColumnType("datetime")
                .HasColumnName("ErasedDT");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IsLetterNfa).HasColumnName("IsLetterNFA");
            entity.Property(e => e.Jrbdate)
                .HasColumnType("datetime")
                .HasColumnName("JRBDate");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.OutofTownParticipatingJrb).HasColumnName("OutofTownParticipatingJRB");
            entity.Property(e => e.RestitutionCompletedDate).HasColumnType("datetime");
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
            entity.Property(e => e.SummonsNumber).HasMaxLength(50);
            entity.Property(e => e.SupplementSeq).HasColumnName("SupplementSEQ");
            entity.Property(e => e.YouthServiceCompletedDt)
                .HasColumnType("datetime")
                .HasColumnName("YouthServiceCompletedDT");
        });

        modelBuilder.Entity<RptCriminalHistoryMisdemeanor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CriminalHistory_Misdemeanor");

            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestNumber).HasMaxLength(50);
            entity.Property(e => e.ArrestingFirstN).HasMaxLength(50);
            entity.Property(e => e.ArrestingFullN).HasMaxLength(154);
            entity.Property(e => e.ArrestingLastN).HasMaxLength(50);
            entity.Property(e => e.CdCcswitch).HasColumnName("cdCCSwitch");
            entity.Property(e => e.CdConditionalDischargeTerm).HasColumnName("cdConditionalDischargeTerm");
            entity.Property(e => e.CdConditionalDischargeTermString)
                .HasMaxLength(100)
                .HasColumnName("cdConditionalDischargeTermString");
            entity.Property(e => e.CdDispositionDate)
                .HasColumnType("date")
                .HasColumnName("cdDispositionDate");
            entity.Property(e => e.CdDocketNumber)
                .HasMaxLength(20)
                .HasColumnName("cdDocketNumber");
            entity.Property(e => e.CdErasureDate)
                .HasColumnType("date")
                .HasColumnName("cdErasureDate");
            entity.Property(e => e.CdFineAmount)
                .HasColumnType("money")
                .HasColumnName("cdFineAmount");
            entity.Property(e => e.CdFineRemitted)
                .HasColumnType("money")
                .HasColumnName("cdFineRemitted");
            entity.Property(e => e.CdJailTerm).HasColumnName("cdJailTerm");
            entity.Property(e => e.CdJailTermString)
                .HasMaxLength(100)
                .HasColumnName("cdJailTermString");
            entity.Property(e => e.CdOtherFeesAmount)
                .HasColumnType("money")
                .HasColumnName("cdOtherFeesAmount");
            entity.Property(e => e.CdProbationTerm).HasColumnName("cdProbationTerm");
            entity.Property(e => e.CdProbationTermString)
                .HasMaxLength(100)
                .HasColumnName("cdProbationTermString");
            entity.Property(e => e.CdRefStatuteCode)
                .HasMaxLength(100)
                .HasColumnName("cdRefStatuteCode");
            entity.Property(e => e.CdRefstatuteDefinition).HasColumnName("cdREFStatuteDefinition");
            entity.Property(e => e.CdSpecialParoleTerm).HasColumnName("cdSpecialParoleTerm");
            entity.Property(e => e.CdSpecialParoleTermString)
                .HasMaxLength(100)
                .HasColumnName("cdSpecialParoleTermString");
            entity.Property(e => e.CdStatuteClass)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteClass");
            entity.Property(e => e.CdStatuteCode)
                .HasMaxLength(200)
                .HasColumnName("cdStatuteCode");
            entity.Property(e => e.CdStatuteCount).HasColumnName("cdStatuteCount");
            entity.Property(e => e.CdStatuteDescription).HasColumnName("cdStatuteDescription");
            entity.Property(e => e.CdStatuteType)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteType");
            entity.Property(e => e.CdSuspendedJailTerm).HasColumnName("cdSuspendedJailTerm");
            entity.Property(e => e.CdSuspendedJailTermString)
                .HasMaxLength(100)
                .HasColumnName("cdSuspendedJailTermString");
            entity.Property(e => e.CdTimeServed)
                .HasMaxLength(10)
                .HasColumnName("cdTimeServed");
            entity.Property(e => e.CdVerdictCode).HasColumnName("cdVerdictCode");
            entity.Property(e => e.CdVerdictFinding)
                .HasMaxLength(100)
                .HasColumnName("cdVerdictFinding");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.RefstatuteCode)
                .HasMaxLength(100)
                .HasColumnName("REFStatuteCode");
            entity.Property(e => e.RefstatuteDefinition).HasColumnName("REFStatuteDefinition");
        });

        modelBuilder.Entity<RptCriminalHistoryNolle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CriminalHistory_Nolle");

            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestNumber).HasMaxLength(50);
            entity.Property(e => e.ArrestingFirstN).HasMaxLength(50);
            entity.Property(e => e.ArrestingFullN).HasMaxLength(154);
            entity.Property(e => e.ArrestingLastN).HasMaxLength(50);
            entity.Property(e => e.CdCcswitch).HasColumnName("cdCCSwitch");
            entity.Property(e => e.CdConditionalDischargeTerm).HasColumnName("cdConditionalDischargeTerm");
            entity.Property(e => e.CdConditionalDischargeTermString)
                .HasMaxLength(100)
                .HasColumnName("cdConditionalDischargeTermString");
            entity.Property(e => e.CdDispositionDate)
                .HasColumnType("date")
                .HasColumnName("cdDispositionDate");
            entity.Property(e => e.CdDocketNumber)
                .HasMaxLength(20)
                .HasColumnName("cdDocketNumber");
            entity.Property(e => e.CdErasureDate)
                .HasColumnType("date")
                .HasColumnName("cdErasureDate");
            entity.Property(e => e.CdFineAmount)
                .HasColumnType("money")
                .HasColumnName("cdFineAmount");
            entity.Property(e => e.CdFineRemitted)
                .HasColumnType("money")
                .HasColumnName("cdFineRemitted");
            entity.Property(e => e.CdJailTerm).HasColumnName("cdJailTerm");
            entity.Property(e => e.CdJailTermString)
                .HasMaxLength(100)
                .HasColumnName("cdJailTermString");
            entity.Property(e => e.CdOtherFeesAmount)
                .HasColumnType("money")
                .HasColumnName("cdOtherFeesAmount");
            entity.Property(e => e.CdProbationTerm).HasColumnName("cdProbationTerm");
            entity.Property(e => e.CdProbationTermString)
                .HasMaxLength(100)
                .HasColumnName("cdProbationTermString");
            entity.Property(e => e.CdRefStatuteCode)
                .HasMaxLength(100)
                .HasColumnName("cdRefStatuteCode");
            entity.Property(e => e.CdRefstatuteDefinition).HasColumnName("cdREFStatuteDefinition");
            entity.Property(e => e.CdSpecialParoleTerm).HasColumnName("cdSpecialParoleTerm");
            entity.Property(e => e.CdSpecialParoleTermString)
                .HasMaxLength(100)
                .HasColumnName("cdSpecialParoleTermString");
            entity.Property(e => e.CdStatuteClass)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteClass");
            entity.Property(e => e.CdStatuteCode)
                .HasMaxLength(200)
                .HasColumnName("cdStatuteCode");
            entity.Property(e => e.CdStatuteCount).HasColumnName("cdStatuteCount");
            entity.Property(e => e.CdStatuteDescription).HasColumnName("cdStatuteDescription");
            entity.Property(e => e.CdStatuteType)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteType");
            entity.Property(e => e.CdSuspendedJailTerm).HasColumnName("cdSuspendedJailTerm");
            entity.Property(e => e.CdSuspendedJailTermString)
                .HasMaxLength(100)
                .HasColumnName("cdSuspendedJailTermString");
            entity.Property(e => e.CdTimeServed)
                .HasMaxLength(10)
                .HasColumnName("cdTimeServed");
            entity.Property(e => e.CdVerdictCode).HasColumnName("cdVerdictCode");
            entity.Property(e => e.CdVerdictFinding)
                .HasMaxLength(100)
                .HasColumnName("cdVerdictFinding");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.RefstatuteCode)
                .HasMaxLength(100)
                .HasColumnName("REFStatuteCode");
            entity.Property(e => e.RefstatuteDefinition).HasColumnName("REFStatuteDefinition");
        });

        modelBuilder.Entity<RptCriminalHistoryOffense>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CriminalHistory_Offense");

            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestNumber).HasMaxLength(20);
            entity.Property(e => e.ArrestingFirstN).HasMaxLength(50);
            entity.Property(e => e.ArrestingFullN).HasMaxLength(154);
            entity.Property(e => e.ArrestingLastN).HasMaxLength(50);
            entity.Property(e => e.CdCcswitch).HasColumnName("cdCCSwitch");
            entity.Property(e => e.CdConditionalDischargeTerm).HasColumnName("cdConditionalDischargeTerm");
            entity.Property(e => e.CdConditionalDischargeTermString)
                .HasMaxLength(100)
                .HasColumnName("cdConditionalDischargeTermString");
            entity.Property(e => e.CdDispositionDate)
                .HasColumnType("date")
                .HasColumnName("cdDispositionDate");
            entity.Property(e => e.CdDocketNumber)
                .HasMaxLength(20)
                .HasColumnName("cdDocketNumber");
            entity.Property(e => e.CdErasureDate)
                .HasColumnType("date")
                .HasColumnName("cdErasureDate");
            entity.Property(e => e.CdFineAmount)
                .HasColumnType("money")
                .HasColumnName("cdFineAmount");
            entity.Property(e => e.CdFineRemitted)
                .HasColumnType("money")
                .HasColumnName("cdFineRemitted");
            entity.Property(e => e.CdJailTerm).HasColumnName("cdJailTerm");
            entity.Property(e => e.CdJailTermString)
                .HasMaxLength(100)
                .HasColumnName("cdJailTermString");
            entity.Property(e => e.CdOtherFeesAmount)
                .HasColumnType("money")
                .HasColumnName("cdOtherFeesAmount");
            entity.Property(e => e.CdProbationTerm).HasColumnName("cdProbationTerm");
            entity.Property(e => e.CdProbationTermString)
                .HasMaxLength(100)
                .HasColumnName("cdProbationTermString");
            entity.Property(e => e.CdRefStatuteCode)
                .HasMaxLength(100)
                .HasColumnName("cdRefStatuteCode");
            entity.Property(e => e.CdRefstatuteDefinition).HasColumnName("cdREFStatuteDefinition");
            entity.Property(e => e.CdSpecialParoleTerm).HasColumnName("cdSpecialParoleTerm");
            entity.Property(e => e.CdSpecialParoleTermString)
                .HasMaxLength(100)
                .HasColumnName("cdSpecialParoleTermString");
            entity.Property(e => e.CdStatuteClass)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteClass");
            entity.Property(e => e.CdStatuteCode)
                .HasMaxLength(200)
                .HasColumnName("cdStatuteCode");
            entity.Property(e => e.CdStatuteCount).HasColumnName("cdStatuteCount");
            entity.Property(e => e.CdStatuteDescription).HasColumnName("cdStatuteDescription");
            entity.Property(e => e.CdStatuteType)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteType");
            entity.Property(e => e.CdSuspendedJailTerm).HasColumnName("cdSuspendedJailTerm");
            entity.Property(e => e.CdSuspendedJailTermString)
                .HasMaxLength(100)
                .HasColumnName("cdSuspendedJailTermString");
            entity.Property(e => e.CdTimeServed)
                .HasMaxLength(10)
                .HasColumnName("cdTimeServed");
            entity.Property(e => e.CdVerdictCode).HasColumnName("cdVerdictCode");
            entity.Property(e => e.CdVerdictFinding)
                .HasMaxLength(100)
                .HasColumnName("cdVerdictFinding");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(50);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.RefstatuteCode)
                .HasMaxLength(100)
                .HasColumnName("REFStatuteCode");
            entity.Property(e => e.RefstatuteDefinition).HasColumnName("REFStatuteDefinition");
        });

        modelBuilder.Entity<RptCriminalHistoryOfficer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CriminalHistory_Officer");

            entity.Property(e => e.ArrestNumber).HasMaxLength(20);
            entity.Property(e => e.ArrestingOfficer).HasMaxLength(154);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(50);
            entity.Property(e => e.ReportedOfficer).HasMaxLength(154);
        });

        modelBuilder.Entity<RptCriminalHistoryPerson>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CriminalHistory_Person");

            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Ethnicity).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(206);
            entity.Property(e => e.GivenName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.Race).HasMaxLength(100);
            entity.Property(e => e.Sex).HasMaxLength(100);
            entity.Property(e => e.SurName).HasMaxLength(50);
        });

        modelBuilder.Entity<RptCriminalHistoryTrafficStop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_CriminalHistory_TrafficStops");

            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestNumber).HasMaxLength(20);
            entity.Property(e => e.ArrestingFirstN).HasMaxLength(50);
            entity.Property(e => e.ArrestingFullN).HasMaxLength(154);
            entity.Property(e => e.ArrestingLastN).HasMaxLength(50);
            entity.Property(e => e.CdCcswitch).HasColumnName("cdCCSwitch");
            entity.Property(e => e.CdConditionalDischargeTerm).HasColumnName("cdConditionalDischargeTerm");
            entity.Property(e => e.CdConditionalDischargeTermString)
                .HasMaxLength(100)
                .HasColumnName("cdConditionalDischargeTermString");
            entity.Property(e => e.CdDispositionDate)
                .HasColumnType("date")
                .HasColumnName("cdDispositionDate");
            entity.Property(e => e.CdDocketNumber)
                .HasMaxLength(20)
                .HasColumnName("cdDocketNumber");
            entity.Property(e => e.CdErasureDate)
                .HasColumnType("date")
                .HasColumnName("cdErasureDate");
            entity.Property(e => e.CdFineAmount)
                .HasColumnType("money")
                .HasColumnName("cdFineAmount");
            entity.Property(e => e.CdFineRemitted)
                .HasColumnType("money")
                .HasColumnName("cdFineRemitted");
            entity.Property(e => e.CdJailTerm).HasColumnName("cdJailTerm");
            entity.Property(e => e.CdJailTermString)
                .HasMaxLength(100)
                .HasColumnName("cdJailTermString");
            entity.Property(e => e.CdOtherFeesAmount)
                .HasColumnType("money")
                .HasColumnName("cdOtherFeesAmount");
            entity.Property(e => e.CdProbationTerm).HasColumnName("cdProbationTerm");
            entity.Property(e => e.CdProbationTermString)
                .HasMaxLength(100)
                .HasColumnName("cdProbationTermString");
            entity.Property(e => e.CdRefStatuteCode)
                .HasMaxLength(100)
                .HasColumnName("cdRefStatuteCode");
            entity.Property(e => e.CdRefstatuteDefinition).HasColumnName("cdREFStatuteDefinition");
            entity.Property(e => e.CdSpecialParoleTerm).HasColumnName("cdSpecialParoleTerm");
            entity.Property(e => e.CdSpecialParoleTermString)
                .HasMaxLength(100)
                .HasColumnName("cdSpecialParoleTermString");
            entity.Property(e => e.CdStatuteClass)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteClass");
            entity.Property(e => e.CdStatuteCode)
                .HasMaxLength(200)
                .HasColumnName("cdStatuteCode");
            entity.Property(e => e.CdStatuteCount).HasColumnName("cdStatuteCount");
            entity.Property(e => e.CdStatuteDescription).HasColumnName("cdStatuteDescription");
            entity.Property(e => e.CdStatuteType)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteType");
            entity.Property(e => e.CdSuspendedJailTerm).HasColumnName("cdSuspendedJailTerm");
            entity.Property(e => e.CdSuspendedJailTermString)
                .HasMaxLength(100)
                .HasColumnName("cdSuspendedJailTermString");
            entity.Property(e => e.CdTimeServed)
                .HasMaxLength(10)
                .HasColumnName("cdTimeServed");
            entity.Property(e => e.CdVerdictCode).HasColumnName("cdVerdictCode");
            entity.Property(e => e.CdVerdictFinding)
                .HasMaxLength(100)
                .HasColumnName("cdVerdictFinding");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(50);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.RefstatuteCode)
                .HasMaxLength(100)
                .HasColumnName("REFStatuteCode");
            entity.Property(e => e.RefstatuteDefinition).HasColumnName("REFStatuteDefinition");
        });

        modelBuilder.Entity<RptDrug>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_Drug");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Description).HasMaxLength(300);
            entity.Property(e => e.Drug).HasMaxLength(100);
            entity.Property(e => e.DrugType).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentStart).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Officer).HasMaxLength(154);
            entity.Property(e => e.Unit).HasMaxLength(100);
            entity.Property(e => e.Value).HasColumnType("money");
            entity.Property(e => e.Weight).HasMaxLength(100);
        });

        modelBuilder.Entity<RptDrugArrestCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_DrugArrestCounts");

            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.CustNonCust)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EntryNumberType).HasMaxLength(50);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.JuvOrAdult)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RptDuireport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_DUIReport");

            entity.Property(e => e.ArrestBookingId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArrestBookingID");
            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.FullName).HasMaxLength(206);
            entity.Property(e => e.GivenName).HasMaxLength(50);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.PickUpCategoryGroup).HasMaxLength(100);
            entity.Property(e => e.PickUpClassification).HasMaxLength(100);
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.SupplementSeq).HasColumnName("SupplementSEQ");
            entity.Property(e => e.SurName).HasMaxLength(50);
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");
        });

        modelBuilder.Entity<RptEvadePpawaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_EvadePPAWAction");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.PersonInvolvment).HasMaxLength(100);
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
        });

        modelBuilder.Entity<RptEvadePpawcount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_EvadePPAWcount");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.IncidentType).HasMaxLength(50);
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
        });

        modelBuilder.Entity<RptLarcenyAuto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_LarcenyAuto");

            entity.Property(e => e.ActAttempt).HasMaxLength(100);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.LarcenyType)
                .HasMaxLength(24)
                .IsUnicode(false);
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
        });

        modelBuilder.Entity<RptLarcenyAutoArrest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_LarcenyAutoArrests");

            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArrestID");
            entity.Property(e => e.ArresteeRes).HasMaxLength(800);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.FullName).HasMaxLength(206);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentLocation).HasMaxLength(300);
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.LarcenyType)
                .HasMaxLength(24)
                .IsUnicode(false);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
        });

        modelBuilder.Entity<RptMissingPerson>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_MissingPerson");

            entity.Property(e => e.Cadnumber)
                .HasMaxLength(1000)
                .HasColumnName("CADNumber");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Givenname).HasMaxLength(50);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.PersonAge).IsUnicode(false);
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.ResidentialLocation).HasMaxLength(800);
            entity.Property(e => e.Surname).HasMaxLength(50);
        });

        modelBuilder.Entity<RptMissingPersonEver>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_MissingPersonEver");

            entity.Property(e => e.Cadnumber)
                .HasMaxLength(1000)
                .HasColumnName("CADNumber");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Givenname).HasMaxLength(50);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.PersonAge).IsUnicode(false);
            entity.Property(e => e.PrimaryIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryIncidentID");
            entity.Property(e => e.ResidentialLocation).HasMaxLength(800);
            entity.Property(e => e.Surname).HasMaxLength(50);
        });

        modelBuilder.Entity<RptNarrativesIncident>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_NarrativesIncident");

            entity.Property(e => e.Cadnumber)
                .HasMaxLength(1000)
                .HasColumnName("CADNumber");
            entity.Property(e => e.CallTypeId).HasColumnName("CallTypeID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.FullName).HasMaxLength(154);
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentNumberSup)
                .HasMaxLength(73)
                .IsUnicode(false);
            entity.Property(e => e.IncidentOccuredDtend)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTEnd");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.InvestigativeStatus).HasMaxLength(100);
            entity.Property(e => e.PickUpCategoryGroup).HasMaxLength(100);
            entity.Property(e => e.PickUpClassification).HasMaxLength(100);
            entity.Property(e => e.ReportStatus).HasMaxLength(100);
            entity.Property(e => e.SupplementSeq).HasColumnName("SupplementSEQ");
        });

        modelBuilder.Entity<RptOfficerActivityArrestCustodial>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_OfficerActivityArrestCustodial");

            entity.Property(e => e.Activity)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.AppId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Category)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CountDateTime).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.OfficerId).HasColumnName("OfficerID");
            entity.Property(e => e.OfficerName).HasMaxLength(154);
            entity.Property(e => e.Rank).HasMaxLength(50);
        });

        modelBuilder.Entity<RptOfficerActivityArrestNonCust>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_OfficerActivityArrestNonCust");

            entity.Property(e => e.Activity)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AppId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AppID");
            entity.Property(e => e.Category)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CountDateTime).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.OfficerId).HasColumnName("OfficerID");
            entity.Property(e => e.OfficerName).HasMaxLength(154);
            entity.Property(e => e.Rank).HasMaxLength(50);
        });

        modelBuilder.Entity<RptOfficerActivityCrash>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_OfficerActivityCrash");

            entity.Property(e => e.Activity)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.AppId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AppID");
            entity.Property(e => e.Category)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CountDateTime).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.OfficerId).HasColumnName("OfficerID");
            entity.Property(e => e.OfficerName).HasMaxLength(154);
            entity.Property(e => e.Rank).HasMaxLength(50);
        });

        modelBuilder.Entity<RptOfficerActivityGetArrest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_OfficerActivity_GetArrest");

            entity.Property(e => e.ArrestBookingId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArrestBookingID");
            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestOfficerId).HasColumnName("ArrestOfficerID");
            entity.Property(e => e.ArrestingOfficer).HasMaxLength(101);
            entity.Property(e => e.BookingDateTime).HasColumnType("datetime");
            entity.Property(e => e.BookingOfficer).HasMaxLength(154);
            entity.Property(e => e.BookingOfficerId).HasColumnName("BookingOfficerID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.NumArrestMisd).HasColumnName("NumArrestMISD");
            entity.Property(e => e.NumCaseNc).HasColumnName("NumCaseNC");
            entity.Property(e => e.NumTicketUar).HasColumnName("NumTicketUAR");
            entity.Property(e => e.Rank).HasMaxLength(50);
        });

        modelBuilder.Entity<RptOfficerActivityGetArrestMisd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_OfficerActivity_GetArrestMISD");

            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArrestOfficerId).HasColumnName("ArrestOfficerID");
            entity.Property(e => e.ArrestingOfficer).HasMaxLength(101);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.NumArrestMisd).HasColumnName("NumArrestMISD");
            entity.Property(e => e.NumCaseNc).HasColumnName("NumCaseNC");
            entity.Property(e => e.NumTicketUar).HasColumnName("NumTicketUAR");
            entity.Property(e => e.Rank).HasMaxLength(50);
            entity.Property(e => e.SummonsInfractionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SummonsInfractionID");
        });

        modelBuilder.Entity<RptOfficerActivityGetCrash>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_OfficerActivity_GetCrash");

            entity.Property(e => e.CrashId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashID");
            entity.Property(e => e.CrashNumber).HasMaxLength(100);
            entity.Property(e => e.CrashOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("CrashOccuredDTStart");
            entity.Property(e => e.CrashReportedOfficer).HasMaxLength(101);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.NumArrestMisd).HasColumnName("NumArrestMISD");
            entity.Property(e => e.NumCaseNc).HasColumnName("NumCaseNC");
            entity.Property(e => e.NumTicketUar).HasColumnName("NumTicketUAR");
            entity.Property(e => e.Rank).HasMaxLength(50);
            entity.Property(e => e.ReportedEmployeeId).HasColumnName("ReportedEmployeeID");
        });

        modelBuilder.Entity<RptOfficerActivityGetIncident>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_OfficerActivity_GetIncident");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentReportedOfficer).HasMaxLength(101);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.NumArrestMisd).HasColumnName("NumArrestMISD");
            entity.Property(e => e.NumCaseNc).HasColumnName("NumCaseNC");
            entity.Property(e => e.NumTicketUar).HasColumnName("NumTicketUAR");
            entity.Property(e => e.Rank).HasMaxLength(50);
            entity.Property(e => e.ReportedEmployeeId).HasColumnName("ReportedEmployeeID");
        });

        modelBuilder.Entity<RptOfficerActivityGetIncidentNc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_OfficerActivity_GetIncidentNC");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentReportedOfficer).HasMaxLength(101);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.NumArrestMisd).HasColumnName("NumArrestMISD");
            entity.Property(e => e.NumCaseNc).HasColumnName("NumCaseNC");
            entity.Property(e => e.NumTicketUar).HasColumnName("NumTicketUAR");
            entity.Property(e => e.Rank).HasMaxLength(50);
            entity.Property(e => e.ReportedEmployeeId).HasColumnName("ReportedEmployeeID");
        });

        modelBuilder.Entity<RptOfficerActivityGetTrafficStop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_OfficerActivity_GetTrafficStop");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.NumArrestMisd).HasColumnName("NumArrestMISD");
            entity.Property(e => e.NumCaseNc).HasColumnName("NumCaseNC");
            entity.Property(e => e.NumTicketUar).HasColumnName("NumTicketUAR");
            entity.Property(e => e.Rank).HasMaxLength(50);
            entity.Property(e => e.ReportedEmployeeId).HasColumnName("ReportedEmployeeID");
            entity.Property(e => e.TrafficStopDateTime).HasColumnType("datetime");
            entity.Property(e => e.TrafficStopOfficer).HasMaxLength(101);
        });

        modelBuilder.Entity<RptOfficerActivityGetWarrant>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_OfficerActivity_GetWarrant");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.NumArrestMisd).HasColumnName("NumArrestMISD");
            entity.Property(e => e.NumCaseNc).HasColumnName("NumCaseNC");
            entity.Property(e => e.NumTicketUar).HasColumnName("NumTicketUAR");
            entity.Property(e => e.Rank).HasMaxLength(50);
            entity.Property(e => e.RequestingOfficerId).HasColumnName("RequestingOfficerID");
            entity.Property(e => e.WarrantId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("WarrantID");
            entity.Property(e => e.WarrantOfficer).HasMaxLength(101);
        });

        modelBuilder.Entity<RptOfficerActivityIncident>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_OfficerActivityIncident");

            entity.Property(e => e.Activity)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.AppId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AppID");
            entity.Property(e => e.Category)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.CountDateTime).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.OfficerId).HasColumnName("OfficerID");
            entity.Property(e => e.OfficerName).HasMaxLength(154);
            entity.Property(e => e.Rank).HasMaxLength(50);
        });

        modelBuilder.Entity<RptOfficerActivityTrafficStop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_OfficerActivityTrafficStop");

            entity.Property(e => e.Activity).HasMaxLength(100);
            entity.Property(e => e.AppId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AppID");
            entity.Property(e => e.Category)
                .HasMaxLength(21)
                .IsUnicode(false);
            entity.Property(e => e.CountDateTime).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.OfficerId).HasColumnName("OfficerID");
            entity.Property(e => e.OfficerName).HasMaxLength(154);
            entity.Property(e => e.Rank).HasMaxLength(50);
        });

        modelBuilder.Entity<RptOfficerActivityWarrant>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_OfficerActivityWarrant");

            entity.Property(e => e.Activity)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.AppId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AppID");
            entity.Property(e => e.Category)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.CountDateTime).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.OfficerId).HasColumnName("OfficerID");
            entity.Property(e => e.OfficerName).HasMaxLength(154);
            entity.Property(e => e.Rank).HasMaxLength(50);
        });

        modelBuilder.Entity<RptPforce1aGetAllForceType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_PForce_1aGetAllForceType");

            entity.Property(e => e.ForceType).HasMaxLength(200);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
        });

        modelBuilder.Entity<RptPforce1bGetAllForceTypeText>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_PForce_1bGetAllForceTypeText");

            entity.Property(e => e.DisplayString).HasMaxLength(100);
            entity.Property(e => e.ForceType).HasMaxLength(200);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
        });

        modelBuilder.Entity<RptPforce2aGetAllWeaponType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_PForce_2aGetAllWeaponType");

            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.WeaponType).HasMaxLength(200);
        });

        modelBuilder.Entity<RptPforce2bGetAllWeaponTypeText>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_PForce_2bGetAllWeaponTypeText");

            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.WeaponType).HasMaxLength(100);
            entity.Property(e => e.WeaponTypeId)
                .HasMaxLength(200)
                .HasColumnName("WeaponTypeID");
        });

        modelBuilder.Entity<RptPforce3aGetAllSubjBeh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_PForce_3aGetAllSubjBeh");

            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.SubjectBehavior).HasMaxLength(200);
        });

        modelBuilder.Entity<RptPforce3bGetAllSubjBehText>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_PForce_3bGetAllSubjBehText");

            entity.Property(e => e.DisplayString).HasMaxLength(100);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.SubjectBehavior).HasMaxLength(200);
        });

        modelBuilder.Entity<RptPforce4aGetAllSubjCond>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_PForce_4aGetAllSubjCond");

            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.SubjectCondition).HasMaxLength(200);
        });

        modelBuilder.Entity<RptPforce4bGetAllSubjCondText>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_PForce_4bGetAllSubjCondText");

            entity.Property(e => e.DisplayString).HasMaxLength(100);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.SubjectCondition).HasMaxLength(200);
        });

        modelBuilder.Entity<RptPforce5aGetAllOfficerCond>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_PForce_5aGetAllOfficerCond");

            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.OfficerCondition).HasMaxLength(200);
        });

        modelBuilder.Entity<RptPforce5bGetAllOfficerCondText>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_PForce_5bGetAllOfficerCondText");

            entity.Property(e => e.DisplayString).HasMaxLength(100);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.OfficerCondition).HasMaxLength(200);
        });

        modelBuilder.Entity<RptPuofOfficerControlMethod>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_PUOF_OfficerControlMethod");

            entity.Property(e => e.IncidentId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.InvolvementDateTime).HasColumnType("datetime");
            entity.Property(e => e.OfficerId).HasColumnName("OfficerID");
            entity.Property(e => e.OfficerName).HasMaxLength(154);
        });

        modelBuilder.Entity<RptPuofSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_PUOF_Summary");

            entity.Property(e => e.ActionsLeadToIncidentOtherDesc).HasMaxLength(100);
            entity.Property(e => e.ChemicalMunitions).HasMaxLength(270);
            entity.Property(e => e.Dcfaresult).HasColumnName("DCFAResult");
            entity.Property(e => e.Dcfasubject).HasColumnName("DCFASubject");
            entity.Property(e => e.Dcfaweapon).HasColumnName("DCFAWeapon");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EdwdeadlyForceJustified)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("EDWDeadlyForceJustified");
            entity.Property(e => e.EdwdeploymentType).HasColumnName("EDWDeploymentType");
            entity.Property(e => e.EdwtypeofForceAfter)
                .HasMaxLength(200)
                .HasColumnName("EDWTypeofForceAfter");
            entity.Property(e => e.EdwtypeofForcePrior)
                .HasMaxLength(200)
                .HasColumnName("EDWTypeofForcePrior");
            entity.Property(e => e.EmployeeWitnessesIdlst).HasColumnName("EmployeeWitnessesIDLst");
            entity.Property(e => e.ImpactMunition).HasMaxLength(270);
            entity.Property(e => e.ImpactWeaponBaton).HasMaxLength(409);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.InitialPerceptionArmedDesc)
                .HasMaxLength(100)
                .HasColumnName("InitialPerception_ArmedDesc");
            entity.Property(e => e.InitialPerceptionOtherDesc)
                .HasMaxLength(100)
                .HasColumnName("InitialPerception_OtherDesc");
            entity.Property(e => e.InvolvedEmployee1ControlMethodsOtherDesc).HasMaxLength(100);
            entity.Property(e => e.InvolvementDateTime).HasColumnType("datetime");
            entity.Property(e => e.IsOfficerDispatched)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.IsOfficerInitiated)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.LocationDescription).HasMaxLength(403);
            entity.Property(e => e.Ocspray)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("OCSpray");
            entity.Property(e => e.OfficerCheckedByMed).HasMaxLength(100);
            entity.Property(e => e.OfficerHospital).HasMaxLength(200);
            entity.Property(e => e.OfficerHospitalization)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.OfficerId).HasColumnName("OfficerID");
            entity.Property(e => e.OfficerInjuryOther).HasMaxLength(200);
            entity.Property(e => e.OfficerName).HasMaxLength(154);
            entity.Property(e => e.SubOtherResistanceDesc).HasMaxLength(201);
            entity.Property(e => e.SubjDob)
                .HasColumnType("datetime")
                .HasColumnName("SubjDOB");
            entity.Property(e => e.SubjEthn).HasMaxLength(100);
            entity.Property(e => e.SubjHosptialization)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.SubjOtherInjury).HasMaxLength(200);
            entity.Property(e => e.SubjRace).HasMaxLength(100);
            entity.Property(e => e.SubjSex).HasMaxLength(100);
            entity.Property(e => e.SubjWarned)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.SupvisorName).HasMaxLength(154);
            entity.Property(e => e.SuspectId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SuspectID");
            entity.Property(e => e.SuspectName).HasMaxLength(206);
            entity.Property(e => e.UniqueId)
                .HasMaxLength(132)
                .HasColumnName("UniqueID");
            entity.Property(e => e.ViewIncidentUrl).HasColumnName("ViewIncidentURL");
            entity.Property(e => e.WasOfficerFlaggedDown)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RptRacialProfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_RacialProfile");

            entity.Property(e => e.Ctresident).HasColumnName("CTResident");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Ehisp).HasColumnName("EHisp");
            entity.Property(e => e.EmiddleEs).HasColumnName("EMiddleEs");
            entity.Property(e => e.Eunknown).HasColumnName("EUnknown");
            entity.Property(e => e.FullName).HasMaxLength(154);
            entity.Property(e => e.Gfemale).HasColumnName("GFemale");
            entity.Property(e => e.Gmale).HasColumnName("GMale");
            entity.Property(e => e.Gunknown).HasColumnName("GUnknown");
            entity.Property(e => e.Raindian).HasColumnName("RAIndian");
            entity.Property(e => e.Rasian).HasColumnName("RAsian");
            entity.Property(e => e.Rblack).HasColumnName("RBlack");
            entity.Property(e => e.ReportedEmployeeId).HasColumnName("ReportedEmployeeID");
            entity.Property(e => e.Rother).HasColumnName("ROther");
            entity.Property(e => e.Rwhite).HasColumnName("RWhite");
            entity.Property(e => e.TrafficStopDateTime).HasColumnType("datetime");
            entity.Property(e => e.TrafficStopNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<RptRecentlyFiledCrash>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_RecentlyFiledCrash");

            entity.Property(e => e.CrashLocation).HasMaxLength(800);
            entity.Property(e => e.CrashNumber).HasMaxLength(100);
            entity.Property(e => e.CrashStart).HasColumnType("datetime");
            entity.Property(e => e.CrashType).HasMaxLength(1000);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.FiledDate).HasColumnType("datetime");
            entity.Property(e => e.ReportWriter).HasMaxLength(101);
            entity.Property(e => e.ReportingUnit).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(100);
        });

        modelBuilder.Entity<RptRefDrugStatuteDef>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_RefDrugStatuteDef");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.Appendix).HasMaxLength(100);
            entity.Property(e => e.CashEffectDate).HasColumnType("date");
            entity.Property(e => e.CashFeeAmt)
                .HasColumnType("money")
                .HasColumnName("Cash_Fee_amt");
            entity.Property(e => e.CashFineAmt)
                .HasColumnType("money")
                .HasColumnName("Cash_Fine_amt");
            entity.Property(e => e.CashMunicipalFee)
                .HasColumnType("money")
                .HasColumnName("Cash_Municipal_Fee");
            entity.Property(e => e.CashPlusAmt)
                .HasColumnType("money")
                .HasColumnName("Cash_PLUS_amt");
            entity.Property(e => e.CashRepealDate).HasColumnType("date");
            entity.Property(e => e.CashStfAmt)
                .HasColumnType("money")
                .HasColumnName("Cash_STF_amt");
            entity.Property(e => e.CashSurchargeAmt)
                .HasColumnType("money")
                .HasColumnName("Cash_Surcharge_amt");
            entity.Property(e => e.CashTotalAmt)
                .HasColumnType("money")
                .HasColumnName("Cash_total_amt");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CissverifiedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("CISSVerifiedDateTime");
            entity.Property(e => e.CitationUpdateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CiteAs).HasMaxLength(100);
            entity.Property(e => e.Court).HasMaxLength(50);
            entity.Property(e => e.DataProcessId).HasColumnName("DataProcessID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.ImportDateTime).HasColumnType("datetime");
            entity.Property(e => e.ImportSource).HasMaxLength(100);
            entity.Property(e => e.KeyGroupName).HasMaxLength(100);
            entity.Property(e => e.KeySort).HasMaxLength(100);
            entity.Property(e => e.NibrscodeId).HasColumnName("NIBRSCodeID");
            entity.Property(e => e.OffenseClass).HasMaxLength(100);
            entity.Property(e => e.OffenseType).HasMaxLength(100);
            entity.Property(e => e.RecordEffectedOn).HasColumnType("datetime");
            entity.Property(e => e.RecordExpiratedOn).HasColumnType("datetime");
            entity.Property(e => e.RefstatuteDefinitionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REFStatuteDefinitionID");
            entity.Property(e => e.ShortName).HasMaxLength(100);
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.Zone).HasMaxLength(50);
        });

        modelBuilder.Entity<RptRpsexRace>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_RPSexRace");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Ethnicity).HasMaxLength(100);
            entity.Property(e => e.Race).HasMaxLength(100);
            entity.Property(e => e.ResultofStop).HasMaxLength(100);
            entity.Property(e => e.Sex).HasMaxLength(100);
            entity.Property(e => e.TrafficStopDateTime).HasColumnType("datetime");
            entity.Property(e => e.TrafficStopId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopID");
        });

        modelBuilder.Entity<RptSummonInfraction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_SummonInfraction");

            entity.Property(e => e.Acl)
                .HasMaxLength(100)
                .HasColumnName("ACL");
            entity.Property(e => e.Arrestee).HasMaxLength(206);
            entity.Property(e => e.Cadnumber)
                .HasMaxLength(1000)
                .HasColumnName("CADNumber");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.LocationDetailDisplayString).HasMaxLength(800);
            entity.Property(e => e.OffenseId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OffenseID");
            entity.Property(e => e.ReportingOfficer).HasMaxLength(207);
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
            entity.Property(e => e.SummonsInfractionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SummonsInfractionID");
            entity.Property(e => e.SummonsNumber).HasMaxLength(50);
            entity.Property(e => e.SupplementSeq).HasColumnName("SupplementSEQ");
        });

        modelBuilder.Entity<RptTcexportLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_TCExportLog");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.ExportStatus).HasMaxLength(100);
            entity.Property(e => e.ExportedOn).HasColumnType("datetime");
            entity.Property(e => e.ReportedEmployee).HasMaxLength(154);
            entity.Property(e => e.TicketNumber).HasMaxLength(20);
            entity.Property(e => e.TrafficStopDateTime).HasColumnType("datetime");
            entity.Property(e => e.TrafficStopNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<RptTrafficStopCountsByResultofStop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_TrafficStopCountsByResultofStop");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DisplayString).HasMaxLength(100);
            entity.Property(e => e.JuvenileOrAdult)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.TrafficStopDateTime).HasColumnType("datetime");
            entity.Property(e => e.TrafficStopId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopID");
        });

        modelBuilder.Entity<RptTrafficStopOp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_TrafficStop_OP");

            entity.Property(e => e.Apartment).HasMaxLength(50);
            entity.Property(e => e.BadgeNumber).HasMaxLength(50);
            entity.Property(e => e.Building).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.DepEmployeeId)
                .HasMaxLength(50)
                .HasColumnName("DepEmployeeID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Floor).HasMaxLength(10);
            entity.Property(e => e.FullName).HasMaxLength(154);
            entity.Property(e => e.HouseNumber).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Location).HasMaxLength(300);
            entity.Property(e => e.LocationDetailDisplayString).HasMaxLength(800);
            entity.Property(e => e.LocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LocationID");
            entity.Property(e => e.LocationShortDisplayString).HasMaxLength(300);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OffenseType).HasMaxLength(100);
            entity.Property(e => e.Result).HasMaxLength(100);
            entity.Property(e => e.ShortName).HasMaxLength(100);
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
            entity.Property(e => e.Suite).HasMaxLength(10);
            entity.Property(e => e.TrafficStopDateTime).HasColumnType("datetime");
            entity.Property(e => e.TrafficStopNumber).HasMaxLength(50);
            entity.Property(e => e.Unit).HasMaxLength(10);
        });

        modelBuilder.Entity<RptTrafficStopProactiveEnforcement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPT_TrafficStopProactiveEnforcement");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.OffenseCity)
                .HasMaxLength(100)
                .HasColumnName("Offense City");
            entity.Property(e => e.ResultOfStop)
                .HasMaxLength(100)
                .HasColumnName("Result of Stop");
            entity.Property(e => e.TrafficStopDateTime).HasColumnType("datetime");
            entity.Property(e => e.TrafficStopId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopID");
        });

        modelBuilder.Entity<RptUcrasradult1select>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRAdult_1Select");

            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
        });

        modelBuilder.Entity<RptUcrasradult2case>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRAdult_2Case");

            entity.Property(e => e.AmericanIndianAknative).HasColumnName("AmericanIndian_AKNative");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e._18).HasColumnName("18");
            entity.Property(e => e._19).HasColumnName("19");
            entity.Property(e => e._20).HasColumnName("20");
            entity.Property(e => e._21).HasColumnName("21");
            entity.Property(e => e._22).HasColumnName("22");
            entity.Property(e => e._23).HasColumnName("23");
            entity.Property(e => e._24).HasColumnName("24");
            entity.Property(e => e._2529).HasColumnName("25-29");
            entity.Property(e => e._3034).HasColumnName("30-34");
            entity.Property(e => e._3539).HasColumnName("35-39");
            entity.Property(e => e._4044).HasColumnName("40-44");
            entity.Property(e => e._4549).HasColumnName("45-49");
            entity.Property(e => e._5054).HasColumnName("50-54");
            entity.Property(e => e._5559).HasColumnName("55-59");
            entity.Property(e => e._6064).HasColumnName("60-64");
            entity.Property(e => e._65Over).HasColumnName("65_over");
        });

        modelBuilder.Entity<RptUcrasradult3aAllDept>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRAdult_3aAllDept");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<RptUcrasradult3bGroupRefUcr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRAdult_3bGroupRefUCR");

            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.FirstInGroup).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.ReportCategory).HasMaxLength(300);
            entity.Property(e => e.ReportGroup).HasMaxLength(300);
            entity.Property(e => e._18).HasColumnName("18");
            entity.Property(e => e._19).HasColumnName("19");
            entity.Property(e => e._20).HasColumnName("20");
            entity.Property(e => e._21).HasColumnName("21");
            entity.Property(e => e._22).HasColumnName("22");
            entity.Property(e => e._23).HasColumnName("23");
            entity.Property(e => e._24).HasColumnName("24");
            entity.Property(e => e._2529).HasColumnName("25-29");
            entity.Property(e => e._3034).HasColumnName("30-34");
            entity.Property(e => e._3539).HasColumnName("35-39");
            entity.Property(e => e._4044).HasColumnName("40-44");
            entity.Property(e => e._4549).HasColumnName("45-49");
            entity.Property(e => e._5054).HasColumnName("50-54");
            entity.Property(e => e._5559).HasColumnName("55-59");
            entity.Property(e => e._6064).HasColumnName("60-64");
            entity.Property(e => e._65Over).HasColumnName("65_over");
        });

        modelBuilder.Entity<RptUcrasradult4>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRAdult_4");

            entity.Property(e => e.AmericanIndianAknative).HasColumnName("AmericanIndian_AKNative");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.OffenseClass).HasMaxLength(300);
            entity.Property(e => e._18).HasColumnName("18");
            entity.Property(e => e._19).HasColumnName("19");
            entity.Property(e => e._20).HasColumnName("20");
            entity.Property(e => e._21).HasColumnName("21");
            entity.Property(e => e._22).HasColumnName("22");
            entity.Property(e => e._23).HasColumnName("23");
            entity.Property(e => e._24).HasColumnName("24");
            entity.Property(e => e._2529).HasColumnName("25-29");
            entity.Property(e => e._3034).HasColumnName("30-34");
            entity.Property(e => e._3539).HasColumnName("35-39");
            entity.Property(e => e._4044).HasColumnName("40-44");
            entity.Property(e => e._4549).HasColumnName("45-49");
            entity.Property(e => e._5054).HasColumnName("50-54");
            entity.Property(e => e._5559).HasColumnName("55-59");
            entity.Property(e => e._6064).HasColumnName("60-64");
            entity.Property(e => e._65Over).HasColumnName("65_over");
        });

        modelBuilder.Entity<RptUcrasradultDrugTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRAdult_DrugTotal");

            entity.Property(e => e.AmericanIndianAknative).HasColumnName("AmericanIndian_AKNative");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.OffenseClass).HasMaxLength(300);
            entity.Property(e => e.SoP)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e._18).HasColumnName("18");
            entity.Property(e => e._19).HasColumnName("19");
            entity.Property(e => e._20).HasColumnName("20");
            entity.Property(e => e._21).HasColumnName("21");
            entity.Property(e => e._22).HasColumnName("22");
            entity.Property(e => e._23).HasColumnName("23");
            entity.Property(e => e._24).HasColumnName("24");
            entity.Property(e => e._2529).HasColumnName("25-29");
            entity.Property(e => e._3034).HasColumnName("30-34");
            entity.Property(e => e._3539).HasColumnName("35-39");
            entity.Property(e => e._4044).HasColumnName("40-44");
            entity.Property(e => e._4549).HasColumnName("45-49");
            entity.Property(e => e._5054).HasColumnName("50-54");
            entity.Property(e => e._5559).HasColumnName("55-59");
            entity.Property(e => e._6064).HasColumnName("60-64");
            entity.Property(e => e._65Over).HasColumnName("65_over");
        });

        modelBuilder.Entity<RptUcrasradultDrugTotalF>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRAdult_DrugTotalF");

            entity.Property(e => e.AmericanIndianAknative).HasColumnName("AmericanIndian_AKNative");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.OffenseClass).HasMaxLength(300);
            entity.Property(e => e.SoP)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e._18).HasColumnName("18");
            entity.Property(e => e._19).HasColumnName("19");
            entity.Property(e => e._20).HasColumnName("20");
            entity.Property(e => e._21).HasColumnName("21");
            entity.Property(e => e._22).HasColumnName("22");
            entity.Property(e => e._23).HasColumnName("23");
            entity.Property(e => e._24).HasColumnName("24");
            entity.Property(e => e._2529).HasColumnName("25-29");
            entity.Property(e => e._3034).HasColumnName("30-34");
            entity.Property(e => e._3539).HasColumnName("35-39");
            entity.Property(e => e._4044).HasColumnName("40-44");
            entity.Property(e => e._4549).HasColumnName("45-49");
            entity.Property(e => e._5054).HasColumnName("50-54");
            entity.Property(e => e._5559).HasColumnName("55-59");
            entity.Property(e => e._6064).HasColumnName("60-64");
            entity.Property(e => e._65Over).HasColumnName("65_over");
        });

        modelBuilder.Entity<RptUcrasradultDrugTotalM>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRAdult_DrugTotalM");

            entity.Property(e => e.AmericanIndianAknative).HasColumnName("AmericanIndian_AKNative");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.OffenseClass).HasMaxLength(300);
            entity.Property(e => e.SoP)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e._18).HasColumnName("18");
            entity.Property(e => e._19).HasColumnName("19");
            entity.Property(e => e._20).HasColumnName("20");
            entity.Property(e => e._21).HasColumnName("21");
            entity.Property(e => e._22).HasColumnName("22");
            entity.Property(e => e._23).HasColumnName("23");
            entity.Property(e => e._24).HasColumnName("24");
            entity.Property(e => e._2529).HasColumnName("25-29");
            entity.Property(e => e._3034).HasColumnName("30-34");
            entity.Property(e => e._3539).HasColumnName("35-39");
            entity.Property(e => e._4044).HasColumnName("40-44");
            entity.Property(e => e._4549).HasColumnName("45-49");
            entity.Property(e => e._5054).HasColumnName("50-54");
            entity.Property(e => e._5559).HasColumnName("55-59");
            entity.Property(e => e._6064).HasColumnName("60-64");
            entity.Property(e => e._65Over).HasColumnName("65_over");
        });

        modelBuilder.Entity<RptUcrasradultOp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRAdult_OP");

            entity.Property(e => e.AmericanIndianAknative).HasColumnName("AmericanIndian_AKNative");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.OffenseClass).HasMaxLength(300);
            entity.Property(e => e._18).HasColumnName("18");
            entity.Property(e => e._19).HasColumnName("19");
            entity.Property(e => e._20).HasColumnName("20");
            entity.Property(e => e._21).HasColumnName("21");
            entity.Property(e => e._22).HasColumnName("22");
            entity.Property(e => e._23).HasColumnName("23");
            entity.Property(e => e._24).HasColumnName("24");
            entity.Property(e => e._2529).HasColumnName("25-29");
            entity.Property(e => e._3034).HasColumnName("30-34");
            entity.Property(e => e._3539).HasColumnName("35-39");
            entity.Property(e => e._4044).HasColumnName("40-44");
            entity.Property(e => e._4549).HasColumnName("45-49");
            entity.Property(e => e._5054).HasColumnName("50-54");
            entity.Property(e => e._5559).HasColumnName("55-59");
            entity.Property(e => e._6064).HasColumnName("60-64");
            entity.Property(e => e._65Over).HasColumnName("65_over");
        });

        modelBuilder.Entity<RptUcrasradultOp1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRAdult_OP1");

            entity.Property(e => e.AmericanIndianAknative).HasColumnName("AmericanIndian_AKNative");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.OffenseClass).HasMaxLength(300);
            entity.Property(e => e._18).HasColumnName("18");
            entity.Property(e => e._19).HasColumnName("19");
            entity.Property(e => e._20).HasColumnName("20");
            entity.Property(e => e._21).HasColumnName("21");
            entity.Property(e => e._22).HasColumnName("22");
            entity.Property(e => e._23).HasColumnName("23");
            entity.Property(e => e._24).HasColumnName("24");
            entity.Property(e => e._2529).HasColumnName("25-29");
            entity.Property(e => e._3034).HasColumnName("30-34");
            entity.Property(e => e._3539).HasColumnName("35-39");
            entity.Property(e => e._4044).HasColumnName("40-44");
            entity.Property(e => e._4549).HasColumnName("45-49");
            entity.Property(e => e._5054).HasColumnName("50-54");
            entity.Property(e => e._5559).HasColumnName("55-59");
            entity.Property(e => e._6064).HasColumnName("60-64");
            entity.Property(e => e._65Over).HasColumnName("65_over");
        });

        modelBuilder.Entity<RptUcrasradultOp2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRAdult_OP2");

            entity.Property(e => e.AmericanIndianAknative).HasColumnName("AmericanIndian_AKNative");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.OffenseClass).HasMaxLength(300);
            entity.Property(e => e._18).HasColumnName("18");
            entity.Property(e => e._19).HasColumnName("19");
            entity.Property(e => e._20).HasColumnName("20");
            entity.Property(e => e._21).HasColumnName("21");
            entity.Property(e => e._22).HasColumnName("22");
            entity.Property(e => e._23).HasColumnName("23");
            entity.Property(e => e._24).HasColumnName("24");
            entity.Property(e => e._2529).HasColumnName("25-29");
            entity.Property(e => e._3034).HasColumnName("30-34");
            entity.Property(e => e._3539).HasColumnName("35-39");
            entity.Property(e => e._4044).HasColumnName("40-44");
            entity.Property(e => e._4549).HasColumnName("45-49");
            entity.Property(e => e._5054).HasColumnName("50-54");
            entity.Property(e => e._5559).HasColumnName("55-59");
            entity.Property(e => e._6064).HasColumnName("60-64");
            entity.Property(e => e._65Over).HasColumnName("65_over");
        });

        modelBuilder.Entity<RptUcrasrjuv1select>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRJuv_1Select");

            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
        });

        modelBuilder.Entity<RptUcrasrjuv2case>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRJuv_2Case");

            entity.Property(e => e.AmericanIndianAknative).HasColumnName("AmericanIndian_AKNative");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e._1012).HasColumnName("10-12");
            entity.Property(e => e._1314).HasColumnName("13-14");
            entity.Property(e => e._15).HasColumnName("15");
            entity.Property(e => e._16).HasColumnName("16");
            entity.Property(e => e._17).HasColumnName("17");
        });

        modelBuilder.Entity<RptUcrasrjuv3bGroupRefUcr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRJuv_3bGroupRefUCR");

            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.FirstInGroup).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.ReportCategory).HasMaxLength(300);
            entity.Property(e => e.ReportGroup).HasMaxLength(300);
            entity.Property(e => e._1012).HasColumnName("10-12");
            entity.Property(e => e._1314).HasColumnName("13-14");
            entity.Property(e => e._15).HasColumnName("15");
            entity.Property(e => e._16).HasColumnName("16");
            entity.Property(e => e._17).HasColumnName("17");
        });

        modelBuilder.Entity<RptUcrasrjuv4>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRJuv_4");

            entity.Property(e => e.AmericanIndianAknative).HasColumnName("AmericanIndian_AKNative");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.OffenseClass).HasMaxLength(300);
            entity.Property(e => e._1012).HasColumnName("10-12");
            entity.Property(e => e._1314).HasColumnName("13-14");
            entity.Property(e => e._15).HasColumnName("15");
            entity.Property(e => e._16).HasColumnName("16");
            entity.Property(e => e._17).HasColumnName("17");
        });

        modelBuilder.Entity<RptUcrasrjuvDrugTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRJuv_DrugTotal");

            entity.Property(e => e.AmericanIndianAknative).HasColumnName("AmericanIndian_AKNative");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.OffenseClass).HasMaxLength(300);
            entity.Property(e => e.SoP)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e._1012).HasColumnName("10-12");
            entity.Property(e => e._1314).HasColumnName("13-14");
            entity.Property(e => e._15).HasColumnName("15");
            entity.Property(e => e._16).HasColumnName("16");
            entity.Property(e => e._17).HasColumnName("17");
        });

        modelBuilder.Entity<RptUcrasrjuvDrugTotalF>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRJuv_DrugTotalF");

            entity.Property(e => e.AmericanIndianAknative).HasColumnName("AmericanIndian_AKNative");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.OffenseClass).HasMaxLength(300);
            entity.Property(e => e.SoP)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e._1012).HasColumnName("10-12");
            entity.Property(e => e._1314).HasColumnName("13-14");
            entity.Property(e => e._15).HasColumnName("15");
            entity.Property(e => e._16).HasColumnName("16");
            entity.Property(e => e._17).HasColumnName("17");
        });

        modelBuilder.Entity<RptUcrasrjuvDrugTotalM>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRJuv_DrugTotalM");

            entity.Property(e => e.AmericanIndianAknative).HasColumnName("AmericanIndian_AKNative");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.OffenseClass).HasMaxLength(300);
            entity.Property(e => e.SoP)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e._1012).HasColumnName("10-12");
            entity.Property(e => e._1314).HasColumnName("13-14");
            entity.Property(e => e._15).HasColumnName("15");
            entity.Property(e => e._16).HasColumnName("16");
            entity.Property(e => e._17).HasColumnName("17");
        });

        modelBuilder.Entity<RptUcrasrjuvOp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRJuv_OP");

            entity.Property(e => e.AmericanIndianAknative).HasColumnName("AmericanIndian_AKNative");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.OffenseClass).HasMaxLength(300);
            entity.Property(e => e._1012).HasColumnName("10-12");
            entity.Property(e => e._1314).HasColumnName("13-14");
            entity.Property(e => e._15).HasColumnName("15");
            entity.Property(e => e._16).HasColumnName("16");
            entity.Property(e => e._17).HasColumnName("17");
        });

        modelBuilder.Entity<RptUcrasrjuvOp1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRJuv_OP1");

            entity.Property(e => e.AmericanIndianAknative).HasColumnName("AmericanIndian_AKNative");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.OffenseClass).HasMaxLength(300);
            entity.Property(e => e._1012).HasColumnName("10-12");
            entity.Property(e => e._1314).HasColumnName("13-14");
            entity.Property(e => e._15).HasColumnName("15");
            entity.Property(e => e._16).HasColumnName("16");
            entity.Property(e => e._17).HasColumnName("17");
        });

        modelBuilder.Entity<RptUcrasrjuvOp2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRASRJuv_OP2");

            entity.Property(e => e.AmericanIndianAknative).HasColumnName("AmericanIndian_AKNative");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.AsianPacificIslander).HasColumnName("Asian_PacificIslander");
            entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.OffenseClass).HasMaxLength(300);
            entity.Property(e => e._1012).HasColumnName("10-12");
            entity.Property(e => e._1314).HasColumnName("13-14");
            entity.Property(e => e._15).HasColumnName("15");
            entity.Property(e => e._16).HasColumnName("16");
            entity.Property(e => e._17).HasColumnName("17");
        });

        modelBuilder.Entity<RptUcraudit1getIncident>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRAudit_1GetIncident");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ClearanceCode).HasMaxLength(100);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(154);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.LocationShortDisplayString).HasMaxLength(300);
            entity.Property(e => e.RefItemId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RefItemID");
            entity.Property(e => e.ReportCategory).HasMaxLength(300);
            entity.Property(e => e.ReportGroup).HasMaxLength(300);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
        });

        modelBuilder.Entity<RptUcraudit2getEventType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRAudit_2GetEventType");

            entity.Property(e => e.Cadnumber)
                .HasMaxLength(1000)
                .HasColumnName("CADNumber");
            entity.Property(e => e.CallForServiceType).HasMaxLength(100);
            entity.Property(e => e.CallTypeId).HasColumnName("CallTypeID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
        });

        modelBuilder.Entity<RptUcraudit3getStolenRecProp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRAudit_3GetStolenRecProp");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.RecoveredPropValue).HasColumnType("money");
            entity.Property(e => e.StolenPropValue).HasColumnType("money");
        });

        modelBuilder.Entity<RptUcraudit4getStolenRecVeh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRAudit_4GetStolenRecVeh");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.RecoveredVehValue).HasColumnType("money");
            entity.Property(e => e.StolenVehValue).HasColumnType("money");
        });

        modelBuilder.Entity<RptUcraudit5unionPropVeh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRAudit_5UnionPropVeh");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.RecoveredPropValue).HasColumnType("money");
            entity.Property(e => e.RecoveredVehValue).HasColumnType("money");
            entity.Property(e => e.StolenPropValue).HasColumnType("money");
            entity.Property(e => e.StolenVehValue).HasColumnType("money");
        });

        modelBuilder.Entity<RptUcrauditOp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRAudit_OP");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ClearanceCode).HasMaxLength(100);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(154);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.LocationShortDisplayString).HasMaxLength(300);
            entity.Property(e => e.RecoveredValue).HasColumnType("money");
            entity.Property(e => e.ReportCategory).HasMaxLength(300);
            entity.Property(e => e.ReportGroup).HasMaxLength(300);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.StolenValue).HasColumnType("money");
        });

        modelBuilder.Entity<RptUcrhom1a1selectVictim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRHom1a_1SelectVictim");

            entity.Property(e => e.Arrestee).HasColumnName("arrestee");
            entity.Property(e => e.ArresteeInvolveIncId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArresteeInvolveIncID");
            entity.Property(e => e.CadreprotedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("CADReprotedDateTime");
            entity.Property(e => e.DateofOccurrence).HasColumnType("datetime");
            entity.Property(e => e.DepartName).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EthnicityCode).HasMaxLength(100);
            entity.Property(e => e.GenderCode).HasMaxLength(100);
            entity.Property(e => e.IncId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncID");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.LinkedPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LinkedPersonID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.PersonRelationLnkcode).HasColumnName("PersonRelationLNKCode");
            entity.Property(e => e.PrimaryPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryPersonID");
            entity.Property(e => e.RaceCode).HasMaxLength(100);
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.VictimEthnicity).HasMaxLength(100);
            entity.Property(e => e.VictimRace).HasMaxLength(100);
            entity.Property(e => e.VictimRelationship).HasMaxLength(100);
            entity.Property(e => e.VictimSex).HasMaxLength(100);
            entity.Property(e => e.WeaponUsed).HasMaxLength(100);
        });

        modelBuilder.Entity<RptUcrhom1a2countVictim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRHom1a_2CountVictim");

            entity.Property(e => e.CadreprotedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("CADReprotedDateTime");
            entity.Property(e => e.DateofOccurrence).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DepartmentName).HasMaxLength(50);
            entity.Property(e => e.EthnicityCode).HasMaxLength(100);
            entity.Property(e => e.GenderCode).HasMaxLength(100);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.LinkedPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LinkedPersonID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.RaceCode).HasMaxLength(100);
            entity.Property(e => e.Ucrcategory)
                .HasMaxLength(50)
                .HasColumnName("UCRCategory");
            entity.Property(e => e.VictimEthnicity).HasMaxLength(100);
            entity.Property(e => e.VictimRace).HasMaxLength(100);
            entity.Property(e => e.VictimRelationship).HasMaxLength(100);
            entity.Property(e => e.VictimSex).HasMaxLength(100);
            entity.Property(e => e.WeaponUsed).HasMaxLength(100);
        });

        modelBuilder.Entity<RptUcrhom1a3selectOffender>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRHom1a_3SelectOffender");

            entity.Property(e => e.CadreprotedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("CADReprotedDateTime");
            entity.Property(e => e.DateofOccurrence).HasColumnType("datetime");
            entity.Property(e => e.DepartName).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EthnicityCode).HasMaxLength(100);
            entity.Property(e => e.GenderCode).HasMaxLength(100);
            entity.Property(e => e.IncId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncID");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.OffenderEthnicity).HasMaxLength(100);
            entity.Property(e => e.OffenderRace).HasMaxLength(100);
            entity.Property(e => e.OffenderSex).HasMaxLength(100);
            entity.Property(e => e.RaceCode).HasMaxLength(100);
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.WeaponUsed).HasMaxLength(100);
        });

        modelBuilder.Entity<RptUcrhom1a4countOffender>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRHom1a_4CountOffender");

            entity.Property(e => e.CadreprotedDateTime2)
                .HasColumnType("datetime")
                .HasColumnName("CADReprotedDateTime_2");
            entity.Property(e => e.DateOfOccurrence2)
                .HasColumnType("datetime")
                .HasColumnName("DateOfOccurrence_2");
            entity.Property(e => e.DepartmentId2).HasColumnName("DepartmentID_2");
            entity.Property(e => e.DepartmentName2)
                .HasMaxLength(50)
                .HasColumnName("DepartmentName_2");
            entity.Property(e => e.EthnicityCode).HasMaxLength(100);
            entity.Property(e => e.GenderCode).HasMaxLength(100);
            entity.Property(e => e.IncidentId2)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID_2");
            entity.Property(e => e.Mpid2)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID_2");
            entity.Property(e => e.OffenderEthnicity).HasMaxLength(100);
            entity.Property(e => e.OffenderRace).HasMaxLength(100);
            entity.Property(e => e.OffenderSex).HasMaxLength(100);
            entity.Property(e => e.RaceCode).HasMaxLength(100);
            entity.Property(e => e.Ucrcategory2)
                .HasMaxLength(50)
                .HasColumnName("UCRCategory_2");
            entity.Property(e => e.WeaponUsed2)
                .HasMaxLength(100)
                .HasColumnName("WeaponUsed_2");
        });

        modelBuilder.Entity<RptUcrhom1a5countVictimOffender>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRHom1a_5CountVictimOffender");

            entity.Property(e => e.DepartmentId3).HasColumnName("DepartmentID_3");
            entity.Property(e => e.IncidentId3)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID_3");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
        });

        modelBuilder.Entity<RptUcrhom1aOp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRHom1a_OP");

            entity.Property(e => e.Classification).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DepartmentId2).HasColumnName("DepartmentID_2");
            entity.Property(e => e.DepartmentId3).HasColumnName("DepartmentID_3");
            entity.Property(e => e.EthnicityCodeOff).HasMaxLength(100);
            entity.Property(e => e.EthnicityCodeVic).HasMaxLength(100);
            entity.Property(e => e.GenderCodeOff).HasMaxLength(100);
            entity.Property(e => e.GenderCodeVic).HasMaxLength(100);
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.Mpid2)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID_2");
            entity.Property(e => e.OccurDate).HasColumnType("datetime");
            entity.Property(e => e.OffenderEthnicity).HasMaxLength(100);
            entity.Property(e => e.OffenderRace).HasMaxLength(100);
            entity.Property(e => e.OffenderSex).HasMaxLength(100);
            entity.Property(e => e.RaceCodeOff).HasMaxLength(100);
            entity.Property(e => e.RaceCodeVic).HasMaxLength(100);
            entity.Property(e => e.VictimEthnicity).HasMaxLength(100);
            entity.Property(e => e.VictimRace).HasMaxLength(100);
            entity.Property(e => e.VictimRelationship).HasMaxLength(100);
            entity.Property(e => e.VictimSex).HasMaxLength(100);
            entity.Property(e => e.WeaponUsed).HasMaxLength(100);
        });

        modelBuilder.Entity<RptUcrhom1b1selectVictim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRHom1b_1SelectVictim");

            entity.Property(e => e.Arrestee).HasColumnName("arrestee");
            entity.Property(e => e.ArresteeInvolveIncId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArresteeInvolveIncID");
            entity.Property(e => e.CadreprotedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("CADReprotedDateTime");
            entity.Property(e => e.DateofOccurrence).HasColumnType("datetime");
            entity.Property(e => e.DepartName).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EthnicityCode).HasMaxLength(100);
            entity.Property(e => e.GenderCode).HasMaxLength(100);
            entity.Property(e => e.IncId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncID");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.LinkedPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LinkedPersonID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.PersonRelationLnkcode).HasColumnName("PersonRelationLNKCode");
            entity.Property(e => e.PrimaryPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryPersonID");
            entity.Property(e => e.RaceCode).HasMaxLength(100);
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.VictimEthnicity).HasMaxLength(100);
            entity.Property(e => e.VictimRace).HasMaxLength(100);
            entity.Property(e => e.VictimRelationship).HasMaxLength(100);
            entity.Property(e => e.VictimSex).HasMaxLength(100);
            entity.Property(e => e.WeaponUsed).HasMaxLength(100);
        });

        modelBuilder.Entity<RptUcrhom1b2countVictim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRHom1b_2CountVictim");

            entity.Property(e => e.CadreprotedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("CADReprotedDateTime");
            entity.Property(e => e.DateofOccurrence).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DepartmentName).HasMaxLength(50);
            entity.Property(e => e.EthnicityCode).HasMaxLength(100);
            entity.Property(e => e.GenderCode).HasMaxLength(100);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.LinkedPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LinkedPersonID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.RaceCode).HasMaxLength(100);
            entity.Property(e => e.Ucrcategory)
                .HasMaxLength(50)
                .HasColumnName("UCRCategory");
            entity.Property(e => e.VictimEthnicity).HasMaxLength(100);
            entity.Property(e => e.VictimRace).HasMaxLength(100);
            entity.Property(e => e.VictimRelationship).HasMaxLength(100);
            entity.Property(e => e.VictimSex).HasMaxLength(100);
            entity.Property(e => e.WeaponUsed).HasMaxLength(100);
        });

        modelBuilder.Entity<RptUcrhom1b3selectOffender>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRHom1b_3SelectOffender");

            entity.Property(e => e.CadreprotedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("CADReprotedDateTime");
            entity.Property(e => e.DateofOccurrence).HasColumnType("datetime");
            entity.Property(e => e.DepartName).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EthnicityCode).HasMaxLength(100);
            entity.Property(e => e.GenderCode).HasMaxLength(100);
            entity.Property(e => e.IncId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncID");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.OffenderEthnicity).HasMaxLength(100);
            entity.Property(e => e.OffenderRace).HasMaxLength(100);
            entity.Property(e => e.OffenderSex).HasMaxLength(100);
            entity.Property(e => e.RaceCode).HasMaxLength(100);
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.WeaponUsed).HasMaxLength(100);
        });

        modelBuilder.Entity<RptUcrhom1b4countOffender>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRHom1b_4CountOffender");

            entity.Property(e => e.CadreprotedDateTime2)
                .HasColumnType("datetime")
                .HasColumnName("CADReprotedDateTime_2");
            entity.Property(e => e.DateOfOccurrence2)
                .HasColumnType("datetime")
                .HasColumnName("DateOfOccurrence_2");
            entity.Property(e => e.DepartmentId2).HasColumnName("DepartmentID_2");
            entity.Property(e => e.DepartmentName2)
                .HasMaxLength(50)
                .HasColumnName("DepartmentName_2");
            entity.Property(e => e.EthnicityCode).HasMaxLength(100);
            entity.Property(e => e.GenderCode).HasMaxLength(100);
            entity.Property(e => e.IncidentId2)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID_2");
            entity.Property(e => e.Mpid2)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID_2");
            entity.Property(e => e.OffenderEthnicity).HasMaxLength(100);
            entity.Property(e => e.OffenderRace).HasMaxLength(100);
            entity.Property(e => e.OffenderSex).HasMaxLength(100);
            entity.Property(e => e.RaceCode).HasMaxLength(100);
            entity.Property(e => e.Ucrcategory2)
                .HasMaxLength(50)
                .HasColumnName("UCRCategory_2");
            entity.Property(e => e.WeaponUsed2)
                .HasMaxLength(100)
                .HasColumnName("WeaponUsed_2");
        });

        modelBuilder.Entity<RptUcrhom1b5countVictimOffender>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRHom1b_5CountVictimOffender");

            entity.Property(e => e.DepartmentId3).HasColumnName("DepartmentID_3");
            entity.Property(e => e.IncidentId3)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID_3");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
        });

        modelBuilder.Entity<RptUcrhom1bOp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRHom1b_OP");

            entity.Property(e => e.Classification).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DepartmentId2).HasColumnName("DepartmentID_2");
            entity.Property(e => e.DepartmentId3).HasColumnName("DepartmentID_3");
            entity.Property(e => e.EthnicityCodeOff).HasMaxLength(100);
            entity.Property(e => e.EthnicityCodeVic).HasMaxLength(100);
            entity.Property(e => e.GenderCodeOff).HasMaxLength(100);
            entity.Property(e => e.GenderCodeVic).HasMaxLength(100);
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.Mpid2)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID_2");
            entity.Property(e => e.OccurDate).HasColumnType("datetime");
            entity.Property(e => e.OffenderEthnicity).HasMaxLength(100);
            entity.Property(e => e.OffenderRace).HasMaxLength(100);
            entity.Property(e => e.OffenderSex).HasMaxLength(100);
            entity.Property(e => e.RaceCodeOff).HasMaxLength(100);
            entity.Property(e => e.RaceCodeVic).HasMaxLength(100);
            entity.Property(e => e.VictimEthnicity).HasMaxLength(100);
            entity.Property(e => e.VictimRace).HasMaxLength(100);
            entity.Property(e => e.VictimRelationship).HasMaxLength(100);
            entity.Property(e => e.VictimSex).HasMaxLength(100);
            entity.Property(e => e.WeaponUsed).HasMaxLength(100);
        });

        modelBuilder.Entity<RptUcrhomicde>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRHomicdes");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Ethnicity).HasMaxLength(100);
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Name).HasMaxLength(206);
            entity.Property(e => e.Race).HasMaxLength(100);
            entity.Property(e => e.Type)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RptUcrmonthlyArson1bSelectClearance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRMonthlyArson_1bSelectClearance");

            entity.Property(e => e.ClearanceDate).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");
        });

        modelBuilder.Entity<RptUcrmonthlyArson1select>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRMonthlyArson_1Select");

            entity.Property(e => e.CategoryGroup).HasMaxLength(50);
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");
        });

        modelBuilder.Entity<RptUcrmonthlyArson2bGroupArson>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRMonthlyArson_2bGroupArson");

            entity.Property(e => e.Classification).HasMaxLength(300);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.IncidentOccuredDtstart).HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OffenseGroup).HasMaxLength(300);
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.Unfounded).HasColumnName("unfounded");
        });

        modelBuilder.Entity<RptUcrmonthlyArson3aGetVehicleValue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRMonthlyArson_3aGetVehicleValue");

            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.VehicleValue).HasColumnType("money");
        });

        modelBuilder.Entity<RptUcrmonthlyArson3getPropertyValue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRMonthlyArson_3GetPropertyValue");

            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.PropertyValue).HasColumnType("money");
        });

        modelBuilder.Entity<RptUcrmonthlyArson4clearanceJuv>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRMonthlyArson_4ClearanceJuv");

            entity.Property(e => e.Classification).HasMaxLength(300);
            entity.Property(e => e.ClearanceDate).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.OffenseGroup).HasMaxLength(300);
            entity.Property(e => e.ReportDefinitionId).HasColumnName("ReportDefinitionID");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");
        });

        modelBuilder.Entity<RptUcrmonthlyArson5>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRMonthlyArson_5");

            entity.Property(e => e.Classification).HasMaxLength(300);
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OffenseGroup).HasMaxLength(300);
            entity.Property(e => e.PropertyValue).HasColumnType("money");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.VehicleValue).HasColumnType("money");
        });

        modelBuilder.Entity<RptUcrmonthlyArsonOp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRMonthlyArson_OP");

            entity.Property(e => e.Classification).HasMaxLength(300);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OffenseGroup).HasMaxLength(300);
            entity.Property(e => e.TotalValue).HasColumnType("money");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
        });

        modelBuilder.Entity<RptUcrreturnA1bSelectClearance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRReturnA_1bSelectClearance");

            entity.Property(e => e.ClearanceDate).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.ReportCategory).HasMaxLength(300);
            entity.Property(e => e.ReportGroup).HasMaxLength(300);
        });

        modelBuilder.Entity<RptUcrreturnA1select>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRReturnA_1Select");

            entity.Property(e => e.ClearanceDate).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.ReportCategory).HasMaxLength(300);
            entity.Property(e => e.ReportGroup).HasMaxLength(300);
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");
        });

        modelBuilder.Entity<RptUcrreturnA2aAllDept>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRReturnA_2aAllDept");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<RptUcrreturnA2bGroupRefUcr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRReturnA_2bGroupRefUCR");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ReportCategory).HasMaxLength(300);
            entity.Property(e => e.ReportGroup).HasMaxLength(300);
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
        });

        modelBuilder.Entity<RptUcrreturnA3aArresteeAge>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRReturnA_3aArresteeAge");

            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
        });

        modelBuilder.Entity<RptUcrreturnA3bArresteeJuv>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRReturnA_3bArresteeJuv");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
        });

        modelBuilder.Entity<RptUcrreturnA4clearanceJuv>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRReturnA_4ClearanceJuv");

            entity.Property(e => e.ClearanceDate).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.ReportCategory).HasMaxLength(300);
            entity.Property(e => e.ReportGroup).HasMaxLength(300);
        });

        modelBuilder.Entity<RptUcrreturnAOp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRReturnA_OP");

            entity.Property(e => e.ClearanceDate).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ReportCategory).HasMaxLength(300);
            entity.Property(e => e.ReportGroup).HasMaxLength(300);
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
        });

        modelBuilder.Entity<RptUcrsuppAoffense1select>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRSuppAOffense_1Select");

            entity.Property(e => e.CategoryGroup).HasMaxLength(50);
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EstimatedVehicleValue).HasColumnType("money");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.PropertyId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PropertyID");
            entity.Property(e => e.PropertyValue).HasColumnType("money");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");
            entity.Property(e => e.Value).HasColumnType("money");
            entity.Property(e => e.VehicleValue).HasColumnType("money");
        });

        modelBuilder.Entity<RptUcrsuppAoffense3bGroupUcr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRSuppAOffense_3bGroupUCR");

            entity.Property(e => e.Classification).HasMaxLength(300);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OffenseGroup).HasMaxLength(300);
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<RptUcrsuppAoffense3cGroupStolenRecWhere>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRSuppAOffense_3cGroupStolenRecWhere");

            entity.Property(e => e.Classification).HasMaxLength(300);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OffenseGroup).HasMaxLength(300);
            entity.Property(e => e.RefIncidentReferenceDataId).HasColumnName("RefIncidentReferenceDataID");
        });

        modelBuilder.Entity<RptUcrsuppAoffense4>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRSuppAOffense_4");

            entity.Property(e => e.Classification).HasMaxLength(300);
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.OffenseGroup).HasMaxLength(300);
            entity.Property(e => e.PropertyId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PropertyID");
            entity.Property(e => e.StolenValue).HasColumnType("money");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
        });

        modelBuilder.Entity<RptUcrsuppAoffenseOp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRSuppAOffense_OP");

            entity.Property(e => e.Classification).HasMaxLength(300);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OffenseGroup).HasMaxLength(300);
            entity.Property(e => e.StolenValue).HasColumnType("money");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
        });

        modelBuilder.Entity<RptUcrsuppAoffenseOp7x>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRSuppAOffense_OP7x");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.ReportCategory).HasMaxLength(300);
            entity.Property(e => e.ReportGroup).HasMaxLength(300);
        });

        modelBuilder.Entity<RptUcrsuppApropType1selectProperty>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRSuppAPropType_1SelectProperty");

            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.RecoveredValue).HasColumnType("money");
            entity.Property(e => e.Rptcategory)
                .HasMaxLength(100)
                .HasColumnName("RPTCategory");
            entity.Property(e => e.Value)
                .HasColumnType("money")
                .HasColumnName("value");
        });

        modelBuilder.Entity<RptUcrsuppApropType2sumStolenRec>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRSuppAPropType_2SumStolenRec");

            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.RecoveredValue).HasColumnType("money");
            entity.Property(e => e.Rptcategory)
                .HasMaxLength(100)
                .HasColumnName("RPTCategory");
            entity.Property(e => e.StolenValue).HasColumnType("money");
        });

        modelBuilder.Entity<RptUcrsuppApropType3aAllDept>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRSuppAPropType_3aAllDept");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<RptUcrsuppApropType3bGroupPropUcr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRSuppAPropType_3bGroupPropUCR");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.IncidentOccuredDtstart).HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Rptcategory)
                .HasMaxLength(100)
                .HasColumnName("RPTCategory");
        });

        modelBuilder.Entity<RptUcrsuppApropType3cGroupVehUcr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRSuppAPropType_3cGroupVehUCR");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.IncidentOccuredDtstart).HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Rptcategory)
                .HasMaxLength(33)
                .IsUnicode(false)
                .HasColumnName("RPTCategory");
        });

        modelBuilder.Entity<RptUcrsuppApropType4selectVehicle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRSuppAPropType_4SelectVehicle");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Ucrtype)
                .HasMaxLength(33)
                .IsUnicode(false)
                .HasColumnName("UCRType");
            entity.Property(e => e.Value).HasColumnType("money");
        });

        modelBuilder.Entity<RptUcrsuppApropType5sumStolenRecVeh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRSuppAPropType_5SumStolenRecVeh");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.RecoveredValue).HasColumnType("money");
            entity.Property(e => e.StolenValue).HasColumnType("money");
            entity.Property(e => e.Ucrtype)
                .HasMaxLength(33)
                .IsUnicode(false)
                .HasColumnName("UCRType");
        });

        modelBuilder.Entity<RptUcrsuppApropTypeOp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRSuppAPropType_OP");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.RecoveredValue).HasColumnType("money");
            entity.Property(e => e.Rptcategory)
                .HasMaxLength(100)
                .HasColumnName("RPTCategory");
            entity.Property(e => e.StolenValue).HasColumnType("money");
        });

        modelBuilder.Entity<RptUcrsuppApropTypeOpveh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRSuppAPropType_OPVeh");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.RecoveredValue).HasColumnType("money");
            entity.Property(e => e.Rptcategory)
                .HasMaxLength(33)
                .IsUnicode(false)
                .HasColumnName("RPTCategory");
            entity.Property(e => e.StolenValue).HasColumnType("money");
        });

        modelBuilder.Entity<RptUcrxref1arrestee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRXRef_1arrestee");

            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Ethnicity).HasMaxLength(100);
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.Race).HasMaxLength(100);
            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
        });

        modelBuilder.Entity<RptUcrxref2classProp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRXRef_2classProp");

            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.TotRecPropValue).HasColumnType("money");
            entity.Property(e => e.TotStolenPropValue).HasColumnType("money");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.ValueRange).HasMaxLength(100);
        });

        modelBuilder.Entity<RptUcrxref4veh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRXRef_4Veh");

            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.IncidentStatusId).HasColumnName("IncidentStatusID");
            entity.Property(e => e.TotRecVehValue).HasColumnType("money");
            entity.Property(e => e.TotStolenVehValue).HasColumnType("money");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.ValueRange).HasMaxLength(100);
        });

        modelBuilder.Entity<RptUcrxrefOp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_UCRXRef_OP");

            entity.Property(e => e.ArrestDateTime).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Ethnicity).HasMaxLength(100);
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IncidentOccuredDtstart)
                .HasColumnType("datetime")
                .HasColumnName("IncidentOccuredDTStart");
            entity.Property(e => e.Race).HasMaxLength(100);
            entity.Property(e => e.TotRecPropValue).HasColumnType("money");
            entity.Property(e => e.TotRecVehValue).HasColumnType("money");
            entity.Property(e => e.TotStolenPropValue).HasColumnType("money");
            entity.Property(e => e.TotStolenVehValue).HasColumnType("money");
            entity.Property(e => e.Ucrcode)
                .HasMaxLength(5)
                .HasColumnName("UCRCode");
            entity.Property(e => e.UcrcodeDisplayName)
                .HasMaxLength(50)
                .HasColumnName("UCRCodeDisplayName");
            entity.Property(e => e.ValueRange).HasMaxLength(100);
        });

        modelBuilder.Entity<RptWarrant1getContact>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_Warrant_1GetContact");

            entity.Property(e => e.ContactData).HasMaxLength(400);
            entity.Property(e => e.ContactType).HasMaxLength(50);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
        });

        modelBuilder.Entity<RptWarrant2getPhone>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_Warrant_2GetPhone");

            entity.Property(e => e.ContactData).HasMaxLength(400);
            entity.Property(e => e.ContactType).HasMaxLength(50);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
        });

        modelBuilder.Entity<RptWarrant3getName>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_Warrant_3GetName");

            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.FullName).HasMaxLength(206);
            entity.Property(e => e.GivenName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.SurName).HasMaxLength(50);
        });

        modelBuilder.Entity<RptWarrantOp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_Warrant_OP");

            entity.Property(e => e.BondAmount).HasColumnType("money");
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CourtDate).HasColumnType("date");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.GivenName).HasMaxLength(50);
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IssuedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LocationDetailDisplayString).HasMaxLength(800);
            entity.Property(e => e.LocationShortDisplayString).HasMaxLength(300);
            entity.Property(e => e.Name).HasMaxLength(206);
            entity.Property(e => e.Officer).HasMaxLength(154);
            entity.Property(e => e.ReceivedDateTime).HasColumnType("datetime");
            entity.Property(e => e.RptStatus).HasMaxLength(100);
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.StatuteCode).HasMaxLength(100);
            entity.Property(e => e.SurName).HasMaxLength(50);
            entity.Property(e => e.SwornDate).HasColumnType("datetime");
            entity.Property(e => e.WarrantEffectDateTime).HasColumnType("datetime");
            entity.Property(e => e.WarrantExpirationDateTime).HasColumnType("datetime");
            entity.Property(e => e.WarrantNumber).HasMaxLength(20);
            entity.Property(e => e.WarrantStatus).HasMaxLength(100);
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .HasColumnName("ZIP");
        });

        modelBuilder.Entity<RptWarrantStuffStatue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Rpt_WarrantStuffStatues");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.BondAmount).HasColumnType("money");
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CityStateKey).HasMaxLength(201);
            entity.Property(e => e.CourtDate).HasColumnType("date");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IssuedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LocationDetailDisplayString).HasMaxLength(800);
            entity.Property(e => e.LocationShortDisplayString).HasMaxLength(300);
            entity.Property(e => e.Name).HasMaxLength(206);
            entity.Property(e => e.Officer).HasMaxLength(154);
            entity.Property(e => e.ReceivedDateTime).HasColumnType("datetime");
            entity.Property(e => e.RptStatus).HasMaxLength(100);
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.Street).HasMaxLength(300);
            entity.Property(e => e.SwornDate).HasColumnType("datetime");
            entity.Property(e => e.WarrantEffectDateTime).HasColumnType("datetime");
            entity.Property(e => e.WarrantExpirationDateTime).HasColumnType("datetime");
            entity.Property(e => e.WarrantNumber).HasMaxLength(20);
            entity.Property(e => e.WarrantStatus).HasMaxLength(100);
            entity.Property(e => e.WarrantType).HasMaxLength(100);
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .HasColumnName("ZIP");
        });

        modelBuilder.Entity<Sample>(entity =>
        {
            entity.ToTable("sample");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Drawing)
                .HasColumnType("image")
                .HasColumnName("drawing");
            entity.Property(e => e.Drawingstring).HasColumnName("drawingstring");
        });

        modelBuilder.Entity<SecuredIncident>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SecuredIncidents");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.GrantedByEmployeeId).HasColumnName("GrantedByEmployeeID");
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IndividualSecurityToUserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IndividualSecurityToUserID");
        });

        modelBuilder.Entity<SecurityGroupMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SecurityGroupMembers");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DepartmentOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentOrgID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.RootOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RootOrgID");
        });

        modelBuilder.Entity<SecurityObject>(entity =>
        {
            entity.HasKey(e => e.SecurityObjectId).HasName("PK_SECURITYOBJECTS");

            entity.Property(e => e.SecurityObjectId).HasColumnName("SecurityObjectID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.Comments).HasMaxLength(200);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DirectoryMapping).HasMaxLength(200);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Agency).WithMany(p => p.SecurityObjects)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_SECURITY_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.Department).WithMany(p => p.SecurityObjects)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_SECURITY_REFERENCE_DEPARTME2");
        });

        modelBuilder.Entity<SecurityObjectToprofile>(entity =>
        {
            entity.HasKey(e => e.SecurityObjectToprofileId).HasName("PK_SECURITYOBJECTTOPROFILE");

            entity.ToTable("SecurityObjectTOProfile");

            entity.Property(e => e.SecurityObjectToprofileId).HasColumnName("SecurityObjectTOProfileID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Permission).HasMaxLength(100);
            entity.Property(e => e.SecurityObjectId).HasColumnName("SecurityObjectID");
            entity.Property(e => e.SecurityProfileId).HasColumnName("SecurityProfileID");

            entity.HasOne(d => d.SecurityObject).WithMany(p => p.SecurityObjectToprofiles)
                .HasForeignKey(d => d.SecurityObjectId)
                .HasConstraintName("FK_SECURITY_REFERENCE_SECURITY3");

            entity.HasOne(d => d.SecurityProfile).WithMany(p => p.SecurityObjectToprofiles)
                .HasForeignKey(d => d.SecurityProfileId)
                .HasConstraintName("FK_SECURITY_REFERENCE_SECURITY2");
        });

        modelBuilder.Entity<SecurityObjectTouserRole>(entity =>
        {
            entity.HasKey(e => e.SecurityObjectTouserId).HasName("PK_SECURITYOBJECTTOUSERROLE");

            entity.ToTable("SecurityObjectTOUserRole");

            entity.Property(e => e.SecurityObjectTouserId).HasColumnName("SecurityObjectTOUserID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplytoInvolvementCode).HasMaxLength(100);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Permission).HasMaxLength(100);
            entity.Property(e => e.SecurityObjectId).HasColumnName("SecurityObjectID");
            entity.Property(e => e.SecurityRoleId).HasColumnName("SecurityRoleID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.SecurityObject).WithMany(p => p.SecurityObjectTouserRoles)
                .HasForeignKey(d => d.SecurityObjectId)
                .HasConstraintName("FK_SECURITY_REFERENCE_SECURITY4");

            entity.HasOne(d => d.SecurityRole).WithMany(p => p.SecurityObjectTouserRoles)
                .HasForeignKey(d => d.SecurityRoleId)
                .HasConstraintName("FK_SECURITY_REFERENCE_SECURITY5");

            entity.HasOne(d => d.User).WithMany(p => p.SecurityObjectTouserRoles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_SECURITY_REFERENCE_USERS2");
        });

        modelBuilder.Entity<SecurityProfile>(entity =>
        {
            entity.HasKey(e => e.SecurityProfileId).HasName("PK_SECURITYPROFILE");

            entity.ToTable("SecurityProfile");

            entity.Property(e => e.SecurityProfileId).HasColumnName("SecurityProfileID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Comments).HasMaxLength(200);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<SecurityRole>(entity =>
        {
            entity.HasKey(e => e.SecurityRoleId).HasName("PK_SECURITYROLES");

            entity.Property(e => e.SecurityRoleId).HasColumnName("SecurityRoleID");
            entity.Property(e => e.IsSupportWidgetAccessible).HasDefaultValueSql("((0))");
            entity.Property(e => e.RoleName).HasMaxLength(100);
            entity.Property(e => e.SpecialRoleForDepartmentId).HasColumnName("SpecialRoleForDepartmentID");

            entity.HasOne(d => d.SpecialRoleForDepartment).WithMany(p => p.SecurityRoles)
                .HasForeignKey(d => d.SpecialRoleForDepartmentId)
                .HasConstraintName("FK_SECURITY_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<SecurityRoleToUser>(entity =>
        {
            entity.HasKey(e => e.SecurityRoleToUserId).HasName("PK_SECURITYROLETOUSERS");

            entity.HasIndex(e => e.SecurityRoleId, "IX_SecurityRoleToUsers_SecurityRoleID");

            entity.HasIndex(e => e.UserId, "IX_SecurityRoleToUsers_UserID");

            entity.Property(e => e.SecurityRoleToUserId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SecurityRoleToUserID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SecurityRoleId).HasColumnName("SecurityRoleID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.SecurityRole).WithMany(p => p.SecurityRoleToUsers)
                .HasForeignKey(d => d.SecurityRoleId)
                .HasConstraintName("FK_SECURITY_REFERENCE_SECURITY");

            entity.HasOne(d => d.User).WithMany(p => p.SecurityRoleToUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_SECURITY_REFERENCE_USERS");
        });

        modelBuilder.Entity<SerialLock>(entity =>
        {
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.ResourceName).HasMaxLength(50);
        });

        modelBuilder.Entity<ServiceCall>(entity =>
        {
            entity.HasKey(e => e.ServiceCallId).HasName("PK_SERVICECALL");

            entity.ToTable("ServiceCall");

            entity.HasIndex(e => e.Cadid, "IX_ServiceCall_CADID");

            entity.HasIndex(e => e.PrimaryLocationId, "IX_ServiceCall_PrimaryLocationID");

            entity.HasIndex(e => e.ReportStatusId, "IX_ServiceCall_ReportStatusID");

            entity.Property(e => e.ServiceCallId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ServiceCallID");
            entity.Property(e => e.ActivityEndDate).HasColumnType("datetime");
            entity.Property(e => e.ActivityStartDate).HasColumnType("datetime");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Cadid).HasColumnName("CADID");
            entity.Property(e => e.CallArrivedDate).HasColumnType("datetime");
            entity.Property(e => e.CallClearedDate).HasColumnType("datetime");
            entity.Property(e => e.CallCreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CallDispatchedDate).HasColumnType("datetime");
            entity.Property(e => e.CallMechanism).HasMaxLength(100);
            entity.Property(e => e.CallOperator).HasMaxLength(200);
            entity.Property(e => e.CallOriginator).HasMaxLength(200);
            entity.Property(e => e.CallPriority).HasMaxLength(30);
            entity.Property(e => e.CallTypeId).HasColumnName("CallTypeID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DispositionCode).HasMaxLength(30);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HbcallType).HasColumnName("HBCallType");
            entity.Property(e => e.HbfinialCallType).HasColumnName("HBFinialCallType");
            entity.Property(e => e.PrimaryLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PrimaryLocationID");
            entity.Property(e => e.ReportCode).HasMaxLength(200);
            entity.Property(e => e.ReportEmployeeId).HasColumnName("ReportEmployeeID");
            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
            entity.Property(e => e.ScstatusId).HasColumnName("SCStatusID");
            entity.Property(e => e.SecondaryLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SecondaryLocationID");
            entity.Property(e => e.ServiceCallTransferDatetime).HasColumnType("datetime");
            entity.Property(e => e.Source).HasMaxLength(30);

            entity.HasOne(d => d.CallType).WithMany(p => p.ServiceCalls)
                .HasForeignKey(d => d.CallTypeId)
                .HasConstraintName("FK_SERVICEC_REFERENCE_REFCALLF");

            entity.HasOne(d => d.Department).WithMany(p => p.ServiceCalls)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_SERVICEC_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.PrimaryLocation).WithMany(p => p.ServiceCallPrimaryLocations)
                .HasForeignKey(d => d.PrimaryLocationId)
                .HasConstraintName("FK_SERVICEC_REFERENCE_MSTRLOCA2");

            entity.HasOne(d => d.ReportEmployee).WithMany(p => p.ServiceCalls)
                .HasForeignKey(d => d.ReportEmployeeId)
                .HasConstraintName("FK_SERVICEC_REFERENCE_DEPARTME3");

            entity.HasOne(d => d.ReportStatus).WithMany(p => p.ServiceCallReportStatuses)
                .HasForeignKey(d => d.ReportStatusId)
                .HasConstraintName("FK_SERVICEC_REFERENCE_SYSAPPLI");

            entity.HasOne(d => d.Scstatus).WithMany(p => p.ServiceCallScstatuses)
                .HasForeignKey(d => d.ScstatusId)
                .HasConstraintName("FK_SERVICEC_REFERENCE_SYSAPPLI2");

            entity.HasOne(d => d.SecondaryLocation).WithMany(p => p.ServiceCallSecondaryLocations)
                .HasForeignKey(d => d.SecondaryLocationId)
                .HasConstraintName("FK_SERVICEC_REFERENCE_MSTRLOCA");
        });

        modelBuilder.Entity<ServiceCallComment>(entity =>
        {
            entity.HasKey(e => e.ServiceCallCommentsId).HasName("PK_SERVICECALLCOMMENTS");

            entity.HasIndex(e => new { e.ServiceCallId, e.CadcommentId }, "ServiceCallIDINX");

            entity.Property(e => e.ServiceCallCommentsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ServiceCallCommentsID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CadcommentId).HasColumnName("CADCommentID");
            entity.Property(e => e.CommentsCreatedBy).HasMaxLength(100);
            entity.Property(e => e.CommentsCreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.ServiceCallId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ServiceCallID");

            entity.HasOne(d => d.ServiceCall).WithMany(p => p.ServiceCallComments)
                .HasForeignKey(d => d.ServiceCallId)
                .HasConstraintName("FK_SERVICEC_REFERENCE_SERVICECr4");
        });

        modelBuilder.Entity<ServiceCallDispatchedOffical>(entity =>
        {
            entity.HasKey(e => e.ServiceCallDispatchedOfficalId).HasName("PK_SERVICECALLDISPATCHEDOFFICA");

            entity.ToTable("ServiceCallDispatchedOffical");

            entity.HasIndex(e => e.EnforcementOfficialUnitId, "EnforcementOfficialUnitID");

            entity.HasIndex(e => new { e.AssignedOfficalId, e.IsNumberHolder }, "ServiceCallDispatchedOffical_AI_E");

            entity.HasIndex(e => e.IsNumberHolder, "ServiceCallDispatchedOffical_IsNumberHolder_EA");

            entity.Property(e => e.ServiceCallDispatchedOfficalId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ServiceCallDispatchedOfficalID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AssignedOfficalId).HasColumnName("AssignedOfficalID");
            entity.Property(e => e.AssignedOfficalName).HasMaxLength(200);
            entity.Property(e => e.AssignmentCategoryCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CadonlineUnitEmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CADOnlineUnitEmployeeID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EnforcementOfficialUnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("EnforcementOfficialUnitID");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.AssignedOffical).WithMany(p => p.ServiceCallDispatchedOfficals)
                .HasForeignKey(d => d.AssignedOfficalId)
                .HasConstraintName("FK_SERVICEC_REFERENCE_DEPARTME");

            entity.HasOne(d => d.EnforcementOfficialUnit).WithMany(p => p.ServiceCallDispatchedOfficals)
                .HasForeignKey(d => d.EnforcementOfficialUnitId)
                .HasConstraintName("FK_SERVICEC_REFERENCE_ENFORCEM");
        });

        modelBuilder.Entity<ServiceCallDisposition>(entity =>
        {
            entity.HasKey(e => e.ServiceCallDispositionId).HasName("PK_SERVICECALLDISPOSITION");

            entity.ToTable("ServiceCallDisposition");

            entity.HasIndex(e => e.ServiceCallId, "IX_ServiceCallDisposition_ServiceCallID");

            entity.Property(e => e.ServiceCallDispositionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ServiceCallDispositionID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ArrestId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ArrestID");
            entity.Property(e => e.CitationTicketId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CitationTicketID");
            entity.Property(e => e.CrashId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CrashID");
            entity.Property(e => e.DispositionCodeId).HasColumnName("DispositionCodeID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentID");
            entity.Property(e => e.ServiceCallId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ServiceCallID");
            entity.Property(e => e.TicketId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TicketID");

            entity.HasOne(d => d.DispositionCode).WithMany(p => p.ServiceCallDispositions)
                .HasForeignKey(d => d.DispositionCodeId)
                .HasConstraintName("FK_SERVICEC_REFERENCE_REFDISPO");

            entity.HasOne(d => d.ServiceCall).WithMany(p => p.ServiceCallDispositions)
                .HasForeignKey(d => d.ServiceCallId)
                .HasConstraintName("FK_SERVICEC_REFERENCE_SERVICEC");
        });

        modelBuilder.Entity<ServiceCallLog>(entity =>
        {
            entity.HasKey(e => e.ServiceCallLogId).HasName("PK_SERVICECALLLOG");

            entity.ToTable("ServiceCallLog");

            entity.HasIndex(e => e.IncidentServiceCallId, "ServiceCallIDINX");

            entity.Property(e => e.ServiceCallLogId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ServiceCallLogID");
            entity.Property(e => e.ActionDateTime).HasColumnType("datetime");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CadeventUnitActionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CADEventUnitActionID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentServiceCallId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentServiceCallID");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.IncidentServiceCall).WithMany(p => p.ServiceCallLogs)
                .HasForeignKey(d => d.IncidentServiceCallId)
                .HasConstraintName("FK_SERVICEC_REFERENCE_SERVICECf");
        });

        modelBuilder.Entity<ServiceCallQuestionAnswer>(entity =>
        {
            entity.HasKey(e => e.ServiceCallQuestionAnswerId).HasName("PK_SERVICECALLQUESTIONANSWER");

            entity.ToTable("ServiceCallQuestionAnswer");

            entity.HasIndex(e => e.ServiceCallPersonId, "IX_ServiceCallQuestionAnswer_ServiceCallPersonID");

            entity.Property(e => e.ServiceCallQuestionAnswerId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ServiceCallQuestionAnswerID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Cadqaid).HasColumnName("CADQAID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.ServiceCallPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ServiceCallPersonID");

            entity.HasOne(d => d.ServiceCallPerson).WithMany(p => p.ServiceCallQuestionAnswers)
                .HasForeignKey(d => d.ServiceCallPersonId)
                .HasConstraintName("FK_SERVICEC_REFERENCE_NONVERIF");
        });

        modelBuilder.Entity<ShiftLogView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ShiftLogView");

            entity.Property(e => e.Aa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AA");
            entity.Property(e => e.Bb)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BB");
            entity.Property(e => e.Cc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CC");
            entity.Property(e => e.Dd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DD");
            entity.Property(e => e.Dist).HasMaxLength(50);
            entity.Property(e => e.Ee)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EE");
            entity.Property(e => e.Expr1)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Ff)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FF");
            entity.Property(e => e.Gg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GG");
            entity.Property(e => e.Hh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("HH");
            entity.Property(e => e.Hh1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("HH1");
            entity.Property(e => e.Landmark).HasMaxLength(300);
            entity.Property(e => e.Street).HasMaxLength(300);
            entity.Property(e => e.Time)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SummonsInfraction>(entity =>
        {
            entity.HasKey(e => e.SummonsInfractionId).HasName("PK_SUMMONSINFRACTION");

            entity.ToTable("SummonsInfraction");

            entity.HasIndex(e => e.TrafficStopId, "IX_SummonsInfraction_TrafficStopID");

            entity.HasIndex(e => e.IncidentPersonInvolvementId, "SummonsInfraction_IncidentPersonInvolvementID_S");

            entity.Property(e => e.SummonsInfractionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SummonsInfractionID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ArrestDate).HasColumnType("datetime");
            entity.Property(e => e.BondAmount).HasColumnType("money");
            entity.Property(e => e.CdAdditionalPdandCaseNumbers)
                .HasMaxLength(100)
                .HasColumnName("cdAdditionalPDandCaseNumbers");
            entity.Property(e => e.CdAdditionalTicketNumbers)
                .HasMaxLength(50)
                .HasColumnName("cdAdditionalTicketNumbers");
            entity.Property(e => e.CdAppealDecidedDate)
                .HasColumnType("date")
                .HasColumnName("cdAppealDecidedDate");
            entity.Property(e => e.CdAppealFiledDate)
                .HasColumnType("date")
                .HasColumnName("cdAppealFiledDate");
            entity.Property(e => e.CdBondForfeitureAmount)
                .HasColumnType("money")
                .HasColumnName("cdBondForfeitureAmount");
            entity.Property(e => e.CdCibindicator)
                .HasMaxLength(10)
                .HasColumnName("cdCIBIndicator");
            entity.Property(e => e.CdCostAmount)
                .HasColumnType("money")
                .HasColumnName("cdCostAmount");
            entity.Property(e => e.CdCostIndicator).HasColumnName("cdCostIndicator");
            entity.Property(e => e.CdCsindicator)
                .HasMaxLength(10)
                .HasColumnName("cdCSIndicator");
            entity.Property(e => e.CdDispositionDate)
                .HasColumnType("date")
                .HasColumnName("cdDispositionDate");
            entity.Property(e => e.CdDispositionMessage)
                .HasMaxLength(30)
                .HasColumnName("cdDispositionMessage");
            entity.Property(e => e.CdDocketNumber)
                .HasMaxLength(20)
                .HasColumnName("cdDocketNumber");
            entity.Property(e => e.CdErasureDate)
                .HasColumnType("date")
                .HasColumnName("cdErasureDate");
            entity.Property(e => e.CdRearrestIndicator)
                .HasMaxLength(10)
                .HasColumnName("cdRearrestIndicator");
            entity.Property(e => e.CdRevisedIndicator)
                .HasMaxLength(10)
                .HasColumnName("cdRevisedIndicator");
            entity.Property(e => e.CdYoswitch)
                .HasMaxLength(10)
                .HasColumnName("cdYOSwitch");
            entity.Property(e => e.CourtDate).HasColumnType("date");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.SummonsNumber).HasMaxLength(50);
            entity.Property(e => e.TrafficStopId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.BondTypeNavigation).WithMany(p => p.SummonsInfractionBondTypeNavigations)
                .HasForeignKey(d => d.BondType)
                .HasConstraintName("FK_SUMMONSI_REFERENCE_REFINCID2");

            entity.HasOne(d => d.CdCostIndicatorNavigation).WithMany(p => p.SummonsInfractionCdCostIndicatorNavigations)
                .HasForeignKey(d => d.CdCostIndicator)
                .HasConstraintName("FK_SUMMONSI_REFERENCE_REFINCID");

            entity.HasOne(d => d.CourtCodeNavigation).WithMany(p => p.SummonsInfractionCourtCodeNavigations)
                .HasForeignKey(d => d.CourtCode)
                .HasConstraintName("FK__SummonsIn__Court__18AC8967");

            entity.HasOne(d => d.IncidentPersonInvolvement).WithMany(p => p.SummonsInfractions)
                .HasForeignKey(d => d.IncidentPersonInvolvementId)
                .HasConstraintName("FK_SUMMONSI_REFERENCE_INCIDENT");

            entity.HasOne(d => d.TrafficStop).WithMany(p => p.SummonsInfractions)
                .HasForeignKey(d => d.TrafficStopId)
                .HasConstraintName("FK_SummonsInfraction_TrafficStop");
        });

        modelBuilder.Entity<SysAgency>(entity =>
        {
            entity.HasKey(e => e.AgencyId).HasName("PK_SYSAGENCY");

            entity.ToTable("SysAgency");

            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
        });

        modelBuilder.Entity<SysApplicationRelation>(entity =>
        {
            entity.HasKey(e => e.MstrapplicationRelationId).HasName("PK_SYSAPPLICATIONRELATION");

            entity.ToTable("SysApplicationRelation", tb =>
                {
                    tb.HasTrigger("TRG_InsertSysApplicationRelationHierarchy");
                    tb.HasTrigger("TRG_UpdateSysApplicationRelationHierarchy");
                });

            entity.HasIndex(e => new { e.CreatedFromApplication, e.GeneratedToApplication }, "INX_ApplicationType");

            entity.HasIndex(e => new { e.CreatedFromApplication, e.CreatedFromApplicationPkid }, "SysApplicationRelation_CreatedFromApplication_CreatedFromApplicationPKID_BB");

            entity.HasIndex(e => new { e.GeneratedToApplication, e.GeneratedToApplicationPkid }, "SysApplicationRelation_GeneratedToApplication_GeneratedToApplicationPKID_BB");

            entity.HasIndex(e => new { e.CreatedFromApplication, e.GeneratedToApplication, e.GeneratedToApplicationPkid }, "[SysApplicationRelation_CreatedFromApp_GeneratedApp_GeneratedAppPKID");

            entity.Property(e => e.MstrapplicationRelationId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRApplicationRelationID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedFromApplicationPkid)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CreatedFromApplicationPKID");
            entity.Property(e => e.CreatedFromInvolvementPkid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CreatedFromInvolvementPKID");
            entity.Property(e => e.CreatedFromInvolvementTable).HasMaxLength(300);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GeneratedToApplicationPkid)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("GeneratedToApplicationPKID");
            entity.Property(e => e.GeneratedToInvolvementPkid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("GeneratedToInvolvementPKID");
            entity.Property(e => e.GeneratedToInvolvementTable).HasMaxLength(300);
            entity.Property(e => e.RelationType).HasMaxLength(100);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.CreatedFromApplicationNavigation).WithMany(p => p.SysApplicationRelationCreatedFromApplicationNavigations)
                .HasForeignKey(d => d.CreatedFromApplication)
                .HasConstraintName("FK_SYSAPPLI_REFERENCE_SYSRMSAP3");

            entity.HasOne(d => d.GeneratedToApplicationNavigation).WithMany(p => p.SysApplicationRelationGeneratedToApplicationNavigations)
                .HasForeignKey(d => d.GeneratedToApplication)
                .HasConstraintName("FK_SYSAPPLI_REFERENCE_SYSRMSAP4");
        });

        modelBuilder.Entity<SysApplicationRelationHierarchy>(entity =>
        {
            entity.ToTable("SysApplicationRelationHierarchy");

            entity.HasIndex(e => new { e.GeneratedToApplicationType, e.GeneratedToApplicationId }, "IX_SysApplicationRelationHierarchy_GeneratedToApplicationType_GeneratedToApplicationId");

            entity.HasIndex(e => new { e.ParentApplicationType, e.ParentApplicationId }, "IX_SysApplicationRelationHierarchy_ParentAppType_ParentAppId");

            entity.HasIndex(e => e.SysApplicationRelationId, "IX_SysApplicationRelationHierarchy_SysApplicationRelationId");

            entity.Property(e => e.SysApplicationRelationHierarchyId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedFromApplicationId).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GeneratedToApplicationId).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ParentApplicationId).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SysApplicationRelationId).HasColumnType("numeric(18, 0)");

            entity.HasOne(d => d.SysApplicationRelation).WithMany(p => p.SysApplicationRelationHierarchies)
                .HasForeignKey(d => d.SysApplicationRelationId)
                .HasConstraintName("FK_SysApplicationRelationHierarchy_SysApplicationRelation1");
        });

        modelBuilder.Entity<SysApplicationStatus>(entity =>
        {
            entity.HasKey(e => e.SysApplicationStatusId).HasName("PK_SYSAPPLICATIONSTATUS");

            entity.ToTable("SysApplicationStatus");

            entity.Property(e => e.SysApplicationStatusId)
                .ValueGeneratedNever()
                .HasColumnName("SysApplicationStatusID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Category).HasMaxLength(100);
            entity.Property(e => e.Color).HasMaxLength(100);
            entity.Property(e => e.DataValue).HasMaxLength(30);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NotificationXml)
                .HasColumnType("xml")
                .HasColumnName("NotificationXML");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.SubCategory).HasMaxLength(100);
            entity.Property(e => e.SysrmsapplicationTypeId).HasColumnName("SYSRMSApplicationTypeID");

            entity.HasOne(d => d.Department).WithMany(p => p.SysApplicationStatuses)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_SYSAPPLI_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.SysrmsapplicationType).WithMany(p => p.SysApplicationStatuses)
                .HasForeignKey(d => d.SysrmsapplicationTypeId)
                .HasConstraintName("FK_SYSAPPLI_REFERENCE_SYSRMSAP2");
        });

        modelBuilder.Entity<SysDataValidationControlConfiguration>(entity =>
        {
            entity.ToTable("SysDataValidationControlConfiguration");

            entity.HasIndex(e => e.RequestedApplication, "IX_SysDataValidationControlConfiguration_RequestedApplication");

            entity.HasIndex(e => e.SysDataValidationRuleId, "IX_SysDataValidationControlConfiguration_SysDataValidationRuleID");

            entity.Property(e => e.SysDataValidationControlConfigurationId).HasColumnName("SysDataValidationControlConfigurationID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ChildControlId)
                .HasMaxLength(200)
                .HasColumnName("ChildControlID");
            entity.Property(e => e.ControlType).HasMaxLength(100);
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.ErrorCode).HasMaxLength(100);
            entity.Property(e => e.ParentControlId)
                .HasMaxLength(200)
                .HasColumnName("ParentControlID");
            entity.Property(e => e.SubChildControlId)
                .HasMaxLength(200)
                .HasColumnName("SubChildControlID");
            entity.Property(e => e.SysDataValidationRuleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SysDataValidationRuleID");

            entity.HasOne(d => d.RequestedApplicationNavigation).WithMany(p => p.SysDataValidationControlConfigurations)
                .HasForeignKey(d => d.RequestedApplication)
                .HasConstraintName("FK_SysDataValidationControlConfiguration_SYSRMSApplicationType");

            entity.HasOne(d => d.SysDataValidationRule).WithMany(p => p.SysDataValidationControlConfigurations)
                .HasForeignKey(d => d.SysDataValidationRuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SysDataValidationControlConfiguration_SysDataValidationRules");
        });

        modelBuilder.Entity<SysDataValidationRule>(entity =>
        {
            entity.HasKey(e => e.SysDataValidationRuleId).HasName("PK_SYSDATAVALIDATIONRULES");

            entity.HasIndex(e => e.RequestedApplication, "IX_SysDataValidationRules_RequestedApplication");

            entity.Property(e => e.SysDataValidationRuleId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SysDataValidationRuleID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.CtdotruleId)
                .HasMaxLength(50)
                .HasColumnName("CTDOTRuleID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DisplaySeq).HasColumnName("DisplaySEQ");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ErrorCode).HasMaxLength(100);
            entity.Property(e => e.ErrorGrouping).HasMaxLength(100);
            entity.Property(e => e.ErrorType).HasMaxLength(100);
            entity.Property(e => e.UidisplayString).HasColumnName("UIDisplayString");

            entity.HasOne(d => d.RequestedApplicationNavigation).WithMany(p => p.SysDataValidationRules)
                .HasForeignKey(d => d.RequestedApplication)
                .HasConstraintName("FK_SYSDATAV_REFERENCE_SYSRMSAP");
        });

        modelBuilder.Entity<SysImage>(entity =>
        {
            entity.HasKey(e => e.SysImageId).HasName("PK_SYSIMAGES");

            entity.Property(e => e.SysImageId).HasColumnName("SysImageID");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.ImageData).HasColumnType("image");
            entity.Property(e => e.ImageType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Agency).WithMany(p => p.SysImages)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_SYSIMAGE_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.Department).WithMany(p => p.SysImages)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_SYSIMAGE_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<SysNotificationAction>(entity =>
        {
            entity.HasKey(e => e.SysNotificationActionId).HasName("PK_SYSNOTIFICATIONACTION");

            entity.ToTable("SysNotificationAction");

            entity.Property(e => e.SysNotificationActionId).HasColumnName("SysNotificationActionID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DepartmentOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentOrgID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NotificationMethodId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NotificationMethodID");
            entity.Property(e => e.SecurityRoleId).HasColumnName("SecurityRoleID");
            entity.Property(e => e.SysNotificationPlanId).HasColumnName("SysNotificationPlanID");

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.SysNotificationActions)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_DEPARTME4");

            entity.HasOne(d => d.Department).WithMany(p => p.SysNotificationActions)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_DEPARTME5");

            entity.HasOne(d => d.DepartmentOrg).WithMany(p => p.SysNotificationActions)
                .HasForeignKey(d => d.DepartmentOrgId)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_DEPARTME3");

            entity.HasOne(d => d.NotificationMethod).WithMany(p => p.SysNotificationActions)
                .HasForeignKey(d => d.NotificationMethodId)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_NOTIFICA");

            entity.HasOne(d => d.SecurityRole).WithMany(p => p.SysNotificationActions)
                .HasForeignKey(d => d.SecurityRoleId)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_SECURITY");

            entity.HasOne(d => d.SysNotificationPlan).WithMany(p => p.SysNotificationActions)
                .HasForeignKey(d => d.SysNotificationPlanId)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_SYSNOTIF");
        });

        modelBuilder.Entity<SysNotificationCondition>(entity =>
        {
            entity.HasKey(e => e.SysNotificationConditionsId).HasName("PK_SYSNOTIFICATIONCONDITIONS");

            entity.HasIndex(e => e.LocationId, "IX_SysNotificationConditions_LocationID");

            entity.HasIndex(e => e.Moid, "IX_SysNotificationConditions_MOID");

            entity.HasIndex(e => e.Mpid, "IX_SysNotificationConditions_MPID");

            entity.HasIndex(e => e.Mppid, "IX_SysNotificationConditions_MPPID");

            entity.HasIndex(e => e.Mvid, "IX_SysNotificationConditions_MVID");

            entity.HasIndex(e => e.ReportStatusId, "IX_SysNotificationConditions_ReportStatusID");

            entity.HasIndex(e => e.SysrmsapplicationTypeId, "IX_SysNotificationConditions_SYSRMSApplicationTypeID");

            entity.HasIndex(e => e.SysNotificationPlanId, "IX_SysNotificationConditions_SysNotificationPlanID");

            entity.HasIndex(e => e.SysNotificationTemplateId, "IX_SysNotificationConditions_SysNotificationTemplateID");

            entity.HasIndex(e => e.UcrcodeId, "IX_SysNotificationConditions_UCRCodeID");

            entity.Property(e => e.SysNotificationConditionsId).HasColumnName("SysNotificationConditionsID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationStatusId).HasColumnName("ApplicationStatusID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InvestigativeStatusId).HasColumnName("InvestigativeStatusID");
            entity.Property(e => e.InvolvementCode).HasMaxLength(100);
            entity.Property(e => e.InvolvementRefCodeId).HasColumnName("InvolvementRefCodeID");
            entity.Property(e => e.InvolvementRefCodeTable).HasMaxLength(100);
            entity.Property(e => e.LocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LocationID");
            entity.Property(e => e.Moid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MOID");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.Mppid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPPID");
            entity.Property(e => e.Mvid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MVID");
            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
            entity.Property(e => e.SysNotificationPlanId).HasColumnName("SysNotificationPlanID");
            entity.Property(e => e.SysNotificationTemplateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SysNotificationTemplateID");
            entity.Property(e => e.SysrmsapplicationTypeId).HasColumnName("SYSRMSApplicationTypeID");
            entity.Property(e => e.UcrcodeId).HasColumnName("UCRCodeID");

            entity.HasOne(d => d.ApplicationStatus).WithMany(p => p.SysNotificationConditionApplicationStatuses)
                .HasForeignKey(d => d.ApplicationStatusId)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_SYSAPPLI2");

            entity.HasOne(d => d.Department).WithMany(p => p.SysNotificationConditions)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.InvestigativeStatus).WithMany(p => p.SysNotificationConditionInvestigativeStatuses)
                .HasForeignKey(d => d.InvestigativeStatusId)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_SYSAPPLI");

            entity.HasOne(d => d.Location).WithMany(p => p.SysNotificationConditions)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_MSTRLOCA");

            entity.HasOne(d => d.Mo).WithMany(p => p.SysNotificationConditions)
                .HasForeignKey(d => d.Moid)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_MSTRORGA");

            entity.HasOne(d => d.Mp).WithMany(p => p.SysNotificationConditions)
                .HasForeignKey(d => d.Mpid)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_MSTRPERS");

            entity.HasOne(d => d.Mpp).WithMany(p => p.SysNotificationConditions)
                .HasForeignKey(d => d.Mppid)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_MSTRPROP");

            entity.HasOne(d => d.Mv).WithMany(p => p.SysNotificationConditions)
                .HasForeignKey(d => d.Mvid)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_MSTRVEHI");

            entity.HasOne(d => d.ReportStatus).WithMany(p => p.SysNotificationConditionReportStatuses)
                .HasForeignKey(d => d.ReportStatusId)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_SYSAPPLI3");

            entity.HasOne(d => d.SysNotificationPlan).WithMany(p => p.SysNotificationConditions)
                .HasForeignKey(d => d.SysNotificationPlanId)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_SYSNOTIF3");

            entity.HasOne(d => d.SysNotificationTemplate).WithMany(p => p.SysNotificationConditions)
                .HasForeignKey(d => d.SysNotificationTemplateId)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_SYSNOTIF2");

            entity.HasOne(d => d.SysrmsapplicationType).WithMany(p => p.SysNotificationConditions)
                .HasForeignKey(d => d.SysrmsapplicationTypeId)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_SYSRMSAP");

            entity.HasOne(d => d.Ucrcode).WithMany(p => p.SysNotificationConditions)
                .HasForeignKey(d => d.UcrcodeId)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_REFUCRCO");
        });

        modelBuilder.Entity<SysNotificationPlan>(entity =>
        {
            entity.HasKey(e => e.SysNotificationPlanId).HasName("PK_SYSNOTIFICATIONPLAN");

            entity.ToTable("SysNotificationPlan");

            entity.Property(e => e.SysNotificationPlanId)
                .ValueGeneratedNever()
                .HasColumnName("SysNotificationPlanID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.PlanName).HasMaxLength(100);

            entity.HasOne(d => d.Department).WithMany(p => p.SysNotificationPlans)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_SYSNOTIF_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<SysNotificationTemplate>(entity =>
        {
            entity.HasKey(e => e.SysNotificationTemplateId).HasName("PK_SYSNOTIFICATIONTEMPLATES");

            entity.Property(e => e.SysNotificationTemplateId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SysNotificationTemplateID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(300);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NotificationCategory).HasMaxLength(250);
        });

        modelBuilder.Entity<SysNumberAssignment>(entity =>
        {
            entity.HasKey(e => e.NumberAssignmentId).HasName("PK_SYSNUMBERASSIGNMENTS");

            entity.HasIndex(e => new { e.RequestedAppllication, e.RequestedApplicaionPkid }, "IX_SysNumberAssignments_RequestedAppllication_RequestedApplicaionPKID");

            entity.Property(e => e.NumberAssignmentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NumberAssignmentID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FullNumber).HasMaxLength(200);
            entity.Property(e => e.NumberAssignedDate).HasColumnType("datetime");
            entity.Property(e => e.NumberControllerId).HasColumnName("NumberControllerID");
            entity.Property(e => e.NumberPrefix).HasMaxLength(20);
            entity.Property(e => e.RequestedApplicaionPkid)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("RequestedApplicaionPKID");
            entity.Property(e => e.RequestedEmployeeId).HasColumnName("RequestedEmployeeID");

            entity.HasOne(d => d.Department).WithMany(p => p.SysNumberAssignments)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_SYSNUMBE_REFERENCE_DEPARTME3");

            entity.HasOne(d => d.NumberController).WithMany(p => p.SysNumberAssignments)
                .HasForeignKey(d => d.NumberControllerId)
                .HasConstraintName("FK_SYSNUMBE_REFERENCE_SYSNUMBE2");

            entity.HasOne(d => d.RequestedAppllicationNavigation).WithMany(p => p.SysNumberAssignments)
                .HasForeignKey(d => d.RequestedAppllication)
                .HasConstraintName("FK_SYSNUMBE_REFERENCE_SYSRMSAP2");

            entity.HasOne(d => d.RequestedEmployee).WithMany(p => p.SysNumberAssignments)
                .HasForeignKey(d => d.RequestedEmployeeId)
                .HasConstraintName("FK_SYSNUMBE_REFERENCE_DEPARTME2");
        });

        modelBuilder.Entity<SysNumberController>(entity =>
        {
            entity.HasKey(e => e.NumberControllerId).HasName("PK_SYSNUMBERCONTROLLER");

            entity.ToTable("SysNumberController");

            entity.Property(e => e.NumberControllerId).HasColumnName("NumberControllerID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CopyNumber).HasDefaultValueSql("((0))");
            entity.Property(e => e.CurrentProcessDt)
                .HasColumnType("datetime")
                .HasColumnName("CurrentProcessDT");
            entity.Property(e => e.CurrentProcessSeq).HasColumnName("CurrentProcessSEQ");
            entity.Property(e => e.DateTimeFormat).HasMaxLength(20);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MultiCopyAllowed).HasDefaultValueSql("((0))");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.NumberPreFix).HasMaxLength(20);
            entity.Property(e => e.ReferenceToNumberControllerId).HasColumnName("ReferenceToNumberControllerID");
            entity.Property(e => e.ResetPeriod).HasMaxLength(10);
            entity.Property(e => e.Seqdigits).HasColumnName("SEQDigits");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.SysNumberControllers)
                .HasForeignKey(d => d.ApplicationType)
                .HasConstraintName("FK_SYSNUMBE_REFERENCE_SYSRMSAP");

            entity.HasOne(d => d.Department).WithMany(p => p.SysNumberControllers)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_SYSNUMBE_REFERENCE_DEPARTME");

            entity.HasOne(d => d.ReferenceToNumberController).WithMany(p => p.InverseReferenceToNumberController)
                .HasForeignKey(d => d.ReferenceToNumberControllerId)
                .HasConstraintName("FK_SYSNUMBE_REFERENCE_SYSNUMBE");
        });

        modelBuilder.Entity<SysapplicationActionTraceTemplate>(entity =>
        {
            entity.HasKey(e => e.SysapplicationActionTraceTemplateId).HasName("PK_SYSAPPLICATIONACTIONTRACETE");

            entity.ToTable("SYSApplicationActionTraceTemplate");

            entity.Property(e => e.SysapplicationActionTraceTemplateId).HasColumnName("SYSApplicationActionTraceTemplateID");
            entity.Property(e => e.ActionTemplate).HasMaxLength(500);
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Category).HasMaxLength(250);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<SysapplicationStatusAllowedUi>(entity =>
        {
            entity.HasKey(e => e.SysapplicationStatusAllowedUiid).HasName("PK_SYSAPPLICATIONSTATUSALLOWED");

            entity.ToTable("SYSApplicationStatusAllowedUI");

            entity.Property(e => e.SysapplicationStatusAllowedUiid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SYSApplicationStatusAllowedUIID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationStatusId).HasColumnName("ApplicationStatusID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DepartmentOrgId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DepartmentOrgID");
            entity.Property(e => e.DisplaySeq).HasColumnName("DisplaySEQ");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InvestgativeStatusId).HasColumnName("InvestgativeStatusID");
            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
            entity.Property(e => e.SysrmsapplicationTypeId).HasColumnName("SYSRMSApplicationTypeID");
            entity.Property(e => e.SysrmsuserInterfaceDefinitionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SYSRMSUserInterfaceDefinitionID");
            entity.Property(e => e.UserSecurityRoleId).HasColumnName("UserSecurityRoleID");

            entity.HasOne(d => d.ApplicationStatus).WithMany(p => p.SysapplicationStatusAllowedUiApplicationStatuses)
                .HasForeignKey(d => d.ApplicationStatusId)
                .HasConstraintName("FK_SYSAPPLI_REFERENCE_SYSAPPLI2");

            entity.HasOne(d => d.Department).WithMany(p => p.SysapplicationStatusAllowedUis)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_SYSAPPLI_REFERENCE_DEPARTME12");

            entity.HasOne(d => d.DepartmentOrg).WithMany(p => p.SysapplicationStatusAllowedUis)
                .HasForeignKey(d => d.DepartmentOrgId)
                .HasConstraintName("FK_SYSAPPLI_REFERENCE_DEPARTME");

            entity.HasOne(d => d.InvestgativeStatus).WithMany(p => p.SysapplicationStatusAllowedUiInvestgativeStatuses)
                .HasForeignKey(d => d.InvestgativeStatusId)
                .HasConstraintName("FK_SYSAPPLI_REFERENCE_SYSAPPLI");

            entity.HasOne(d => d.ReportStatus).WithMany(p => p.SysapplicationStatusAllowedUiReportStatuses)
                .HasForeignKey(d => d.ReportStatusId)
                .HasConstraintName("FK_SYSAPPLI_REFERENCE_SYSAPPLI3");

            entity.HasOne(d => d.SysrmsapplicationType).WithMany(p => p.SysapplicationStatusAllowedUis)
                .HasForeignKey(d => d.SysrmsapplicationTypeId)
                .HasConstraintName("FK_SYSAPPLI_REFERENCE_SYSRMSAP");

            entity.HasOne(d => d.SysrmsuserInterfaceDefinition).WithMany(p => p.SysapplicationStatusAllowedUis)
                .HasForeignKey(d => d.SysrmsuserInterfaceDefinitionId)
                .HasConstraintName("FK_SYSAPPLI_REFERENCE_SYSRMSUS");

            entity.HasOne(d => d.UserSecurityRole).WithMany(p => p.SysapplicationStatusAllowedUis)
                .HasForeignKey(d => d.UserSecurityRoleId)
                .HasConstraintName("FK_SYSAPPLI_REFERENCE_SECURITY");
        });

        modelBuilder.Entity<SysapplicationValidation>(entity =>
        {
            entity.ToTable("SYSApplicationValidation");

            entity.HasIndex(e => e.ApplicationType, "IX_SYSApplicationValidation_ApplicationType");

            entity.HasIndex(e => e.EmployeeId, "IX_SYSApplicationValidation_EmployeeID");

            entity.Property(e => e.SysapplicationValidationId)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("SYSApplicationValidationID");
            entity.Property(e => e.AddedById).HasColumnName("AddedByID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ApplicationPkid)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ApplicationPKID");
            entity.Property(e => e.EditedById).HasColumnName("EditedByID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.OpenedDate).HasColumnType("datetime");

            entity.HasOne(d => d.AddedBy).WithMany(p => p.SysapplicationValidationAddedBies)
                .HasForeignKey(d => d.AddedById)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSApplicationValidation_DepartmentEmployees1");

            entity.HasOne(d => d.ApplicationTypeNavigation).WithMany(p => p.SysapplicationValidations)
                .HasForeignKey(d => d.ApplicationType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSApplicationValidation_SYSRMSApplicationType");

            entity.HasOne(d => d.EditedBy).WithMany(p => p.SysapplicationValidationEditedBies)
                .HasForeignKey(d => d.EditedById)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSApplicationValidation_DepartmentEmployees2");

            entity.HasOne(d => d.Employee).WithMany(p => p.SysapplicationValidationEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSApplicationValidation_DepartmentEmployees");
        });

        modelBuilder.Entity<SysreleaseHistory>(entity =>
        {
            entity.HasKey(e => e.ReleaseId);

            entity.ToTable("SYSReleaseHistory");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ReleaseVersion).HasMaxLength(50);
        });

        modelBuilder.Entity<SysrmsapplicationType>(entity =>
        {
            entity.HasKey(e => e.SysrmsapplicationTypeId).HasName("PK_SYSRMSAPPLICATIONTYPE");

            entity.ToTable("SYSRMSApplicationType");

            entity.Property(e => e.SysrmsapplicationTypeId)
                .ValueGeneratedNever()
                .HasColumnName("SYSRMSApplicationTypeID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationType).HasMaxLength(50);
            entity.Property(e => e.DisplayName).HasMaxLength(50);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<SysrmsuserInterfaceDefinition>(entity =>
        {
            entity.HasKey(e => e.SysrmsuserInterfaceDefinitionId).HasName("PK_SYSRMSUSERINTERFACEDEFINITI");

            entity.ToTable("SYSRMSUserInterfaceDefinition");

            entity.Property(e => e.SysrmsuserInterfaceDefinitionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SYSRMSUserInterfaceDefinitionID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CodeId)
                .HasMaxLength(200)
                .HasColumnName("CodeID");
            entity.Property(e => e.ControlType).HasMaxLength(200);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DisplayName).HasMaxLength(200);
            entity.Property(e => e.DisplaySeq).HasColumnName("DisplaySEQ");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsNeedtoCheckatRuntimeforContextMenu).HasDefaultValueSql("((0))");
            entity.Property(e => e.MappingUi)
                .HasMaxLength(200)
                .HasColumnName("MappingUI");
            entity.Property(e => e.MappingUicontrolName)
                .HasMaxLength(200)
                .HasColumnName("MappingUIControlName");
            entity.Property(e => e.SysrmsapplicationTypeId).HasColumnName("SYSRMSApplicationTypeID");
            entity.Property(e => e.Uicategory)
                .HasMaxLength(200)
                .HasColumnName("UICategory");

            entity.HasOne(d => d.Department).WithMany(p => p.SysrmsuserInterfaceDefinitions)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_SYSRMSUS_REFERENCE_DEPARTME");

            entity.HasOne(d => d.SysrmsapplicationType).WithMany(p => p.SysrmsuserInterfaceDefinitions)
                .HasForeignKey(d => d.SysrmsapplicationTypeId)
                .HasConstraintName("FK_SYSRMSUS_REFERENCE_SYSRMSAP");
        });

        modelBuilder.Entity<SystemConfiguration>(entity =>
        {
            entity.HasKey(e => e.SystemConfigurationId).HasName("PK_SYSTEMCONFIGURATION");

            entity.ToTable("SystemConfiguration");

            entity.Property(e => e.SystemConfigurationId).HasColumnName("SystemConfigurationID");
            entity.Property(e => e.Category).HasMaxLength(200);
            entity.Property(e => e.ConfigurationName).HasMaxLength(200);
            entity.Property(e => e.Description).HasMaxLength(200);
        });

        modelBuilder.Entity<TestRmsapplicationDataExportLog>(entity =>
        {
            entity.HasKey(e => e.TestRmsapplicationDataExportLogId).HasName("PK_TESTRMSAPPLICATIONDATAEXPORTLOG");

            entity.ToTable("TestRMSApplicationDataExportLog");

            entity.HasIndex(e => e.RmsapplicationDataExportLogId, "INX_TestRMSApplicationDataExportLog_RMSApplicationDataExportLogID");

            entity.Property(e => e.TestRmsapplicationDataExportLogId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TestRMSApplicationDataExportLogID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(100);
            entity.Property(e => e.Environment).HasMaxLength(150);
            entity.Property(e => e.ErrorCode).HasMaxLength(50);
            entity.Property(e => e.ExportStatus).HasMaxLength(100);
            entity.Property(e => e.ExportTrace).IsUnicode(false);
            entity.Property(e => e.IsSentToCiss).HasColumnName("IsSentToCISS");
            entity.Property(e => e.RequestId)
                .HasMaxLength(50)
                .HasColumnName("RequestID");
            entity.Property(e => e.RmsapplicationDataExportLogId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSApplicationDataExportLogID");
            entity.Property(e => e.SentToCissreason).HasColumnName("SentToCISSReason");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK_TICKET");

            entity.ToTable("Ticket");

            entity.HasIndex(e => e.RelatedVehicleId, "IX_Ticket_RelatedVehicleID");

            entity.HasIndex(e => e.ReportedEmployeeId, "IX_Ticket_ReportedEmployeeID");

            entity.HasIndex(e => e.ViolationLocationId, "IX_Ticket_ViolationLocationID");

            entity.HasIndex(e => e.ViolatorId, "IX_Ticket_ViolatorID");

            entity.Property(e => e.TicketId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TicketID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApprovedDateTime).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastReviewDateTime).HasColumnType("datetime");
            entity.Property(e => e.MstrnarrativeTemplateId).HasColumnName("MSTRNarrativeTemplateID");
            entity.Property(e => e.NarrativeEditedOn).HasColumnType("datetime");
            entity.Property(e => e.RelatedVehicleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RelatedVehicleID");
            entity.Property(e => e.ReportedEmployeeId).HasColumnName("ReportedEmployeeID");
            entity.Property(e => e.TicketCreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.TicketNumber).HasMaxLength(100);
            entity.Property(e => e.TicketStatus).HasMaxLength(50);
            entity.Property(e => e.TicketType).HasMaxLength(100);
            entity.Property(e => e.TotallAmountDue).HasColumnType("money");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.ViolationDateTime).HasColumnType("datetime");
            entity.Property(e => e.ViolationLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ViolationLocationID");
            entity.Property(e => e.ViolatorId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ViolatorID");

            entity.HasOne(d => d.Department).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_TICKET_REFERENCE_DEPARTME");

            entity.HasOne(d => d.MstrnarrativeTemplate).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.MstrnarrativeTemplateId)
                .HasConstraintName("FK_TICKET_REFERENCE_REFNARRA");

            entity.HasOne(d => d.RelatedVehicle).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.RelatedVehicleId)
                .HasConstraintName("FK_TICKET_REFERENCE_MSTRVEHI");

            entity.HasOne(d => d.ReportedEmployee).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.ReportedEmployeeId)
                .HasConstraintName("FK_TICKET_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.ViolationLocation).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.ViolationLocationId)
                .HasConstraintName("FK_TICKET_REFERENCE_MSTRLOCA");

            entity.HasOne(d => d.Violator).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.ViolatorId)
                .HasConstraintName("FK_TICKET_REFERENCE_MSTRPERS");
        });

        modelBuilder.Entity<TicketViolation>(entity =>
        {
            entity.HasKey(e => e.TicketViolationId).HasName("PK_TICKETVIOLATIONS");

            entity.HasIndex(e => e.TicketId, "IX_TicketViolations_TicketID");

            entity.HasIndex(e => e.ViolationId, "IX_TicketViolations_ViolationID");

            entity.Property(e => e.TicketViolationId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TicketViolationID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RefstatuteDefinition).HasColumnName("REFStatuteDefinition");
            entity.Property(e => e.TicketId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TicketID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.ViolationId).HasColumnName("ViolationID");

            entity.HasOne(d => d.RefstatuteDefinitionNavigation).WithMany(p => p.TicketViolations)
                .HasForeignKey(d => d.RefstatuteDefinition)
                .HasConstraintName("FK_TICKETVI_REFERENCE_REFSTATU");

            entity.HasOne(d => d.Ticket).WithMany(p => p.TicketViolations)
                .HasForeignKey(d => d.TicketId)
                .HasConstraintName("FK_TICKETVI_REFERENCE_TICKET");

            entity.HasOne(d => d.Violation).WithMany(p => p.TicketViolations)
                .HasForeignKey(d => d.ViolationId)
                .HasConstraintName("FK_TICKETVI_REFERENCE_REFVIOLA");
        });

        modelBuilder.Entity<TowRequest>(entity =>
        {
            entity.HasKey(e => e.TowRequestId).HasName("PK_TOWREQUESTS");

            entity.HasIndex(e => e.NonVerifiedCallVehicleId, "IX_TowRequests_NonVerifiedCallVehicleID");

            entity.HasIndex(e => e.ReportedEmployeeId, "IX_TowRequests_ReportedEmployeeID");

            entity.HasIndex(e => e.TowFromLocationId, "IX_TowRequests_TowFromLocationID");

            entity.HasIndex(e => e.TowToLocationId, "IX_TowRequests_TowToLocationID");

            entity.Property(e => e.TowRequestId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TowRequestID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateNotified).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HoldAuthorizationBy).HasMaxLength(100);
            entity.Property(e => e.NonVerifiedCallVehicleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NonVerifiedCallVehicleID");
            entity.Property(e => e.ReportedEmployeeId).HasColumnName("ReportedEmployeeID");
            entity.Property(e => e.StatusDateTime).HasColumnType("datetime");
            entity.Property(e => e.TowAuthorizedBy).HasMaxLength(100);
            entity.Property(e => e.TowCompanyAddressDirecctoryId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TowCompanyAddressDirecctoryID");
            entity.Property(e => e.TowFromLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TowFromLocationID");
            entity.Property(e => e.TowNumber).HasMaxLength(50);
            entity.Property(e => e.TowReason).HasMaxLength(100);
            entity.Property(e => e.TowStatus).HasMaxLength(100);
            entity.Property(e => e.TowToLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TowToLocationID");
            entity.Property(e => e.TowTypeCode).HasMaxLength(100);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.NonVerifiedCallVehicle).WithMany(p => p.TowRequests)
                .HasForeignKey(d => d.NonVerifiedCallVehicleId)
                .HasConstraintName("FK_TOWREQUE_REFERENCE_NONVERIF");

            entity.HasOne(d => d.NotifiedByNavigation).WithMany(p => p.TowRequestNotifiedByNavigations)
                .HasForeignKey(d => d.NotifiedBy)
                .HasConstraintName("FK_TOWREQUE_REFERENCE_DEPARTME");

            entity.HasOne(d => d.ReportedEmployee).WithMany(p => p.TowRequestReportedEmployees)
                .HasForeignKey(d => d.ReportedEmployeeId)
                .HasConstraintName("FK_TOWREQUE_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.TowCompanyAddressDirecctory).WithMany(p => p.TowRequests)
                .HasForeignKey(d => d.TowCompanyAddressDirecctoryId)
                .HasConstraintName("FK_TOWREQUE_REFERENCE_ADDRESSD");

            entity.HasOne(d => d.TowFromLocation).WithMany(p => p.TowRequestTowFromLocations)
                .HasForeignKey(d => d.TowFromLocationId)
                .HasConstraintName("FK_TOWREQUE_REFERENCE_MSTRLOCA2");

            entity.HasOne(d => d.TowToLocation).WithMany(p => p.TowRequestTowToLocations)
                .HasForeignKey(d => d.TowToLocationId)
                .HasConstraintName("FK_TOWREQUE_REFERENCE_MSTRLOCA");
        });

        modelBuilder.Entity<TrafficStop>(entity =>
        {
            entity.HasKey(e => e.TrafficStopId).HasName("PK_TRAFFICSTOP");

            entity.ToTable("TrafficStop");

            entity.HasIndex(e => e.DataEntryEmployeeId, "IX_TrafficStop_DataEntryEmployeeID");

            entity.HasIndex(e => e.OffenseLocationId, "IX_TrafficStop_OffenseLocationID");

            entity.HasIndex(e => e.ReportedEmployeeId, "IX_TrafficStop_ReportedEmployeeID");

            entity.HasIndex(e => e.TowRequestId, "IX_TrafficStop_TowRequestID");

            entity.HasIndex(e => e.TrafficStopLocationId, "IX_TrafficStop_TrafficStopLocationID");

            entity.HasIndex(e => e.TrafficStopResultCode, "IX_TrafficStop_TrafficStopResultCode");

            entity.HasIndex(e => e.VehicleId, "IX_TrafficStop_VehicleID");

            entity.HasIndex(e => e.ViolatorId, "IX_TrafficStop_ViolatorID");

            entity.HasIndex(e => e.DepartmentId, "TrafficStop_DepartmentID_TTVTVRTDCTT");

            entity.HasIndex(e => e.TrafficStopStatusCode, "TrafficStop_TrafficStopStatusCode_TTVTVRDCRTT");

            entity.Property(e => e.TrafficStopId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Cadnumber)
                .HasMaxLength(1000)
                .HasColumnName("CADNumber");
            entity.Property(e => e.CdAdditionalPdandCaseNumbers)
                .HasMaxLength(100)
                .HasColumnName("cdAdditionalPDandCaseNumbers");
            entity.Property(e => e.CdAdditionalTicketNumbers)
                .HasMaxLength(50)
                .HasColumnName("cdAdditionalTicketNumbers");
            entity.Property(e => e.CdAppealDecidedDate)
                .HasColumnType("date")
                .HasColumnName("cdAppealDecidedDate");
            entity.Property(e => e.CdAppealFiledDate)
                .HasColumnType("date")
                .HasColumnName("cdAppealFiledDate");
            entity.Property(e => e.CdBondForfeitureAmount)
                .HasColumnType("money")
                .HasColumnName("cdBondForfeitureAmount");
            entity.Property(e => e.CdCibindicator)
                .HasMaxLength(10)
                .HasColumnName("cdCIBIndicator");
            entity.Property(e => e.CdCostAmount)
                .HasColumnType("money")
                .HasColumnName("cdCostAmount");
            entity.Property(e => e.CdCostIndicator).HasColumnName("cdCostIndicator");
            entity.Property(e => e.CdCsindicator)
                .HasMaxLength(10)
                .HasColumnName("cdCSIndicator");
            entity.Property(e => e.CdDispositionDate)
                .HasColumnType("date")
                .HasColumnName("cdDispositionDate");
            entity.Property(e => e.CdDispositionMessage)
                .HasMaxLength(30)
                .HasColumnName("cdDispositionMessage");
            entity.Property(e => e.CdDocketNumber)
                .HasMaxLength(20)
                .HasColumnName("cdDocketNumber");
            entity.Property(e => e.CdErasureDate)
                .HasColumnType("date")
                .HasColumnName("cdErasureDate");
            entity.Property(e => e.CdRearrestIndicator)
                .HasMaxLength(10)
                .HasColumnName("cdRearrestIndicator");
            entity.Property(e => e.CdRevisedIndicator)
                .HasMaxLength(10)
                .HasColumnName("cdRevisedIndicator");
            entity.Property(e => e.CdYoswitch)
                .HasMaxLength(10)
                .HasColumnName("cdYOSwitch");
            entity.Property(e => e.DataEntryEmployeeId).HasColumnName("DataEntryEmployeeID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsPaperTicketUsed).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsTwoSidedPdf).HasColumnName("IsTwoSidedPDF");
            entity.Property(e => e.NarrativeEditedOn).HasColumnType("datetime");
            entity.Property(e => e.OffenseLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OffenseLocationID");
            entity.Property(e => e.ReportedEmployeeId).HasColumnName("ReportedEmployeeID");
            entity.Property(e => e.ReportingUnit).HasMaxLength(50);
            entity.Property(e => e.ReportingUnitArea).HasMaxLength(100);
            entity.Property(e => e.ReportingUnitProvider).HasMaxLength(50);
            entity.Property(e => e.ReportingUnitShift).HasMaxLength(50);
            entity.Property(e => e.TicketPrintOutDt)
                .HasColumnType("datetime")
                .HasColumnName("TicketPrintOutDT");
            entity.Property(e => e.TotallAmountDue).HasColumnType("money");
            entity.Property(e => e.TowRequestId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TowRequestID");
            entity.Property(e => e.TrafficStopDateTime).HasColumnType("datetime");
            entity.Property(e => e.TrafficStopLocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopLocationID");
            entity.Property(e => e.TrafficStopNumber).HasMaxLength(50);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.UsedNarrativeTemplateId).HasColumnName("UsedNarrativeTemplateID");
            entity.Property(e => e.VehicleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("VehicleID");
            entity.Property(e => e.ViolatorId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ViolatorID");

            entity.HasOne(d => d.CdCostIndicatorNavigation).WithMany(p => p.TrafficStops)
                .HasForeignKey(d => d.CdCostIndicator)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_REFINCID9");

            entity.HasOne(d => d.DataEntryEmployee).WithMany(p => p.TrafficStopDataEntryEmployees)
                .HasForeignKey(d => d.DataEntryEmployeeId)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_DEPARTME");

            entity.HasOne(d => d.Department).WithMany(p => p.TrafficStops)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.OffenseLocation).WithMany(p => p.TrafficStopOffenseLocations)
                .HasForeignKey(d => d.OffenseLocationId)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_MSTRLOCA");

            entity.HasOne(d => d.ReportedEmployee).WithMany(p => p.TrafficStopReportedEmployees)
                .HasForeignKey(d => d.ReportedEmployeeId)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_DEPARTME3");

            entity.HasOne(d => d.TowRequest).WithMany(p => p.TrafficStops)
                .HasForeignKey(d => d.TowRequestId)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_TOWREQUE");

            entity.HasOne(d => d.TrafficStopLocation).WithMany(p => p.TrafficStopTrafficStopLocations)
                .HasForeignKey(d => d.TrafficStopLocationId)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_MSTRLOCA2");

            entity.HasOne(d => d.TrafficStopResultCodeNavigation).WithMany(p => p.TrafficStops)
                .HasForeignKey(d => d.TrafficStopResultCode)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_REFTRAFF2");

            entity.HasOne(d => d.TrafficStopStatusCodeNavigation).WithMany(p => p.TrafficStops)
                .HasForeignKey(d => d.TrafficStopStatusCode)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_SYSAPPLI");

            entity.HasOne(d => d.UsedNarrativeTemplate).WithMany(p => p.TrafficStops)
                .HasForeignKey(d => d.UsedNarrativeTemplateId)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_REFNARRA");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.TrafficStops)
                .HasForeignKey(d => d.VehicleId)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_MSTRVEHI");

            entity.HasOne(d => d.Violator).WithMany(p => p.TrafficStops)
                .HasForeignKey(d => d.ViolatorId)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_MSTRPERS");
        });

        modelBuilder.Entity<TrafficStopCitationDetail>(entity =>
        {
            entity.HasKey(e => e.TrafficStopCitationDetailId).HasName("PK_TRAFFICSTOPCITATIONDETAIL");

            entity.ToTable("TrafficStopCitationDetail");

            entity.HasIndex(e => e.TrafficStopId, "TrafficStopCitationDetail_TrafficStopID");

            entity.Property(e => e.TrafficStopCitationDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopCitationDetailID");
            entity.Property(e => e.ActualSpeed).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AnswerDt)
                .HasColumnType("datetime")
                .HasColumnName("AnswerDT");
            entity.Property(e => e.CitationAmount).HasColumnType("money");
            entity.Property(e => e.CitationTicketNumber).HasMaxLength(20);
            entity.Property(e => e.Dotnumber)
                .HasMaxLength(50)
                .HasColumnName("DOTNumber");
            entity.Property(e => e.IsBothConstschoolZone).HasColumnName("IsBothCONSTSchoolZone");
            entity.Property(e => e.IsCdl).HasColumnName("IsCDL");
            entity.Property(e => e.IsConstzone).HasColumnName("IsCONSTZone");
            entity.Property(e => e.IsCv).HasColumnName("IsCV");
            entity.Property(e => e.IsHm).HasColumnName("isHM");
            entity.Property(e => e.IsPhotoId).HasColumnName("IsPhotoID");
            entity.Property(e => e.PostedSpeed).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.SentToBureauDateTime).HasColumnType("datetime");
            entity.Property(e => e.TicketPdf)
                .HasColumnType("image")
                .HasColumnName("TicketPDF");
            entity.Property(e => e.TicketXml)
                .HasColumnType("xml")
                .HasColumnName("TicketXML");
            entity.Property(e => e.TrafficStopId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopID");

            entity.HasOne(d => d.LocationAreaCodeNavigation).WithMany(p => p.TrafficStopCitationDetailLocationAreaCodeNavigations)
                .HasForeignKey(d => d.LocationAreaCode)
                .HasConstraintName("FK_CITATION_REFERENCE_REFTRAFF4");

            entity.HasOne(d => d.RoadSurfaceConditionCodeNavigation).WithMany(p => p.TrafficStopCitationDetailRoadSurfaceConditionCodeNavigations)
                .HasForeignKey(d => d.RoadSurfaceConditionCode)
                .HasConstraintName("FK_CITATION_REFERENCE_REFTRAFF3");

            entity.HasOne(d => d.TrafficStop).WithMany(p => p.TrafficStopCitationDetails)
                .HasForeignKey(d => d.TrafficStopId)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_TRAFFICS2");

            entity.HasOne(d => d.TrafficeConditionCodeNavigation).WithMany(p => p.TrafficStopCitationDetailTrafficeConditionCodeNavigations)
                .HasForeignKey(d => d.TrafficeConditionCode)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_REFTRAFF3");

            entity.HasOne(d => d.VisibilityConditionCodeNavigation).WithMany(p => p.TrafficStopCitationDetailVisibilityConditionCodeNavigations)
                .HasForeignKey(d => d.VisibilityConditionCode)
                .HasConstraintName("FK_CITATION_REFERENCE_REFTRAFF5");
        });

        modelBuilder.Entity<TrafficStopViolation>(entity =>
        {
            entity.HasKey(e => e.TrafficStopViolationId).HasName("PK_TRAFFICSTOPVIOLATIONS");

            entity.HasIndex(e => e.TrafficStopId, "IX_TrafficStopViolations_TrafficStopID");

            entity.HasIndex(e => e.ViolationId, "IX_TrafficStopViolations_ViolationID");

            entity.Property(e => e.TrafficStopViolationId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopViolationID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Amount)
                .HasColumnType("money")
                .HasColumnName("amount");
            entity.Property(e => e.CdCcswitch).HasColumnName("cdCCSwitch");
            entity.Property(e => e.CdChargeNumber).HasColumnName("cdChargeNumber");
            entity.Property(e => e.CdConditionalDischargeTerm).HasColumnName("cdConditionalDischargeTerm");
            entity.Property(e => e.CdConditionalDischargeType).HasColumnName("cdConditionalDischargeType");
            entity.Property(e => e.CdDocketNumber)
                .HasMaxLength(20)
                .HasColumnName("cdDocketNumber");
            entity.Property(e => e.CdDvindicator)
                .HasMaxLength(10)
                .HasColumnName("cdDVIndicator");
            entity.Property(e => e.CdFineAmount)
                .HasColumnType("money")
                .HasColumnName("cdFineAmount");
            entity.Property(e => e.CdFineRemitted)
                .HasColumnType("money")
                .HasColumnName("cdFineRemitted");
            entity.Property(e => e.CdJailTerm).HasColumnName("cdJailTerm");
            entity.Property(e => e.CdJailType).HasColumnName("cdJailType");
            entity.Property(e => e.CdOtherFeesAmount)
                .HasColumnType("money")
                .HasColumnName("cdOtherFeesAmount");
            entity.Property(e => e.CdPlea).HasColumnName("cdPlea");
            entity.Property(e => e.CdProbationTerm).HasColumnName("cdProbationTerm");
            entity.Property(e => e.CdProbationType).HasColumnName("cdProbationType");
            entity.Property(e => e.CdRecordNumber).HasColumnName("cdRecordNumber");
            entity.Property(e => e.CdRefstatuteDefinitionId).HasColumnName("cdREFStatuteDefinitionID");
            entity.Property(e => e.CdSpecialParoleTerm).HasColumnName("cdSpecialParoleTerm");
            entity.Property(e => e.CdSpecialParoleType).HasColumnName("cdSpecialParoleType");
            entity.Property(e => e.CdStatuteCax)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteCAX");
            entity.Property(e => e.CdStatuteClass)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteClass");
            entity.Property(e => e.CdStatuteCode)
                .HasMaxLength(200)
                .HasColumnName("cdStatuteCode");
            entity.Property(e => e.CdStatuteCount).HasColumnName("cdStatuteCount");
            entity.Property(e => e.CdStatuteDescription).HasColumnName("cdStatuteDescription");
            entity.Property(e => e.CdStatuteType)
                .HasMaxLength(10)
                .HasColumnName("cdStatuteType");
            entity.Property(e => e.CdSuspendedJailTerm).HasColumnName("cdSuspendedJailTerm");
            entity.Property(e => e.CdSuspendedJailType).HasColumnName("cdSuspendedJailType");
            entity.Property(e => e.CdTimeServed)
                .HasMaxLength(10)
                .HasColumnName("cdTimeServed");
            entity.Property(e => e.CdVerdictFinding).HasColumnName("cdVerdictFinding");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RefstatuteDefinitionId).HasColumnName("REFStatuteDefinitionID");
            entity.Property(e => e.TrafficStopId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopID");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.ViolationId).HasColumnName("ViolationID");

            entity.HasOne(d => d.CdCcswitchNavigation).WithMany(p => p.TrafficStopViolationCdCcswitchNavigations)
                .HasForeignKey(d => d.CdCcswitch)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_REFINCID");

            entity.HasOne(d => d.CdConditionalDischargeTypeNavigation).WithMany(p => p.TrafficStopViolationCdConditionalDischargeTypeNavigations)
                .HasForeignKey(d => d.CdConditionalDischargeType)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_REFINCID8");

            entity.HasOne(d => d.CdJailTypeNavigation).WithMany(p => p.TrafficStopViolationCdJailTypeNavigations)
                .HasForeignKey(d => d.CdJailType)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_REFINCID5");

            entity.HasOne(d => d.CdPleaNavigation).WithMany(p => p.TrafficStopViolationCdPleaNavigations)
                .HasForeignKey(d => d.CdPlea)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_REFINCID2");

            entity.HasOne(d => d.CdProbationTypeNavigation).WithMany(p => p.TrafficStopViolationCdProbationTypeNavigations)
                .HasForeignKey(d => d.CdProbationType)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_REFINCID6");

            entity.HasOne(d => d.CdRefstatuteDefinition).WithMany(p => p.TrafficStopViolationCdRefstatuteDefinitions)
                .HasForeignKey(d => d.CdRefstatuteDefinitionId)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_REFSTATU");

            entity.HasOne(d => d.CdSpecialParoleTypeNavigation).WithMany(p => p.TrafficStopViolationCdSpecialParoleTypeNavigations)
                .HasForeignKey(d => d.CdSpecialParoleType)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_REFINCID7");

            entity.HasOne(d => d.CdSuspendedJailTypeNavigation).WithMany(p => p.TrafficStopViolationCdSuspendedJailTypeNavigations)
                .HasForeignKey(d => d.CdSuspendedJailType)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_REFINCID4");

            entity.HasOne(d => d.CdVerdictFindingNavigation).WithMany(p => p.TrafficStopViolationCdVerdictFindingNavigations)
                .HasForeignKey(d => d.CdVerdictFinding)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_REFINCID3");

            entity.HasOne(d => d.RefstatuteDefinition).WithMany(p => p.TrafficStopViolationRefstatuteDefinitions)
                .HasForeignKey(d => d.RefstatuteDefinitionId)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_REFSTATU2");

            entity.HasOne(d => d.TrafficStop).WithMany(p => p.TrafficStopViolations)
                .HasForeignKey(d => d.TrafficStopId)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_TRAFFICS3");

            entity.HasOne(d => d.Violation).WithMany(p => p.TrafficStopViolations)
                .HasForeignKey(d => d.ViolationId)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_REFVIOLA");
        });

        modelBuilder.Entity<TrafficStopWarningDetail>(entity =>
        {
            entity.HasKey(e => e.TrafficStopWarningDetailId).HasName("PK_TRAFFICSTOPWARNINGDETAIL");

            entity.ToTable("TrafficStopWarningDetail");

            entity.HasIndex(e => e.TrafficStopId, "IX_TrafficStopWarningDetail_TrafficStopID");

            entity.Property(e => e.TrafficStopWarningDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopWarningDetailID");
            entity.Property(e => e.DefectiveEquipmentXml)
                .HasColumnType("xml")
                .HasColumnName("DefectiveEquipmentXML");
            entity.Property(e => e.TicketPdf)
                .HasColumnType("image")
                .HasColumnName("TicketPDF");
            entity.Property(e => e.TrafficStopId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopID");
            entity.Property(e => e.WarningTicketNumber).HasMaxLength(20);

            entity.HasOne(d => d.ConditionsRoadCodeNavigation).WithMany(p => p.TrafficStopWarningDetailConditionsRoadCodeNavigations)
                .HasForeignKey(d => d.ConditionsRoadCode)
                .HasConstraintName("FK_WARNINGD_REFERENCE_REFTRAFF5");

            entity.HasOne(d => d.ConditionsTimeCodeNavigation).WithMany(p => p.TrafficStopWarningDetailConditionsTimeCodeNavigations)
                .HasForeignKey(d => d.ConditionsTimeCode)
                .HasConstraintName("FK_WARNINGD_REFERENCE_REFTRAFF2");

            entity.HasOne(d => d.ConditionsTrafficCodeNavigation).WithMany(p => p.TrafficStopWarningDetailConditionsTrafficCodeNavigations)
                .HasForeignKey(d => d.ConditionsTrafficCode)
                .HasConstraintName("FK_WARNINGD_REFERENCE_REFTRAFF3");

            entity.HasOne(d => d.ConditionsWeatherCodeNavigation).WithMany(p => p.TrafficStopWarningDetailConditionsWeatherCodeNavigations)
                .HasForeignKey(d => d.ConditionsWeatherCode)
                .HasConstraintName("FK_WARNINGD_REFERENCE_REFTRAFF4");

            entity.HasOne(d => d.DefectiveEquipmentCodeNavigation).WithMany(p => p.TrafficStopWarningDetailDefectiveEquipmentCodeNavigations)
                .HasForeignKey(d => d.DefectiveEquipmentCode)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_REFTRAFF");

            entity.HasOne(d => d.TrafficStop).WithMany(p => p.TrafficStopWarningDetails)
                .HasForeignKey(d => d.TrafficStopId)
                .HasConstraintName("FK_TRAFFICS_REFERENCE_TRAFFICS");
        });

        modelBuilder.Entity<TrxBackgroundCheck>(entity =>
        {
            entity.HasKey(e => e.BackgroundCheckId).HasName("PK_TRXBACKGROUNDCHECK");

            entity.ToTable("TrxBackgroundCheck");

            entity.HasIndex(e => e.CheckedMasterPersonId, "IX_TrxBackgroundCheck_CheckedMasterPersonID");

            entity.HasIndex(e => e.CheckedMasterVehicleId, "IX_TrxBackgroundCheck_CheckedMasterVehicleID");

            entity.HasIndex(e => e.CheckedServiceCallPersonId, "IX_TrxBackgroundCheck_CheckedServiceCallPersonID");

            entity.HasIndex(e => e.CheckedServiceCallVehicleId, "IX_TrxBackgroundCheck_CheckedServiceCallVehicleID");

            entity.Property(e => e.BackgroundCheckId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BackgroundCheckID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CadbackgroundCheckId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CADBackgroundCheckID");
            entity.Property(e => e.CheckedMasterPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CheckedMasterPersonID");
            entity.Property(e => e.CheckedMasterVehicleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CheckedMasterVehicleID");
            entity.Property(e => e.CheckedServiceCallPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CheckedServiceCallPersonID");
            entity.Property(e => e.CheckedServiceCallVehicleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CheckedServiceCallVehicleID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.ParsedResponseData).HasColumnType("xml");
            entity.Property(e => e.RequestBy).HasMaxLength(200);
            entity.Property(e => e.RequestDateTime).HasColumnType("datetime");
            entity.Property(e => e.RequestType).HasMaxLength(50);
            entity.Property(e => e.RequestXml)
                .HasColumnType("xml")
                .HasColumnName("RequestXML");
            entity.Property(e => e.ResponseDoneDateTime).HasColumnType("datetime");
            entity.Property(e => e.ScreenResponseData).HasColumnType("ntext");

            entity.HasOne(d => d.CheckedMasterPerson).WithMany(p => p.TrxBackgroundChecks)
                .HasForeignKey(d => d.CheckedMasterPersonId)
                .HasConstraintName("FK_TRXBACKG_REFERENCE_MSTRPERS");

            entity.HasOne(d => d.CheckedMasterVehicle).WithMany(p => p.TrxBackgroundChecks)
                .HasForeignKey(d => d.CheckedMasterVehicleId)
                .HasConstraintName("FK_TRXBACKG_REFERENCE_MSTRVEHI");

            entity.HasOne(d => d.CheckedServiceCallPerson).WithMany(p => p.TrxBackgroundChecks)
                .HasForeignKey(d => d.CheckedServiceCallPersonId)
                .HasConstraintName("FK_TRX_BACK_REFERENCE_SERVICEC2");

            entity.HasOne(d => d.CheckedServiceCallVehicle).WithMany(p => p.TrxBackgroundChecks)
                .HasForeignKey(d => d.CheckedServiceCallVehicleId)
                .HasConstraintName("FK_TRXBACKG_REFERENCE_NONVERIF");
        });

        modelBuilder.Entity<UnknownNameChangeHelpQueryPersonHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UnknownNameChangeHelpQueryPersonHistory");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(100);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.CrashPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_PersonInvolvementID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.FieldInterviewPersonInvolvmentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("FieldInterviewPersonInvolvmentID");
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.IncidentPersonInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IncidentPersonInvolvementID");
            entity.Property(e => e.InvolvementCode).HasMaxLength(150);
            entity.Property(e => e.InvolvementRefCodeId).HasColumnName("InvolvementRefCodeID");
            entity.Property(e => e.InvolvementRefCodeTable).HasMaxLength(100);
            entity.Property(e => e.MasterIndexId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MasterIndexID");
            entity.Property(e => e.MasterIndexTable).HasMaxLength(100);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.MstrpersonApplictionInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRPersonApplictionInvolvementID");
            entity.Property(e => e.NewMpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NewMPID");
            entity.Property(e => e.OldMpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OldMPID");
            entity.Property(e => e.TrafficStopId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopID");
        });

        modelBuilder.Entity<UnknownNameChangeHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UnknownNameChangeHistory");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ChangeFieldName).HasMaxLength(500);
            entity.Property(e => e.ChangeTableName).HasMaxLength(500);
            entity.Property(e => e.ChangeTablePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ChangeTablePK");
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.NewMpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NewMPID");
        });

        modelBuilder.Entity<UnknownRegNumChangeHelpQueryVehicleHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UnknownRegNumChangeHelpQueryVehicleHistory");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ApplicationNumber).HasMaxLength(100);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.CrashVehicleInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Crash_VehicleInvolvementID");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.FieldInterviewVehicleInvolvmentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("FieldInterviewVehicleInvolvmentID");
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.HelpQueryVehicleInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("HelpQueryVehicleInvolvementID");
            entity.Property(e => e.IncidentVehicleInvolvementId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Incident_VehicleInvolvementID");
            entity.Property(e => e.InvolvementCode).HasMaxLength(100);
            entity.Property(e => e.InvolvementRefCodeId).HasColumnName("InvolvementRefCodeID");
            entity.Property(e => e.InvolvementRefCodeTable).HasMaxLength(100);
            entity.Property(e => e.MasterIndexId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MasterIndexID");
            entity.Property(e => e.MasterIndexTable).HasMaxLength(100);
            entity.Property(e => e.Mvid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MVID");
            entity.Property(e => e.NewMvid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NewMVID");
            entity.Property(e => e.OldMvid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OldMVID");
            entity.Property(e => e.TrafficStopId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TrafficStopID");
        });

        modelBuilder.Entity<UnknownRegNumChangeHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UnknownRegNumChangeHistory");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ChangeFieldName).HasMaxLength(500);
            entity.Property(e => e.ChangeTableName).HasMaxLength(500);
            entity.Property(e => e.ChangeTablePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ChangeTablePK");
            entity.Property(e => e.Mvid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MVID");
            entity.Property(e => e.NewMvid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NewMVID");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_USERS");

            entity.HasIndex(e => e.DepartmentEmployeeId, "IX_Users_DepartmentEmployeeID");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.ChallengeAnswer1).HasMaxLength(200);
            entity.Property(e => e.ChallengeAnswer2).HasMaxLength(200);
            entity.Property(e => e.ChallengeAnswer3).HasMaxLength(200);
            entity.Property(e => e.ChallengeQuestion1).HasMaxLength(200);
            entity.Property(e => e.ChallengeQuestion2).HasMaxLength(200);
            entity.Property(e => e.ChallengeQuestion3).HasMaxLength(200);
            entity.Property(e => e.CriminalJusticeAccessCertNum).HasMaxLength(50);
            entity.Property(e => e.CriminalJusticeAccessExpiry).HasMaxLength(50);
            entity.Property(e => e.CriminalJusticeAccessPassword).HasMaxLength(50);
            entity.Property(e => e.CriminalJusticeAccessUserName).HasMaxLength(50);
            entity.Property(e => e.DepartmentEmployeeId).HasColumnName("DepartmentEmployeeID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DirectoryId)
                .HasMaxLength(20)
                .HasColumnName("DirectoryID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.PasswordExpiry).HasColumnType("date");
            entity.Property(e => e.SignaturePassword).HasMaxLength(50);
            entity.Property(e => e.SignatureStroke).HasColumnType("image");
            entity.Property(e => e.UserEmail).HasMaxLength(200);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserProfileXml)
                .HasColumnType("xml")
                .HasColumnName("UserProfileXML");

            entity.HasOne(d => d.Agency).WithMany(p => p.Users)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_USERS_REFERENCE_SYSAGENC");

            entity.HasOne(d => d.DepartmentEmployee).WithMany(p => p.Users)
                .HasForeignKey(d => d.DepartmentEmployeeId)
                .HasConstraintName("FK_USERS_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.Department).WithMany(p => p.Users)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_USERS_REFERENCE_DEPARTME");
        });

        modelBuilder.Entity<UserToken>(entity =>
        {
            entity.HasKey(e => e.UserTokenId).HasName("PK__UserToke__BD92DEBBEE6D58EF");

            entity.ToTable("UserToken");

            entity.Property(e => e.UserTokenId).HasColumnName("UserTokenID");
            entity.Property(e => e.AddedName).IsUnicode(false);
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.RefreshTokenExpiry).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserTokens)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserToken__UserI__12DEA178");
        });

        modelBuilder.Entity<ViewMstrcontactPhone>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MSTRContactPhone");

            entity.Property(e => e.ApplicationNumber).HasMaxLength(20);
            entity.Property(e => e.ApplicationTypePk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ApplicationTypePK");
            entity.Property(e => e.ContactData).HasMaxLength(400);
            entity.Property(e => e.EditedOn).HasMaxLength(100);
            entity.Property(e => e.EditedOnDateTime)
                .HasMaxLength(19)
                .HasColumnName("editedOnDateTime");
            entity.Property(e => e.Extension).HasMaxLength(50);
            entity.Property(e => e.Mpid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MPID");
            entity.Property(e => e.MstrcontactId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MSTRContactID");
            entity.Property(e => e.PhoneNumber).HasMaxLength(4000);
            entity.Property(e => e.StartOfExt).HasColumnName("StartOfEXT");
            entity.Property(e => e.TypeOfContactString).HasMaxLength(50);
        });

        modelBuilder.Entity<VwApplicationDataProcessItemDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_ApplicationDataProcessItemDetail");

            entity.Property(e => e.DataBindingXml)
                .HasColumnType("xml")
                .HasColumnName("DataBindingXML");
            entity.Property(e => e.DefaultValue).HasMaxLength(100);
            entity.Property(e => e.ProcessControllerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ProcessControllerID");
            entity.Property(e => e.StepItemDefinitionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("StepItemDefinitionID");
            entity.Property(e => e.StepItemId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("StepItemID");
            entity.Property(e => e.StepItemName).HasMaxLength(200);
            entity.Property(e => e.StepItemType).HasMaxLength(100);
            entity.Property(e => e.StepName).HasMaxLength(100);
            entity.Property(e => e.StepStatus).HasMaxLength(100);
            entity.Property(e => e.UserAnswerStr).HasColumnName("UserAnswerSTR");
        });

        modelBuilder.Entity<Warrant>(entity =>
        {
            entity.HasKey(e => e.WarrantId).HasName("PK_WARRANTS");

            entity.HasIndex(e => e.DataEntryEmployeeId, "IX_Warrants_DataEntryEmployeeID");

            entity.HasIndex(e => e.RequestingOfficerId, "IX_Warrants_RequestingOfficerID");

            entity.HasIndex(e => e.WarrantPersonId, "IX_Warrants_WarrantPersonID");

            entity.HasIndex(e => e.WarrantStatusId, "IX_Warrants_WarrantStatusID");

            entity.HasIndex(e => e.RelatedIncidentId, "Warrants_RelatedIncidentID");

            entity.HasIndex(e => e.ReportStatusId, "Warrants_ReportStatusID_WRWRWDAW");

            entity.Property(e => e.WarrantId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("WarrantID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AffidavitDateTime).HasColumnType("datetime");
            entity.Property(e => e.AffidavitEditedName).HasMaxLength(100);
            entity.Property(e => e.BondAmount).HasColumnType("money");
            entity.Property(e => e.Collectnumber)
                .HasMaxLength(100)
                .HasColumnName("COLLECTNumber");
            entity.Property(e => e.CourtDate).HasColumnType("date");
            entity.Property(e => e.DataEntryEmployeeId).HasColumnName("DataEntryEmployeeID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.ExtraditableDetails).HasMaxLength(300);
            entity.Property(e => e.IncidentNumber).HasMaxLength(100);
            entity.Property(e => e.IssuedDateTime).HasColumnType("datetime");
            entity.Property(e => e.JacketNumber).HasMaxLength(100);
            entity.Property(e => e.Judge).HasMaxLength(100);
            entity.Property(e => e.Ncicnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NCICNumber");
            entity.Property(e => e.NotaryId).HasColumnName("NotaryID");
            entity.Property(e => e.ReceivedDateTime).HasColumnType("datetime");
            entity.Property(e => e.RelatedIncidentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RelatedIncidentID");
            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
            entity.Property(e => e.RequestingOfficerId).HasColumnName("RequestingOfficerID");
            entity.Property(e => e.SwornDate).HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UniqueID");
            entity.Property(e => e.UsedNarrativeTemplateId).HasColumnName("UsedNarrativeTemplateID");
            entity.Property(e => e.WarrantEffectDateTime).HasColumnType("datetime");
            entity.Property(e => e.WarrantExpirationDateTime).HasColumnType("datetime");
            entity.Property(e => e.WarrantNumber).HasMaxLength(20);
            entity.Property(e => e.WarrantPersonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("WarrantPersonID");
            entity.Property(e => e.WarrantStatusDateTime).HasColumnType("datetime");
            entity.Property(e => e.WarrantStatusId).HasColumnName("WarrantStatusID");

            entity.HasOne(d => d.BondTypeCodeNavigation).WithMany(p => p.WarrantBondTypeCodeNavigations)
                .HasForeignKey(d => d.BondTypeCode)
                .HasConstraintName("FK_WARRANTS_REFERENCE_REFINCID3");

            entity.HasOne(d => d.CourtNavigation).WithMany(p => p.WarrantCourtNavigations)
                .HasForeignKey(d => d.Court)
                .HasConstraintName("FK_WARRANTS_REFERENCE_REFINCID");

            entity.HasOne(d => d.DataEntryEmployee).WithMany(p => p.WarrantDataEntryEmployees)
                .HasForeignKey(d => d.DataEntryEmployeeId)
                .HasConstraintName("FK_WARRANTS_REFERENCE_DEPARTME");

            entity.HasOne(d => d.Department).WithMany(p => p.Warrants)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_WARRANTS_REFERENCE_DEPARTME2");

            entity.HasOne(d => d.Notary).WithMany(p => p.WarrantNotaries)
                .HasForeignKey(d => d.NotaryId)
                .HasConstraintName("FK_WARRANTS_REFERENCE_DEPTEMPLOYEE");

            entity.HasOne(d => d.RelatedIncident).WithMany(p => p.Warrants)
                .HasForeignKey(d => d.RelatedIncidentId)
                .HasConstraintName("FK_WARRANTS_REFERENCE_INCIDENT");

            entity.HasOne(d => d.ReportStatus).WithMany(p => p.WarrantReportStatuses)
                .HasForeignKey(d => d.ReportStatusId)
                .HasConstraintName("FK_WARRANTS_REFERENCE_SYSAPPLI");

            entity.HasOne(d => d.RequestingOfficer).WithMany(p => p.WarrantRequestingOfficers)
                .HasForeignKey(d => d.RequestingOfficerId)
                .HasConstraintName("FK_WARRANTS_REFERENCE_DEPARTME3");

            entity.HasOne(d => d.UsedNarrativeTemplate).WithMany(p => p.Warrants)
                .HasForeignKey(d => d.UsedNarrativeTemplateId)
                .HasConstraintName("FK_WARRANTS_REFERENCE_REFNARRA");

            entity.HasOne(d => d.WarrantPerson).WithMany(p => p.Warrants)
                .HasForeignKey(d => d.WarrantPersonId)
                .HasConstraintName("FK_WARRANTS_REFERENCE_MSTRPERS");

            entity.HasOne(d => d.WarrantSourceCodeNavigation).WithMany(p => p.WarrantWarrantSourceCodeNavigations)
                .HasForeignKey(d => d.WarrantSourceCode)
                .HasConstraintName("FK_WARRANTS_REFERENCE_REFINCID4");

            entity.HasOne(d => d.WarrantStatus).WithMany(p => p.WarrantWarrantStatuses)
                .HasForeignKey(d => d.WarrantStatusId)
                .HasConstraintName("FK_WARRANTS_REFERENCE_SYSAPPLI2");

            entity.HasOne(d => d.WarrantTypeCodeNavigation).WithMany(p => p.WarrantWarrantTypeCodeNavigations)
                .HasForeignKey(d => d.WarrantTypeCode)
                .HasConstraintName("FK_WARRANTS_REFERENCE_REFINCID2");
        });

        modelBuilder.Entity<WarrantAttempt>(entity =>
        {
            entity.HasKey(e => e.WarrantAttemptId).HasName("PK_WARRANTATTEMPTS");

            entity.HasIndex(e => e.LocationId, "IX_WarrantAttempts_LocationID");

            entity.HasIndex(e => e.WarrantId, "IX_WarrantAttempts_WarrantID");

            entity.Property(e => e.WarrantAttemptId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("WarrantAttemptID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AttemptDate).HasColumnType("datetime");
            entity.Property(e => e.AttemptStatus).HasMaxLength(20);
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LocationID");
            entity.Property(e => e.WarrantId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("WarrantID");

            entity.HasOne(d => d.AttemptOfficerNameNavigation).WithMany(p => p.WarrantAttempts)
                .HasForeignKey(d => d.AttemptOfficerName)
                .HasConstraintName("FK_WARRANTA_REFERENCE_DEPARTME");

            entity.HasOne(d => d.AttemptTypeCodeNavigation).WithMany(p => p.WarrantAttempts)
                .HasForeignKey(d => d.AttemptTypeCode)
                .HasConstraintName("FK_WARRANTA_REFERENCE_REFINCID");

            entity.HasOne(d => d.Location).WithMany(p => p.WarrantAttempts)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_WARRANTA_REFERENCE_MSTRLOCA");

            entity.HasOne(d => d.Warrant).WithMany(p => p.WarrantAttempts)
                .HasForeignKey(d => d.WarrantId)
                .HasConstraintName("FK_WARRANTA_REFERENCE_WARRANTS");
        });

        modelBuilder.Entity<WarrantGeneratedReport>(entity =>
        {
            entity.HasIndex(e => e.WarrantId, "IX_WarrantGeneratedReports_WarrantID");

            entity.Property(e => e.WarrantGeneratedReportId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("WarrantGeneratedReportID");
            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.RmsworkFlowControllerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSWorkFlowControllerID");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.WarrantId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("WarrantID");

            entity.HasOne(d => d.ReportStatusNavigation).WithMany(p => p.WarrantGeneratedReportReportStatusNavigations)
                .HasForeignKey(d => d.ReportStatus)
                .HasConstraintName("FK_WarrantGeneratedReports_SysApplicationStatus1");

            entity.HasOne(d => d.RmsworkFlowController).WithMany(p => p.WarrantGeneratedReports)
                .HasForeignKey(d => d.RmsworkFlowControllerId)
                .HasConstraintName("FK_WarrantGeneratedReports_RMSWorkFlowController");

            entity.HasOne(d => d.Warrant).WithMany(p => p.WarrantGeneratedReports)
                .HasForeignKey(d => d.WarrantId)
                .HasConstraintName("FK_WarrantGeneratedReports_Warrants");

            entity.HasOne(d => d.WarrantStatusNavigation).WithMany(p => p.WarrantGeneratedReportWarrantStatusNavigations)
                .HasForeignKey(d => d.WarrantStatus)
                .HasConstraintName("FK_WarrantGeneratedReports_SysApplicationStatus");
        });

        modelBuilder.Entity<WarrantOffense>(entity =>
        {
            entity.HasKey(e => e.WarrantOffenseId).HasName("PK_WARRANTOFFENSE");

            entity.ToTable("WarrantOffense");

            entity.HasIndex(e => e.WarrantId, "IX_WarrantOffense_WarrantID");

            entity.Property(e => e.WarrantOffenseId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("WarrantOffenseID");
            entity.Property(e => e.AclflagCode).HasColumnName("ACLFlagCode");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OffenseSeq).HasColumnName("OffenseSEQ");
            entity.Property(e => e.OnOrAboutDate).HasMaxLength(200);
            entity.Property(e => e.WarrantId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("WarrantID");
            entity.Property(e => e.WarrantOffenseCodeId).HasColumnName("WarrantOffenseCodeID");

            entity.HasOne(d => d.AclflagCodeNavigation).WithMany(p => p.WarrantOffenseAclflagCodeNavigations)
                .HasForeignKey(d => d.AclflagCode)
                .HasConstraintName("FK_WARRANTO_REFERENCE_REFINCID2");

            entity.HasOne(d => d.Agency).WithMany(p => p.WarrantOffenseAgencies)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_WARRANTO_REFERENCE_REFINCID");

            entity.HasOne(d => d.Warrant).WithMany(p => p.WarrantOffenses)
                .HasForeignKey(d => d.WarrantId)
                .HasConstraintName("FK_WARRANTO_REFERENCE_WARRANTS");

            entity.HasOne(d => d.WarrantOffenseCode).WithMany(p => p.WarrantOffenses)
                .HasForeignKey(d => d.WarrantOffenseCodeId)
                .HasConstraintName("FK_WARRANTO_REFERENCE_REFSTATU");
        });

        modelBuilder.Entity<WfallowedUi>(entity =>
        {
            entity.HasKey(e => e.WfallowedUiid).HasName("PK_WFALLOWEDUI");

            entity.ToTable("WFAllowedUI");

            entity.HasIndex(e => e.ApplicationStatusId, "IX_WFAllowedUI_ApplicationStatusID");

            entity.HasIndex(e => e.RmsworkFlowDefId, "IX_WFAllowedUI_RMSWorkFlowDefID");

            entity.HasIndex(e => e.SysrmsuserInterfaceDefinitionId, "IX_WFAllowedUI_SYSRMSUserInterfaceDefinitionID");

            entity.Property(e => e.WfallowedUiid)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("WFAllowedUIID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ApplicationStatusId).HasColumnName("ApplicationStatusID");
            entity.Property(e => e.DisplaySeq).HasColumnName("DisplaySEQ");
            entity.Property(e => e.EditedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OkactionWf)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OKActionWF");
            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
            entity.Property(e => e.RmsworkFlowDefId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("RMSWorkFlowDefID");
            entity.Property(e => e.SysrmsuserInterfaceDefinitionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SYSRMSUserInterfaceDefinitionID");

            entity.HasOne(d => d.ApplicationStatus).WithMany(p => p.WfallowedUiApplicationStatuses)
                .HasForeignKey(d => d.ApplicationStatusId)
                .HasConstraintName("FK_WFALLOWE_REFERENCE_SYSAPPLI2");

            entity.HasOne(d => d.OkactionWfNavigation).WithMany(p => p.WfallowedUiOkactionWfNavigations)
                .HasForeignKey(d => d.OkactionWf)
                .HasConstraintName("FK_WFALLOWE_REFERENCE_RMSWORKF");

            entity.HasOne(d => d.ReportStatus).WithMany(p => p.WfallowedUiReportStatuses)
                .HasForeignKey(d => d.ReportStatusId)
                .HasConstraintName("FK_WFALLOWE_REFERENCE_SYSAPPLI");

            entity.HasOne(d => d.RmsworkFlowDef).WithMany(p => p.WfallowedUiRmsworkFlowDefs)
                .HasForeignKey(d => d.RmsworkFlowDefId)
                .HasConstraintName("FK_WFALLOWE_REFERENCE_RMSWORKF2");

            entity.HasOne(d => d.SysrmsuserInterfaceDefinition).WithMany(p => p.WfallowedUis)
                .HasForeignKey(d => d.SysrmsuserInterfaceDefinitionId)
                .HasConstraintName("FK_WFALLOWE_REFERENCE_SYSRMSUS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
