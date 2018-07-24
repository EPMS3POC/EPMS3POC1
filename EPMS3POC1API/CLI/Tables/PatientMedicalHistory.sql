CREATE TABLE [CLI].[PatientMedicalHistory] (
    [PatientMedicalHistoryId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [PatientId]               BIGINT       NOT NULL,
    [StartTime]               DATETIME     NULL,
    [EndTime]                 DATETIME     NULL,
    [UserName]                VARCHAR (50) NULL,
    [Program]                 VARCHAR (50) NULL,
    [CreatedDateTime]         DATETIME     NOT NULL,
    [ModifiedDateTime]        DATETIME     NOT NULL,
    [CreatedByUser]           VARCHAR (80) NOT NULL,
    [ModifiedByUser]          VARCHAR (80) NULL,
    [CreatedByProgram]        VARCHAR (80) NOT NULL,
    [ModifiedByProgram]       VARCHAR (80) NULL,
    [RecordStatus]            INT          NOT NULL,
    CONSTRAINT [PK_PatientMedicalHistoryHeader] PRIMARY KEY CLUSTERED ([PatientMedicalHistoryId] ASC),
    CONSTRAINT [R_126] FOREIGN KEY ([PatientId]) REFERENCES [PER].[Patient] ([PatientId])
);

