using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Accounting
    {
        public Accounting()
        {
            Statement = new HashSet<Statement>();
        }

        public long AccountingId { get; set; }
        public long FacilityId { get; set; }

        public Facility Facility { get; set; }
        public ICollection<Statement> Statement { get; set; }
    }
}
