using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class PatientChartReview
    {
        public PatientChartReview()
        {
            ChartReviewCategoryHistory = new HashSet<ChartReviewCategoryHistory>();
            ChartReviewItemHistory = new HashSet<ChartReviewItemHistory>();
        }

        public long PatientChartReviewId { get; set; }
        public long? AppointmentNumber { get; set; }
        public DateTime? StartTimeStamp { get; set; }
        public DateTime? EndTimeStamp { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? PatientId { get; set; }

        public Patient Patient { get; set; }
        public ICollection<ChartReviewCategoryHistory> ChartReviewCategoryHistory { get; set; }
        public ICollection<ChartReviewItemHistory> ChartReviewItemHistory { get; set; }
    }
}
