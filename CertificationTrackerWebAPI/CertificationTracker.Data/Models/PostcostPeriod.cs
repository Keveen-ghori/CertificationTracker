using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PostcostPeriod
{
    public decimal PostcostPeriodId { get; set; }

    public DateTime? PoststartDate { get; set; }

    public DateTime? PostendDate { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? EditedName { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public virtual ICollection<PostcostRank> PostcostRanks { get; set; } = new List<PostcostRank>();

    public virtual ICollection<Postcourse> Postcourses { get; set; } = new List<Postcourse>();
}
