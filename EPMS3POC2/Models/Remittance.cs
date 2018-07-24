using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Remittance
    {
        public Remittance()
        {
            TransactionCredit = new HashSet<TransactionCredit>();
        }

        public long RemittanceId { get; set; }
        public long? InsuranceId { get; set; }
        public string EobcheckNumber { get; set; }
        public decimal? EobcheckAmount { get; set; }
        public string EobaccountNumber { get; set; }
        public DateTime? EobreceivedDate { get; set; }
        public string Eobpayer { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Insurance Insurance { get; set; }
        public ICollection<TransactionCredit> TransactionCredit { get; set; }
    }
}
