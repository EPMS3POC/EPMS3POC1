using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class CreditAccount
    {
        public long CreditAccountId { get; set; }
        public long? AccountId { get; set; }
        public long? LenderId { get; set; }
        public long? CreditAccountStatusId { get; set; }
        public decimal? CreditMaximum { get; set; }
        public decimal? CreditBalanceDue { get; set; }
        public string AccountNumber { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Account Account { get; set; }
        public CreditAccountStatus CreditAccountStatus { get; set; }
        public Lender Lender { get; set; }
    }
}
