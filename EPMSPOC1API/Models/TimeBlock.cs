using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class TimeBlock
    {
        public TimeBlock()
        {
            MasterCalendar = new HashSet<MasterCalendar>();
            TimeSlot = new HashSet<TimeSlot>();
        }

        public long TimeBlockId { get; set; }
        public int? TimeBlock1 { get; set; }
        public string TimeBlockDescription { get; set; }
        public string TimeBlockCode { get; set; }
        public string TimeBlockName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<MasterCalendar> MasterCalendar { get; set; }
        public ICollection<TimeSlot> TimeSlot { get; set; }
    }
}
