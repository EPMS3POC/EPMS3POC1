CREATE TABLE [CLI].[MedicalHistorySection] (
    [MedicalHistorySectionId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [Priority]                         INT            NULL,
    [MedicalHistorySectionDescription] VARCHAR (1024) NULL,
    [MedicalHistorySectionCode]        CHAR (5)       NULL,
    [MedicalHistorySectionName]        VARCHAR (64)   NULL,
    [CreatedDateTime]                  DATETIME       NOT NULL,
    [ModifiedDateTime]                 DATETIME       NOT NULL,
    [CreatedByUser]                    VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                   VARCHAR (80)   NULL,
    [CreatedByProgram]                 VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]                VARCHAR (80)   NULL,
    [RecordStatus]                     INT            NOT NULL,
    CONSTRAINT [PK_MedicalHistorySection] PRIMARY KEY CLUSTERED ([MedicalHistorySectionId] ASC)
);

