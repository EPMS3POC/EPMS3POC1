CREATE TABLE [USR].[Role] (
    [RoleId]            BIGINT         IDENTITY (1, 1) NOT NULL,
    [RoleCode]          VARCHAR (5)    NULL,
    [RoleDescription]   VARCHAR (1024) NULL,
    [RoleName]          VARCHAR (32)   NULL,
    [CreatedDateTime]   DATETIME       NOT NULL,
    [ModifiedDateTime]  DATETIME       NOT NULL,
    [CreatedByUser]     VARCHAR (80)   NOT NULL,
    [ModifiedByUser]    VARCHAR (80)   NULL,
    [CreatedByProgram]  VARCHAR (80)   NOT NULL,
    [ModifiedByProgram] VARCHAR (80)   NULL,
    [RecordStatus]      INT            NOT NULL,
    CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED ([RoleId] ASC)
);

