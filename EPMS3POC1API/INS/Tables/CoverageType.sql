CREATE TABLE [INS].[CoverageType] (
    [CoverageTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CoverageTypeDescription] VARCHAR (1024) NULL,
    [CoverageTypeCode]        CHAR (5)       NULL,
    [CoverageTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]         DATETIME       NOT NULL,
    [ModifiedDateTime]        DATETIME       NOT NULL,
    [CreatedByUser]           VARCHAR (80)   NOT NULL,
    [ModifiedByUser]          VARCHAR (80)   NULL,
    [CreatedByProgram]        VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]       VARCHAR (80)   NULL,
    [RecordStatus]            INT            NOT NULL,
    CONSTRAINT [XPKCoverageType] PRIMARY KEY CLUSTERED ([CoverageTypeId] ASC)
);

