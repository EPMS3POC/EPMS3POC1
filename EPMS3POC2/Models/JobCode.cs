using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class JobCode
    {
        public long JobCodeId { get; set; }
        public long? RoleId { get; set; }
        public string JobCodeCode { get; set; }
        public string JobCodeName { get; set; }
        public string JobCodeDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Role Role { get; set; }
    }
}
