CREATE TABLE [CLI].[DiagnosticCenterContact] (
    [DiagnosticCenterContactId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [DiagnosticCenterId]        BIGINT       NULL,
    [PersonId]                  BIGINT       NULL,
    [CreatedDateTime]           DATETIME     NOT NULL,
    [ModifiedDateTime]          DATETIME     NOT NULL,
    [CreatedByUser]             VARCHAR (80) NOT NULL,
    [ModifiedByUser]            VARCHAR (80) NULL,
    [CreatedByProgram]          VARCHAR (80) NOT NULL,
    [ModifiedByProgram]         VARCHAR (80) NULL,
    [RecordStatus]              INT          NOT NULL,
    CONSTRAINT [XPKDiagnosticCenterContact] PRIMARY KEY CLUSTERED ([DiagnosticCenterContactId] ASC),
    CONSTRAINT [R_781] FOREIGN KEY ([DiagnosticCenterId]) REFERENCES [CLI].[DiagnosticCenter] ([DiagnosticCenterId]),
    CONSTRAINT [R_782] FOREIGN KEY ([PersonId]) REFERENCES [PER].[Person] ([PersonId])
);

