using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class MasterCalendar
    {
        public MasterCalendar()
        {
            FacilitySchedule = new HashSet<FacilitySchedule>();
        }

        public long MasterCalendarId { get; set; }
        public long MasterScheduleId { get; set; }
        public DateTime? MasterDate { get; set; }
        public long? TimeBlockId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public MasterSchedule MasterSchedule { get; set; }
        public TimeBlock TimeBlock { get; set; }
        public ICollection<FacilitySchedule> FacilitySchedule { get; set; }
    }
}
