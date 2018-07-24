using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class TimeSlot
    {
        public TimeSlot()
        {
            AppointmentTimeSlot = new HashSet<AppointmentTimeSlot>();
        }

        public long TimeSlotId { get; set; }
        public long OperatoryId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? BlockedDate { get; set; }
        public DateTime? TimeSlotDate { get; set; }
        public long? TimeBlockId { get; set; }
        public string TimeSlotDescription { get; set; }
        public string TimeSlotCode { get; set; }
        public string TimeSlotName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Operatory Operatory { get; set; }
        public TimeBlock TimeBlock { get; set; }
        public ICollection<AppointmentTimeSlot> AppointmentTimeSlot { get; set; }
    }
}
