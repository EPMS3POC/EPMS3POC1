using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class WeightMeasurement
    {
        public WeightMeasurement()
        {
            VitalState = new HashSet<VitalState>();
        }

        public long WeightMeasurementId { get; set; }
        public string WeightMeasurementCode { get; set; }
        public string WeightMeasurementName { get; set; }
        public string WeightMeasurementDescription { get; set; }
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
