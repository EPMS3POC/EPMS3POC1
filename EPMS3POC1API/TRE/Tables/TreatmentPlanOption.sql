CREATE TABLE [TRE].[TreatmentPlanOption] (
    [TreatmentPlanOptionId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [TreatmentPlanOptionDescription] VARCHAR (1024) NULL,
    [TreatmentPlanOptionCode]        CHAR (5)       NULL,
    [TreatmentPlanOptionName]        VARCHAR (40)   NULL,
    [CreatedDateTime]                DATETIME       NOT NULL,
    [ModifiedDateTime]               DATETIME       NOT NULL,
    [CreatedByUser]                  VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                 VARCHAR (80)   NULL,
    [CreatedByProgram]               VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]              VARCHAR (80)   NULL,
    [RecordStatus]                   INT            NOT NULL,
    CONSTRAINT [XPKTreatmentPlanOption] PRIMARY KEY CLUSTERED ([TreatmentPlanOptionId] ASC)
);

