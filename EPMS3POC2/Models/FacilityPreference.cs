using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class FacilityPreference
    {
        public long FacilityPreferenceId { get; set; }
        public long? FacilityId { get; set; }
        public long? ClearingHouseId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ClearingHouse ClearingHouse { get; set; }
        public Facility Facility { get; set; }
    }
}
