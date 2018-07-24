CREATE TABLE [USR].[UserType] (
    [UserTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [UserTypeCode]        VARCHAR (5)    NULL,
    [UserTypeName]        VARCHAR (32)   NULL,
    [UserTypeDescription] VARCHAR (1024) NULL,
    [CreatedDateTime]     DATETIME       NOT NULL,
    [ModifiedDateTime]    DATETIME       NOT NULL,
    [CreatedByUser]       VARCHAR (80)   NOT NULL,
    [ModifiedByUser]      VARCHAR (80)   NULL,
    [CreatedByProgram]    VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]   VARCHAR (80)   NULL,
    [RecordStatus]        INT            NOT NULL,
    CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED ([UserTypeId] ASC)
);

