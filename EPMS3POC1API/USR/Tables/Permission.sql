CREATE TABLE [USR].[Permission] (
    [PermissionId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [PermissionCode]        VARCHAR (5)    NULL,
    [PermissionName]        VARCHAR (32)   NULL,
    [PermissionDescription] VARCHAR (1024) NULL,
    [CreatedDateTime]       DATETIME       NOT NULL,
    [ModifiedDateTime]      DATETIME       NOT NULL,
    [CreatedByUser]         VARCHAR (80)   NOT NULL,
    [ModifiedByUser]        VARCHAR (80)   NULL,
    [CreatedByProgram]      VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]     VARCHAR (80)   NULL,
    [RecordStatus]          INT            NOT NULL,
    CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED ([PermissionId] ASC)
);

