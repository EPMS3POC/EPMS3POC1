using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class ChartReviewItemType
    {
        public ChartReviewItemType()
        {
            ChartReviewItemHistory = new HashSet<ChartReviewItemHistory>();
        }

        public long ChartReviewItemTypeId { get; set; }
        public string ChartReviewItemTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? ChartReviewCategoryId { get; set; }

        public ChartReviewCategory ChartReviewCategory { get; set; }
        public ICollection<ChartReviewItemHistory> ChartReviewItemHistory { get; set; }
    }
}
