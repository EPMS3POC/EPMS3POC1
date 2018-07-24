CREATE TABLE [CLI].[PatientNoteTemplate] (
    [PatientNoteTemplateId] BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]                  NVARCHAR (100) NULL,
    [UserNote]              NVARCHAR (1)   NULL,
    [OfficeId]              BIGINT         NULL,
    [CreatedDateTime]       DATETIME       NOT NULL,
    [ModifiedDateTime]      DATETIME       NOT NULL,
    [CreatedByUser]         VARCHAR (80)   NOT NULL,
    [ModifiedByUser]        VARCHAR (80)   NULL,
    [CreatedByProgram]      VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]     VARCHAR (80)   NULL,
    [RecordStatus]          INT            NOT NULL,
    CONSTRAINT [XPKPatientNoteTemplate] PRIMARY KEY CLUSTERED ([PatientNoteTemplateId] ASC)
);

