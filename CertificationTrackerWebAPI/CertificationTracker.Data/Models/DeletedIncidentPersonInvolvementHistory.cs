using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DeletedIncidentPersonInvolvementHistory
{
    public decimal Id { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }
}
