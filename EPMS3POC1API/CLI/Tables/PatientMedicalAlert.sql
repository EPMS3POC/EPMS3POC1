CREATE TABLE [CLI].[PatientMedicalAlert] (
    [PatientMedicalAlertId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [AlertPriority]         INT          NULL,
    [CreatedDateTime]       DATETIME     NOT NULL,
    [ModifiedDateTime]      DATETIME     NOT NULL,
    [CreatedByUser]         VARCHAR (80) NOT NULL,
    [ModifiedByUser]        VARCHAR (80) NULL,
    [CreatedByProgram]      VARCHAR (80) NOT NULL,
    [ModifiedByProgram]     VARCHAR (80) NULL,
    [RecordStatus]          INT          NOT NULL,
    [PatientId]             BIGINT       NULL,
    [MedicalAlertId]        BIGINT       NULL,
    CONSTRAINT [PK_PatientMedicalAlert] PRIMARY KEY CLUSTERED ([PatientMedicalAlertId] ASC),
    CONSTRAINT [R_879] FOREIGN KEY ([PatientId]) REFERENCES [PER].[Patient] ([PatientId]),
    CONSTRAINT [R_880] FOREIGN KEY ([MedicalAlertId]) REFERENCES [CLI].[MedicalAlert] ([MedicalAlertId])
);

