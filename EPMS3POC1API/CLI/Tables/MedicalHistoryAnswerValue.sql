CREATE TABLE [CLI].[MedicalHistoryAnswerValue] (
    [MedicalHistoryAnswerValueId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [MedicalHistoryAnswerValueDescription] VARCHAR (1024) NULL,
    [MedicalHistoryAnswerValueCode]        CHAR (5)       NULL,
    [MedicalHistoryAnswerValueName]        VARCHAR (64)   NULL,
    [CreatedDateTime]                      DATETIME       NOT NULL,
    [ModifiedDateTime]                     DATETIME       NOT NULL,
    [CreatedByUser]                        VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                       VARCHAR (80)   NULL,
    [CreatedByProgram]                     VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]                    VARCHAR (80)   NULL,
    [RecordStatus]                         INT            NOT NULL,
    CONSTRAINT [PK_MedicalHistoryAnswerValue] PRIMARY KEY CLUSTERED ([MedicalHistoryAnswerValueId] ASC)
);

