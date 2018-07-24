using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class EntityMappingLog
    {
        public long EntityMappingLogId { get; set; }
        public long? EntityId { get; set; }
        public long? PreviousMappingId { get; set; }
        public DateTime? MappedDateTime { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Entity Entity { get; set; }
    }
}
