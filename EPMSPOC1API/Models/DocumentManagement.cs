using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class DocumentManagement
    {
        public long DocumentManagementId { get; set; }
        public long? PatientId { get; set; }
        public long DocumentCategoryId { get; set; }
        public long DocumentSubCategoryId { get; set; }
        public string DocumentPath { get; set; }
        public DateTime? EstimateRunDateTime { get; set; }
        public string TemplateName { get; set; }
        public string TemplateContent { get; set; }
        public string Notes { get; set; }
        public DateTime? OnlineUploadTime { get; set; }
        public DateTime? OfflineUploadTime { get; set; }
        public int? OnlineOrOfflineStatus { get; set; }
        public int? OrderId { get; set; }
        public string RadiologistDetails { get; set; }
        public string InterpretationDetails { get; set; }
        public int? SignedStatusId { get; set; }
        public string ConsentStatus { get; set; }
        public long? FacilityId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public DocumentCategory DocumentCategory { get; set; }
        public DocumentSubCategory DocumentSubCategory { get; set; }
        public Facility Facility { get; set; }
        public Patient Patient { get; set; }
    }
}
