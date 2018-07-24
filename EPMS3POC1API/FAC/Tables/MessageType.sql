CREATE TABLE [FAC].[MessageType] (
    [MessageTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [MessageTypeDescription] VARCHAR (1024) NULL,
    [MessageTypeCode]        CHAR (5)       NULL,
    [MessageTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]        DATETIME       NOT NULL,
    [ModifiedDateTime]       DATETIME       NOT NULL,
    [CreatedByUser]          VARCHAR (80)   NOT NULL,
    [ModifiedByUser]         VARCHAR (80)   NULL,
    [CreatedByProgram]       VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]      VARCHAR (80)   NULL,
    [RecordStatus]           INT            NOT NULL,
    CONSTRAINT [PK_MessageType] PRIMARY KEY CLUSTERED ([MessageTypeId] ASC)
);

