using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class County
    {
        public County()
        {
            Address = new HashSet<Address>();
            City = new HashSet<City>();
        }

        public long CountyId { get; set; }
        public string CountyCode { get; set; }
        public string CountyName { get; set; }
        public string CountyDescription { get; set; }
        public long? StateId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public int? TaxRate { get; set; }

        public State State { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<City> City { get; set; }
    }
}
