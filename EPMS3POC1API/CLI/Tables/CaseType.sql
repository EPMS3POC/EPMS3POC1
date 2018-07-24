CREATE TABLE [CLI].[CaseType] (
    [CaseTypeId]        BIGINT       IDENTITY (1, 1) NOT NULL,
    [CaseTypeCode]      CHAR (5)     NULL,
    [CaseTypeName]      VARCHAR (40) NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [PK_CaseType] PRIMARY KEY CLUSTERED ([CaseTypeId] ASC)
);

