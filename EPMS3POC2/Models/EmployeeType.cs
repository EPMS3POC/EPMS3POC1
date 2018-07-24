using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            Employee = new HashSet<Employee>();
        }

        public long EmployeeTypeId { get; set; }
        public string EmployeeTypeCode { get; set; }
        public string EmployeeTypeName { get; set; }
        public string EmployeeTypeDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
