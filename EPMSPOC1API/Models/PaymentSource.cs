using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class PaymentSource
    {
        public PaymentSource()
        {
            Payment = new HashSet<Payment>();
        }

        public long PaymentSourceId { get; set; }
        public string PaymentSourceDescription { get; set; }
        public string PaymentSourceCode { get; set; }
        public string PaymentSourceName { get; set; }
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
