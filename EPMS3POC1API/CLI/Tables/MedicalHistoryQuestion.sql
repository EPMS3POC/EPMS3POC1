CREATE TABLE [CLI].[MedicalHistoryQuestion] (
    [MedicalHistoryQuestionId]                 BIGINT        IDENTITY (1, 1) NOT NULL,
    [MedicalHistoryQuestionName]               VARCHAR (128) NULL,
    [Text]                                     VARCHAR (512) NULL,
    [MedicalHistoryAnswerTypeId]               BIGINT        NOT NULL,
    [MedicalHistoryControlTypeId]              BIGINT        NOT NULL,
    [ParentMedicalHistoryQuestionId]           BIGINT        NULL,
    [ParentMedicalHistoryQuestionTriggerValue] VARCHAR (256) NULL,
    [Priority]                                 INT           NULL,
    [CreatedDateTime]                          DATETIME      NOT NULL,
    [ModifiedDateTime]                         DATETIME      NOT NULL,
    [CreatedByUser]                            VARCHAR (80)  NOT NULL,
    [ModifiedByUser]                           VARCHAR (80)  NULL,
    [CreatedByProgram]                         VARCHAR (80)  NOT NULL,
    [ModifiedByProgram]                        VARCHAR (80)  NULL,
    [RecordStatus]                             INT           NOT NULL,
    [MedicalHistorySectionId]                  BIGINT        NULL,
    CONSTRAINT [PK_MedicalHistoryQuestion] PRIMARY KEY CLUSTERED ([MedicalHistoryQuestionId] ASC),
    CONSTRAINT [R_166] FOREIGN KEY ([MedicalHistoryAnswerTypeId]) REFERENCES [CLI].[MedicalHistoryAnswerType] ([MedicalHistoryAnswerTypeId]),
    CONSTRAINT [R_379] FOREIGN KEY ([MedicalHistoryControlTypeId]) REFERENCES [CLI].[MedicalHistoryControlType] ([MedicalHistoryControlTypeId]),
    CONSTRAINT [R_882] FOREIGN KEY ([MedicalHistorySectionId]) REFERENCES [CLI].[MedicalHistorySection] ([MedicalHistorySectionId])
);

