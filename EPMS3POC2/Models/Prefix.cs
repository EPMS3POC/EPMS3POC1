using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Prefix
    {
        public Prefix()
        {
            Person = new HashSet<Person>();
        }

        public long PrefixId { get; set; }
        public string PrefixCode { get; set; }
        public string PrefixName { get; set; }
        public string PrefixDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Person> Person { get; set; }
    }
}
