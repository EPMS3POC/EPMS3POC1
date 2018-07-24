using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class BillingSoftware
    {
        public BillingSoftware()
        {
            ClearingHouse = new HashSet<ClearingHouse>();
        }

        public long BillingSoftwareId { get; set; }
        public string CustomerKey { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<ClearingHouse> ClearingHouse { get; set; }
    }
}
