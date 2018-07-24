using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Telecom
    {
        public Telecom()
        {
            TelecomVendor = new HashSet<TelecomVendor>();
        }

        public long TelecomId { get; set; }
        public long FacilityId { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string TelecomDescription { get; set; }
        public string TelecomCode { get; set; }
        public string TelecomName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Facility Facility { get; set; }
        public ICollection<TelecomVendor> TelecomVendor { get; set; }
    }
}
