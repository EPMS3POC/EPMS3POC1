﻿CREATE TABLE [CLI].[DiagnosticTestCategoryTarget] (
    [DiagnosticTestCategoryTargetId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [DiagnosticTestCategoryTargetDescription] VARCHAR (1024) NULL,
    [DiagnosticTestCategoryTargetCode]        CHAR (5)       NULL,
    [DiagnosticTestCategoryTargetName]        VARCHAR (40)   NULL,
    [CreatedDateTime]                         DATETIME       NOT NULL,
    [ModifiedDateTime]                        DATETIME       NOT NULL,
    [CreatedByUser]                           VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                          VARCHAR (80)   NULL,
    [CreatedByProgram]                        VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]                       VARCHAR (80)   NULL,
    [RecordStatus]                            INT            NOT NULL,
    CONSTRAINT [PK_DiagnosticTestCategoryTarget] PRIMARY KEY CLUSTERED ([DiagnosticTestCategoryTargetId] ASC)
);

