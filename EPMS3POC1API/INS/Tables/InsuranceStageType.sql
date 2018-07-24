CREATE TABLE [INS].[InsuranceStageType] (
    [InsuranceStageTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [InsuranceStageTypeDescription] VARCHAR (1024) NULL,
    [InsuranceStageTypeCode]        CHAR (5)       NULL,
    [InsuranceStageTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]               DATETIME       NOT NULL,
    [ModifiedDateTime]              DATETIME       NOT NULL,
    [CreatedByUser]                 VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                VARCHAR (80)   NULL,
    [CreatedByProgram]              VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]             VARCHAR (80)   NULL,
    [RecordStatus]                  INT            NOT NULL,
    CONSTRAINT [XPKInsuranceStageType] PRIMARY KEY CLUSTERED ([InsuranceStageTypeId] ASC)
);

