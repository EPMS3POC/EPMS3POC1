﻿using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Cotsvendor
    {
        public long CotsvendorId { get; set; }
        public string MerchantIdValue { get; set; }
        public string MerchantName { get; set; }
        public long? FacilityId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Facility Facility { get; set; }
    }
}
