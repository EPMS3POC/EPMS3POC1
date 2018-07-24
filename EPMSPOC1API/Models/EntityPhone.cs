using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class EntityPhone
    {
        public long EntityPhoneId { get; set; }
        public long? PhoneId { get; set; }
        public long? EntityId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Entity Entity { get; set; }
        public Phone Phone { get; set; }
    }
}
