CREATE TABLE [USR].[View] (
    [ViewId]            BIGINT         IDENTITY (1, 1) NOT NULL,
    [ViewCode]          VARCHAR (5)    NULL,
    [ViewName]          VARCHAR (32)   NULL,
    [ViewDescription]   VARCHAR (1024) NULL,
    [CreatedDateTime]   DATETIME       NOT NULL,
    [ModifiedDateTime]  DATETIME       NOT NULL,
    [CreatedByUser]     VARCHAR (80)   NOT NULL,
    [ModifiedByUser]    VARCHAR (80)   NULL,
    [CreatedByProgram]  VARCHAR (80)   NOT NULL,
    [ModifiedByProgram] VARCHAR (80)   NULL,
    [RecordStatus]      INT            NOT NULL,
    [ModuleId]          BIGINT         NULL,
    CONSTRAINT [PK_View] PRIMARY KEY CLUSTERED ([ViewId] ASC),
    CONSTRAINT [R_865] FOREIGN KEY ([ModuleId]) REFERENCES [USR].[Module] ([ModuleId])
);

