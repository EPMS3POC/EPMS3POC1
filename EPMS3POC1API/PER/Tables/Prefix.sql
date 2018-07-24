CREATE TABLE [PER].[Prefix] (
    [PrefixId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [PrefixName]        VARCHAR (32)   NULL,
    [PrefixDescription] VARCHAR (1024) NULL,
    [PrefixCode]        VARCHAR (5)    NULL,
    [CreatedDateTime]   DATETIME       NOT NULL,
    [ModifiedDateTime]  DATETIME       NOT NULL,
    [CreatedByUser]     VARCHAR (80)   NOT NULL,
    [ModifiedByUser]    VARCHAR (80)   NULL,
    [CreatedByProgram]  VARCHAR (80)   NOT NULL,
    [ModifiedByProgram] VARCHAR (80)   NULL,
    [RecordStatus]      INT            NOT NULL,
    CONSTRAINT [PK_Prefix] PRIMARY KEY CLUSTERED ([PrefixId] ASC)
);

