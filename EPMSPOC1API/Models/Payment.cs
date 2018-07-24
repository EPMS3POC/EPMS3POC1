using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Payment
    {
        public Payment()
        {
            TransactionCredit = new HashSet<TransactionCredit>();
        }

        public long PaymentId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public long? PaymentModeId { get; set; }
        public string PaymentReference { get; set; }
        public decimal? PaymentAmount { get; set; }
        public string PaymentComments { get; set; }
        public long? PaymentStatusId { get; set; }
        public decimal? PostedAmount { get; set; }
        public decimal? UnAppliedAmount { get; set; }
        public long? PaymentSourceId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public PaymentMode PaymentMode { get; set; }
        public PaymentSource PaymentSource { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public ICollection<TransactionCredit> TransactionCredit { get; set; }
    }
}
