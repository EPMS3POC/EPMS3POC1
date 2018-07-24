using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class MessageTarget
    {
        public long MessageTargetId { get; set; }
        public long MarketingId { get; set; }
        public int? RoleId { get; set; }
        public long MessageId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Marketing Marketing { get; set; }
        public Message Message { get; set; }
    }
}
