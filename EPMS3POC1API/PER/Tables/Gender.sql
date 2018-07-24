CREATE TABLE [PER].[Gender] (
    [GenderId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [GenderName]        VARCHAR (32)   NULL,
    [GenderDescription] VARCHAR (1024) NULL,
    [GenderCode]        VARCHAR (5)    NULL,
    [CreatedDateTime]   DATETIME       NOT NULL,
    [ModifiedDateTime]  DATETIME       NOT NULL,
    [CreatedByUser]     VARCHAR (80)   NOT NULL,
    [ModifiedByUser]    VARCHAR (80)   NULL,
    [CreatedByProgram]  VARCHAR (80)   NOT NULL,
    [ModifiedByProgram] VARCHAR (80)   NULL,
    [RecordStatus]      INT            NOT NULL,
    CONSTRAINT [PK_Gender] PRIMARY KEY NONCLUSTERED ([GenderId] ASC)
);

