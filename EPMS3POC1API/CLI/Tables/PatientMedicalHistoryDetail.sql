CREATE TABLE [CLI].[PatientMedicalHistoryDetail] (
    [PatientMedicalHistoryDetailId]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [MedicalHistoryAnswer]            VARCHAR (256) NULL,
    [CreatedDateTime]                 DATETIME      NOT NULL,
    [ModifiedDateTime]                DATETIME      NOT NULL,
    [CreatedByUser]                   VARCHAR (80)  NOT NULL,
    [ModifiedByUser]                  VARCHAR (80)  NULL,
    [CreatedByProgram]                VARCHAR (80)  NOT NULL,
    [ModifiedByProgram]               VARCHAR (80)  NULL,
    [RecordStatus]                    INT           NOT NULL,
    [MedicalHistoryAnswerTypeValueId] BIGINT        NULL,
    [PatientMedicalHistoryId]         BIGINT        NULL,
    [MedicalHistoryQuestionId]        BIGINT        NULL,
    CONSTRAINT [PK_PatientMedicalHistoryDetail] PRIMARY KEY CLUSTERED ([PatientMedicalHistoryDetailId] ASC),
    CONSTRAINT [R_772] FOREIGN KEY ([MedicalHistoryAnswerTypeValueId]) REFERENCES [CLI].[MedicalHistoryAnswerTypeValue] ([MedicalHistoryAnswerTypeValueId]),
    CONSTRAINT [R_881] FOREIGN KEY ([PatientMedicalHistoryId]) REFERENCES [CLI].[PatientMedicalHistory] ([PatientMedicalHistoryId]),
    CONSTRAINT [R_885] FOREIGN KEY ([MedicalHistoryQuestionId]) REFERENCES [CLI].[MedicalHistoryQuestion] ([MedicalHistoryQuestionId])
);

