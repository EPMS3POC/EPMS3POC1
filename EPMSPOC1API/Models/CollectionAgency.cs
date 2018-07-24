using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class CollectionAgency
    {
        public CollectionAgency()
        {
            CollectionAccount = new HashSet<CollectionAccount>();
        }

        public long CollectionAgencyId { get; set; }
        public long? FinanceId { get; set; }
        public string CollectionAgencyName { get; set; }
        public string CollectionAgencyDescription { get; set; }
        public string CollectionAgencyCode { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Finance Finance { get; set; }
        public ICollection<CollectionAccount> CollectionAccount { get; set; }
    }
}
