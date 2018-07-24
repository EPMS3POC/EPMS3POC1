using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class CoverageBookType
    {
        public CoverageBookType()
        {
            CoverageBook = new HashSet<CoverageBook>();
        }

        public long CoverageBookTypeId { get; set; }
        public string CoverageBookTypeCode { get; set; }
        public string CoverageBookTypeName { get; set; }
        public string CoverageBookTypeDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<CoverageBook> CoverageBook { get; set; }
    }
}
