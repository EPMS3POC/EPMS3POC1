CREATE TABLE [TRE].[MasterTreatmentPlan] (
    [MasterTreatmentPlanId]          BIGINT       IDENTITY (1, 1) NOT NULL,
    [VisitReasonTypeId]              BIGINT       NULL,
    [CreatedDateTime]                DATETIME     NOT NULL,
    [ModifiedDateTime]               DATETIME     NOT NULL,
    [CreatedByUser]                  VARCHAR (80) NOT NULL,
    [ModifiedByUser]                 VARCHAR (80) NULL,
    [CreatedByProgram]               VARCHAR (80) NOT NULL,
    [ModifiedByProgram]              VARCHAR (80) NULL,
    [RecordStatus]                   INT          NOT NULL,
    [MasterTreatmentPlanNumber]      INT          NULL,
    [MasterTreatmentPlanDescription] VARCHAR (45) NULL,
    [MasterTreatmentPlanCode]        CHAR (5)     NULL,
    [AppointmentClassId]             BIGINT       NULL,
    CONSTRAINT [XPKMasterTreatmentPlan] PRIMARY KEY CLUSTERED ([MasterTreatmentPlanId] ASC),
    CONSTRAINT [R_568] FOREIGN KEY ([VisitReasonTypeId]) REFERENCES [SCH].[VisitReasonType] ([VisitReasonTypeId]),
    CONSTRAINT [R_657] FOREIGN KEY ([AppointmentClassId]) REFERENCES [SCH].[AppointmentClass] ([AppointmentClassId])
);

