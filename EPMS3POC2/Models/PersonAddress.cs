using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class PersonAddress
    {
        public long PersonAddressId { get; set; }
        public long PersonId { get; set; }
        public long AddressTypeId { get; set; }
        public long AddressId { get; set; }
        public string PersonAddressComment { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Address Address { get; set; }
        public AddressType AddressType { get; set; }
        public Person Person { get; set; }
    }
}
