CREATE TABLE [CLI].[DiagnosticTestCategoryType] (
    [DiagnosticTestCategoryTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [DiagnosticTestCategoryTypeDescription] VARCHAR (1024) NULL,
    [DiagnosticTestCategoryTypeCode]        CHAR (5)       NULL,
    [DiagnosticTestCategoryTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]                       DATETIME       NOT NULL,
    [ModifiedDateTime]                      DATETIME       NOT NULL,
    [CreatedByUser]                         VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                        VARCHAR (80)   NULL,
    [CreatedByProgram]                      VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]                     VARCHAR (80)   NULL,
    [RecordStatus]                          INT            NOT NULL,
    CONSTRAINT [PK_DiagnosticTestCategoryType] PRIMARY KEY CLUSTERED ([DiagnosticTestCategoryTypeId] ASC)
);

