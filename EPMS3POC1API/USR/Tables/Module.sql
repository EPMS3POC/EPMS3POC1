CREATE TABLE [USR].[Module] (
    [ModuleId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [ModuleCode]        VARCHAR (5)    NULL,
    [ModuleName]        VARCHAR (32)   NULL,
    [ModuleDescription] VARCHAR (1024) NULL,
    [CreatedDateTime]   DATETIME       NOT NULL,
    [ModifiedDateTime]  DATETIME       NOT NULL,
    [CreatedByUser]     VARCHAR (80)   NOT NULL,
    [ModifiedByUser]    VARCHAR (80)   NULL,
    [CreatedByProgram]  VARCHAR (80)   NOT NULL,
    [ModifiedByProgram] VARCHAR (80)   NULL,
    [RecordStatus]      INT            NOT NULL,
    CONSTRAINT [PK_Module] PRIMARY KEY CLUSTERED ([ModuleId] ASC)
);

