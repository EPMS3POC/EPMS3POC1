﻿CREATE TABLE [TRE].[PatientTreatmentPlan] (
    [PatientTreatmentPlanId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [TreatmentPlanDate]               DATETIME       NULL,
    [ToothSurface]                    VARCHAR (20)   NULL,
    [TotalPlanFee]                    VARCHAR (20)   NULL,
    [TreatmentPlanOptionId]           BIGINT         NOT NULL,
    [PatientId]                       BIGINT         NOT NULL,
    [EstimateRunDateTime]             DATETIME       NULL,
    [TotalCouponDiscount]             DECIMAL (8, 2) NULL,
    [TotalEstimatedInsuranceDiscount] DECIMAL (8, 2) NULL,
    [TotalEstimatedInsuranceBenefit]  DECIMAL (8, 2) NULL,
    [PatientFinancialResponsibility]  DECIMAL (8, 2) NULL,
    [PatientBalance]                  DECIMAL (8, 2) NULL,
    [PlannedPayment]                  DECIMAL (8, 2) NULL,
    [RemainingAmount]                 DECIMAL (8, 2) NULL,
    [PdfFileName]                     VARCHAR (50)   NULL,
    [PdfFilePath]                     VARCHAR (200)  NULL,
    [DiagnosingProvider]              VARCHAR (20)   NULL,
    [InsideReferringProvider]         VARCHAR (20)   NULL,
    [IsOverrideFeeSchedule]           SMALLINT       NULL,
    [IsContractRequired]              SMALLINT       NULL,
    [ContractNumber]                  VARCHAR (20)   NULL,
    [ExceptionNumber]                 VARCHAR (20)   NULL,
    [IsPreAuthorizationRequired]      SMALLINT       NULL,
    [PreAuthorizationNumber]          VARCHAR (20)   NULL,
    [DatePreAuthorizationFiled]       DATETIME       NULL,
    [PreAuthorizationExpires]         DATETIME       NULL,
    [DateApproved]                    DATETIME       NULL,
    [DateComplete]                    DATETIME       NULL,
    [CreatedDateTime]                 DATETIME       NOT NULL,
    [ModifiedDateTime]                DATETIME       NOT NULL,
    [CreatedByUser]                   VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                  VARCHAR (80)   NULL,
    [CreatedByProgram]                VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]               VARCHAR (80)   NULL,
    [RecordStatus]                    INT            NOT NULL,
    [MasterTreatmentPlanId]           BIGINT         NULL,
    [ProviderId]                      BIGINT         NULL,
    [BundledServiceId]                BIGINT         NULL,
    [PatientToothId]                  BIGINT         NULL,
    CONSTRAINT [XPKPatientTreatmentPlan] PRIMARY KEY CLUSTERED ([PatientTreatmentPlanId] ASC),
    CONSTRAINT [R_337] FOREIGN KEY ([TreatmentPlanOptionId]) REFERENCES [TRE].[TreatmentPlanOption] ([TreatmentPlanOptionId]),
    CONSTRAINT [R_606] FOREIGN KEY ([PatientId]) REFERENCES [PER].[Patient] ([PatientId]),
    CONSTRAINT [R_631] FOREIGN KEY ([MasterTreatmentPlanId]) REFERENCES [TRE].[MasterTreatmentPlan] ([MasterTreatmentPlanId]),
    CONSTRAINT [R_677] FOREIGN KEY ([ProviderId]) REFERENCES [FAC].[Provider] ([ProviderId]),
    CONSTRAINT [R_752] FOREIGN KEY ([BundledServiceId]) REFERENCES [TRE].[BundledService] ([BundledServiceId]),
    CONSTRAINT [R_791] FOREIGN KEY ([PatientToothId]) REFERENCES [CLI].[PatientTooth] ([PatientToothId])
);

