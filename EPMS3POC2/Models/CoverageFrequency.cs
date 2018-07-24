using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class CoverageFrequency
    {
        public long CoverageFrequencyId { get; set; }
        public string CoverageCategory { get; set; }
        public string CoverageSubCategory { get; set; }
        public short? TwoQuadrantsPerDay { get; set; }
        public short? FourQuadrantsPerDay { get; set; }
        public short? TwiceAyear { get; set; }
        public short? TwoPerTwelveMonth { get; set; }
        public int? CycleEveryMonth { get; set; }
        public int? AgeLimit { get; set; }
        public DateTime? LastDate { get; set; }
        public DateTime? NextDate { get; set; }
        public long? CoverageBookId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public CoverageBook CoverageBook { get; set; }
    }
}
