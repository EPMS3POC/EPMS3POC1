CREATE TABLE [CLI].[DiagnosticLocationType] (
    [DiagnosticLocationTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [DiagnosticLocationTypeDescription] VARCHAR (1024) NULL,
    [DiagnosticLocationTypeCode]        CHAR (5)       NULL,
    [DiagnosticLocationTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]                   DATETIME       NOT NULL,
    [ModifiedDateTime]                  DATETIME       NOT NULL,
    [CreatedByUser]                     VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                    VARCHAR (80)   NULL,
    [CreatedByProgram]                  VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]                 VARCHAR (80)   NULL,
    [RecordStatus]                      INT            NOT NULL,
    CONSTRAINT [PK_DiagnosticLocationType] PRIMARY KEY CLUSTERED ([DiagnosticLocationTypeId] ASC)
);

