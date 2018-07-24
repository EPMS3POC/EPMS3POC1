using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class PulseRhythmType
    {
        public PulseRhythmType()
        {
            VitalState = new HashSet<VitalState>();
        }

        public long PulseRhythmTypeId { get; set; }
        public string PulseRhythmTypeDescription { get; set; }
        public string PulseRhythmTypeCode { get; set; }
        public string PulseRhythmTypeName { get; set; }
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
