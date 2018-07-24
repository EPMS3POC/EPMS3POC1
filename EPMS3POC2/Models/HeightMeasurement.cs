using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class HeightMeasurement
    {
        public HeightMeasurement()
        {
            VitalState = new HashSet<VitalState>();
        }

        public long HeightMeasurementId { get; set; }
        public string HeightMeasurementDescription { get; set; }
        public string HeightMeasurementCode { get; set; }
        public string HeightMeasurementName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<VitalState> VitalState { get; set; }
    }
}
