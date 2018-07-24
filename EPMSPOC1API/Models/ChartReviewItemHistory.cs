using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class ChartReviewItemHistory
    {
        public long ChartReviewItemHistoryId { get; set; }
        public long ChartReviewStatusId { get; set; }
        public long? PatientId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? PatientChartReviewId { get; set; }
        public long? ChartReviewItemTypeId { get; set; }

        public ChartReviewItemType ChartReviewItemType { get; set; }
        public ChartReviewStatus ChartReviewStatus { get; set; }
        public Patient Patient { get; set; }
        public PatientChartReview PatientChartReview { get; set; }
    }
}
