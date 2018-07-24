using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class VitalState
    {
        public VitalState()
        {
            BloodPressureReading = new HashSet<BloodPressureReading>();
        }

        public long VitalStateId { get; set; }
        public long PatientId { get; set; }
        public DateTime? VitalDate { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Height { get; set; }
        public decimal? Temperature { get; set; }
        public int? Pulse { get; set; }
        public string VitalStateDescription { get; set; }
        public int? Respiration { get; set; }
        public decimal? Bmi { get; set; }
        public int? HeartRate { get; set; }
        public int? SeverityOfPain { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? EmployeeId { get; set; }
        public long? WeightMeasurementId { get; set; }
        public long? HeightMeasurementId { get; set; }
        public long? PulseRhythmTypeId { get; set; }
        public long? BmistatusId { get; set; }

        public Bmistatus Bmistatus { get; set; }
        public Employee Employee { get; set; }
        public HeightMeasurement HeightMeasurement { get; set; }
        public Patient Patient { get; set; }
        public PulseRhythmType PulseRhythmType { get; set; }
        public WeightMeasurement WeightMeasurement { get; set; }
        public ICollection<BloodPressureReading> BloodPressureReading { get; set; }
    }
}
