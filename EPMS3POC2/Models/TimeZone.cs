using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class TimeZone
    {
        public TimeZone()
        {
            FacilitySchedule = new HashSet<FacilitySchedule>();
        }

        public long TimeZoneId { get; set; }
        public string TimeZoneDescription { get; set; }
        public string TimeZoneCode { get; set; }
        public string TimeZoneName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<FacilitySchedule> FacilitySchedule { get; set; }
    }
}
