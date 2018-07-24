using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class MessageSourceMap
    {
        public long MessageSourceMapId { get; set; }
        public long MessageId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? MessageSourceId { get; set; }

        public Message Message { get; set; }
        public MessageSource MessageSource { get; set; }
    }
}
