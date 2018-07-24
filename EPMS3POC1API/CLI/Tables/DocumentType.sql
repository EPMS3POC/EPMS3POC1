CREATE TABLE [CLI].[DocumentType] (
    [DocumentTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [DocumentTypeDescription] VARCHAR (1024) NULL,
    [DocumentTypeCode]        CHAR (5)       NULL,
    [DocumentTypeName]        VARCHAR (50)   NULL,
    [CreatedDateTime]         DATETIME       NOT NULL,
    [ModifiedDateTime]        DATETIME       NOT NULL,
    [CreatedByUser]           VARCHAR (80)   NOT NULL,
    [ModifiedByUser]          VARCHAR (80)   NULL,
    [CreatedByProgram]        VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]       VARCHAR (80)   NULL,
    [RecordStatus]            INT            NOT NULL,
    CONSTRAINT [PK_DocumentType] PRIMARY KEY CLUSTERED ([DocumentTypeId] ASC)
);

