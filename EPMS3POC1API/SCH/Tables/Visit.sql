CREATE TABLE [SCH].[Visit] (
    [VisitNumber]            INT          NULL,
    [VisitId]                BIGINT       IDENTITY (1, 1) NOT NULL,
    [VisitReasonTypeId]      BIGINT       NULL,
    [IsWaitListed]           SMALLINT     NULL,
    [CreatedDateTime]        DATETIME     NOT NULL,
    [ModifiedDateTime]       DATETIME     NOT NULL,
    [CreatedByUser]          VARCHAR (80) NOT NULL,
    [ModifiedByUser]         VARCHAR (80) NULL,
    [CreatedByProgram]       VARCHAR (80) NOT NULL,
    [ModifiedByProgram]      VARCHAR (80) NULL,
    [RecordStatus]           INT          NOT NULL,
    [ProviderId]             BIGINT       NULL,
    [DateOfService]          DATETIME     NULL,
    [PatientTreatmentPlanId] BIGINT       NULL,
    CONSTRAINT [XPKVisit] PRIMARY KEY CLUSTERED ([VisitId] ASC),
    CONSTRAINT [R_549] FOREIGN KEY ([VisitReasonTypeId]) REFERENCES [SCH].[VisitReasonType] ([VisitReasonTypeId]),
    CONSTRAINT [R_589] FOREIGN KEY ([PatientTreatmentPlanId]) REFERENCES [TRE].[PatientTreatmentPlan] ([PatientTreatmentPlanId]),
    CONSTRAINT [R_658] FOREIGN KEY ([ProviderId]) REFERENCES [FAC].[Provider] ([ProviderId])
);

