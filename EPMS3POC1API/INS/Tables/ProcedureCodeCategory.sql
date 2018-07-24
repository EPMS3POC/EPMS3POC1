CREATE TABLE [INS].[ProcedureCodeCategory] (
    [ProcedureCodeCategoryId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [ProcedureCodeCategory]   VARCHAR (50) NULL,
    [ProcedureCodeMin]        VARCHAR (50) NULL,
    [ProcedureCodeMax]        VARCHAR (50) NULL,
    [CreatedDateTime]         DATETIME     NOT NULL,
    [ModifiedDateTime]        DATETIME     NOT NULL,
    [CreatedByUser]           VARCHAR (80) NOT NULL,
    [ModifiedByUser]          VARCHAR (80) NULL,
    [CreatedByProgram]        VARCHAR (80) NOT NULL,
    [ModifiedByProgram]       VARCHAR (80) NULL,
    [RecordStatus]            INT          NOT NULL,
    CONSTRAINT [PK_ProcedureCodeCategories] PRIMARY KEY CLUSTERED ([ProcedureCodeCategoryId] ASC)
);

