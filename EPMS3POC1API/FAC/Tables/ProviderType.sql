CREATE TABLE [FAC].[ProviderType] (
    [ProviderTypeId]          BIGINT       IDENTITY (1, 1) NOT NULL,
    [ProviderTypeCode]        CHAR (5)     NULL,
    [ProviderTypeName]        VARCHAR (40) NULL,
    [ProviderTypeDescription] VARCHAR (12) NULL,
    [CreatedDateTime]         DATETIME     NOT NULL,
    [ModifiedDateTime]        DATETIME     NOT NULL,
    [CreatedByUser]           VARCHAR (80) NOT NULL,
    [ModifiedByUser]          VARCHAR (80) NULL,
    [CreatedByProgram]        VARCHAR (80) NOT NULL,
    [ModifiedByProgram]       VARCHAR (80) NULL,
    [RecordStatus]            INT          NOT NULL,
    CONSTRAINT [XPKProviderType] PRIMARY KEY CLUSTERED ([ProviderTypeId] ASC)
);

