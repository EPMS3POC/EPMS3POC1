CREATE TABLE [PER].[AppointmentPreference] (
    [PatientId]               BIGINT       NOT NULL,
    [AppointmentPreferenceId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [StartTime]               DATETIME     NULL,
    [EndTime]                 DATETIME     NULL,
    [CreatedDateTime]         DATETIME     NOT NULL,
    [ModifiedDateTime]        DATETIME     NOT NULL,
    [CreatedByUser]           VARCHAR (80) NOT NULL,
    [ModifiedByUser]          VARCHAR (80) NULL,
    [CreatedByProgram]        VARCHAR (80) NOT NULL,
    [ModifiedByProgram]       VARCHAR (80) NULL,
    [RecordStatus]            INT          NOT NULL,
    CONSTRAINT [XPKAppointmentPreference] PRIMARY KEY CLUSTERED ([AppointmentPreferenceId] ASC),
    CONSTRAINT [R_136] FOREIGN KEY ([PatientId]) REFERENCES [PER].[Patient] ([PatientId])
);

