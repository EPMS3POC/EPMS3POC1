using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class AddressType
    {
        public AddressType()
        {
            InsuranceAddress = new HashSet<InsuranceAddress>();
            PersonAddress = new HashSet<PersonAddress>();
        }

        public long AddressTypeId { get; set; }
        public string AddressTypeCode { get; set; }
        public string AddressTypeName { get; set; }
        public string AddressTypeDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<InsuranceAddress> InsuranceAddress { get; set; }
        public ICollection<PersonAddress> PersonAddress { get; set; }
    }
}
