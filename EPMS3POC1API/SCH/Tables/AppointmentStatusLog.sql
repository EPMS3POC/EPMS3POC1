CREATE TABLE [SCH].[AppointmentStatusLog] (
    [AppointmentStatusLogId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [LogDateTime]            DATETIME     NULL,
    [CreatedDateTime]        DATETIME     NOT NULL,
    [ModifiedDateTime]       DATETIME     NOT NULL,
    [CreatedByUser]          VARCHAR (80) NOT NULL,
    [ModifiedByUser]         VARCHAR (80) NULL,
    [CreatedByProgram]       VARCHAR (80) NOT NULL,
    [ModifiedByProgram]      VARCHAR (80) NULL,
    [RecordStatus]           INT          NOT NULL,
    [AppointmentId]          BIGINT       NOT NULL,
    [PreviousStatusId]       BIGINT       NULL,
    [AppointmentStatusId]    BIGINT       NULL,
    CONSTRAINT [XPKAppointmentStatusLog] PRIMARY KEY CLUSTERED ([AppointmentStatusLogId] ASC),
    CONSTRAINT [R_648] FOREIGN KEY ([AppointmentId]) REFERENCES [SCH].[Appointment] ([AppointmentId]),
    CONSTRAINT [R_652] FOREIGN KEY ([AppointmentStatusId]) REFERENCES [SCH].[AppointmentStatus] ([AppointmentStatusId])
);

