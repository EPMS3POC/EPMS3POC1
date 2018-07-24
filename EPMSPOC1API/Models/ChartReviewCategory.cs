using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class ChartReviewCategory
    {
        public ChartReviewCategory()
        {
            ChartReviewCategoryHistory = new HashSet<ChartReviewCategoryHistory>();
            ChartReviewItemType = new HashSet<ChartReviewItemType>();
        }

        public long ChartReviewCategoryId { get; set; }
        public string ChartReviewCategoryDescription { get; set; }
        public string ChartReviewCategoryCode { get; set; }
        public string ChartReviewCategoryName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<ChartReviewCategoryHistory> ChartReviewCategoryHistory { get; set; }
        public ICollection<ChartReviewItemType> ChartReviewItemType { get; set; }
    }
}
