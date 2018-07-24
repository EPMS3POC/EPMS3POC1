using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class BloodPressureActivity
    {
        public BloodPressureActivity()
        {
            BloodPressureReading = new HashSet<BloodPressureReading>();
        }

        public long BloodPressureActivityId { get; set; }
        public string BloodPressureActivityDescription { get; set; }
        public string BloodPressureActivityCode { get; set; }
        public string BloodPressureActivityName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<BloodPressureReading> BloodPressureReading { get; set; }
    }
}
