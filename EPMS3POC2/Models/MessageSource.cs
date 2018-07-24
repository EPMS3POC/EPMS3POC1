using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class MessageSource
    {
        public MessageSource()
        {
            MessageSourceMap = new HashSet<MessageSourceMap>();
        }

        public long MessageSourceId { get; set; }
        public string Module { get; set; }
        public string Object { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? ApplicationId { get; set; }

        public Application Application { get; set; }
        public ICollection<MessageSourceMap> MessageSourceMap { get; set; }
    }
}
