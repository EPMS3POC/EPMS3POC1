using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Appointment
    {
        public Appointment()
        {
            AppointmentNoShowFee = new HashSet<AppointmentNoShowFee>();
            AppointmentStatusLog = new HashSet<AppointmentStatusLog>();
            AppointmentTimeSlot = new HashSet<AppointmentTimeSlot>();
            ChartAudit = new HashSet<ChartAudit>();
            CheckInNote = new HashSet<CheckInNote>();
            Confirmation = new HashSet<Confirmation>();
            ExcuseNote = new HashSet<ExcuseNote>();
        }

        public long AppointmentId { get; set; }
        public long? VisitId { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string CallReminderStatus { get; set; }
        public DateTime? CreateAppointmentDateTime { get; set; }
        public long? AppointmentTypeId { get; set; }
        public decimal? RevenueAmount { get; set; }
        public int? ChairMinutes { get; set; }
        public long? AppointmentStatusId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public AppointmentStatus AppointmentStatus { get; set; }
        public AppointmentType AppointmentType { get; set; }
        public Visit Visit { get; set; }
        public ICollection<AppointmentNoShowFee> AppointmentNoShowFee { get; set; }
        public ICollection<AppointmentStatusLog> AppointmentStatusLog { get; set; }
        public ICollection<AppointmentTimeSlot> AppointmentTimeSlot { get; set; }
        public ICollection<ChartAudit> ChartAudit { get; set; }
        public ICollection<CheckInNote> CheckInNote { get; set; }
        public ICollection<Confirmation> Confirmation { get; set; }
        public ICollection<ExcuseNote> ExcuseNote { get; set; }
    }
}
