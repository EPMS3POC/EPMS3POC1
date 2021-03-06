﻿using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class ReviewReason
    {
        public ReviewReason()
        {
            ChartAudit = new HashSet<ChartAudit>();
        }

        public long ReviewReasonId { get; set; }
        public string ReviewReasonDescription { get; set; }
        public string ReviewReasonCode { get; set; }
        public string ReviewReasonName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<ChartAudit> ChartAudit { get; set; }
    }
}
