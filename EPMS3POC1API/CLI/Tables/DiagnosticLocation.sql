CREATE TABLE [CLI].[DiagnosticLocation] (
    [DiagnosticLocationId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [DiagnosticLocationDescription] VARCHAR (1024) NULL,
    [DiagnosticLocationCode]        CHAR (5)       NULL,
    [DiagnosticLocationName]        VARCHAR (40)   NULL,
    [DiagnosticLocationTypeId]      BIGINT         NULL,
    [CreatedDateTime]               DATETIME       NOT NULL,
    [ModifiedDateTime]              DATETIME       NOT NULL,
    [CreatedByUser]                 VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                VARCHAR (80)   NULL,
    [CreatedByProgram]              VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]             VARCHAR (80)   NULL,
    [RecordStatus]                  INT            NOT NULL,
    CONSTRAINT [PK_DiagnosticLocations] PRIMARY KEY CLUSTERED ([DiagnosticLocationId] ASC),
    CONSTRAINT [R_623] FOREIGN KEY ([DiagnosticLocationTypeId]) REFERENCES [CLI].[DiagnosticLocationType] ([DiagnosticLocationTypeId])
);

