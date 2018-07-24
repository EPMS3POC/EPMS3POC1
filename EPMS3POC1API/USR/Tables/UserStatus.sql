CREATE TABLE [USR].[UserStatus] (
    [UserStatusId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [UserStatusCode]        VARCHAR (5)    NULL,
    [UserStatusName]        VARCHAR (32)   NULL,
    [UserStatusDescription] VARCHAR (1024) NULL,
    [CreatedDateTime]       DATETIME       NOT NULL,
    [ModifiedDateTime]      DATETIME       NOT NULL,
    [CreatedByUser]         VARCHAR (80)   NOT NULL,
    [ModifiedByUser]        VARCHAR (80)   NULL,
    [CreatedByProgram]      VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]     VARCHAR (80)   NULL,
    [RecordStatus]          INT            NOT NULL,
    CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED ([UserStatusId] ASC)
);

