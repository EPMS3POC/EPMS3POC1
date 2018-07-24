CREATE TABLE [SCH].[CheckInNote] (
    [CheckInNote]       VARCHAR (1024) NULL,
    [CreatedDateTime]   DATETIME       NOT NULL,
    [ModifiedDateTime]  DATETIME       NOT NULL,
    [CreatedByUser]     VARCHAR (80)   NOT NULL,
    [ModifiedByUser]    VARCHAR (80)   NULL,
    [CreatedByProgram]  VARCHAR (80)   NOT NULL,
    [ModifiedByProgram] VARCHAR (80)   NULL,
    [RecordStatus]      INT            NOT NULL,
    [CheckInNoteId]     BIGINT         IDENTITY (1, 1) NOT NULL,
    [AppointmentId]     BIGINT         NULL,
    CONSTRAINT [XPKCheckInNote] PRIMARY KEY CLUSTERED ([CheckInNoteId] ASC),
    CONSTRAINT [R_861] FOREIGN KEY ([AppointmentId]) REFERENCES [SCH].[Appointment] ([AppointmentId])
);

