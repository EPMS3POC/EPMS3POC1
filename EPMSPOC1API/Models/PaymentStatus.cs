using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class PaymentStatus
    {
        public PaymentStatus()
        {
            Payment = new HashSet<Payment>();
        }

        public long PaymentStatusId { get; set; }
        public string PaymentStatusCode { get; set; }
        public string PaymentStatusName { get; set; }
        public string PaymentStatusDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Payment> Payment { get; set; }
    }
}
