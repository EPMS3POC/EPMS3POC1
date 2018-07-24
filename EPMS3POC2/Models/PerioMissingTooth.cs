using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class PerioMissingTooth
    {
        public long PerioMissingToothId { get; set; }
        public int? ToothNumber { get; set; }
        public short? IsPerioMissingTooth { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? PerioChartId { get; set; }
        public long? PatientToothId { get; set; }

        public PatientTooth PatientTooth { get; set; }
        public PerioChart PerioChart { get; set; }
    }
}
