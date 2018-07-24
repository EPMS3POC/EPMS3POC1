CREATE TABLE [CLI].[DiagnosticCenterAddress] (
    [DiagnosticCenterAddressId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [AddressId]                 BIGINT       NULL,
    [DiagnosticCenterId]        BIGINT       NULL,
    [CreatedDateTime]           DATETIME     NOT NULL,
    [ModifiedDateTime]          DATETIME     NOT NULL,
    [CreatedByUser]             VARCHAR (80) NOT NULL,
    [ModifiedByUser]            VARCHAR (80) NULL,
    [CreatedByProgram]          VARCHAR (80) NOT NULL,
    [ModifiedByProgram]         VARCHAR (80) NULL,
    [RecordStatus]              INT          NOT NULL,
    CONSTRAINT [XPKDiagnosticCenterAddress] PRIMARY KEY CLUSTERED ([DiagnosticCenterAddressId] ASC),
    CONSTRAINT [R_779] FOREIGN KEY ([AddressId]) REFERENCES [PER].[Address] ([AddressId]),
    CONSTRAINT [R_780] FOREIGN KEY ([DiagnosticCenterId]) REFERENCES [CLI].[DiagnosticCenter] ([DiagnosticCenterId])
);

