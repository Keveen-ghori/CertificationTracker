using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RmsuserQueryResult
{
    public decimal RmsuserQueryResultId { get; set; }

    public decimal RequestedByUserId { get; set; }

    public int? RequestedByDepartmentEmployeeId { get; set; }

    public string? QueryType { get; set; }

    public string? QueryRequest { get; set; }

    public string? QueryResult { get; set; }

    public string? QueryDuration { get; set; }

    public string? OtherQueryInformation { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? QuerySubmitDateTime { get; set; }

    public DateTime? QueryResultDateTime { get; set; }

    public Guid? UniqueId { get; set; }

    public string? Source { get; set; }

    public string? QueryRequestDescription { get; set; }

    public string? CollectQueryRequest { get; set; }

    public string? CollectQueryResult { get; set; }

    public decimal? LinkedMstrpersonId { get; set; }

    public decimal? LinkedMstrvehicleId { get; set; }

    public decimal? LinkedMstrpropertyId { get; set; }

    public bool? IsMonitorRequired { get; set; }

    public bool? IsNewDataArrived { get; set; }

    public string? CaptainCtcollectQueryResult { get; set; }

    public string? CaptainCtcollecScreenResult { get; set; }

    public bool? QueryResultCompleted { get; set; }

    public decimal? GeneratedByRmsuserQueryResultId { get; set; }

    public int? CaptainCollectStatusId { get; set; }

    public string? CaptainCollectErrorText { get; set; }

    public int? QueryDurationMs { get; set; }

    public virtual SysApplicationStatus? CaptainCollectStatus { get; set; }

    public virtual RmsuserQueryResult? GeneratedByRmsuserQueryResult { get; set; }

    public virtual ICollection<RmsuserQueryResult> InverseGeneratedByRmsuserQueryResult { get; set; } = new List<RmsuserQueryResult>();
}
