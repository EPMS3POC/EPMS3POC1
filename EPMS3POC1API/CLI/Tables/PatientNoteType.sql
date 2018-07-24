CREATE TABLE [CLI].[PatientNoteType] (
    [PatientNoteTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [PatientNoteTypeDescription] VARCHAR (1024) NULL,
    [PatientNoteTypeCode]        CHAR (5)       NULL,
    [PatientNoteTypeName]        VARCHAR (50)   NULL,
    [CreatedDateTime]            DATETIME       NOT NULL,
    [ModifiedDateTime]           DATETIME       NOT NULL,
    [CreatedByUser]              VARCHAR (80)   NOT NULL,
    [ModifiedByUser]             VARCHAR (80)   NULL,
    [CreatedByProgram]           VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]          VARCHAR (80)   NULL,
    [RecordStatus]               INT            NOT NULL,
    CONSTRAINT [PK_PatientNoteType] PRIMARY KEY CLUSTERED ([PatientNoteTypeId] ASC)
);

