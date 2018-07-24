using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class PatientProcedureLog
    {
        public PatientProcedureLog()
        {
            TransactionDebit = new HashSet<TransactionDebit>();
        }

        public long PatientProcedureLogId { get; set; }
        public long? PatientProcedureId { get; set; }
        public long? PatientTreatmentPlanId { get; set; }
        public long? VisitId { get; set; }
        public string Surface { get; set; }
        public int? Tooth { get; set; }
        public string ToothRange { get; set; }
        public int? MesialShift { get; set; }
        public int? MesialRotate { get; set; }
        public int? OcclusalShift { get; set; }
        public int? OcclusalRotate { get; set; }
        public int? FacialShift { get; set; }
        public int? FacialRotate { get; set; }
        public int? ProcedureOption { get; set; }
        public long FacilityId { get; set; }
        public DateTime? DateOfService { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? PatientId { get; set; }
        public long? PatientToothId { get; set; }
        public long? AccountId { get; set; }
        public long? EntityId { get; set; }
        public long? OrganizationId { get; set; }

        public PatientProcedure PatientProcedure { get; set; }
        public PatientTooth PatientTooth { get; set; }
        public ICollection<TransactionDebit> TransactionDebit { get; set; }
    }
}
