using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class PatientTooth
    {
        public PatientTooth()
        {
            PatientProcedure = new HashSet<PatientProcedure>();
            PatientProcedureLog = new HashSet<PatientProcedureLog>();
            PatientTreatmentPlan = new HashSet<PatientTreatmentPlan>();
            PerioChart = new HashSet<PerioChart>();
            PerioMeasure = new HashSet<PerioMeasure>();
            PerioMissingTooth = new HashSet<PerioMissingTooth>();
        }

        public long PatientToothId { get; set; }
        public string PatientToothCode { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<PatientProcedure> PatientProcedure { get; set; }
        public ICollection<PatientProcedureLog> PatientProcedureLog { get; set; }
        public ICollection<PatientTreatmentPlan> PatientTreatmentPlan { get; set; }
        public ICollection<PerioChart> PerioChart { get; set; }
        public ICollection<PerioMeasure> PerioMeasure { get; set; }
        public ICollection<PerioMissingTooth> PerioMissingTooth { get; set; }
    }
}
