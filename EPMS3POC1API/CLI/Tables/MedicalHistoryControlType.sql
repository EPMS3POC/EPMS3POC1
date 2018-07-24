CREATE TABLE [CLI].[MedicalHistoryControlType] (
    [MedicalHistoryControlTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [MedicalHistoryControlTypeDescription] VARCHAR (1024) NULL,
    [MedicalHistoryControlTypeCode]        CHAR (5)       NULL,
    [MedicalHistoryControlTypeName]        VARCHAR (64)   NULL,
    [CreatedDateTime]                      DATETIME       NOT NULL,
    [ModifiedDateTime]                     DATETIME       NOT NULL,
    [CreatedByUser]                        VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                       VARCHAR (80)   NULL,
    [CreatedByProgram]                     VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]                    VARCHAR (80)   NULL,
    [RecordStatus]                         INT            NOT NULL,
    CONSTRAINT [PK_MedicalHistoryControlType] PRIMARY KEY CLUSTERED ([MedicalHistoryControlTypeId] ASC)
);

