CREATE TABLE [INS].[CoverageLimitType] (
    [CoverageLimitTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CoverageLimitTypeDescription] VARCHAR (1024) NULL,
    [CoverageLimitTypeCode]        CHAR (5)       NULL,
    [CoverageLimitTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]              DATETIME       NOT NULL,
    [ModifiedDateTime]             DATETIME       NOT NULL,
    [CreatedByUser]                VARCHAR (80)   NOT NULL,
    [ModifiedByUser]               VARCHAR (80)   NULL,
    [CreatedByProgram]             VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]            VARCHAR (80)   NULL,
    [RecordStatus]                 INT            NOT NULL,
    CONSTRAINT [XPKCoverageLimitType] PRIMARY KEY CLUSTERED ([CoverageLimitTypeId] ASC)
);

