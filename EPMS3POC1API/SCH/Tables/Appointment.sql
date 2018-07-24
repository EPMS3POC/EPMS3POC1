CREATE TABLE [SCH].[Appointment] (
    [AppointmentId]             BIGINT       IDENTITY (1, 1) NOT NULL,
    [AppointmentDate]           DATETIME     NULL,
    [CallReminderStatus]        CHAR (1)     CONSTRAINT [DF_Appointments_CallReminderStatus] DEFAULT ('A') NULL,
    [CreateAppointmentDateTime] DATETIME     NULL,
    [AppointmentTypeId]         BIGINT       NULL,
    [VisitId]                   BIGINT       NULL,
    [RevenueAmount]             MONEY        NULL,
    [ChairMinutes]              INT          NULL,
    [CreatedDateTime]           DATETIME     NOT NULL,
    [ModifiedDateTime]          DATETIME     NOT NULL,
    [CreatedByUser]             VARCHAR (80) NOT NULL,
    [ModifiedByUser]            VARCHAR (80) NULL,
    [CreatedByProgram]          VARCHAR (80) NOT NULL,
    [ModifiedByProgram]         VARCHAR (80) NULL,
    [RecordStatus]              INT          NOT NULL,
    [AppointmentStatusId]       BIGINT       NULL,
    CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED ([AppointmentId] ASC),
    CONSTRAINT [R_122] FOREIGN KEY ([AppointmentTypeId]) REFERENCES [SCH].[AppointmentType] ([AppointmentTypeId]),
    CONSTRAINT [R_415] FOREIGN KEY ([VisitId]) REFERENCES [SCH].[Visit] ([VisitId]),
    CONSTRAINT [R_650] FOREIGN KEY ([AppointmentStatusId]) REFERENCES [SCH].[AppointmentStatus] ([AppointmentStatusId])
);

