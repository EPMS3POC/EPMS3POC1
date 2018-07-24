using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class TelecomVendor
    {
        public long TelecomVendorId { get; set; }
        public long TelecomId { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Ipaddress { get; set; }
        public string Ispipgateway { get; set; }
        public string IspphoneNumber { get; set; }
        public string IspserviceType { get; set; }
        public string Ispvendor { get; set; }
        public string TelecomVendorDescription { get; set; }
        public string TelecomVendorCode { get; set; }
        public string TelecomVendorName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Telecom Telecom { get; set; }
    }
}
