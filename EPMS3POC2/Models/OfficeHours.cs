using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class OfficeHours
    {
        public long OfficeHoursId { get; set; }
        public long FacilityScheduleId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? OfficeHoursDate { get; set; }
        public string OfficeHoursDescription { get; set; }
        public string OfficeHoursCode { get; set; }
        public string OfficeHoursName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public FacilitySchedule FacilitySchedule { get; set; }
    }
}
