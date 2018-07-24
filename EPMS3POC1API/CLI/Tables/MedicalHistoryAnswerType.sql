CREATE TABLE [CLI].[MedicalHistoryAnswerType] (
    [MedicalHistoryAnswerTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [MedicalHistoryAnswerTypeDescription] VARCHAR (1024) NULL,
    [MedicalHistoryAnswerTypeCode]        CHAR (5)       NULL,
    [MedicalHistoryAnswerTypeName]        VARCHAR (64)   NULL,
    [CreatedDateTime]                     DATETIME       NOT NULL,
    [ModifiedDateTime]                    DATETIME       NOT NULL,
    [CreatedByUser]                       VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                      VARCHAR (80)   NULL,
    [CreatedByProgram]                    VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]                   VARCHAR (80)   NULL,
    [RecordStatus]                        INT            NOT NULL,
    CONSTRAINT [PK_MedicalHistoryAnswerType] PRIMARY KEY CLUSTERED ([MedicalHistoryAnswerTypeId] ASC)
);

