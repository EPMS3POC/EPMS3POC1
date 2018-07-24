using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class PerioChart
    {
        public PerioChart()
        {
            PerioMeasure = new HashSet<PerioMeasure>();
            PerioMissingTooth = new HashSet<PerioMissingTooth>();
        }

        public long PerioChartId { get; set; }
        public string PerioChartName { get; set; }
        public short? Score1 { get; set; }
        public short? Score2 { get; set; }
        public short? Score3 { get; set; }
        public short? Score4 { get; set; }
        public short? Score5 { get; set; }
        public short? Score6 { get; set; }
        public short? IsCompleted { get; set; }
        public long? Laaid { get; set; }
        public long? PerioExamId { get; set; }
        public long? PatientToothId { get; set; }
        public long? ToothTypeId { get; set; }
        public long? PerioChangeToothId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? ConditionBySextantId { get; set; }
        public long? ConditionsOnAllTeethId { get; set; }
        public long? BrushTypeId { get; set; }
        public long? TobaccoTypeId { get; set; }
        public long? CaseTypeId { get; set; }

        public BrushType BrushType { get; set; }
        public CaseType CaseType { get; set; }
        public ConditionBySextant ConditionBySextant { get; set; }
        public ConditionsOnAllTeeth ConditionsOnAllTeeth { get; set; }
        public PatientTooth PatientTooth { get; set; }
        public PerioChangeTooth PerioChangeTooth { get; set; }
        public PerioExam PerioExam { get; set; }
        public TobaccoType TobaccoType { get; set; }
        public ToothType ToothType { get; set; }
        public ICollection<PerioMeasure> PerioMeasure { get; set; }
        public ICollection<PerioMissingTooth> PerioMissingTooth { get; set; }
    }
}
