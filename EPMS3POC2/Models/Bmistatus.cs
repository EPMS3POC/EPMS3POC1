using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Bmistatus
    {
        public Bmistatus()
        {
            VitalState = new HashSet<VitalState>();
        }

        public long BmistatusId { get; set; }
        public string BmistatusDescription { get; set; }
        public string BmistatusCode { get; set; }
        public string BmistatusName { get; set; }
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
