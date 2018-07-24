using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Message
    {
        public Message()
        {
            MessageSourceMap = new HashSet<MessageSourceMap>();
            MessageTarget = new HashSet<MessageTarget>();
        }

        public long MessageId { get; set; }
        public long MessageTypeId { get; set; }
        public int? SeverityLevel { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string MessageDescription { get; set; }
        public string MessageCode { get; set; }
        public string MessageName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public MessageType MessageType { get; set; }
        public ICollection<MessageSourceMap> MessageSourceMap { get; set; }
        public ICollection<MessageTarget> MessageTarget { get; set; }
    }
}
