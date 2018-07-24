using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class City
    {
        public City()
        {
            Address = new HashSet<Address>();
        }

        public long CityId { get; set; }
        public string CityName { get; set; }
        public string CityDescription { get; set; }
        public string CityCode { get; set; }
        public int? TaxRate { get; set; }
        public long? CountyId { get; set; }
        public long? ZipCodeId { get; set; }

        public County County { get; set; }
        public ZipCode ZipCode { get; set; }
        public ICollection<Address> Address { get; set; }
    }
}
