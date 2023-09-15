using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptRacialProfile
{
    public int? DepartmentId { get; set; }

    public string? TrafficStopNumber { get; set; }

    public DateTime? TrafficStopDateTime { get; set; }

    public int? ReportedEmployeeId { get; set; }

    public string? FullName { get; set; }

    public int Count { get; set; }

    public int Gmale { get; set; }

    public int Gfemale { get; set; }

    public int Gunknown { get; set; }

    public int Rwhite { get; set; }

    public int Rblack { get; set; }

    public int Raindian { get; set; }

    public int Rasian { get; set; }

    public int Rother { get; set; }

    public int Ehisp { get; set; }

    public int EmiddleEs { get; set; }

    public int Eunknown { get; set; }

    public int LocalResident { get; set; }

    public int Ctresident { get; set; }

    public int NatureInvs { get; set; }

    public int NatureVio { get; set; }

    public int NatureEqp { get; set; }

    public int D1 { get; set; }

    public int D2 { get; set; }

    public int D3 { get; set; }

    public int EnfGeneral { get; set; }

    public int EnfBlind { get; set; }

    public int EnfSpot { get; set; }

    public int SearchNo { get; set; }

    public int SearchYes { get; set; }

    public int SearchYesP { get; set; }

    public int AuthorityConsent { get; set; }

    public int AuthorityInv { get; set; }

    public int AuthorityOther { get; set; }

    public int CustodyArrest { get; set; }

    public int VehicleSearch { get; set; }

    public int Towed { get; set; }

    public int? TrafficStopResultCode { get; set; }
}
