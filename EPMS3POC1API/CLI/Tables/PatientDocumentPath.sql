CREATE TABLE [CLI].[PatientDocumentPath] (
    [PatientId]             BIGINT       NOT NULL,
    [RootPath]              NVARCHAR (1) NULL,
    [PatientDocumentPathId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [CreatedDateTime]       DATETIME     NOT NULL,
    [ModifiedDateTime]      DATETIME     NOT NULL,
    [CreatedByUser]         VARCHAR (80) NOT NULL,
    [ModifiedByUser]        VARCHAR (80) NULL,
    [CreatedByProgram]      VARCHAR (80) NOT NULL,
    [ModifiedByProgram]     VARCHAR (80) NULL,
    [RecordStatus]          INT          NOT NULL,
    CONSTRAINT [XPKPatientDocumentPath] PRIMARY KEY CLUSTERED ([PatientDocumentPathId] ASC),
    CONSTRAINT [R_395] FOREIGN KEY ([PatientId]) REFERENCES [PER].[Patient] ([PatientId])
);

