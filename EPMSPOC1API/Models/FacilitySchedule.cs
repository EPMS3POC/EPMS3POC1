using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class FacilitySchedule
    {
        public FacilitySchedule()
        {
            Employee = new HashSet<Employee>();
            OfficeHours = new HashSet<OfficeHours>();
            Operatory = new HashSet<Operatory>();
        }

        public long FacilityScheduleId { get; set; }
        public long FacilityId { get; set; }
        public long? TimeZoneId { get; set; }
        public long? MasterCalendarId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Facility Facility { get; set; }
        public MasterCalendar MasterCalendar { get; set; }
        public TimeZone TimeZone { get; set; }
        public ICollection<Employee> Employee { get; set; }
        public ICollection<OfficeHours> OfficeHours { get; set; }
        public ICollection<Operatory> Operatory { get; set; }
    }
}
