CREATE TABLE [CLI].[MedicalHistoryAnswerTypeValue] (
    [MedicalHistoryAnswerTypeValueId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [Priority]                        INT          NULL,
    [CreatedDateTime]                 DATETIME     NOT NULL,
    [ModifiedDateTime]                DATETIME     NOT NULL,
    [CreatedByUser]                   VARCHAR (80) NOT NULL,
    [ModifiedByUser]                  VARCHAR (80) NULL,
    [CreatedByProgram]                VARCHAR (80) NOT NULL,
    [ModifiedByProgram]               VARCHAR (80) NULL,
    [RecordStatus]                    INT          NOT NULL,
    [MedicalHistoryAnswerTypeId]      BIGINT       NULL,
    [MedicalHistoryAnswerValueId]     BIGINT       NULL,
    CONSTRAINT [PK_MedicalHistoryAnswerTypeValue] PRIMARY KEY CLUSTERED ([MedicalHistoryAnswerTypeValueId] ASC),
    CONSTRAINT [R_883] FOREIGN KEY ([MedicalHistoryAnswerTypeId]) REFERENCES [CLI].[MedicalHistoryAnswerType] ([MedicalHistoryAnswerTypeId]),
    CONSTRAINT [R_884] FOREIGN KEY ([MedicalHistoryAnswerValueId]) REFERENCES [CLI].[MedicalHistoryAnswerValue] ([MedicalHistoryAnswerValueId])
);

