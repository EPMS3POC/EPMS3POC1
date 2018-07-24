CREATE TABLE [TRE].[MasterProcedure] (
    [MasterProcedureId]          BIGINT       IDENTITY (1, 1) NOT NULL,
    [MasterTreatmentPlanId]      BIGINT       NULL,
    [CDTCode]                    CHAR (5)     NULL,
    [SnodentCode]                VARCHAR (20) NULL,
    [ICD_10Code]                 VARCHAR (20) NULL,
    [CreatedDateTime]            DATETIME     NOT NULL,
    [ModifiedDateTime]           DATETIME     NOT NULL,
    [CreatedByUser]              VARCHAR (80) NOT NULL,
    [ModifiedByUser]             VARCHAR (80) NULL,
    [CreatedByProgram]           VARCHAR (80) NOT NULL,
    [ModifiedByProgram]          VARCHAR (80) NULL,
    [RecordStatus]               INT          NOT NULL,
    [MasterProcedureDescription] VARCHAR (45) NULL,
    CONSTRAINT [XPKMasterProcedure] PRIMARY KEY CLUSTERED ([MasterProcedureId] ASC),
    CONSTRAINT [R_567] FOREIGN KEY ([MasterTreatmentPlanId]) REFERENCES [TRE].[MasterTreatmentPlan] ([MasterTreatmentPlanId])
);

