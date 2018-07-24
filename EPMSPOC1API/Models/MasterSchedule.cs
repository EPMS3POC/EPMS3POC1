using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class MasterSchedule
    {
        public MasterSchedule()
        {
            MasterCalendar = new HashSet<MasterCalendar>();
        }

        public long MasterScheduleId { get; set; }
        public long FacilityId { get; set; }
        public string MasterScheduleDescription { get; set; }
        public string MasterScheduleCode { get; set; }
        public string MasterScheduleName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Facility Facility { get; set; }
        public ICollection<MasterCalendar> MasterCalendar { get; set; }
    }
}
