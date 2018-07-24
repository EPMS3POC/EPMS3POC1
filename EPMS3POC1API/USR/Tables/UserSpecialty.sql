CREATE TABLE [USR].[UserSpecialty] (
    [UserSpecialtyId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [UserSpecialtyCode]        VARCHAR (5)    NULL,
    [UserSpecialtyName]        VARCHAR (32)   NULL,
    [UserSpecialtyDescription] VARCHAR (1024) NULL,
    [CreatedDateTime]          DATETIME       NOT NULL,
    [ModifiedDateTime]         DATETIME       NOT NULL,
    [CreatedByUser]            VARCHAR (80)   NOT NULL,
    [ModifiedByUser]           VARCHAR (80)   NULL,
    [CreatedByProgram]         VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]        VARCHAR (80)   NULL,
    [RecordStatus]             INT            NOT NULL,
    CONSTRAINT [PK_UserSpeciality] PRIMARY KEY CLUSTERED ([UserSpecialtyId] ASC)
);

