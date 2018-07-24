using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Patient
    {
        public Patient()
        {
            AppointmentPreference = new HashSet<AppointmentPreference>();
            ChartReviewItemHistory = new HashSet<ChartReviewItemHistory>();
            CoverageBook = new HashSet<CoverageBook>();
            DocumentManagement = new HashSet<DocumentManagement>();
            OrderImage = new HashSet<OrderImage>();
            PatientChartReview = new HashSet<PatientChartReview>();
            PatientConsentForm = new HashSet<PatientConsentForm>();
            PatientDocumentPath = new HashSet<PatientDocumentPath>();
            PatientMedicalAlert = new HashSet<PatientMedicalAlert>();
            PatientMedicalHistory = new HashSet<PatientMedicalHistory>();
            PatientNote = new HashSet<PatientNote>();
            PatientPhoto = new HashSet<PatientPhoto>();
            PatientPreference = new HashSet<PatientPreference>();
            PatientTreatmentPlan = new HashSet<PatientTreatmentPlan>();
            PerioExam = new HashSet<PerioExam>();
            Relationship = new HashSet<Relationship>();
            VitalState = new HashSet<VitalState>();
        }

        public long PatientId { get; set; }
        public int? PatientDoseSpotIdentifier { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long AccountId { get; set; }
        public string PatientCode { get; set; }

        public Account Account { get; set; }
        public ICollection<AppointmentPreference> AppointmentPreference { get; set; }
        public ICollection<ChartReviewItemHistory> ChartReviewItemHistory { get; set; }
        public ICollection<CoverageBook> CoverageBook { get; set; }
        public ICollection<DocumentManagement> DocumentManagement { get; set; }
        public ICollection<OrderImage> OrderImage { get; set; }
        public ICollection<PatientChartReview> PatientChartReview { get; set; }
        public ICollection<PatientConsentForm> PatientConsentForm { get; set; }
        public ICollection<PatientDocumentPath> PatientDocumentPath { get; set; }
        public ICollection<PatientMedicalAlert> PatientMedicalAlert { get; set; }
        public ICollection<PatientMedicalHistory> PatientMedicalHistory { get; set; }
        public ICollection<PatientNote> PatientNote { get; set; }
        public ICollection<PatientPhoto> PatientPhoto { get; set; }
        public ICollection<PatientPreference> PatientPreference { get; set; }
        public ICollection<PatientTreatmentPlan> PatientTreatmentPlan { get; set; }
        public ICollection<PerioExam> PerioExam { get; set; }
        public ICollection<Relationship> Relationship { get; set; }
        public ICollection<VitalState> VitalState { get; set; }
    }
}
