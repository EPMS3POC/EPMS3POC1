using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EPMS3POC2.Models
{
    public class EPMSPOCContext : DbContext
    {
        public EPMSPOCContext(DbContextOptions<EPMSPOCContext> options) 
            : base(options)
        { }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Accounting> Accounting { get; set; }
        public virtual DbSet<AccountStatus> AccountStatus { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<Adjustment> Adjustment { get; set; }
        public virtual DbSet<AdjustmentCode> AdjustmentCode { get; set; }
        public virtual DbSet<AdjustmentType> AdjustmentType { get; set; }
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<AppointmentCancellationCode> AppointmentCancellationCode { get; set; }
        public virtual DbSet<AppointmentClass> AppointmentClass { get; set; }
        public virtual DbSet<AppointmentNoShowFee> AppointmentNoShowFee { get; set; }
        public virtual DbSet<AppointmentPreference> AppointmentPreference { get; set; }
        public virtual DbSet<AppointmentStatus> AppointmentStatus { get; set; }
        public virtual DbSet<AppointmentStatusLog> AppointmentStatusLog { get; set; }
        public virtual DbSet<AppointmentTimeSlot> AppointmentTimeSlot { get; set; }
        public virtual DbSet<AppointmentType> AppointmentType { get; set; }
        public virtual DbSet<BillingSoftware> BillingSoftware { get; set; }
        public virtual DbSet<BloodPressureActivity> BloodPressureActivity { get; set; }
        public virtual DbSet<BloodPressureReading> BloodPressureReading { get; set; }
        public virtual DbSet<Bmistatus> Bmistatus { get; set; }
        public virtual DbSet<BrushType> BrushType { get; set; }
        public virtual DbSet<BundledService> BundledService { get; set; }
        public virtual DbSet<BundledServiceMasterProcedure> BundledServiceMasterProcedure { get; set; }
        public virtual DbSet<CaseType> CaseType { get; set; }
        public virtual DbSet<CategoryFilter> CategoryFilter { get; set; }
        public virtual DbSet<ChartAudit> ChartAudit { get; set; }
        public virtual DbSet<ChartAuditStatus> ChartAuditStatus { get; set; }
        public virtual DbSet<ChartReviewCategory> ChartReviewCategory { get; set; }
        public virtual DbSet<ChartReviewCategoryHistory> ChartReviewCategoryHistory { get; set; }
        public virtual DbSet<ChartReviewItemHistory> ChartReviewItemHistory { get; set; }
        public virtual DbSet<ChartReviewItemType> ChartReviewItemType { get; set; }
        public virtual DbSet<ChartReviewStatus> ChartReviewStatus { get; set; }
        public virtual DbSet<Check> Check { get; set; }
        public virtual DbSet<CheckInNote> CheckInNote { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Claim> Claim { get; set; }
        public virtual DbSet<ClaimStatus> ClaimStatus { get; set; }
        public virtual DbSet<ClaimType> ClaimType { get; set; }
        public virtual DbSet<ClearingHouse> ClearingHouse { get; set; }
        public virtual DbSet<CollectionAccount> CollectionAccount { get; set; }
        public virtual DbSet<CollectionAgency> CollectionAgency { get; set; }
        public virtual DbSet<ConditionBySextant> ConditionBySextant { get; set; }
        public virtual DbSet<ConditionsOnAllTeeth> ConditionsOnAllTeeth { get; set; }
        public virtual DbSet<Confirmation> Confirmation { get; set; }
        public virtual DbSet<ConsentForm> ConsentForm { get; set; }
        public virtual DbSet<Cotsvendor> Cotsvendor { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<County> County { get; set; }
        public virtual DbSet<Coupon> Coupon { get; set; }
        public virtual DbSet<CouponAdjustment> CouponAdjustment { get; set; }
        public virtual DbSet<CouponOption> CouponOption { get; set; }
        public virtual DbSet<CouponOptionType> CouponOptionType { get; set; }
        public virtual DbSet<CouponStatus> CouponStatus { get; set; }
        public virtual DbSet<CouponType> CouponType { get; set; }
        public virtual DbSet<CoverageBook> CoverageBook { get; set; }
        public virtual DbSet<CoverageBookType> CoverageBookType { get; set; }
        public virtual DbSet<CoverageFrequency> CoverageFrequency { get; set; }
        public virtual DbSet<CoverageLimit> CoverageLimit { get; set; }
        public virtual DbSet<CoverageLimitType> CoverageLimitType { get; set; }
        public virtual DbSet<CoverageNetworkType> CoverageNetworkType { get; set; }
        public virtual DbSet<CoveragePlanType> CoveragePlanType { get; set; }
        public virtual DbSet<CoverageProcedure> CoverageProcedure { get; set; }
        public virtual DbSet<CoverageType> CoverageType { get; set; }
        public virtual DbSet<CreditAccount> CreditAccount { get; set; }
        public virtual DbSet<CreditAccountStatus> CreditAccountStatus { get; set; }
        public virtual DbSet<DemographicField> DemographicField { get; set; }
        public virtual DbSet<DemographicRule> DemographicRule { get; set; }
        public virtual DbSet<DiagnosticCenter> DiagnosticCenter { get; set; }
        public virtual DbSet<DiagnosticCenterAddress> DiagnosticCenterAddress { get; set; }
        public virtual DbSet<DiagnosticCenterContact> DiagnosticCenterContact { get; set; }
        public virtual DbSet<DiagnosticCenterPhone> DiagnosticCenterPhone { get; set; }
        public virtual DbSet<DiagnosticLocation> DiagnosticLocation { get; set; }
        public virtual DbSet<DiagnosticLocationType> DiagnosticLocationType { get; set; }
        public virtual DbSet<DiagnosticTestCategory> DiagnosticTestCategory { get; set; }
        public virtual DbSet<DiagnosticTestCategoryTarget> DiagnosticTestCategoryTarget { get; set; }
        public virtual DbSet<DiagnosticTestCategoryType> DiagnosticTestCategoryType { get; set; }
        public virtual DbSet<DocumentCategory> DocumentCategory { get; set; }
        public virtual DbSet<DocumentManagement> DocumentManagement { get; set; }
        public virtual DbSet<DocumentMapping> DocumentMapping { get; set; }
        public virtual DbSet<DocumentSubCategory> DocumentSubCategory { get; set; }
        public virtual DbSet<DocumentType> DocumentType { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeType> EmployeeType { get; set; }
        public virtual DbSet<Entity> Entity { get; set; }
        public virtual DbSet<EntityAddress> EntityAddress { get; set; }
        public virtual DbSet<EntityMappingLog> EntityMappingLog { get; set; }
        public virtual DbSet<EntityPhone> EntityPhone { get; set; }
        public virtual DbSet<ExcuseNote> ExcuseNote { get; set; }
        public virtual DbSet<Facility> Facility { get; set; }
        public virtual DbSet<FacilityAddress> FacilityAddress { get; set; }
        public virtual DbSet<FacilityLanguage> FacilityLanguage { get; set; }
        public virtual DbSet<FacilityPhone> FacilityPhone { get; set; }
        public virtual DbSet<FacilityPreference> FacilityPreference { get; set; }
        public virtual DbSet<FacilitySchedule> FacilitySchedule { get; set; }
        public virtual DbSet<FeeSchedule> FeeSchedule { get; set; }
        public virtual DbSet<FeeScheduleDetail> FeeScheduleDetail { get; set; }
        public virtual DbSet<FeeScheduleType> FeeScheduleType { get; set; }
        public virtual DbSet<Field> Field { get; set; }
        public virtual DbSet<Finance> Finance { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<GeneralContractorContact> GeneralContractorContact { get; set; }
        public virtual DbSet<GeoCode> GeoCode { get; set; }
        public virtual DbSet<Guarantor> Guarantor { get; set; }
        public virtual DbSet<HeightMeasurement> HeightMeasurement { get; set; }
        public virtual DbSet<IdentityProofType> IdentityProofType { get; set; }
        public virtual DbSet<Insurance> Insurance { get; set; }
        public virtual DbSet<InsuranceAddress> InsuranceAddress { get; set; }
        public virtual DbSet<InsuranceContact> InsuranceContact { get; set; }
        public virtual DbSet<InsuranceElectronicTransaction> InsuranceElectronicTransaction { get; set; }
        public virtual DbSet<InsuranceElectronicTransactionType> InsuranceElectronicTransactionType { get; set; }
        public virtual DbSet<InsurancePayer> InsurancePayer { get; set; }
        public virtual DbSet<InsurancePayerIdentity> InsurancePayerIdentity { get; set; }
        public virtual DbSet<InsurancePolicyType> InsurancePolicyType { get; set; }
        public virtual DbSet<InsuranceStageType> InsuranceStageType { get; set; }
        public virtual DbSet<JobCode> JobCode { get; set; }
        public virtual DbSet<LandLordContact> LandLordContact { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Ledger> Ledger { get; set; }
        public virtual DbSet<Lender> Lender { get; set; }
        public virtual DbSet<LenderType> LenderType { get; set; }
        public virtual DbSet<LocationStatus> LocationStatus { get; set; }
        public virtual DbSet<Marketing> Marketing { get; set; }
        public virtual DbSet<MasterCalendar> MasterCalendar { get; set; }
        public virtual DbSet<MasterPayee> MasterPayee { get; set; }
        public virtual DbSet<MasterPayer> MasterPayer { get; set; }
        public virtual DbSet<MasterProcedure> MasterProcedure { get; set; }
        public virtual DbSet<MasterSchedule> MasterSchedule { get; set; }
        public virtual DbSet<MasterTreatmentPlan> MasterTreatmentPlan { get; set; }
        public virtual DbSet<MedicalAlert> MedicalAlert { get; set; }
        public virtual DbSet<MedicalHistoryAnswerType> MedicalHistoryAnswerType { get; set; }
        public virtual DbSet<MedicalHistoryAnswerTypeValue> MedicalHistoryAnswerTypeValue { get; set; }
        public virtual DbSet<MedicalHistoryAnswerValue> MedicalHistoryAnswerValue { get; set; }
        public virtual DbSet<MedicalHistoryControlType> MedicalHistoryControlType { get; set; }
        public virtual DbSet<MedicalHistoryQuestion> MedicalHistoryQuestion { get; set; }
        public virtual DbSet<MedicalHistorySection> MedicalHistorySection { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MessageSource> MessageSource { get; set; }
        public virtual DbSet<MessageSourceMap> MessageSourceMap { get; set; }
        public virtual DbSet<MessageTarget> MessageTarget { get; set; }
        public virtual DbSet<MessageType> MessageType { get; set; }
        public virtual DbSet<Module> Module { get; set; }
        public virtual DbSet<OfficeHours> OfficeHours { get; set; }
        public virtual DbSet<Operatory> Operatory { get; set; }
        public virtual DbSet<OrderImage> OrderImage { get; set; }
        public virtual DbSet<OrderImageDiagnosticTestCategory> OrderImageDiagnosticTestCategory { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientChartReview> PatientChartReview { get; set; }
        public virtual DbSet<PatientConsentForm> PatientConsentForm { get; set; }
        public virtual DbSet<PatientDocumentPath> PatientDocumentPath { get; set; }
        public virtual DbSet<PatientMedicalAlert> PatientMedicalAlert { get; set; }
        public virtual DbSet<PatientMedicalHistory> PatientMedicalHistory { get; set; }
        public virtual DbSet<PatientMedicalHistoryDetail> PatientMedicalHistoryDetail { get; set; }
        public virtual DbSet<PatientNote> PatientNote { get; set; }
        public virtual DbSet<PatientNoteTemplate> PatientNoteTemplate { get; set; }
        public virtual DbSet<PatientNoteType> PatientNoteType { get; set; }
        public virtual DbSet<PatientPerson> PatientPerson { get; set; }
        public virtual DbSet<PatientPhoto> PatientPhoto { get; set; }
        public virtual DbSet<PatientPreference> PatientPreference { get; set; }
        public virtual DbSet<PatientProcedure> PatientProcedure { get; set; }
        public virtual DbSet<PatientProcedureLog> PatientProcedureLog { get; set; }
        public virtual DbSet<PatientTooth> PatientTooth { get; set; }
        public virtual DbSet<PatientTreatmentPlan> PatientTreatmentPlan { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PaymentMode> PaymentMode { get; set; }
        public virtual DbSet<PaymentSource> PaymentSource { get; set; }
        public virtual DbSet<PaymentStatus> PaymentStatus { get; set; }
        public virtual DbSet<PerioChangeTooth> PerioChangeTooth { get; set; }
        public virtual DbSet<PerioChart> PerioChart { get; set; }
        public virtual DbSet<PerioExam> PerioExam { get; set; }
        public virtual DbSet<PerioMeasure> PerioMeasure { get; set; }
        public virtual DbSet<PerioMissingTooth> PerioMissingTooth { get; set; }
        public virtual DbSet<PerioNote> PerioNote { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonAddress> PersonAddress { get; set; }
        public virtual DbSet<PersonLanguage> PersonLanguage { get; set; }
        public virtual DbSet<PersonPhone> PersonPhone { get; set; }
        public virtual DbSet<Phone> Phone { get; set; }
        public virtual DbSet<PhoneType> PhoneType { get; set; }
        public virtual DbSet<PreferenceType> PreferenceType { get; set; }
        public virtual DbSet<Prefix> Prefix { get; set; }
        public virtual DbSet<ProcedureCodeCategory> ProcedureCodeCategory { get; set; }
        public virtual DbSet<Promotion> Promotion { get; set; }
        public virtual DbSet<PromotionType> PromotionType { get; set; }
        public virtual DbSet<Prospect> Prospect { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<ProviderInsurance> ProviderInsurance { get; set; }
        public virtual DbSet<ProviderType> ProviderType { get; set; }
        public virtual DbSet<PulseRhythmType> PulseRhythmType { get; set; }
        public virtual DbSet<RealEstate> RealEstate { get; set; }
        public virtual DbSet<Relationship> Relationship { get; set; }
        public virtual DbSet<RelationshipType> RelationshipType { get; set; }
        public virtual DbSet<Remittance> Remittance { get; set; }
        public virtual DbSet<ReviewReason> ReviewReason { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RolePermission> RolePermission { get; set; }
        public virtual DbSet<RuleCondition> RuleCondition { get; set; }
        public virtual DbSet<RuleOperator> RuleOperator { get; set; }
        public virtual DbSet<SecurityQuestion> SecurityQuestion { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Statement> Statement { get; set; }
        public virtual DbSet<Subscriber> Subscriber { get; set; }
        public virtual DbSet<Suffix> Suffix { get; set; }
        public virtual DbSet<Telecom> Telecom { get; set; }
        public virtual DbSet<TelecomVendor> TelecomVendor { get; set; }
        public virtual DbSet<TimeBlock> TimeBlock { get; set; }
        public virtual DbSet<TimeSlot> TimeSlot { get; set; }
        public virtual DbSet<TimeZone> TimeZone { get; set; }
        public virtual DbSet<TobaccoType> TobaccoType { get; set; }
        public virtual DbSet<ToothType> ToothType { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<TransactionCredit> TransactionCredit { get; set; }
        public virtual DbSet<TransactionDebit> TransactionDebit { get; set; }
        public virtual DbSet<TreatmentPlanOption> TreatmentPlanOption { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserPermission> UserPermission { get; set; }
        public virtual DbSet<UserSpecialty> UserSpecialty { get; set; }
        public virtual DbSet<UserStatus> UserStatus { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<View> View { get; set; }
        public virtual DbSet<Visit> Visit { get; set; }
        public virtual DbSet<VisitReasonType> VisitReasonType { get; set; }
        public virtual DbSet<VitalState> VitalState { get; set; }
        public virtual DbSet<WeightMeasurement> WeightMeasurement { get; set; }
        public virtual DbSet<ZipCode> ZipCode { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server=DESKTOP-H1OJJBC\\SQLEXPRESS;Database=EPMS3POC1;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account", "ACC");
               
                entity.Property(e => e.AccountNumber).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.AccountStatus)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.AccountStatusId)
                    .HasConstraintName("R_718");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_826");

                entity.HasOne(d => d.Guarantor)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.GuarantorId)
                    .HasConstraintName("R_297");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.StatementId)
                    .HasConstraintName("R_365");

                entity.HasOne(d => d.Subscriber)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.SubscriberId)
                    .HasConstraintName("R_313");
            });

            modelBuilder.Entity<Accounting>(entity =>
            {
                entity.ToTable("Accounting", "ACC");

                entity.Property(e => e.AccountingId).ValueGeneratedNever();

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.Accounting)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_345");
            });

            modelBuilder.Entity<AccountStatus>(entity =>
            {
                entity.ToTable("AccountStatus", "ACC");

                entity.Property(e => e.AccountStatusCode).HasColumnType("char(5)");

                entity.Property(e => e.AccountStatusDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.AccountStatusName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address", "PER");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine3)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.SpecialInstructions)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("R_918");

                entity.HasOne(d => d.County)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CountyId)
                    .HasConstraintName("R_686");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("R_905");

                entity.HasOne(d => d.ZipCode)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.ZipCodeId)
                    .HasConstraintName("R_115");
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.ToTable("AddressType", "PER");

                entity.Property(e => e.AddressTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.AddressTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.AddressTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Adjustment>(entity =>
            {
                entity.ToTable("Adjustment", "ACC");

                entity.Property(e => e.AdjustmentAmount).HasColumnType("money");

                entity.Property(e => e.AdjustmentComments)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.AdjustmentDate).HasColumnType("datetime");

                entity.Property(e => e.AdjustmentReference)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.AdjustmentCode)
                    .WithMany(p => p.Adjustment)
                    .HasForeignKey(d => d.AdjustmentCodeId)
                    .HasConstraintName("R_681");

                entity.HasOne(d => d.AdjustmentType)
                    .WithMany(p => p.Adjustment)
                    .HasForeignKey(d => d.AdjustmentTypeId)
                    .HasConstraintName("R_683");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Adjustment)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("R_682");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.Adjustment)
                    .HasForeignKey(d => d.TransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_859");
            });

            modelBuilder.Entity<AdjustmentCode>(entity =>
            {
                entity.ToTable("AdjustmentCode", "ACC");

                entity.Property(e => e.AdjustmentCodeCode).HasColumnType("char(5)");

                entity.Property(e => e.AdjustmentCodeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.AdjustmentCodeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.AdjustmentType)
                    .WithMany(p => p.AdjustmentCode)
                    .HasForeignKey(d => d.AdjustmentTypeId)
                    .HasConstraintName("R_684");
            });

            modelBuilder.Entity<AdjustmentType>(entity =>
            {
                entity.ToTable("AdjustmentType", "ACC");

                entity.Property(e => e.AdjustmentTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.AdjustmentTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.AdjustmentTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("Application", "FAC");

                entity.Property(e => e.ApplicationCode).HasColumnType("char(5)");

                entity.Property(e => e.ApplicationDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment", "SCH");

                entity.Property(e => e.AppointmentDate).HasColumnType("datetime");

                entity.Property(e => e.CallReminderStatus)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.CreateAppointmentDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RevenueAmount).HasColumnType("money");

                entity.HasOne(d => d.AppointmentStatus)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.AppointmentStatusId)
                    .HasConstraintName("R_650");

                entity.HasOne(d => d.AppointmentType)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.AppointmentTypeId)
                    .HasConstraintName("R_122");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.VisitId)
                    .HasConstraintName("R_415");
            });

            modelBuilder.Entity<AppointmentCancellationCode>(entity =>
            {
                entity.ToTable("AppointmentCancellationCode", "SCH");

                entity.Property(e => e.AppointmentCancellationCodeCode).HasColumnType("char(5)");

                entity.Property(e => e.AppointmentCancellationCodeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentCancellationCodeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DefaultCharge).HasColumnType("money");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppointmentClass>(entity =>
            {
                entity.ToTable("AppointmentClass", "SCH");

                entity.Property(e => e.AppointmentClassCode).HasColumnType("char(5)");

                entity.Property(e => e.AppointmentClassDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentClassName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Operatory)
                    .WithMany(p => p.AppointmentClass)
                    .HasForeignKey(d => d.OperatoryId)
                    .HasConstraintName("R_612");

                entity.HasOne(d => d.ProviderType)
                    .WithMany(p => p.AppointmentClass)
                    .HasForeignKey(d => d.ProviderTypeId)
                    .HasConstraintName("R_544");
            });

            modelBuilder.Entity<AppointmentNoShowFee>(entity =>
            {
                entity.ToTable("AppointmentNoShowFee", "SCH");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DefaultCharge).HasColumnType("money");

                entity.Property(e => e.InitiatedByWhom)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.AppointmentCancellationCode)
                    .WithMany(p => p.AppointmentNoShowFee)
                    .HasForeignKey(d => d.AppointmentCancellationCodeId)
                    .HasConstraintName("R_134");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.AppointmentNoShowFee)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("R_138");
            });

            modelBuilder.Entity<AppointmentPreference>(entity =>
            {
                entity.ToTable("AppointmentPreference", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.AppointmentPreference)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_136");
            });

            modelBuilder.Entity<AppointmentStatus>(entity =>
            {
                entity.ToTable("AppointmentStatus", "SCH");

                entity.Property(e => e.AppointmentStatusCode).HasColumnType("char(5)");

                entity.Property(e => e.AppointmentStatusDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentStatusName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppointmentStatusLog>(entity =>
            {
                entity.ToTable("AppointmentStatusLog", "SCH");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.LogDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.AppointmentStatusLog)
                    .HasForeignKey(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_648");

                entity.HasOne(d => d.AppointmentStatus)
                    .WithMany(p => p.AppointmentStatusLog)
                    .HasForeignKey(d => d.AppointmentStatusId)
                    .HasConstraintName("R_652");
            });

            modelBuilder.Entity<AppointmentTimeSlot>(entity =>
            {
                entity.ToTable("AppointmentTimeSlot", "SCH");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.AppointmentTimeSlot)
                    .HasForeignKey(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_321");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AppointmentTimeSlot)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("R_854");

                entity.HasOne(d => d.TimeSlot)
                    .WithMany(p => p.AppointmentTimeSlot)
                    .HasForeignKey(d => d.TimeSlotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_176");
            });

            modelBuilder.Entity<AppointmentType>(entity =>
            {
                entity.ToTable("AppointmentType", "SCH");

                entity.Property(e => e.AppointmentTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.AppointmentTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Cptcode)
                    .HasColumnName("CPTCode")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BillingSoftware>(entity =>
            {
                entity.ToTable("BillingSoftware", "INS");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerKey)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BloodPressureActivity>(entity =>
            {
                entity.ToTable("BloodPressureActivity", "CLI");

                entity.Property(e => e.BloodPressureActivityCode).HasColumnType("char(5)");

                entity.Property(e => e.BloodPressureActivityDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.BloodPressureActivityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BloodPressureReading>(entity =>
            {
                entity.ToTable("BloodPressureReading", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.BloodPressureActivity)
                    .WithMany(p => p.BloodPressureReading)
                    .HasForeignKey(d => d.BloodPressureActivityId)
                    .HasConstraintName("R_777");

                entity.HasOne(d => d.VitalState)
                    .WithMany(p => p.BloodPressureReading)
                    .HasForeignKey(d => d.VitalStateId)
                    .HasConstraintName("R_778");
            });

            modelBuilder.Entity<Bmistatus>(entity =>
            {
                entity.ToTable("BMIStatus", "CLI");

                entity.Property(e => e.BmistatusId).HasColumnName("BMIStatusId");

                entity.Property(e => e.BmistatusCode)
                    .HasColumnName("BMIStatusCode")
                    .HasColumnType("char(5)");

                entity.Property(e => e.BmistatusDescription)
                    .HasColumnName("BMIStatusDescription")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.BmistatusName)
                    .HasColumnName("BMIStatusName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BrushType>(entity =>
            {
                entity.ToTable("BrushType", "CLI");

                entity.Property(e => e.BrushTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.BrushTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.BrushTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BundledService>(entity =>
            {
                entity.ToTable("BundledService", "TRE");

                entity.Property(e => e.BundledServiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BundledServiceDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.BundledServiceName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BundledServiceMasterProcedure>(entity =>
            {
                entity.ToTable("BundledServiceMasterProcedure", "TRE");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.BundledService)
                    .WithMany(p => p.BundledServiceMasterProcedure)
                    .HasForeignKey(d => d.BundledServiceId)
                    .HasConstraintName("R_749");

                entity.HasOne(d => d.MasterProcedure)
                    .WithMany(p => p.BundledServiceMasterProcedure)
                    .HasForeignKey(d => d.MasterProcedureId)
                    .HasConstraintName("R_750");
            });

            modelBuilder.Entity<CaseType>(entity =>
            {
                entity.ToTable("CaseType", "CLI");

                entity.Property(e => e.CaseTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.CaseTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CategoryFilter>(entity =>
            {
                entity.ToTable("CategoryFilter", "TRE");

                entity.Property(e => e.CategoryFilterCode).HasColumnType("char(5)");

                entity.Property(e => e.CategoryFilterDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryFilterName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChartAudit>(entity =>
            {
                entity.ToTable("ChartAudit", "SCH");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.ChartAudit)
                    .HasForeignKey(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_517");

                entity.HasOne(d => d.ChartAuditStatus)
                    .WithMany(p => p.ChartAudit)
                    .HasForeignKey(d => d.ChartAuditStatusId)
                    .HasConstraintName("R_586");

                entity.HasOne(d => d.ReviewReason)
                    .WithMany(p => p.ChartAudit)
                    .HasForeignKey(d => d.ReviewReasonId)
                    .HasConstraintName("R_587");
            });

            modelBuilder.Entity<ChartAuditStatus>(entity =>
            {
                entity.ToTable("ChartAuditStatus", "SCH");

                entity.Property(e => e.ChartAuditStatusCode).HasColumnType("char(5)");

                entity.Property(e => e.ChartAuditStatusDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ChartAuditStatusName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChartReviewCategory>(entity =>
            {
                entity.ToTable("ChartReviewCategory", "CLI");

                entity.Property(e => e.ChartReviewCategoryCode).HasColumnType("char(5)");

                entity.Property(e => e.ChartReviewCategoryDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ChartReviewCategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChartReviewCategoryHistory>(entity =>
            {
                entity.ToTable("ChartReviewCategoryHistory", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.ChartReviewCategory)
                    .WithMany(p => p.ChartReviewCategoryHistory)
                    .HasForeignKey(d => d.ChartReviewCategoryId)
                    .HasConstraintName("R_893");

                entity.HasOne(d => d.ChartReviewStatus)
                    .WithMany(p => p.ChartReviewCategoryHistory)
                    .HasForeignKey(d => d.ChartReviewStatusId)
                    .HasConstraintName("R_890");

                entity.HasOne(d => d.PatientChartReview)
                    .WithMany(p => p.ChartReviewCategoryHistory)
                    .HasForeignKey(d => d.PatientChartReviewId)
                    .HasConstraintName("R_892");
            });

            modelBuilder.Entity<ChartReviewItemHistory>(entity =>
            {
                entity.ToTable("ChartReviewItemHistory", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.ChartReviewItemType)
                    .WithMany(p => p.ChartReviewItemHistory)
                    .HasForeignKey(d => d.ChartReviewItemTypeId)
                    .HasConstraintName("R_895");

                entity.HasOne(d => d.ChartReviewStatus)
                    .WithMany(p => p.ChartReviewItemHistory)
                    .HasForeignKey(d => d.ChartReviewStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_862");

                entity.HasOne(d => d.PatientChartReview)
                    .WithMany(p => p.ChartReviewItemHistory)
                    .HasForeignKey(d => d.PatientChartReviewId)
                    .HasConstraintName("R_891");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ChartReviewItemHistory)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("R_366");
            });

            modelBuilder.Entity<ChartReviewItemType>(entity =>
            {
                entity.ToTable("ChartReviewItemType", "CLI");

                entity.Property(e => e.ChartReviewItemTypeName).HasMaxLength(50);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.ChartReviewCategory)
                    .WithMany(p => p.ChartReviewItemType)
                    .HasForeignKey(d => d.ChartReviewCategoryId)
                    .HasConstraintName("R_894");
            });

            modelBuilder.Entity<ChartReviewStatus>(entity =>
            {
                entity.ToTable("ChartReviewStatus", "CLI");

                entity.Property(e => e.ChartReviewStatusCode).HasColumnType("char(5)");

                entity.Property(e => e.ChartReviewStatusDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ChartReviewStatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Check>(entity =>
            {
                entity.ToTable("Check", "ACC");

                entity.Property(e => e.CheckId).ValueGeneratedNever();

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankRountingNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckFilieName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckImage)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DateOfPayment)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IclreceivedDate)
                    .HasColumnName("ICLReceivedDate")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Micrdata)
                    .HasColumnName("MICRData")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.MasterPayee)
                    .WithMany(p => p.Check)
                    .HasForeignKey(d => d.MasterPayeeId)
                    .HasConstraintName("R_762");

                entity.HasOne(d => d.MasterPayer)
                    .WithMany(p => p.Check)
                    .HasForeignKey(d => d.MasterPayerId)
                    .HasConstraintName("R_761");
            });

            modelBuilder.Entity<CheckInNote>(entity =>
            {
                entity.ToTable("CheckInNote", "SCH");

                entity.Property(e => e.CheckInNote1)
                    .HasColumnName("CheckInNote")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.CheckInNote)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("R_861");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City", "PER");

                entity.Property(e => e.CityCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CityDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.County)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountyId)
                    .HasConstraintName("R_917");

                entity.HasOne(d => d.ZipCode)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.ZipCodeId)
                    .HasConstraintName("R_919");
            });

            modelBuilder.Entity<Claim>(entity =>
            {
                entity.ToTable("Claim", "INS");

                entity.Property(e => e.BalanceAmount).HasColumnType("money");

                entity.Property(e => e.CardIssueDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.GeneratedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Npinumber)
                    .HasColumnName("NPINumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlanCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StandardCharges).HasColumnType("money");

                entity.Property(e => e.TreatmentPlanCharges).HasColumnType("money");

                entity.HasOne(d => d.ClaimStatus)
                    .WithMany(p => p.Claim)
                    .HasForeignKey(d => d.ClaimStatusId)
                    .HasConstraintName("R_711");

                entity.HasOne(d => d.ClaimType)
                    .WithMany(p => p.Claim)
                    .HasForeignKey(d => d.ClaimTypeId)
                    .HasConstraintName("R_519");

                entity.HasOne(d => d.ProviderInsurance)
                    .WithMany(p => p.Claim)
                    .HasForeignKey(d => d.ProviderInsuranceId)
                    .HasConstraintName("R_521");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Claim)
                    .HasForeignKey(d => d.VisitId)
                    .HasConstraintName("R_680");
            });

            modelBuilder.Entity<ClaimStatus>(entity =>
            {
                entity.ToTable("ClaimStatus", "INS");

                entity.Property(e => e.ClaimStatusCode).HasColumnType("char(5)");

                entity.Property(e => e.ClaimStatusDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimStatusName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ClaimType>(entity =>
            {
                entity.ToTable("ClaimType", "INS");

                entity.Property(e => e.ClaimTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.ClaimTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ClearingHouse>(entity =>
            {
                entity.ToTable("ClearingHouse", "INS");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EligibilityPassword)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EligibilityUserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.BillingSoftware)
                    .WithMany(p => p.ClearingHouse)
                    .HasForeignKey(d => d.BillingSoftwareId)
                    .HasConstraintName("R_704");
            });

            modelBuilder.Entity<CollectionAccount>(entity =>
            {
                entity.ToTable("CollectionAccount", "FIN");

                entity.Property(e => e.AmountPastDue).HasColumnType("money");

                entity.Property(e => e.CollectedBalance).HasColumnType("money");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CollectionAccount)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("R_721");

                entity.HasOne(d => d.CollectionAgency)
                    .WithMany(p => p.CollectionAccount)
                    .HasForeignKey(d => d.CollectionAgencyId)
                    .HasConstraintName("R_720");
            });

            modelBuilder.Entity<CollectionAgency>(entity =>
            {
                entity.ToTable("CollectionAgency", "FIN");

                entity.Property(e => e.CollectionAgencyCode).HasColumnType("char(5)");

                entity.Property(e => e.CollectionAgencyDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CollectionAgencyName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Finance)
                    .WithMany(p => p.CollectionAgency)
                    .HasForeignKey(d => d.FinanceId)
                    .HasConstraintName("R_722");
            });

            modelBuilder.Entity<ConditionBySextant>(entity =>
            {
                entity.ToTable("ConditionBySextant", "CLI");

                entity.Property(e => e.ConditionBySextantCode).HasColumnType("char(5)");

                entity.Property(e => e.ConditionBySextantDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionBySextantName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConditionsOnAllTeeth>(entity =>
            {
                entity.ToTable("ConditionsOnAllTeeth", "CLI");

                entity.Property(e => e.ConditionsOnAllTeethCode).HasColumnType("char(5)");

                entity.Property(e => e.ConditionsOnAllTeethDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionsOnAllTeethName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Confirmation>(entity =>
            {
                entity.ToTable("Confirmation", "SCH");

                entity.Property(e => e.ConfirmationCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.Confirmation)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("R_588");
            });

            modelBuilder.Entity<ConsentForm>(entity =>
            {
                entity.ToTable("ConsentForm", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.FormType).HasMaxLength(100);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(1);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ConsentForm)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("R_621");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.ConsentForm)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("R_388");
            });

            modelBuilder.Entity<Cotsvendor>(entity =>
            {
                entity.ToTable("COTSVendor", "FAC");

                entity.Property(e => e.CotsvendorId).HasColumnName("COTSVendorId");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.MerchantIdValue)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.Cotsvendor)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("R_585");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country", "PER");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode3)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CountryDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CountryTelephoneCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<County>(entity =>
            {
                entity.ToTable("County", "PER");

                entity.Property(e => e.CountyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CountyDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CountyName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.County)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("R_685");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.ToTable("Coupon", "FAC");

                entity.Property(e => e.ActiveDate).HasColumnType("datetime");

                entity.Property(e => e.AdjustmentValue)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CouponCode).HasColumnType("char(5)");

                entity.Property(e => e.CouponDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CouponTitle)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.CouponAdjustment)
                    .WithMany(p => p.Coupon)
                    .HasForeignKey(d => d.CouponAdjustmentId)
                    .HasConstraintName("R_319");

                entity.HasOne(d => d.CouponStatus)
                    .WithMany(p => p.Coupon)
                    .HasForeignKey(d => d.CouponStatusId)
                    .HasConstraintName("R_640");

                entity.HasOne(d => d.CouponType)
                    .WithMany(p => p.Coupon)
                    .HasForeignKey(d => d.CouponTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_314");

                entity.HasOne(d => d.MasterProcedure)
                    .WithMany(p => p.Coupon)
                    .HasForeignKey(d => d.MasterProcedureId)
                    .HasConstraintName("R_595");

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.Coupon)
                    .HasForeignKey(d => d.PromotionId)
                    .HasConstraintName("R_611");
            });

            modelBuilder.Entity<CouponAdjustment>(entity =>
            {
                entity.ToTable("CouponAdjustment", "FAC");

                entity.Property(e => e.CouponAdjustmentCode).HasColumnType("char(5)");

                entity.Property(e => e.CouponAdjustmentDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CouponAdjustmentName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CouponOption>(entity =>
            {
                entity.ToTable("CouponOption", "FAC");

                entity.Property(e => e.CouponOptionlValue)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.CouponOption)
                    .HasForeignKey(d => d.CouponId)
                    .HasConstraintName("R_647");

                entity.HasOne(d => d.CouponOptionType)
                    .WithMany(p => p.CouponOption)
                    .HasForeignKey(d => d.CouponOptionTypeId)
                    .HasConstraintName("R_646");
            });

            modelBuilder.Entity<CouponOptionType>(entity =>
            {
                entity.ToTable("CouponOptionType", "FAC");

                entity.Property(e => e.CouponOptionTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.CouponOptionTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CouponOptionTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CouponStatus>(entity =>
            {
                entity.ToTable("CouponStatus", "FAC");

                entity.Property(e => e.CouponStatusCode).HasColumnType("char(5)");

                entity.Property(e => e.CouponStatusDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CouponStatusName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CouponType>(entity =>
            {
                entity.ToTable("CouponType", "FAC");

                entity.Property(e => e.CouponTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.CouponTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CouponTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CoverageBook>(entity =>
            {
                entity.ToTable("CoverageBook", "INS");

                entity.Property(e => e.CoverageName).HasMaxLength(1);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PlanName).HasMaxLength(1);

                entity.HasOne(d => d.CoverageBookType)
                    .WithMany(p => p.CoverageBook)
                    .HasForeignKey(d => d.CoverageBookTypeId)
                    .HasConstraintName("R_758");

                entity.HasOne(d => d.Insurance)
                    .WithMany(p => p.CoverageBook)
                    .HasForeignKey(d => d.InsuranceId)
                    .HasConstraintName("R_736");

                entity.HasOne(d => d.InsurancePayer)
                    .WithMany(p => p.CoverageBook)
                    .HasForeignKey(d => d.InsurancePayerId)
                    .HasConstraintName("R_757");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.CoverageBook)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("R_737");

                entity.HasOne(d => d.Subscriber)
                    .WithMany(p => p.CoverageBook)
                    .HasForeignKey(d => d.SubscriberId)
                    .HasConstraintName("R_738");
            });

            modelBuilder.Entity<CoverageBookType>(entity =>
            {
                entity.ToTable("CoverageBookType", "INS");

                entity.Property(e => e.CoverageBookTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.CoverageBookTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CoverageBookTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CoverageFrequency>(entity =>
            {
                entity.ToTable("CoverageFrequency", "INS");

                entity.Property(e => e.CoverageCategory).HasMaxLength(100);

                entity.Property(e => e.CoverageSubCategory).HasMaxLength(100);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.FourQuadrantsPerDay).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NextDate).HasColumnType("datetime");

                entity.Property(e => e.TwiceAyear)
                    .HasColumnName("TwiceAYear")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TwoPerTwelveMonth).HasDefaultValueSql("((0))");

                entity.Property(e => e.TwoQuadrantsPerDay).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CoverageBook)
                    .WithMany(p => p.CoverageFrequency)
                    .HasForeignKey(d => d.CoverageBookId)
                    .HasConstraintName("R_743");
            });

            modelBuilder.Entity<CoverageLimit>(entity =>
            {
                entity.ToTable("CoverageLimit", "INS");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.LimitAmount).HasColumnType("money");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RemainingAmount).HasColumnType("money");

                entity.Property(e => e.UsedAmount).HasColumnType("money");

                entity.HasOne(d => d.CoverageBook)
                    .WithMany(p => p.CoverageLimit)
                    .HasForeignKey(d => d.CoverageBookId)
                    .HasConstraintName("R_742");

                entity.HasOne(d => d.CoverageLimitType)
                    .WithMany(p => p.CoverageLimit)
                    .HasForeignKey(d => d.CoverageLimitTypeId)
                    .HasConstraintName("R_741");

                entity.HasOne(d => d.CoverageNetworkType)
                    .WithMany(p => p.CoverageLimit)
                    .HasForeignKey(d => d.CoverageNetworkTypeId)
                    .HasConstraintName("R_739");

                entity.HasOne(d => d.CoveragePlanType)
                    .WithMany(p => p.CoverageLimit)
                    .HasForeignKey(d => d.CoveragePlanTypeId)
                    .HasConstraintName("R_740");
            });

            modelBuilder.Entity<CoverageLimitType>(entity =>
            {
                entity.ToTable("CoverageLimitType", "INS");

                entity.Property(e => e.CoverageLimitTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.CoverageLimitTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CoverageLimitTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CoverageNetworkType>(entity =>
            {
                entity.ToTable("CoverageNetworkType", "INS");

                entity.Property(e => e.CoverageNetworkTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.CoverageNetworkTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CoverageNetworkTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CoveragePlanType>(entity =>
            {
                entity.ToTable("CoveragePlanType", "INS");

                entity.Property(e => e.CoveragePlanTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.CoveragePlanTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CoveragePlanTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CoverageProcedure>(entity =>
            {
                entity.ToTable("CoverageProcedure", "INS");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(1);

                entity.HasOne(d => d.CoverageBook)
                    .WithMany(p => p.CoverageProcedure)
                    .HasForeignKey(d => d.CoverageBookId)
                    .HasConstraintName("R_746");

                entity.HasOne(d => d.CoverageNetworkType)
                    .WithMany(p => p.CoverageProcedure)
                    .HasForeignKey(d => d.CoverageNetworkTypeId)
                    .HasConstraintName("R_744");

                entity.HasOne(d => d.ProcedureCodeCategory)
                    .WithMany(p => p.CoverageProcedure)
                    .HasForeignKey(d => d.ProcedureCodeCategoryId)
                    .HasConstraintName("R_745");
            });

            modelBuilder.Entity<CoverageType>(entity =>
            {
                entity.ToTable("CoverageType", "INS");

                entity.Property(e => e.CoverageTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.CoverageTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CoverageTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CreditAccount>(entity =>
            {
                entity.ToTable("CreditAccount", "FIN");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreditBalanceDue).HasColumnType("money");

                entity.Property(e => e.CreditMaximum).HasColumnType("money");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CreditAccount)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("R_692");

                entity.HasOne(d => d.CreditAccountStatus)
                    .WithMany(p => p.CreditAccount)
                    .HasForeignKey(d => d.CreditAccountStatusId)
                    .HasConstraintName("R_719");

                entity.HasOne(d => d.Lender)
                    .WithMany(p => p.CreditAccount)
                    .HasForeignKey(d => d.LenderId)
                    .HasConstraintName("R_691");
            });

            modelBuilder.Entity<CreditAccountStatus>(entity =>
            {
                entity.ToTable("CreditAccountStatus", "FIN");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreditAccountStatusCode).HasColumnType("char(5)");

                entity.Property(e => e.CreditAccountStatusDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAccountStatusName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DemographicField>(entity =>
            {
                entity.ToTable("DemographicField", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DemographicFieldCode).HasColumnType("char(5)");

                entity.Property(e => e.DemographicFieldDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DemographicFieldName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DemographicRule>(entity =>
            {
                entity.ToTable("DemographicRule", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RuleValueCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.DemographicRule)
                    .HasForeignKey(d => d.CouponId)
                    .HasConstraintName("R_643");

                entity.HasOne(d => d.DemographicField)
                    .WithMany(p => p.DemographicRule)
                    .HasForeignKey(d => d.DemographicFieldId)
                    .HasConstraintName("R_645");

                entity.HasOne(d => d.RuleCondition)
                    .WithMany(p => p.DemographicRule)
                    .HasForeignKey(d => d.RuleConditionId)
                    .HasConstraintName("R_641");

                entity.HasOne(d => d.RuleOperator)
                    .WithMany(p => p.DemographicRule)
                    .HasForeignKey(d => d.RuleOperatorId)
                    .HasConstraintName("R_642");
            });

            modelBuilder.Entity<DiagnosticCenter>(entity =>
            {
                entity.ToTable("DiagnosticCenter", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DiagnosticCenterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.DiagnosticCenter)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("R_629");
            });

            modelBuilder.Entity<DiagnosticCenterAddress>(entity =>
            {
                entity.ToTable("DiagnosticCenterAddress", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.DiagnosticCenterAddress)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("R_779");

                entity.HasOne(d => d.DiagnosticCenter)
                    .WithMany(p => p.DiagnosticCenterAddress)
                    .HasForeignKey(d => d.DiagnosticCenterId)
                    .HasConstraintName("R_780");
            });

            modelBuilder.Entity<DiagnosticCenterContact>(entity =>
            {
                entity.ToTable("DiagnosticCenterContact", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.DiagnosticCenter)
                    .WithMany(p => p.DiagnosticCenterContact)
                    .HasForeignKey(d => d.DiagnosticCenterId)
                    .HasConstraintName("R_781");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.DiagnosticCenterContact)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("R_782");
            });

            modelBuilder.Entity<DiagnosticCenterPhone>(entity =>
            {
                entity.ToTable("DiagnosticCenterPhone", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.DiagnosticCenter)
                    .WithMany(p => p.DiagnosticCenterPhone)
                    .HasForeignKey(d => d.DiagnosticCenterId)
                    .HasConstraintName("R_784");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.DiagnosticCenterPhone)
                    .HasForeignKey(d => d.PhoneId)
                    .HasConstraintName("R_783");

                entity.HasOne(d => d.PhoneType)
                    .WithMany(p => p.DiagnosticCenterPhone)
                    .HasForeignKey(d => d.PhoneTypeId)
                    .HasConstraintName("R_785");
            });

            modelBuilder.Entity<DiagnosticLocation>(entity =>
            {
                entity.ToTable("DiagnosticLocation", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DiagnosticLocationCode).HasColumnType("char(5)");

                entity.Property(e => e.DiagnosticLocationDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticLocationName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.DiagnosticLocationType)
                    .WithMany(p => p.DiagnosticLocation)
                    .HasForeignKey(d => d.DiagnosticLocationTypeId)
                    .HasConstraintName("R_623");
            });

            modelBuilder.Entity<DiagnosticLocationType>(entity =>
            {
                entity.ToTable("DiagnosticLocationType", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DiagnosticLocationTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.DiagnosticLocationTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticLocationTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DiagnosticTestCategory>(entity =>
            {
                entity.ToTable("DiagnosticTestCategory", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DiagnosticTestCategoryCode).HasColumnType("char(5)");

                entity.Property(e => e.DiagnosticTestCategoryDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticTestCategoryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.DiagnosticTestCategoryTarget)
                    .WithMany(p => p.DiagnosticTestCategory)
                    .HasForeignKey(d => d.DiagnosticTestCategoryTargetId)
                    .HasConstraintName("R_625");

                entity.HasOne(d => d.DiagnosticTestCategoryType)
                    .WithMany(p => p.DiagnosticTestCategory)
                    .HasForeignKey(d => d.DiagnosticTestCategoryTypeId)
                    .HasConstraintName("R_624");
            });

            modelBuilder.Entity<DiagnosticTestCategoryTarget>(entity =>
            {
                entity.ToTable("DiagnosticTestCategoryTarget", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DiagnosticTestCategoryTargetCode).HasColumnType("char(5)");

                entity.Property(e => e.DiagnosticTestCategoryTargetDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticTestCategoryTargetName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DiagnosticTestCategoryType>(entity =>
            {
                entity.ToTable("DiagnosticTestCategoryType", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DiagnosticTestCategoryTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.DiagnosticTestCategoryTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticTestCategoryTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DocumentCategory>(entity =>
            {
                entity.ToTable("DocumentCategory", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DocumentCategoryCode).HasColumnType("char(5)");

                entity.Property(e => e.DocumentCategoryDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentCategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DocumentManagement>(entity =>
            {
                entity.ToTable("DocumentManagement", "CLI");

                entity.Property(e => e.ConsentStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DocumentPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EstimateRunDateTime).HasColumnType("datetime");

                entity.Property(e => e.InterpretationDetails)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OfflineUploadTime).HasColumnType("datetime");

                entity.Property(e => e.OnlineUploadTime).HasColumnType("datetime");

                entity.Property(e => e.RadiologistDetails)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateContent)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.DocumentCategory)
                    .WithMany(p => p.DocumentManagement)
                    .HasForeignKey(d => d.DocumentCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_390");

                entity.HasOne(d => d.DocumentSubCategory)
                    .WithMany(p => p.DocumentManagement)
                    .HasForeignKey(d => d.DocumentSubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_389");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.DocumentManagement)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("R_488");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.DocumentManagement)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("R_487");
            });

            modelBuilder.Entity<DocumentMapping>(entity =>
            {
                entity.ToTable("DocumentMapping", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.TemplateId)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.DocumentCategory)
                    .WithMany(p => p.DocumentMapping)
                    .HasForeignKey(d => d.DocumentCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_392");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.DocumentMapping)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("R_787");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.DocumentMapping)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("R_393");

                entity.HasOne(d => d.PatientNoteTemplate)
                    .WithMany(p => p.DocumentMapping)
                    .HasForeignKey(d => d.PatientNoteTemplateId)
                    .HasConstraintName("R_756");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.DocumentMapping)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("R_394");
            });

            modelBuilder.Entity<DocumentSubCategory>(entity =>
            {
                entity.ToTable("DocumentSubCategory", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.SubCatgoryFileName)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SubcategoryName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.DocumentCategory)
                    .WithMany(p => p.DocumentSubCategory)
                    .HasForeignKey(d => d.DocumentCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_391");
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.ToTable("DocumentType", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DocumentTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.DocumentTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .HasConstraintName("R_860");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("R_914");

                entity.HasOne(d => d.FacilitySchedule)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.FacilityScheduleId)
                    .HasConstraintName("R_554");

                entity.HasOne(d => d.ProviderType)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.ProviderTypeId)
                    .HasConstraintName("R_849");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.ToTable("EmployeeType", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EmployeeTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.EmployeeTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Entity>(entity =>
            {
                entity.ToTable("Entity", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EmailIdentifier)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EntityCode).HasColumnType("char(5)");

                entity.Property(e => e.EntityDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.EntityName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalMarketingName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.WebsiteAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationStatus)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.LocationStatusId)
                    .HasConstraintName("R_572");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_265");
            });

            modelBuilder.Entity<EntityAddress>(entity =>
            {
                entity.ToTable("EntityAddress", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.EntityAddress)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_575");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.EntityAddress)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("R_576");
            });

            modelBuilder.Entity<EntityMappingLog>(entity =>
            {
                entity.ToTable("EntityMappingLog", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.MappedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.EntityMappingLog)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("R_654");
            });

            modelBuilder.Entity<EntityPhone>(entity =>
            {
                entity.ToTable("EntityPhone", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.EntityPhone)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("R_577");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.EntityPhone)
                    .HasForeignKey(d => d.PhoneId)
                    .HasConstraintName("R_578");
            });

            modelBuilder.Entity<ExcuseNote>(entity =>
            {
                entity.ToTable("ExcuseNote", "SCH");

                entity.Property(e => e.AppointmentEndTime).HasColumnType("datetime");

                entity.Property(e => e.AppointmentStartTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExcuseDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.ExcuseNote)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("R_386");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ExcuseNote)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("R_853");
            });

            modelBuilder.Entity<Facility>(entity =>
            {
                entity.ToTable("Facility", "FAC");

                entity.Property(e => e.CcforceAppointmentAm).HasColumnName("CCForceAppointmentAM");

                entity.Property(e => e.CcforceAppointmentPm).HasColumnName("CCForceAppointmentPM");

                entity.Property(e => e.ClinicProxyUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DoseSpotClinicId)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DoseSpotClinicKey)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EmailIdentifier)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityCode).HasColumnType("char(5)");

                entity.Property(e => e.FacilityDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ReportCategory).HasColumnType("char(1)");

                entity.Property(e => e.WebsiteAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.XRayTime).HasColumnName("X_RayTime");

                entity.HasOne(d => d.LocationStatus)
                    .WithMany(p => p.Facility)
                    .HasForeignKey(d => d.LocationStatusId)
                    .HasConstraintName("R_571");
            });

            modelBuilder.Entity<FacilityAddress>(entity =>
            {
                entity.ToTable("FacilityAddress", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.FacilityAddress)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_270");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.FacilityAddress)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_269");
            });

            modelBuilder.Entity<FacilityLanguage>(entity =>
            {
                entity.ToTable("FacilityLanguage", "FAC");

                entity.Property(e => e.FacilityLanguageId).ValueGeneratedNever();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.FacilityLanguage)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("R_913");
            });

            modelBuilder.Entity<FacilityPhone>(entity =>
            {
                entity.ToTable("FacilityPhone", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.FacilityPhone)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_267");
            });

            modelBuilder.Entity<FacilityPreference>(entity =>
            {
                entity.ToTable("FacilityPreference", "INS");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.ClearingHouse)
                    .WithMany(p => p.FacilityPreference)
                    .HasForeignKey(d => d.ClearingHouseId)
                    .HasConstraintName("R_706");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.FacilityPreference)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("R_705");
            });

            modelBuilder.Entity<FacilitySchedule>(entity =>
            {
                entity.ToTable("FacilitySchedule", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.FacilitySchedule)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_545");

                entity.HasOne(d => d.MasterCalendar)
                    .WithMany(p => p.FacilitySchedule)
                    .HasForeignKey(d => d.MasterCalendarId)
                    .HasConstraintName("R_855");

                entity.HasOne(d => d.TimeZone)
                    .WithMany(p => p.FacilitySchedule)
                    .HasForeignKey(d => d.TimeZoneId)
                    .HasConstraintName("R_563");
            });

            modelBuilder.Entity<FeeSchedule>(entity =>
            {
                entity.ToTable("FeeSchedule", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.FeeScheduleCode).HasColumnType("char(5)");

                entity.Property(e => e.FeeScheduleDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FeeScheduleName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.FeeScheduleType)
                    .WithMany(p => p.FeeSchedule)
                    .HasForeignKey(d => d.FeeScheduleTypeId)
                    .HasConstraintName("R_340");
            });

            modelBuilder.Entity<FeeScheduleDetail>(entity =>
            {
                entity.ToTable("FeeScheduleDetail", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.FeeAmount).HasColumnType("money");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.FeeSchedule)
                    .WithMany(p => p.FeeScheduleDetail)
                    .HasForeignKey(d => d.FeeScheduleId)
                    .HasConstraintName("R_514");

                entity.HasOne(d => d.MasterProcedure)
                    .WithMany(p => p.FeeScheduleDetail)
                    .HasForeignKey(d => d.MasterProcedureId)
                    .HasConstraintName("R_600");
            });

            modelBuilder.Entity<FeeScheduleType>(entity =>
            {
                entity.ToTable("FeeScheduleType", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.FeeScheduleTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.FeeScheduleTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FeeScheduleTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Field>(entity =>
            {
                entity.ToTable("Field", "USR");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.FieldCode).HasColumnType("char(5)");

                entity.Property(e => e.FieldDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.View)
                    .WithMany(p => p.Field)
                    .HasForeignKey(d => d.ViewId)
                    .HasConstraintName("R_866");
            });

            modelBuilder.Entity<Finance>(entity =>
            {
                entity.ToTable("Finance", "FIN");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.FinanceCode).HasColumnType("char(5)");

                entity.Property(e => e.FinanceDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FinanceName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FinanceRegion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialClassAccountGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.Finance)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_336");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Gender", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.GenderCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.GenderDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.GenderName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GeneralContractorContact>(entity =>
            {
                entity.ToTable("GeneralContractorContact", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.GeneralContractorContact)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_716");

                entity.HasOne(d => d.RealEstate)
                    .WithMany(p => p.GeneralContractorContact)
                    .HasForeignKey(d => d.RealEstateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_717");
            });

            modelBuilder.Entity<GeoCode>(entity =>
            {
                entity.ToTable("GeoCode", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.GeoCode)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_591");
            });

            modelBuilder.Entity<Guarantor>(entity =>
            {
                entity.ToTable("Guarantor", "ACC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Guarantor)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_298");
            });

            modelBuilder.Entity<HeightMeasurement>(entity =>
            {
                entity.ToTable("HeightMeasurement", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.HeightMeasurementCode).HasColumnType("char(5)");

                entity.Property(e => e.HeightMeasurementDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.HeightMeasurementName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<IdentityProofType>(entity =>
            {
                entity.ToTable("IdentityProofType", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.IdentityProofTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.IdentityProofTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.IdentityProofTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.ToTable("Insurance", "INS");

                entity.Property(e => e.CoPay).HasColumnType("money");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deductible).HasColumnType("money");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceFacilityId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredId)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PlanName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.ElectronicPayerIdentity)
                    .WithMany(p => p.Insurance)
                    .HasForeignKey(d => d.ElectronicPayerIdentityId)
                    .HasConstraintName("R_709");

                entity.HasOne(d => d.InsurancePayer)
                    .WithMany(p => p.Insurance)
                    .HasForeignKey(d => d.InsurancePayerId)
                    .HasConstraintName("R_404");

                entity.HasOne(d => d.InsurancePolicyType)
                    .WithMany(p => p.Insurance)
                    .HasForeignKey(d => d.InsurancePolicyTypeId)
                    .HasConstraintName("R_702");

                entity.HasOne(d => d.InsuranceStageType)
                    .WithMany(p => p.Insurance)
                    .HasForeignKey(d => d.InsuranceStageTypeId)
                    .HasConstraintName("R_710");

                entity.HasOne(d => d.Subscriber)
                    .WithMany(p => p.Insurance)
                    .HasForeignKey(d => d.SubscriberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_360");
            });

            modelBuilder.Entity<InsuranceAddress>(entity =>
            {
                entity.ToTable("InsuranceAddress", "INS");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.InsuranceAddress)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("R_435");

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.InsuranceAddress)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_436");

                entity.HasOne(d => d.InsurancePayer)
                    .WithMany(p => p.InsuranceAddress)
                    .HasForeignKey(d => d.InsurancePayerId)
                    .HasConstraintName("R_728");
            });

            modelBuilder.Entity<InsuranceContact>(entity =>
            {
                entity.ToTable("InsuranceContact", "INS");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.InsurancePayer)
                    .WithMany(p => p.InsuranceContact)
                    .HasForeignKey(d => d.InsurancePayerId)
                    .HasConstraintName("R_727");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.InsuranceContact)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_694");
            });

            modelBuilder.Entity<InsuranceElectronicTransaction>(entity =>
            {
                entity.ToTable("InsuranceElectronicTransaction", "INS");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.InsuranceElectronicTransactionType)
                    .WithMany(p => p.InsuranceElectronicTransaction)
                    .HasForeignKey(d => d.InsuranceElectronicTransactionTypeId)
                    .HasConstraintName("R_696");

                entity.HasOne(d => d.InsurancePayer)
                    .WithMany(p => p.InsuranceElectronicTransaction)
                    .HasForeignKey(d => d.InsurancePayerId)
                    .HasConstraintName("R_729");
            });

            modelBuilder.Entity<InsuranceElectronicTransactionType>(entity =>
            {
                entity.ToTable("InsuranceElectronicTransactionType", "INS");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.InsuranceElectronicTransactionTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.InsuranceElectronicTransactionTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceElectronicTransactionTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<InsurancePayer>(entity =>
            {
                entity.ToTable("InsurancePayer", "INS");

                entity.Property(e => e.CompanyNumber)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(1);

                entity.Property(e => e.InsuranceCompanyName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsurancePayerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsurancePayerName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InsurancePayerTypeFk).HasColumnName("InsurancePayerTypeFK");

                entity.Property(e => e.MedicaidClaimTypeFk).HasColumnName("MedicaidClaimTypeFK");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Website).HasMaxLength(1);
            });

            modelBuilder.Entity<InsurancePayerIdentity>(entity =>
            {
                entity.HasKey(e => e.ElectronicPayerIdentityId);

                entity.ToTable("InsurancePayerIdentity", "INS");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ElectronicPayerIdentity).HasColumnType("char(18)");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.ClearingHouse)
                    .WithMany(p => p.InsurancePayerIdentity)
                    .HasForeignKey(d => d.ClearingHouseId)
                    .HasConstraintName("R_708");

                entity.HasOne(d => d.InsurancePayer)
                    .WithMany(p => p.InsurancePayerIdentity)
                    .HasForeignKey(d => d.InsurancePayerId)
                    .HasConstraintName("R_707");
            });

            modelBuilder.Entity<InsurancePolicyType>(entity =>
            {
                entity.ToTable("InsurancePolicyType", "INS");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.InsurancePolicyTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.InsurancePolicyTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.InsurancePolicyTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<InsuranceStageType>(entity =>
            {
                entity.ToTable("InsuranceStageType", "INS");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.InsuranceStageTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.InsuranceStageTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceStageTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<JobCode>(entity =>
            {
                entity.ToTable("JobCode", "USR");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.JobCodeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JobCodeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.JobCodeName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.JobCode)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("R_618");
            });

            modelBuilder.Entity<LandLordContact>(entity =>
            {
                entity.ToTable("LandLordContact", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.RealEstate)
                    .WithMany(p => p.LandLordContact)
                    .HasForeignKey(d => d.RealEstateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_715");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Language", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ledger>(entity =>
            {
                entity.ToTable("Ledger", "ACC");

                entity.Property(e => e.AdjustmentAmount).HasColumnType("money");

                entity.Property(e => e.AllowedAmount).HasColumnType("money");

                entity.Property(e => e.BalanceDue).HasColumnType("money");

                entity.Property(e => e.BilledAmount).HasColumnType("money");

                entity.Property(e => e.CoInsurance).HasColumnType("money");

                entity.Property(e => e.CoPay).HasColumnType("money");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeductableAmount).HasColumnType("money");

                entity.Property(e => e.LastStatementDate).HasColumnType("datetime");

                entity.Property(e => e.LedgerBalance).HasColumnType("money");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PaidAmount).HasColumnType("money");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Ledger)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_525");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Ledger)
                    .HasForeignKey(d => d.VisitId)
                    .HasConstraintName("R_678");
            });

            modelBuilder.Entity<Lender>(entity =>
            {
                entity.ToTable("Lender", "FIN");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Finance)
                    .WithMany(p => p.Lender)
                    .HasForeignKey(d => d.FinanceId)
                    .HasConstraintName("R_364");

                entity.HasOne(d => d.LenderType)
                    .WithMany(p => p.Lender)
                    .HasForeignKey(d => d.LenderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_362");
            });

            modelBuilder.Entity<LenderType>(entity =>
            {
                entity.ToTable("LenderType", "FIN");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.LenderTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.LenderTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.LenderTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<LocationStatus>(entity =>
            {
                entity.ToTable("LocationStatus", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.LocationStatusCode).HasColumnType("char(5)");

                entity.Property(e => e.LocationStatusDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.LocationStatusName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Marketing>(entity =>
            {
                entity.ToTable("Marketing", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Dma)
                    .HasColumnName("DMA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalMarketingName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingArea)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OfferDisclaimers)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PricingRegions)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WebsiteActive)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WebsiteComments)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WebsiteGeolocation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WebsiteMarketingPlaza)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WebsiteName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WebsiteNeighboringAreas)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.Marketing)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_335");
            });

            modelBuilder.Entity<MasterCalendar>(entity =>
            {
                entity.ToTable("MasterCalendar", "FAC");

                entity.Property(e => e.MasterCalendarId).ValueGeneratedNever();

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.MasterDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.MasterSchedule)
                    .WithMany(p => p.MasterCalendar)
                    .HasForeignKey(d => d.MasterScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_841");

                entity.HasOne(d => d.TimeBlock)
                    .WithMany(p => p.MasterCalendar)
                    .HasForeignKey(d => d.TimeBlockId)
                    .HasConstraintName("R_856");
            });

            modelBuilder.Entity<MasterPayee>(entity =>
            {
                entity.ToTable("MasterPayee", "ACC");

                entity.Property(e => e.MasterPayeeId).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PayeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterPayer>(entity =>
            {
                entity.ToTable("MasterPayer", "ACC");

                entity.Property(e => e.MasterPayerId).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PayerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterProcedure>(entity =>
            {
                entity.ToTable("MasterProcedure", "TRE");

                entity.Property(e => e.Cdtcode)
                    .HasColumnName("CDTCode")
                    .HasColumnType("char(5)");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Icd10code)
                    .HasColumnName("ICD_10Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MasterProcedureDescription)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.SnodentCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MasterTreatmentPlan)
                    .WithMany(p => p.MasterProcedure)
                    .HasForeignKey(d => d.MasterTreatmentPlanId)
                    .HasConstraintName("R_567");
            });

            modelBuilder.Entity<MasterSchedule>(entity =>
            {
                entity.ToTable("MasterSchedule", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.MasterScheduleCode).HasColumnType("char(5)");

                entity.Property(e => e.MasterScheduleDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.MasterScheduleName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.MasterSchedule)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_842");
            });

            modelBuilder.Entity<MasterTreatmentPlan>(entity =>
            {
                entity.ToTable("MasterTreatmentPlan", "TRE");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.MasterTreatmentPlanCode).HasColumnType("char(5)");

                entity.Property(e => e.MasterTreatmentPlanDescription)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.AppointmentClass)
                    .WithMany(p => p.MasterTreatmentPlan)
                    .HasForeignKey(d => d.AppointmentClassId)
                    .HasConstraintName("R_657");

                entity.HasOne(d => d.VisitReasonType)
                    .WithMany(p => p.MasterTreatmentPlan)
                    .HasForeignKey(d => d.VisitReasonTypeId)
                    .HasConstraintName("R_568");
            });

            modelBuilder.Entity<MedicalAlert>(entity =>
            {
                entity.ToTable("MedicalAlert", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.MedicalAlertCode).HasColumnType("char(5)");

                entity.Property(e => e.MedicalAlertDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalAlertName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MedicalHistoryAnswerType>(entity =>
            {
                entity.ToTable("MedicalHistoryAnswerType", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.MedicalHistoryAnswerTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.MedicalHistoryAnswerTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalHistoryAnswerTypeName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MedicalHistoryAnswerTypeValue>(entity =>
            {
                entity.ToTable("MedicalHistoryAnswerTypeValue", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.MedicalHistoryAnswerType)
                    .WithMany(p => p.MedicalHistoryAnswerTypeValue)
                    .HasForeignKey(d => d.MedicalHistoryAnswerTypeId)
                    .HasConstraintName("R_883");

                entity.HasOne(d => d.MedicalHistoryAnswerValue)
                    .WithMany(p => p.MedicalHistoryAnswerTypeValue)
                    .HasForeignKey(d => d.MedicalHistoryAnswerValueId)
                    .HasConstraintName("R_884");
            });

            modelBuilder.Entity<MedicalHistoryAnswerValue>(entity =>
            {
                entity.ToTable("MedicalHistoryAnswerValue", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.MedicalHistoryAnswerValueCode).HasColumnType("char(5)");

                entity.Property(e => e.MedicalHistoryAnswerValueDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalHistoryAnswerValueName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MedicalHistoryControlType>(entity =>
            {
                entity.ToTable("MedicalHistoryControlType", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.MedicalHistoryControlTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.MedicalHistoryControlTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalHistoryControlTypeName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MedicalHistoryQuestion>(entity =>
            {
                entity.ToTable("MedicalHistoryQuestion", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.MedicalHistoryQuestionName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ParentMedicalHistoryQuestionTriggerValue)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.HasOne(d => d.MedicalHistoryAnswerType)
                    .WithMany(p => p.MedicalHistoryQuestion)
                    .HasForeignKey(d => d.MedicalHistoryAnswerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_166");

                entity.HasOne(d => d.MedicalHistoryControlType)
                    .WithMany(p => p.MedicalHistoryQuestion)
                    .HasForeignKey(d => d.MedicalHistoryControlTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_379");

                entity.HasOne(d => d.MedicalHistorySection)
                    .WithMany(p => p.MedicalHistoryQuestion)
                    .HasForeignKey(d => d.MedicalHistorySectionId)
                    .HasConstraintName("R_882");
            });

            modelBuilder.Entity<MedicalHistorySection>(entity =>
            {
                entity.ToTable("MedicalHistorySection", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.MedicalHistorySectionCode).HasColumnType("char(5)");

                entity.Property(e => e.MedicalHistorySectionDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalHistorySectionName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.Header)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MessageCode).HasColumnType("char(5)");

                entity.Property(e => e.MessageDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.MessageName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.MessageType)
                    .WithMany(p => p.Message)
                    .HasForeignKey(d => d.MessageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_299");
            });

            modelBuilder.Entity<MessageSource>(entity =>
            {
                entity.ToTable("MessageSource", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Object)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.MessageSource)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("R_877");
            });

            modelBuilder.Entity<MessageSourceMap>(entity =>
            {
                entity.ToTable("MessageSourceMap", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.MessageSourceMap)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_301");

                entity.HasOne(d => d.MessageSource)
                    .WithMany(p => p.MessageSourceMap)
                    .HasForeignKey(d => d.MessageSourceId)
                    .HasConstraintName("R_878");
            });

            modelBuilder.Entity<MessageTarget>(entity =>
            {
                entity.ToTable("MessageTarget", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Marketing)
                    .WithMany(p => p.MessageTarget)
                    .HasForeignKey(d => d.MarketingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_351");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.MessageTarget)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_304");
            });

            modelBuilder.Entity<MessageType>(entity =>
            {
                entity.ToTable("MessageType", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.MessageTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.MessageTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.MessageTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.ToTable("Module", "USR");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModuleCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OfficeHours>(entity =>
            {
                entity.ToTable("OfficeHours", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OfficeHoursCode).HasColumnType("char(5)");

                entity.Property(e => e.OfficeHoursDate).HasColumnType("datetime");

                entity.Property(e => e.OfficeHoursDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeHoursName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.FacilitySchedule)
                    .WithMany(p => p.OfficeHours)
                    .HasForeignKey(d => d.FacilityScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_581");
            });

            modelBuilder.Entity<Operatory>(entity =>
            {
                entity.ToTable("Operatory", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OperatoryCode).HasColumnType("char(5)");

                entity.Property(e => e.OperatoryDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.OperatoryName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.FacilitySchedule)
                    .WithMany(p => p.Operatory)
                    .HasForeignKey(d => d.FacilityScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_609");
            });

            modelBuilder.Entity<OrderImage>(entity =>
            {
                entity.ToTable("OrderImage", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Indications)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Jewelry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OpenWounds)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderImagesDate).HasColumnType("datetime");

                entity.Property(e => e.OrderImagesGuid)
                    .HasColumnName("OrderImagesGUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientComfortableEnclosedSpaces)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PatientLieOnBack)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Priority)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RiskOfFall)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduledTestDate).HasColumnType("datetime");

                entity.HasOne(d => d.DiagnosticCenter)
                    .WithMany(p => p.OrderImage)
                    .HasForeignKey(d => d.DiagnosticCenterId)
                    .HasConstraintName("R_907");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.OrderImage)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_396");
            });

            modelBuilder.Entity<OrderImageDiagnosticTestCategory>(entity =>
            {
                entity.ToTable("OrderImageDiagnosticTestCategory", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OrderImageDiagnosticTestCategoryComments).HasMaxLength(150);

                entity.HasOne(d => d.DiagnosticLocation)
                    .WithMany(p => p.OrderImageDiagnosticTestCategory)
                    .HasForeignKey(d => d.DiagnosticLocationId)
                    .HasConstraintName("R_903");

                entity.HasOne(d => d.DiagnosticTestCategory)
                    .WithMany(p => p.OrderImageDiagnosticTestCategory)
                    .HasForeignKey(d => d.DiagnosticTestCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_474");

                entity.HasOne(d => d.OrderImage)
                    .WithMany(p => p.OrderImageDiagnosticTestCategory)
                    .HasForeignKey(d => d.OrderImageId)
                    .HasConstraintName("R_904");
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.ToTable("Organization", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OrganizationCode).HasColumnType("char(5)");

                entity.Property(e => e.OrganizationDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PatientCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_908");
            });

            modelBuilder.Entity<PatientChartReview>(entity =>
            {
                entity.ToTable("PatientChartReview", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartTimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientChartReview)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("R_896");
            });

            modelBuilder.Entity<PatientConsentForm>(entity =>
            {
                entity.ToTable("PatientConsentForm", "CLI");

                entity.Property(e => e.AreaofMouth).HasMaxLength(100);

                entity.Property(e => e.ConsentDate).HasColumnType("datetime");

                entity.Property(e => e.ConsentStatus).HasMaxLength(100);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DateofService).HasColumnType("datetime");

                entity.Property(e => e.DocumentDescription).HasMaxLength(1);

                entity.Property(e => e.DocumentTitle).HasMaxLength(200);

                entity.Property(e => e.FormType).HasMaxLength(100);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(1);

                entity.Property(e => e.SignaturePath).HasMaxLength(200);

                entity.Property(e => e.UploadedForm).HasMaxLength(1);

                entity.HasOne(d => d.ConsentForm)
                    .WithMany(p => p.PatientConsentForm)
                    .HasForeignKey(d => d.ConsentFormId)
                    .HasConstraintName("R_906");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.PatientConsentForm)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .HasConstraintName("R_485");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PatientConsentForm)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("R_494");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.PatientConsentForm)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("R_483");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientConsentForm)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_383");
            });

            modelBuilder.Entity<PatientDocumentPath>(entity =>
            {
                entity.ToTable("PatientDocumentPath", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RootPath).HasMaxLength(1);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientDocumentPath)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_395");
            });

            modelBuilder.Entity<PatientMedicalAlert>(entity =>
            {
                entity.ToTable("PatientMedicalAlert", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.MedicalAlert)
                    .WithMany(p => p.PatientMedicalAlert)
                    .HasForeignKey(d => d.MedicalAlertId)
                    .HasConstraintName("R_880");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientMedicalAlert)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("R_879");
            });

            modelBuilder.Entity<PatientMedicalHistory>(entity =>
            {
                entity.ToTable("PatientMedicalHistory", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Program)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientMedicalHistory)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_126");
            });

            modelBuilder.Entity<PatientMedicalHistoryDetail>(entity =>
            {
                entity.ToTable("PatientMedicalHistoryDetail", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.MedicalHistoryAnswer)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.MedicalHistoryAnswerTypeValue)
                    .WithMany(p => p.PatientMedicalHistoryDetail)
                    .HasForeignKey(d => d.MedicalHistoryAnswerTypeValueId)
                    .HasConstraintName("R_772");

                entity.HasOne(d => d.MedicalHistoryQuestion)
                    .WithMany(p => p.PatientMedicalHistoryDetail)
                    .HasForeignKey(d => d.MedicalHistoryQuestionId)
                    .HasConstraintName("R_885");

                entity.HasOne(d => d.PatientMedicalHistory)
                    .WithMany(p => p.PatientMedicalHistoryDetail)
                    .HasForeignKey(d => d.PatientMedicalHistoryId)
                    .HasConstraintName("R_881");
            });

            modelBuilder.Entity<PatientNote>(entity =>
            {
                entity.ToTable("PatientNote", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NoteDate).HasColumnType("datetime");

                entity.Property(e => e.PatientNoteTypeId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientNote)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("R_381");

                entity.HasOne(d => d.PatientNoteTemplate)
                    .WithMany(p => p.PatientNote)
                    .HasForeignKey(d => d.PatientNoteTemplateId)
                    .HasConstraintName("R_755");

                entity.HasOne(d => d.PatientNoteType)
                    .WithMany(p => p.PatientNote)
                    .HasForeignKey(d => d.PatientNoteTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_382");

                entity.HasOne(d => d.PatientProcedure)
                    .WithMany(p => p.PatientNote)
                    .HasForeignKey(d => d.PatientProcedureId)
                    .HasConstraintName("R_754");
            });

            modelBuilder.Entity<PatientNoteTemplate>(entity =>
            {
                entity.ToTable("PatientNoteTemplate", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UserNote).HasMaxLength(1);
            });

            modelBuilder.Entity<PatientNoteType>(entity =>
            {
                entity.ToTable("PatientNoteType", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PatientNoteTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.PatientNoteTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PatientNoteTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatientPhoto>(entity =>
            {
                entity.ToTable("PatientPhoto", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ImageDate).HasColumnType("datetime");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientPhoto)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_380");
            });

            modelBuilder.Entity<PatientPreference>(entity =>
            {
                entity.ToTable("PatientPreference", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientPreference)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("R_911");

                entity.HasOne(d => d.PreferenceType)
                    .WithMany(p => p.PatientPreference)
                    .HasForeignKey(d => d.PreferenceTypeId)
                    .HasConstraintName("R_834");
            });

            modelBuilder.Entity<PatientProcedure>(entity =>
            {
                entity.ToTable("PatientProcedure", "TRE");

                entity.Property(e => e.CouponDiscount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EstimatedInsuranceBenefit).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.EstimatedInsuranceDiscount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Fee).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PatientFinancialResposibility).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Surface)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SurfaceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ToothQuadrantCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CategoryFilter)
                    .WithMany(p => p.PatientProcedure)
                    .HasForeignKey(d => d.CategoryFilterId)
                    .HasConstraintName("R_409");

                entity.HasOne(d => d.MasterProcedure)
                    .WithMany(p => p.PatientProcedure)
                    .HasForeignKey(d => d.MasterProcedureId)
                    .HasConstraintName("R_824");

                entity.HasOne(d => d.PatientTooth)
                    .WithMany(p => p.PatientProcedure)
                    .HasForeignKey(d => d.PatientToothId)
                    .HasConstraintName("R_828");

                entity.HasOne(d => d.PatientTreatmentPlan)
                    .WithMany(p => p.PatientProcedure)
                    .HasForeignKey(d => d.PatientTreatmentPlanId)
                    .HasConstraintName("R_827");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.PatientProcedure)
                    .HasForeignKey(d => d.VisitId)
                    .HasConstraintName("R_590");
            });

            modelBuilder.Entity<PatientProcedureLog>(entity =>
            {
                entity.ToTable("PatientProcedureLog", "TRE");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DateOfService).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Surface)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ToothRange)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.PatientProcedure)
                    .WithMany(p => p.PatientProcedureLog)
                    .HasForeignKey(d => d.PatientProcedureId)
                    .HasConstraintName("R_417");

                entity.HasOne(d => d.PatientTooth)
                    .WithMany(p => p.PatientProcedureLog)
                    .HasForeignKey(d => d.PatientToothId)
                    .HasConstraintName("R_829");
            });

            modelBuilder.Entity<PatientTooth>(entity =>
            {
                entity.ToTable("PatientTooth", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PatientToothCode).HasColumnType("char(5)");
            });

            modelBuilder.Entity<PatientTreatmentPlan>(entity =>
            {
                entity.ToTable("PatientTreatmentPlan", "TRE");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateComplete).HasColumnType("datetime");

                entity.Property(e => e.DatePreAuthorizationFiled).HasColumnType("datetime");

                entity.Property(e => e.DiagnosingProvider)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EstimateRunDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExceptionNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsideReferringProvider)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PatientBalance).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PatientFinancialResponsibility).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PdfFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PdfFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlannedPayment).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PreAuthorizationExpires).HasColumnType("datetime");

                entity.Property(e => e.PreAuthorizationNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ToothSurface)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCouponDiscount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TotalEstimatedInsuranceBenefit).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TotalEstimatedInsuranceDiscount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TotalPlanFee)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentPlanDate).HasColumnType("datetime");

                entity.HasOne(d => d.BundledService)
                    .WithMany(p => p.PatientTreatmentPlan)
                    .HasForeignKey(d => d.BundledServiceId)
                    .HasConstraintName("R_752");

                entity.HasOne(d => d.MasterTreatmentPlan)
                    .WithMany(p => p.PatientTreatmentPlan)
                    .HasForeignKey(d => d.MasterTreatmentPlanId)
                    .HasConstraintName("R_631");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientTreatmentPlan)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_606");

                entity.HasOne(d => d.PatientTooth)
                    .WithMany(p => p.PatientTreatmentPlan)
                    .HasForeignKey(d => d.PatientToothId)
                    .HasConstraintName("R_791");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.PatientTreatmentPlan)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("R_677");

                entity.HasOne(d => d.TreatmentPlanOption)
                    .WithMany(p => p.PatientTreatmentPlan)
                    .HasForeignKey(d => d.TreatmentPlanOptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_337");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment", "ACC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PaymentAmount).HasColumnType("money");

                entity.Property(e => e.PaymentComments)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentReference)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedAmount).HasColumnType("money");

                entity.Property(e => e.UnAppliedAmount).HasColumnType("money");

                entity.HasOne(d => d.PaymentMode)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.PaymentModeId)
                    .HasConstraintName("R_675");

                entity.HasOne(d => d.PaymentSource)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.PaymentSourceId)
                    .HasConstraintName("R_679");

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .HasConstraintName("R_676");
            });

            modelBuilder.Entity<PaymentMode>(entity =>
            {
                entity.ToTable("PaymentMode", "ACC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PaymentModeCode).HasColumnType("char(5)");

                entity.Property(e => e.PaymentModeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentModeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentSource>(entity =>
            {
                entity.ToTable("PaymentSource", "ACC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PaymentSourceCode).HasColumnType("char(5)");

                entity.Property(e => e.PaymentSourceDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentSourceName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentStatus>(entity =>
            {
                entity.ToTable("PaymentStatus", "ACC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PaymentStatusCode).HasColumnType("char(5)");

                entity.Property(e => e.PaymentStatusDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentStatusName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PerioChangeTooth>(entity =>
            {
                entity.ToTable("PerioChangeTooth", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PerioChart>(entity =>
            {
                entity.ToTable("PerioChart", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsCompleted).HasDefaultValueSql("((1))");

                entity.Property(e => e.Laaid).HasColumnName("LAAId");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PerioChartName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Score1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Score2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Score3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Score4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Score5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Score6).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BrushType)
                    .WithMany(p => p.PerioChart)
                    .HasForeignKey(d => d.BrushTypeId)
                    .HasConstraintName("R_900");

                entity.HasOne(d => d.CaseType)
                    .WithMany(p => p.PerioChart)
                    .HasForeignKey(d => d.CaseTypeId)
                    .HasConstraintName("R_902");

                entity.HasOne(d => d.ConditionBySextant)
                    .WithMany(p => p.PerioChart)
                    .HasForeignKey(d => d.ConditionBySextantId)
                    .HasConstraintName("R_898");

                entity.HasOne(d => d.ConditionsOnAllTeeth)
                    .WithMany(p => p.PerioChart)
                    .HasForeignKey(d => d.ConditionsOnAllTeethId)
                    .HasConstraintName("R_899");

                entity.HasOne(d => d.PatientTooth)
                    .WithMany(p => p.PerioChart)
                    .HasForeignKey(d => d.PatientToothId)
                    .HasConstraintName("R_789");

                entity.HasOne(d => d.PerioChangeTooth)
                    .WithMany(p => p.PerioChart)
                    .HasForeignKey(d => d.PerioChangeToothId)
                    .HasConstraintName("R_234");

                entity.HasOne(d => d.PerioExam)
                    .WithMany(p => p.PerioChart)
                    .HasForeignKey(d => d.PerioExamId)
                    .HasConstraintName("R_788");

                entity.HasOne(d => d.TobaccoType)
                    .WithMany(p => p.PerioChart)
                    .HasForeignKey(d => d.TobaccoTypeId)
                    .HasConstraintName("R_901");

                entity.HasOne(d => d.ToothType)
                    .WithMany(p => p.PerioChart)
                    .HasForeignKey(d => d.ToothTypeId)
                    .HasConstraintName("R_790");
            });

            modelBuilder.Entity<PerioExam>(entity =>
            {
                entity.ToTable("PerioExam", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Diagnosis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PerioExamDate).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PerioExam)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("R_773");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PerioExam)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("R_774");
            });

            modelBuilder.Entity<PerioMeasure>(entity =>
            {
                entity.ToTable("PerioMeasure", "CLI");

                entity.Property(e => e.Bvalue).HasColumnName("BValue");

                entity.Property(e => e.CreatedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Dbvalue).HasColumnName("DBValue");

                entity.Property(e => e.Dlvalue).HasColumnName("DLValue");

                entity.Property(e => e.Lvalue).HasColumnName("LValue");

                entity.Property(e => e.Mbvalue).HasColumnName("MBValue");

                entity.Property(e => e.Mlvalue).HasColumnName("MLValue");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.PatientTooth)
                    .WithMany(p => p.PerioMeasure)
                    .HasForeignKey(d => d.PatientToothId)
                    .HasConstraintName("R_830");

                entity.HasOne(d => d.PerioChart)
                    .WithMany(p => p.PerioMeasure)
                    .HasForeignKey(d => d.PerioChartId)
                    .HasConstraintName("R_897");
            });

            modelBuilder.Entity<PerioMissingTooth>(entity =>
            {
                entity.ToTable("PerioMissingTooth", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.PatientTooth)
                    .WithMany(p => p.PerioMissingTooth)
                    .HasForeignKey(d => d.PatientToothId)
                    .HasConstraintName("R_831");

                entity.HasOne(d => d.PerioChart)
                    .WithMany(p => p.PerioMissingTooth)
                    .HasForeignKey(d => d.PerioChartId)
                    .HasConstraintName("R_760");
            });

            modelBuilder.Entity<PerioNote>(entity =>
            {
                entity.HasKey(e => e.PerioNotesId);

                entity.ToTable("PerioNote", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PerioNoteDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.HasOne(d => d.PerioExam)
                    .WithMany(p => p.PerioNote)
                    .HasForeignKey(d => d.PerioExamId)
                    .HasConstraintName("R_833");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("Permission", "USR");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PermissionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionName)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person", "PER");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.IdentityExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.IdentityProofNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.SocialSecurityNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("R_910");

                entity.HasOne(d => d.IdentityProofType)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.IdentityProofTypeId)
                    .HasConstraintName("R_580");

                entity.HasOne(d => d.Prefix)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.PrefixId)
                    .HasConstraintName("R_570");

                entity.HasOne(d => d.Suffix)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.SuffixId)
                    .HasConstraintName("R_909");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("R_292");
            });

            modelBuilder.Entity<PersonAddress>(entity =>
            {
                entity.ToTable("PersonAddress", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PersonAddressComment)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.PersonAddress)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_241");

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.PersonAddress)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_328");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonAddress)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_242");
            });

            modelBuilder.Entity<PersonLanguage>(entity =>
            {
                entity.ToTable("PersonLanguage", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.PersonLanguage)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_551");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonLanguage)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_552");
            });

            modelBuilder.Entity<PersonPhone>(entity =>
            {
                entity.ToTable("PersonPhone", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonPhone)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_239");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.PersonPhone)
                    .HasForeignKey(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_240");

                entity.HasOne(d => d.PhoneType)
                    .WithMany(p => p.PersonPhone)
                    .HasForeignKey(d => d.PhoneTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_329");
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.ToTable("Phone", "PER");

                entity.Property(e => e.AreaCode).HasColumnType("char(3)");

                entity.Property(e => e.CountryCode).HasColumnType("char(3)");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Extension)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.IsTextCapable).HasColumnType("char(1)");

                entity.Property(e => e.Line).HasColumnType("char(4)");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Nxx)
                    .HasColumnName("NXX")
                    .HasColumnType("char(3)");
            });

            modelBuilder.Entity<PhoneType>(entity =>
            {
                entity.ToTable("PhoneType", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PhoneTypeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneTypeName)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreferenceType>(entity =>
            {
                entity.ToTable("PreferenceType", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PreferenceTypeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PreferenceTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PreferenceTypeName)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prefix>(entity =>
            {
                entity.ToTable("Prefix", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PrefixCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PrefixDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PrefixName)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProcedureCodeCategory>(entity =>
            {
                entity.ToTable("ProcedureCodeCategory", "INS");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ProcedureCodeCategory1)
                    .HasColumnName("ProcedureCodeCategory")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureCodeMax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureCodeMin)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.ToTable("Promotion", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PromotionCode).HasColumnType("char(5)");

                entity.Property(e => e.PromotionDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionNotes)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Marketing)
                    .WithMany(p => p.Promotion)
                    .HasForeignKey(d => d.MarketingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_597");

                entity.HasOne(d => d.PromotionType)
                    .WithMany(p => p.Promotion)
                    .HasForeignKey(d => d.PromotionTypeId)
                    .HasConstraintName("R_338");
            });

            modelBuilder.Entity<PromotionType>(entity =>
            {
                entity.ToTable("PromotionType", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PromotionTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.PromotionTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prospect>(entity =>
            {
                entity.ToTable("Prospect", "FAC");

                entity.Property(e => e.CallerFirstName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CallerLastName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PatientFirstName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PatientLastName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.Prospect)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("R_378");

                entity.HasOne(d => d.VisitReasonType)
                    .WithMany(p => p.Prospect)
                    .HasForeignKey(d => d.VisitReasonTypeId)
                    .HasConstraintName("R_607");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.ToTable("Provider", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Npinumber)
                    .HasColumnName("NPINumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderDoseSpotClinicianId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Provider)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_852");
            });

            modelBuilder.Entity<ProviderInsurance>(entity =>
            {
                entity.ToTable("ProviderInsurance", "INS");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PayeeIdentification)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.InsurancePayer)
                    .WithMany(p => p.ProviderInsurance)
                    .HasForeignKey(d => d.InsurancePayerId)
                    .HasConstraintName("R_733");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ProviderInsurance)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("R_497");
            });

            modelBuilder.Entity<ProviderType>(entity =>
            {
                entity.ToTable("ProviderType", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ProviderTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.ProviderTypeDescription)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PulseRhythmType>(entity =>
            {
                entity.ToTable("PulseRhythmType", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PulseRhythmTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.PulseRhythmTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PulseRhythmTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RealEstate>(entity =>
            {
                entity.ToTable("RealEstate", "FAC");

                entity.Property(e => e.CountyIdentity).HasColumnType("char(2)");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.FeeSchedule)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.RealEstateRegionIdentity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RealEstateSchedulingProviderIdentity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegionIdentity).HasColumnType("char(4)");

                entity.Property(e => e.TaxIdIdentity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Territory)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.RealEstate)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_333");
            });

            modelBuilder.Entity<Relationship>(entity =>
            {
                entity.ToTable("Relationship", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Relationship)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_209");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Relationship)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_208");

                entity.HasOne(d => d.RelationshipType)
                    .WithMany(p => p.Relationship)
                    .HasForeignKey(d => d.RelationshipTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_210");
            });

            modelBuilder.Entity<RelationshipType>(entity =>
            {
                entity.ToTable("RelationshipType", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RelationshipTypeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipTypeName)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Remittance>(entity =>
            {
                entity.ToTable("Remittance", "ACC");

                entity.Property(e => e.RemittanceId).ValueGeneratedNever();

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EobaccountNumber)
                    .HasColumnName("EOBAccountNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EobcheckAmount)
                    .HasColumnName("EOBCheckAmount")
                    .HasColumnType("money");

                entity.Property(e => e.EobcheckNumber)
                    .HasColumnName("EOBCheckNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Eobpayer)
                    .HasColumnName("EOBPayer")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EobreceivedDate)
                    .HasColumnName("EOBReceivedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Insurance)
                    .WithMany(p => p.Remittance)
                    .HasForeignKey(d => d.InsuranceId)
                    .HasConstraintName("R_530");
            });

            modelBuilder.Entity<ReviewReason>(entity =>
            {
                entity.ToTable("ReviewReason", "SCH");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ReviewReasonCode).HasColumnType("char(5)");

                entity.Property(e => e.ReviewReasonDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewReasonName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role", "USR");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RoleCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RoleDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.ToTable("RolePermission", "USR");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RolePermissionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RolePermissionDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.RolePermissionName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.RolePermission)
                    .HasForeignKey(d => d.FieldId)
                    .HasConstraintName("R_867");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.RolePermission)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("R_864");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.RolePermission)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("R_871");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePermission)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("R_869");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RolePermission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_636");

                entity.HasOne(d => d.View)
                    .WithMany(p => p.RolePermission)
                    .HasForeignKey(d => d.ViewId)
                    .HasConstraintName("R_868");
            });

            modelBuilder.Entity<RuleCondition>(entity =>
            {
                entity.ToTable("RuleCondition", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RuleConditionCode).HasColumnType("char(5)");

                entity.Property(e => e.RuleConditionDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.RuleConditionName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RuleOperator>(entity =>
            {
                entity.ToTable("RuleOperator", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RuleOperatorCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RuleOperatorDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.RuleOperatorName)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SecurityQuestion>(entity =>
            {
                entity.ToTable("SecurityQuestion", "USR");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.SecurityQuestionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityQuestionDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityQuestionName)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("State", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StateDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("R_915");
            });

            modelBuilder.Entity<Statement>(entity =>
            {
                entity.ToTable("Statement", "ACC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.StatementCode).HasColumnType("char(5)");

                entity.Property(e => e.StatementDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.StatementName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Accounting)
                    .WithMany(p => p.Statement)
                    .HasForeignKey(d => d.AccountingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_363");
            });

            modelBuilder.Entity<Subscriber>(entity =>
            {
                entity.ToTable("Subscriber", "ACC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.CoverageType)
                    .WithMany(p => p.Subscriber)
                    .HasForeignKey(d => d.CoverageTypeId)
                    .HasConstraintName("R_440");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Subscriber)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_312");
            });

            modelBuilder.Entity<Suffix>(entity =>
            {
                entity.ToTable("Suffix", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.SuffixCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SuffixDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.SuffixName)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Telecom>(entity =>
            {
                entity.ToTable("Telecom", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelecomCode).HasColumnType("char(5)");

                entity.Property(e => e.TelecomDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.TelecomName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.Telecom)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_334");
            });

            modelBuilder.Entity<TelecomVendor>(entity =>
            {
                entity.ToTable("TelecomVendor", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ispipgateway)
                    .HasColumnName("ISPIPGateway")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IspphoneNumber)
                    .HasColumnName("ISPPhoneNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IspserviceType)
                    .HasColumnName("ISPServiceType")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ispvendor)
                    .HasColumnName("ISPVendor")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelecomVendorCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TelecomVendorDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.TelecomVendorName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Telecom)
                    .WithMany(p => p.TelecomVendor)
                    .HasForeignKey(d => d.TelecomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_583");
            });

            modelBuilder.Entity<TimeBlock>(entity =>
            {
                entity.ToTable("TimeBlock", "SCH");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.TimeBlock1).HasColumnName("TimeBlock");

                entity.Property(e => e.TimeBlockCode).HasColumnType("char(5)");

                entity.Property(e => e.TimeBlockDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.TimeBlockName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TimeSlot>(entity =>
            {
                entity.ToTable("TimeSlot", "FAC");

                entity.Property(e => e.BlockedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TimeSlotCode).HasColumnType("char(5)");

                entity.Property(e => e.TimeSlotDate).HasColumnType("datetime");

                entity.Property(e => e.TimeSlotDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.TimeSlotName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Operatory)
                    .WithMany(p => p.TimeSlot)
                    .HasForeignKey(d => d.OperatoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_322");

                entity.HasOne(d => d.TimeBlock)
                    .WithMany(p => p.TimeSlot)
                    .HasForeignKey(d => d.TimeBlockId)
                    .HasConstraintName("R_173");
            });

            modelBuilder.Entity<TimeZone>(entity =>
            {
                entity.ToTable("TimeZone", "FAC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.TimeZoneCode).HasColumnType("char(5)");

                entity.Property(e => e.TimeZoneDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZoneName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TobaccoType>(entity =>
            {
                entity.ToTable("TobaccoType", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.TobaccoTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.TobaccoTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.TobaccoTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ToothType>(entity =>
            {
                entity.ToTable("ToothType", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ToothTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.ToothTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ToothTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transaction", "ACC");

                entity.Property(e => e.AdjustmentAmount).HasColumnType("money");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionAmount).HasColumnType("money");

                entity.Property(e => e.WriteOffAmount).HasColumnType("money");

                entity.HasOne(d => d.Ledger)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_523");
            });

            modelBuilder.Entity<TransactionCredit>(entity =>
            {
                entity.ToTable("TransactionCredit", "ACC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Check)
                    .WithMany(p => p.TransactionCredit)
                    .HasForeignKey(d => d.CheckId)
                    .HasConstraintName("R_763");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.TransactionCredit)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("R_764");

                entity.HasOne(d => d.Remittance)
                    .WithMany(p => p.TransactionCredit)
                    .HasForeignKey(d => d.RemittanceId)
                    .HasConstraintName("R_531");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.TransactionCredit)
                    .HasForeignKey(d => d.TransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_857");
            });

            modelBuilder.Entity<TransactionDebit>(entity =>
            {
                entity.ToTable("TransactionDebit", "ACC");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.PatientProcedure)
                    .WithMany(p => p.TransactionDebit)
                    .HasForeignKey(d => d.PatientProcedureId)
                    .HasConstraintName("R_628");

                entity.HasOne(d => d.PatientProcedureLog)
                    .WithMany(p => p.TransactionDebit)
                    .HasForeignKey(d => d.PatientProcedureLogId)
                    .HasConstraintName("R_825");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.TransactionDebit)
                    .HasForeignKey(d => d.TransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_858");
            });

            modelBuilder.Entity<TreatmentPlanOption>(entity =>
            {
                entity.ToTable("TreatmentPlanOption", "TRE");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.TreatmentPlanOptionCode).HasColumnType("char(5)");

                entity.Property(e => e.TreatmentPlanOptionDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentPlanOptionName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "USR");

                entity.Property(e => e.ActivationDate).HasColumnType("datetime");

                entity.Property(e => e.Answer)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ContractDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LastAccessDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_637");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_638");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_565");

                entity.HasOne(d => d.SecurityQuestion)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.SecurityQuestionId)
                    .HasConstraintName("R_688");

                entity.HasOne(d => d.UserSpecialty)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserSpecialtyId)
                    .HasConstraintName("R_592");

                entity.HasOne(d => d.UserStatus)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_203");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("R_579");
            });

            modelBuilder.Entity<UserPermission>(entity =>
            {
                entity.ToTable("UserPermission", "USR");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserPermissionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UserPermissionDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.UserPermissionName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.UserPermission)
                    .HasForeignKey(d => d.FieldId)
                    .HasConstraintName("R_876");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.UserPermission)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("R_863");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.UserPermission)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("R_870");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPermission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_634");

                entity.HasOne(d => d.View)
                    .WithMany(p => p.UserPermission)
                    .HasForeignKey(d => d.ViewId)
                    .HasConstraintName("R_875");
            });

            modelBuilder.Entity<UserSpecialty>(entity =>
            {
                entity.ToTable("UserSpecialty", "USR");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserSpecialtyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UserSpecialtyDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.UserSpecialtyName)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserStatus>(entity =>
            {
                entity.ToTable("UserStatus", "USR");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserStatusCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UserStatusDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.UserStatusName)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("UserType", "USR");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserTypeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeName)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<View>(entity =>
            {
                entity.ToTable("View", "USR");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ViewCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ViewDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ViewName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.View)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("R_865");
            });

            modelBuilder.Entity<Visit>(entity =>
            {
                entity.ToTable("Visit", "SCH");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DateOfService).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.PatientTreatmentPlan)
                    .WithMany(p => p.Visit)
                    .HasForeignKey(d => d.PatientTreatmentPlanId)
                    .HasConstraintName("R_589");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Visit)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("R_658");

                entity.HasOne(d => d.VisitReasonType)
                    .WithMany(p => p.Visit)
                    .HasForeignKey(d => d.VisitReasonTypeId)
                    .HasConstraintName("R_549");
            });

            modelBuilder.Entity<VisitReasonType>(entity =>
            {
                entity.ToTable("VisitReasonType", "SCH");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.VisitReasonTypeCode).HasColumnType("char(5)");

                entity.Property(e => e.VisitReasonTypeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.VisitReasonTypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VitalState>(entity =>
            {
                entity.ToTable("VitalState", "CLI");

                entity.Property(e => e.Bmi)
                    .HasColumnName("BMI")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.BmistatusId).HasColumnName("BMIStatusId");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Height).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Temperature).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.VitalDate).HasColumnType("datetime");

                entity.Property(e => e.VitalStateDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Bmistatus)
                    .WithMany(p => p.VitalState)
                    .HasForeignKey(d => d.BmistatusId)
                    .HasConstraintName("R_889");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.VitalState)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("R_776");

                entity.HasOne(d => d.HeightMeasurement)
                    .WithMany(p => p.VitalState)
                    .HasForeignKey(d => d.HeightMeasurementId)
                    .HasConstraintName("R_887");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.VitalState)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_179");

                entity.HasOne(d => d.PulseRhythmType)
                    .WithMany(p => p.VitalState)
                    .HasForeignKey(d => d.PulseRhythmTypeId)
                    .HasConstraintName("R_888");

                entity.HasOne(d => d.WeightMeasurement)
                    .WithMany(p => p.VitalState)
                    .HasForeignKey(d => d.WeightMeasurementId)
                    .HasConstraintName("R_886");
            });

            modelBuilder.Entity<WeightMeasurement>(entity =>
            {
                entity.ToTable("WeightMeasurement", "CLI");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.WeightMeasurementCode).HasColumnType("char(5)");

                entity.Property(e => e.WeightMeasurementDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.WeightMeasurementName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZipCode>(entity =>
            {
                entity.ToTable("ZipCode", "PER");

                entity.Property(e => e.CreatedByProgram)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ZipCode1)
                    .HasColumnName("ZipCode")
                    .HasColumnType("char(5)");

                entity.Property(e => e.ZipCodeDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCodeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ZipExtension).HasColumnType("char(4)");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ZipCode)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("R_633");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.ZipCode)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("R_653");
            });
        }
    }
}
