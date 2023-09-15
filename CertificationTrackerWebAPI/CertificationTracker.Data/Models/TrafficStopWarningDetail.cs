using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class TrafficStopWarningDetail
{
    public decimal TrafficStopWarningDetailId { get; set; }

    public decimal? TrafficStopId { get; set; }

    public int? ConditionsTimeCode { get; set; }

    public int? ConditionsTrafficCode { get; set; }

    public int? ConditionsWeatherCode { get; set; }

    public int? ConditionsRoadCode { get; set; }

    public int? DefectiveEquipmentCode { get; set; }

    public string? Other { get; set; }

    public string? OtherDefectiveEquip { get; set; }

    public byte[]? TicketPdf { get; set; }

    public string? DefectiveEquipmentXml { get; set; }

    public string? WarningTicketNumber { get; set; }

    public virtual RefTrafficStopTicketReferenceDatum? ConditionsRoadCodeNavigation { get; set; }

    public virtual RefTrafficStopTicketReferenceDatum? ConditionsTimeCodeNavigation { get; set; }

    public virtual RefTrafficStopTicketReferenceDatum? ConditionsTrafficCodeNavigation { get; set; }

    public virtual RefTrafficStopTicketReferenceDatum? ConditionsWeatherCodeNavigation { get; set; }

    public virtual RefTrafficStopTicketReferenceDatum? DefectiveEquipmentCodeNavigation { get; set; }

    public virtual TrafficStop? TrafficStop { get; set; }
}
