CREATE TABLE [CLI].[DocumentCategory] (
    [DocumentCategoryId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [DocumentCategoryDescription] VARCHAR (1024) NULL,
    [DocumentCategoryCode]        CHAR (5)       NULL,
    [DocumentCategoryName]        VARCHAR (50)   NULL,
    [CreatedDateTime]             DATETIME       NOT NULL,
    [ModifiedDateTime]            DATETIME       NOT NULL,
    [CreatedByUser]               VARCHAR (80)   NOT NULL,
    [ModifiedByUser]              VARCHAR (80)   NULL,
    [CreatedByProgram]            VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]           VARCHAR (80)   NULL,
    [RecordStatus]                INT            NOT NULL,
    CONSTRAINT [PK_DocumentCategory] PRIMARY KEY CLUSTERED ([DocumentCategoryId] ASC)
);

