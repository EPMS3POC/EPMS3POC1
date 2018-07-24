using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class TransactionCredit
    {
        public long TransactionCreditId { get; set; }
        public long TransactionId { get; set; }
        public long? RemittanceId { get; set; }
        public long? CheckId { get; set; }
        public long? PaymentId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Check Check { get; set; }
        public Payment Payment { get; set; }
        public Remittance Remittance { get; set; }
        public Transaction Transaction { get; set; }
    }
}
