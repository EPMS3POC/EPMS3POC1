CREATE TABLE [INS].[CoverageBookType] (
    [CoverageBookTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CoverageBookTypeDescription] VARCHAR (1024) NULL,
    [CoverageBookTypeCode]        CHAR (5)       NULL,
    [CoverageBookTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]             DATETIME       NOT NULL,
    [ModifiedDateTime]            DATETIME       NOT NULL,
    [CreatedByUser]               VARCHAR (80)   NOT NULL,
    [ModifiedByUser]              VARCHAR (80)   NULL,
    [CreatedByProgram]            VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]           VARCHAR (80)   NULL,
    [RecordStatus]                INT            NOT NULL,
    CONSTRAINT [XPKCoverageBookType] PRIMARY KEY CLUSTERED ([CoverageBookTypeId] ASC)
);

