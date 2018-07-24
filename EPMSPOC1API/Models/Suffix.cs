using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Suffix
    {
        public Suffix()
        {
            Person = new HashSet<Person>();
        }

        public long SuffixId { get; set; }
        public string SuffixCode { get; set; }
        public string SuffixName { get; set; }
        public string SuffixDescription { get; set; }
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
