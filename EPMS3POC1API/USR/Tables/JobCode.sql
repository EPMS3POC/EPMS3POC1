CREATE TABLE [USR].[JobCode] (
    [JobCodeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [RoleId]             BIGINT         NULL,
    [JobCodeCode]        VARCHAR (5)    NULL,
    [JobCodeName]        VARCHAR (32)   NULL,
    [JobCodeDescription] VARCHAR (1024) NULL,
    [CreatedDateTime]    DATETIME       NOT NULL,
    [ModifiedDateTime]   DATETIME       NOT NULL,
    [CreatedByUser]      VARCHAR (80)   NOT NULL,
    [ModifiedByUser]     VARCHAR (80)   NULL,
    [CreatedByProgram]   VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]  VARCHAR (80)   NULL,
    [RecordStatus]       INT            NOT NULL,
    CONSTRAINT [PK_JobCode] PRIMARY KEY CLUSTERED ([JobCodeId] ASC),
    CONSTRAINT [R_618] FOREIGN KEY ([RoleId]) REFERENCES [USR].[Role] ([RoleId])
);

