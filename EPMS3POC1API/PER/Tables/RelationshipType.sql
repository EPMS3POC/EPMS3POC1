CREATE TABLE [PER].[RelationshipType] (
    [RelationshipTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [RelationshipTypeName]        VARCHAR (32)   NULL,
    [RelationshipTypeDescription] VARCHAR (1024) NULL,
    [RelationshipTypeCode]        VARCHAR (5)    NULL,
    [CreatedDateTime]             DATETIME       NOT NULL,
    [ModifiedDateTime]            DATETIME       NOT NULL,
    [CreatedByUser]               VARCHAR (80)   NOT NULL,
    [ModifiedByUser]              VARCHAR (80)   NULL,
    [CreatedByProgram]            VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]           VARCHAR (80)   NULL,
    [RecordStatus]                INT            NOT NULL,
    CONSTRAINT [PK_Relationship] PRIMARY KEY CLUSTERED ([RelationshipTypeId] ASC)
);

