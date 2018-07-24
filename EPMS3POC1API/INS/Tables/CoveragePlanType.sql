CREATE TABLE [INS].[CoveragePlanType] (
    [CoveragePlanTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CoveragePlanTypeDescription] VARCHAR (1024) NULL,
    [CoveragePlanTypeCode]        CHAR (5)       NULL,
    [CoveragePlanTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]             DATETIME       NOT NULL,
    [ModifiedDateTime]            DATETIME       NOT NULL,
    [CreatedByUser]               VARCHAR (80)   NOT NULL,
    [ModifiedByUser]              VARCHAR (80)   NULL,
    [CreatedByProgram]            VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]           VARCHAR (80)   NULL,
    [RecordStatus]                INT            NOT NULL,
    CONSTRAINT [XPKCoveragePlanType] PRIMARY KEY CLUSTERED ([CoveragePlanTypeId] ASC)
);

