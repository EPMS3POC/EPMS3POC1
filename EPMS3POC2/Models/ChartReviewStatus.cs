using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class ChartReviewStatus
    {
        public ChartReviewStatus()
        {
            ChartReviewCategoryHistory = new HashSet<ChartReviewCategoryHistory>();
            ChartReviewItemHistory = new HashSet<ChartReviewItemHistory>();
        }

        public long ChartReviewStatusId { get; set; }
        public string ChartReviewStatusCode { get; set; }
        public string ChartReviewStatusName { get; set; }
        public string ChartReviewStatusDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<ChartReviewCategoryHistory> ChartReviewCategoryHistory { get; set; }
        public ICollection<ChartReviewItemHistory> ChartReviewItemHistory { get; set; }
    }
}
