CREATE TABLE [TRE].[BundledService] (
    [BundledServiceId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [BundledServiceDescription] VARCHAR (1024) NULL,
    [BundledServiceCode]        VARCHAR (50)   NULL,
    [BundledServiceName]        VARCHAR (100)  NULL,
    [CreatedDateTime]           DATETIME       NOT NULL,
    [ModifiedDateTime]          DATETIME       NOT NULL,
    [CreatedByUser]             VARCHAR (80)   NOT NULL,
    [ModifiedByUser]            VARCHAR (80)   NULL,
    [CreatedByProgram]          VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]         VARCHAR (80)   NULL,
    [RecordStatus]              INT            NOT NULL,
    CONSTRAINT [XPKBundledService] PRIMARY KEY CLUSTERED ([BundledServiceId] ASC)
);

