using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class CollectionAccount
    {
        public long CollectionAccountId { get; set; }
        public long? CollectionAgencyId { get; set; }
        public long? AccountId { get; set; }
        public decimal? AmountPastDue { get; set; }
        public decimal? CollectedBalance { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Account Account { get; set; }
        public CollectionAgency CollectionAgency { get; set; }
    }
}
