using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class ProviderType
    {
        public ProviderType()
        {
            AppointmentClass = new HashSet<AppointmentClass>();
            Employee = new HashSet<Employee>();
        }

        public long ProviderTypeId { get; set; }
        public string ProviderTypeCode { get; set; }
        public string ProviderTypeName { get; set; }
        public string ProviderTypeDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<AppointmentClass> AppointmentClass { get; set; }
        public ICollection<Employee> Employee { get; set; }
    }
}
