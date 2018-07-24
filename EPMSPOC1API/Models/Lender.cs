using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Lender
    {
        public Lender()
        {
            CreditAccount = new HashSet<CreditAccount>();
        }

        public long LenderId { get; set; }
        public long? FinanceId { get; set; }
        public long LenderTypeId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Finance Finance { get; set; }
        public LenderType LenderType { get; set; }
        public ICollection<CreditAccount> CreditAccount { get; set; }
    }
}
