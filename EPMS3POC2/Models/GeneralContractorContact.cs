using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class GeneralContractorContact
    {
        public long GeneralContractorContactId { get; set; }
        public long RealEstateId { get; set; }
        public long PersonId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Person Person { get; set; }
        public RealEstate RealEstate { get; set; }
    }
}
