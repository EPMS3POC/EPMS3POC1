using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class PaymentMode
    {
        public PaymentMode()
        {
            Payment = new HashSet<Payment>();
        }

        public long PaymentModeId { get; set; }
        public string PaymentModeDescription { get; set; }
        public string PaymentModeCode { get; set; }
        public string PaymentModeName { get; set; }
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
