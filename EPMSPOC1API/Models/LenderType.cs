using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class LenderType
    {
        public LenderType()
        {
            Lender = new HashSet<Lender>();
        }

        public long LenderTypeId { get; set; }
        public string LenderTypeName { get; set; }
        public string LenderTypeDescription { get; set; }
        public string LenderTypeCode { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Lender> Lender { get; set; }
    }
}
