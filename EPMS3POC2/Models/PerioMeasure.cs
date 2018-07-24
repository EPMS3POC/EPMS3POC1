using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class PerioMeasure
    {
        public long PerioMeasureId { get; set; }
        public long? PerioMeasureNumber { get; set; }
        public int? SequenceType { get; set; }
        public int? ToothValue { get; set; }
        public int? Mbvalue { get; set; }
        public int? Bvalue { get; set; }
        public int? Dbvalue { get; set; }
        public int? Mlvalue { get; set; }
        public int? Lvalue { get; set; }
        public int? Dlvalue { get; set; }
        public long? PatientToothId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int? RecordStatus { get; set; }
        public long? PerioChartId { get; set; }

        public PatientTooth PatientTooth { get; set; }
        public PerioChart PerioChart { get; set; }
    }
}
