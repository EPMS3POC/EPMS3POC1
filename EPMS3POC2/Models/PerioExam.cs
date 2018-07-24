using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class PerioExam
    {
        public PerioExam()
        {
            PerioChart = new HashSet<PerioChart>();
            PerioNote = new HashSet<PerioNote>();
        }

        public long PerioExamId { get; set; }
        public long? PerioExamNumber { get; set; }
        public DateTime? PerioExamDate { get; set; }
        public int? FlossingsPerDay { get; set; }
        public int? BrushesPerDay { get; set; }
        public long? EmployeeId { get; set; }
        public long? PatientId { get; set; }
        public string Diagnosis { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Employee Employee { get; set; }
        public Patient Patient { get; set; }
        public ICollection<PerioChart> PerioChart { get; set; }
        public ICollection<PerioNote> PerioNote { get; set; }
    }
}
