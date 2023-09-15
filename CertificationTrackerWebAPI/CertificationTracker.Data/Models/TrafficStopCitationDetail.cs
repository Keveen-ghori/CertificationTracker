using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class TrafficStopCitationDetail
{
    public decimal TrafficStopCitationDetailId { get; set; }

    public decimal? TrafficStopId { get; set; }

    public int? RoadSurfaceConditionCode { get; set; }

    public int? LocationAreaCode { get; set; }

    public int? VisibilityConditionCode { get; set; }

    public int? TrafficeConditionCode { get; set; }

    public decimal? ActualSpeed { get; set; }

    public decimal? PostedSpeed { get; set; }

    public bool? IsTruck { get; set; }

    public bool? IsOverWeight { get; set; }

    public bool? Is8000LbsMore { get; set; }

    public string? Dotnumber { get; set; }

    public bool? IsPhotoId { get; set; }

    public bool? IsCdl { get; set; }

    public bool? IsCv { get; set; }

    public bool? IsHm { get; set; }

    public bool? IsConstzone { get; set; }

    public bool? IsSchoolZone { get; set; }

    public bool? IsBothConstschoolZone { get; set; }

    public string? CitationTicketNumber { get; set; }

    public DateTime? AnswerDt { get; set; }

    public string? TicketXml { get; set; }

    public DateTime? SentToBureauDateTime { get; set; }

    public decimal? CitationAmount { get; set; }

    public byte[]? TicketPdf { get; set; }

    public virtual RefTrafficStopTicketReferenceDatum? LocationAreaCodeNavigation { get; set; }

    public virtual RefTrafficStopTicketReferenceDatum? RoadSurfaceConditionCodeNavigation { get; set; }

    public virtual TrafficStop? TrafficStop { get; set; }

    public virtual RefTrafficStopTicketReferenceDatum? TrafficeConditionCodeNavigation { get; set; }

    public virtual RefTrafficStopTicketReferenceDatum? VisibilityConditionCodeNavigation { get; set; }
}
