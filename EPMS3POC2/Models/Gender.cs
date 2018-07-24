using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Person = new HashSet<Person>();
        }

        public long GenderId { get; set; }
        public string GenderCode { get; set; }
        public string GenderName { get; set; }
        public string GenderDescription { get; set; }
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
