using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Facility
    {
        public Facility()
        {
            Account = new HashSet<Account>();
            Accounting = new HashSet<Accounting>();
            ConsentForm = new HashSet<ConsentForm>();
            Cotsvendor = new HashSet<Cotsvendor>();
            DiagnosticCenter = new HashSet<DiagnosticCenter>();
            DocumentManagement = new HashSet<DocumentManagement>();
            DocumentMapping = new HashSet<DocumentMapping>();
            Employee = new HashSet<Employee>();
            FacilityAddress = new HashSet<FacilityAddress>();
            FacilityPhone = new HashSet<FacilityPhone>();
            FacilityPreference = new HashSet<FacilityPreference>();
            FacilitySchedule = new HashSet<FacilitySchedule>();
            Finance = new HashSet<Finance>();
            Marketing = new HashSet<Marketing>();
            MasterSchedule = new HashSet<MasterSchedule>();
            PatientConsentForm = new HashSet<PatientConsentForm>();
            Prospect = new HashSet<Prospect>();
            RealEstate = new HashSet<RealEstate>();
            Telecom = new HashSet<Telecom>();
            User = new HashSet<User>();
        }

        public long FacilityId { get; set; }
        public long EntityId { get; set; }
        public long? LocationStatusId { get; set; }
        public string FacilityCode { get; set; }
        public string FacilityName { get; set; }
        public string FacilityDescription { get; set; }
        public string WebsiteAddress { get; set; }
        public string EmailIdentifier { get; set; }
        public string ContactName { get; set; }
        public string ReportCategory { get; set; }
        public int? ExamTime { get; set; }
        public int? XRayTime { get; set; }
        public int? CcforceAppointmentAm { get; set; }
        public int? CcforceAppointmentPm { get; set; }
        public string DoseSpotClinicKey { get; set; }
        public string DoseSpotClinicId { get; set; }
        public short? IsWheelChairAccess { get; set; }
        public short? IsPublishFacility { get; set; }
        public short? IsHeadQuarter { get; set; }
        public string ClinicProxyUser { get; set; }
        public int? AncillaryStaffCount { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public LocationStatus LocationStatus { get; set; }
        public ICollection<Account> Account { get; set; }
        public ICollection<Accounting> Accounting { get; set; }
        public ICollection<ConsentForm> ConsentForm { get; set; }
        public ICollection<Cotsvendor> Cotsvendor { get; set; }
        public ICollection<DiagnosticCenter> DiagnosticCenter { get; set; }
        public ICollection<DocumentManagement> DocumentManagement { get; set; }
        public ICollection<DocumentMapping> DocumentMapping { get; set; }
        public ICollection<Employee> Employee { get; set; }
        public ICollection<FacilityAddress> FacilityAddress { get; set; }
        public ICollection<FacilityPhone> FacilityPhone { get; set; }
        public ICollection<FacilityPreference> FacilityPreference { get; set; }
        public ICollection<FacilitySchedule> FacilitySchedule { get; set; }
        public ICollection<Finance> Finance { get; set; }
        public ICollection<Marketing> Marketing { get; set; }
        public ICollection<MasterSchedule> MasterSchedule { get; set; }
        public ICollection<PatientConsentForm> PatientConsentForm { get; set; }
        public ICollection<Prospect> Prospect { get; set; }
        public ICollection<RealEstate> RealEstate { get; set; }
        public ICollection<Telecom> Telecom { get; set; }
        public ICollection<User> User { get; set; }
    }
}
