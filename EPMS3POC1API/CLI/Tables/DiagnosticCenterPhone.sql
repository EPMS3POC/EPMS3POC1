CREATE TABLE [CLI].[DiagnosticCenterPhone] (
    [DiagnosticCenterPhoneId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [PhoneId]                 BIGINT       NULL,
    [DiagnosticCenterId]      BIGINT       NULL,
    [PhoneTypeId]             BIGINT       NULL,
    [CreatedDateTime]         DATETIME     NOT NULL,
    [ModifiedDateTime]        DATETIME     NOT NULL,
    [CreatedByUser]           VARCHAR (80) NOT NULL,
    [ModifiedByUser]          VARCHAR (80) NULL,
    [CreatedByProgram]        VARCHAR (80) NOT NULL,
    [ModifiedByProgram]       VARCHAR (80) NULL,
    [RecordStatus]            INT          NOT NULL,
    CONSTRAINT [XPKDiagnosticCenterPhone] PRIMARY KEY CLUSTERED ([DiagnosticCenterPhoneId] ASC),
    CONSTRAINT [R_783] FOREIGN KEY ([PhoneId]) REFERENCES [PER].[Phone] ([PhoneId]),
    CONSTRAINT [R_784] FOREIGN KEY ([DiagnosticCenterId]) REFERENCES [CLI].[DiagnosticCenter] ([DiagnosticCenterId]),
    CONSTRAINT [R_785] FOREIGN KEY ([PhoneTypeId]) REFERENCES [PER].[PhoneType] ([PhoneTypeId])
);

