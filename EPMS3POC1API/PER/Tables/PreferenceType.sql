CREATE TABLE [PER].[PreferenceType] (
    [PreferenceTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [PreferenceTypeName]        VARCHAR (32)   NULL,
    [PreferenceTypeDescription] VARCHAR (1024) NULL,
    [PreferenceTypeCode]        VARCHAR (5)    NULL,
    [CreatedDateTime]           DATETIME       NOT NULL,
    [ModifiedDateTime]          DATETIME       NOT NULL,
    [CreatedByUser]             VARCHAR (80)   NOT NULL,
    [ModifiedByUser]            VARCHAR (80)   NULL,
    [CreatedByProgram]          VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]         VARCHAR (80)   NULL,
    [RecordStatus]              INT            NOT NULL,
    CONSTRAINT [PK_Preference] PRIMARY KEY CLUSTERED ([PreferenceTypeId] ASC)
);

