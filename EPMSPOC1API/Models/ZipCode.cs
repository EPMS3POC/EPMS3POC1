using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class ZipCode
    {
        public ZipCode()
        {
            Address = new HashSet<Address>();
            City = new HashSet<City>();
        }

        public long ZipCodeId { get; set; }
        public string ZipCode1 { get; set; }
        public string ZipExtension { get; set; }
        public string ZipCodeName { get; set; }
        public string ZipCodeDescription { get; set; }
        public long? CountryId { get; set; }
        public long? StateId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Country Country { get; set; }
        public State State { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<City> City { get; set; }
    }
}
