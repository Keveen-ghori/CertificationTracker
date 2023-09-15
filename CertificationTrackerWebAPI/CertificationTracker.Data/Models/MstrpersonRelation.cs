using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpersonRelation
{
    public decimal MprelationId { get; set; }

    public decimal? PrimaryPersonId { get; set; }

    public decimal? LinkedPersonId { get; set; }

    public int? PersonRelationLnkcode { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public Guid? UniqueId { get; set; }

    public string? Description { get; set; }

    public decimal? CopiedFromPrpersonMprelationId { get; set; }

    public virtual Mstrperson? LinkedPerson { get; set; }

    public virtual RefMstrinxreferenceDatum? PersonRelationLnkcodeNavigation { get; set; }

    public virtual Mstrperson? PrimaryPerson { get; set; }
}
