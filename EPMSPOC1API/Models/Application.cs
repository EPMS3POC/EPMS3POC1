using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Application
    {
        public Application()
        {
            MessageSource = new HashSet<MessageSource>();
        }

        public long ApplicationId { get; set; }
        public string ApplicationDescription { get; set; }
        public string ApplicationCode { get; set; }
        public string ApplicationName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<MessageSource> MessageSource { get; set; }
    }
}
