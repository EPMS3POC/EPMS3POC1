CREATE TABLE [PER].[Suffix] (
    [SuffixId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [SuffixName]        VARCHAR (32)   NULL,
    [SuffixDescription] VARCHAR (1024) NULL,
    [SuffixCode]        VARCHAR (5)    NULL,
    [CreatedDateTime]   DATETIME       NOT NULL,
    [ModifiedDateTime]  DATETIME       NOT NULL,
    [CreatedByUser]     VARCHAR (80)   NOT NULL,
    [ModifiedByUser]    VARCHAR (80)   NULL,
    [CreatedByProgram]  VARCHAR (80)   NOT NULL,
    [ModifiedByProgram] VARCHAR (80)   NULL,
    [RecordStatus]      INT            NOT NULL,
    CONSTRAINT [PK_Suffix] PRIMARY KEY CLUSTERED ([SuffixId] ASC)
);

