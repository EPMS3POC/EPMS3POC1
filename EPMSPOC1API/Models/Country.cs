using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Country
    {
        public Country()
        {
            State = new HashSet<State>();
            ZipCode = new HashSet<ZipCode>();
        }

        public long CountryId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string CountryDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public int? TaxRate { get; set; }
        public string CountryCode3 { get; set; }
        public string CountryTelephoneCode { get; set; }

        public ICollection<State> State { get; set; }
        public ICollection<ZipCode> ZipCode { get; set; }
    }
}
