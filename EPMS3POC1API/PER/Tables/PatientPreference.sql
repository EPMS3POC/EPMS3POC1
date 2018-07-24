CREATE TABLE [PER].[PatientPreference] (
    [PatientPreferenceId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [SystemIdentifier]    BIGINT       NULL,
    [Value]               VARCHAR (20) NULL,
    [PreferenceTypeId]    BIGINT       NULL,
    [CreatedDateTime]     DATETIME     NOT NULL,
    [ModifiedDateTime]    DATETIME     NOT NULL,
    [CreatedByUser]       VARCHAR (80) NOT NULL,
    [ModifiedByUser]      VARCHAR (80) NULL,
    [CreatedByProgram]    VARCHAR (80) NOT NULL,
    [ModifiedByProgram]   VARCHAR (80) NULL,
    [RecordStatus]        INT          NOT NULL,
    [PatientId]           BIGINT       NULL,
    CONSTRAINT [PK_PatientPreference] PRIMARY KEY CLUSTERED ([PatientPreferenceId] ASC),
    CONSTRAINT [R_834] FOREIGN KEY ([PreferenceTypeId]) REFERENCES [PER].[PreferenceType] ([PreferenceTypeId]),
    CONSTRAINT [R_911] FOREIGN KEY ([PatientId]) REFERENCES [PER].[Patient] ([PatientId])
);

