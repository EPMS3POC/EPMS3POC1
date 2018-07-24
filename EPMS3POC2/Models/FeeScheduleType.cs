using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class FeeScheduleType
    {
        public FeeScheduleType()
        {
            FeeSchedule = new HashSet<FeeSchedule>();
        }

        public long FeeScheduleTypeId { get; set; }
        public string FeeScheduleTypeDescription { get; set; }
        public string FeeScheduleTypeCode { get; set; }
        public string FeeScheduleTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<FeeSchedule> FeeSchedule { get; set; }
    }
}
