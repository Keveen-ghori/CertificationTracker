using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class BookingReleaseInfo
{
    public decimal BookingReleaseInfoId { get; set; }

    public decimal? ArrestBookingId { get; set; }

    public string? AttorneyName { get; set; }

    public string? AttorneyAddress { get; set; }

    public string? AttorneyAddressCityStateZip { get; set; }

    public string? AttorneyPhone { get; set; }

    public int? BondType { get; set; }

    public string? BondPostedBy { get; set; }

    public string? BondAddress { get; set; }

    public string? BondAddressCityStateZip { get; set; }

    public string? BondPhone { get; set; }

    public decimal? BondPayment { get; set; }

    public int? ReleaseMethod { get; set; }

    public string? ReleaseMethodOther { get; set; }

    public int? ReleaseOfficerId { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public string? Jurisdiction { get; set; }

    public string? Comments { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual ArrestBooking? ArrestBooking { get; set; }

    public virtual RefIncidentReferenceDatum? BondTypeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? ReleaseMethodNavigation { get; set; }

    public virtual DepartmentEmployee? ReleaseOfficer { get; set; }
}
