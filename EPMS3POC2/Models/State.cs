using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class State
    {
        public State()
        {
            Address = new HashSet<Address>();
            County = new HashSet<County>();
            DocumentMapping = new HashSet<DocumentMapping>();
            ZipCode = new HashSet<ZipCode>();
        }

        public long StateId { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string StateDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? CountryId { get; set; }
        public int? TaxRate { get; set; }

        public Country Country { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<County> County { get; set; }
        public ICollection<DocumentMapping> DocumentMapping { get; set; }
        public ICollection<ZipCode> ZipCode { get; set; }
    }
}
