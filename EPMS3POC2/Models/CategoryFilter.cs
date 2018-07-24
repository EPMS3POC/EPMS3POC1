using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class CategoryFilter
    {
        public CategoryFilter()
        {
            PatientProcedure = new HashSet<PatientProcedure>();
        }

        public long CategoryFilterId { get; set; }
        public string CategoryFilterCode { get; set; }
        public string CategoryFilterName { get; set; }
        public string CategoryFilterDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<PatientProcedure> PatientProcedure { get; set; }
    }
}
