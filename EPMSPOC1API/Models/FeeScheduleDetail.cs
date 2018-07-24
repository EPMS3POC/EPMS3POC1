using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class FeeScheduleDetail
    {
        public long FeeScheduleDetailId { get; set; }
        public decimal? FeeAmount { get; set; }
        public long? FeeScheduleId { get; set; }
        public long? MasterProcedureId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public FeeSchedule FeeSchedule { get; set; }
        public MasterProcedure MasterProcedure { get; set; }
    }
}
