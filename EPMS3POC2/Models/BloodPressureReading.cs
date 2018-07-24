using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class BloodPressureReading
    {
        public long BloodPressureReadingId { get; set; }
        public long? BloodPressureActivityId { get; set; }
        public long? VitalStateId { get; set; }
        public int? SystolicPressure { get; set; }
        public int? DiastolicPressure { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public BloodPressureActivity BloodPressureActivity { get; set; }
        public VitalState VitalState { get; set; }
    }
}
