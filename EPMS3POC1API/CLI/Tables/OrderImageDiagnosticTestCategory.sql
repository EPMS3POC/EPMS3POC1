CREATE TABLE [CLI].[OrderImageDiagnosticTestCategory] (
    [OrderImageDiagnosticTestCategoryId]       BIGINT         IDENTITY (1, 1) NOT NULL,
    [DiagnosticTestCategoryId]                 BIGINT         NOT NULL,
    [OrderImageDiagnosticTestCategoryComments] NVARCHAR (150) NULL,
    [CreatedDateTime]                          DATETIME       NOT NULL,
    [ModifiedDateTime]                         DATETIME       NOT NULL,
    [CreatedByUser]                            VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                           VARCHAR (80)   NULL,
    [CreatedByProgram]                         VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]                        VARCHAR (80)   NULL,
    [RecordStatus]                             INT            NOT NULL,
    [DiagnosticLocationId]                     BIGINT         NULL,
    [OrderImageId]                             BIGINT         NULL,
    CONSTRAINT [PK_ImagingOrderDiagnosticTestCategories] PRIMARY KEY CLUSTERED ([OrderImageDiagnosticTestCategoryId] ASC),
    CONSTRAINT [R_474] FOREIGN KEY ([DiagnosticTestCategoryId]) REFERENCES [CLI].[DiagnosticTestCategory] ([DiagnosticTestCategoryId]),
    CONSTRAINT [R_903] FOREIGN KEY ([DiagnosticLocationId]) REFERENCES [CLI].[DiagnosticLocation] ([DiagnosticLocationId]),
    CONSTRAINT [R_904] FOREIGN KEY ([OrderImageId]) REFERENCES [CLI].[OrderImage] ([OrderImageId])
);

