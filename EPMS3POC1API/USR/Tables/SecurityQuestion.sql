CREATE TABLE [USR].[SecurityQuestion] (
    [SecurityQuestionId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [SecurityQuestionCode]        VARCHAR (5)    NULL,
    [SecurityQuestionName]        VARCHAR (32)   NULL,
    [SecurityQuestionDescription] VARCHAR (1024) NULL,
    [CreatedDateTime]             DATETIME       NOT NULL,
    [ModifiedDateTime]            DATETIME       NOT NULL,
    [CreatedByUser]               VARCHAR (80)   NOT NULL,
    [ModifiedByUser]              VARCHAR (80)   NULL,
    [CreatedByProgram]            VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]           VARCHAR (80)   NULL,
    [RecordStatus]                INT            NOT NULL,
    CONSTRAINT [PK_SecurityQuestion] PRIMARY KEY CLUSTERED ([SecurityQuestionId] ASC)
);

