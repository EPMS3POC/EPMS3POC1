CREATE TABLE [INS].[CoverageNetworkType] (
    [CoverageNetworkTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CoverageNetworkTypeDescription] VARCHAR (1024) NULL,
    [CoverageNetworkTypeCode]        CHAR (5)       NULL,
    [CoverageNetworkTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]                DATETIME       NOT NULL,
    [ModifiedDateTime]               DATETIME       NOT NULL,
    [CreatedByUser]                  VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                 VARCHAR (80)   NULL,
    [CreatedByProgram]               VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]              VARCHAR (80)   NULL,
    [RecordStatus]                   INT            NOT NULL,
    CONSTRAINT [XPKCoverageNetworkType] PRIMARY KEY CLUSTERED ([CoverageNetworkTypeId] ASC)
);

