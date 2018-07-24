CREATE TABLE [CLI].[DiagnosticTestCategory] (
    [DiagnosticTestCategoryId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [DiagnosticTestCategoryDescription] VARCHAR (1024) NULL,
    [DiagnosticTestCategoryCode]        CHAR (5)       NULL,
    [DiagnosticTestCategoryName]        VARCHAR (200)  NULL,
    [DiagnosticTestCategoryTargetId]    BIGINT         NULL,
    [CreatedDateTime]                   DATETIME       NOT NULL,
    [ModifiedDateTime]                  DATETIME       NOT NULL,
    [CreatedByUser]                     VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                    VARCHAR (80)   NULL,
    [CreatedByProgram]                  VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]                 VARCHAR (80)   NULL,
    [RecordStatus]                      INT            NOT NULL,
    [DiagnosticTestCategoryTypeId]      BIGINT         NULL,
    CONSTRAINT [PK_DiagnosticTestCategories] PRIMARY KEY CLUSTERED ([DiagnosticTestCategoryId] ASC),
    CONSTRAINT [R_624] FOREIGN KEY ([DiagnosticTestCategoryTypeId]) REFERENCES [CLI].[DiagnosticTestCategoryType] ([DiagnosticTestCategoryTypeId]),
    CONSTRAINT [R_625] FOREIGN KEY ([DiagnosticTestCategoryTargetId]) REFERENCES [CLI].[DiagnosticTestCategoryTarget] ([DiagnosticTestCategoryTargetId])
);

