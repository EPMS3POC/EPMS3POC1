using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Subscriber
    {
        public Subscriber()
        {
            Account = new HashSet<Account>();
            CoverageBook = new HashSet<CoverageBook>();
            Insurance = new HashSet<Insurance>();
        }

        public long SubscriberId { get; set; }
        public long PersonId { get; set; }
        public long? CoverageTypeId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public CoverageType CoverageType { get; set; }
        public Person Person { get; set; }
        public ICollection<Account> Account { get; set; }
        public ICollection<CoverageBook> CoverageBook { get; set; }
        public ICollection<Insurance> Insurance { get; set; }
    }
}
