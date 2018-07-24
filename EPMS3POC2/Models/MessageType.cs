using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class MessageType
    {
        public MessageType()
        {
            Message = new HashSet<Message>();
        }

        public long MessageTypeId { get; set; }
        public string MessageTypeDescription { get; set; }
        public string MessageTypeCode { get; set; }
        public string MessageTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Message> Message { get; set; }
    }
}
