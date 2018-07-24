CREATE TABLE [SCH].[AppointmentTimeSlot] (
    [AppointmentTimeSlotId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [AppointmentId]         BIGINT       NOT NULL,
    [CreatedDateTime]       DATETIME     NOT NULL,
    [ModifiedDateTime]      DATETIME     NOT NULL,
    [CreatedByUser]         VARCHAR (80) NOT NULL,
    [ModifiedByUser]        VARCHAR (80) NULL,
    [CreatedByProgram]      VARCHAR (80) NOT NULL,
    [ModifiedByProgram]     VARCHAR (80) NULL,
    [RecordStatus]          INT          NOT NULL,
    [TimeSlotId]            BIGINT       NOT NULL,
    [EmployeeId]            BIGINT       NULL,
    CONSTRAINT [PK_AppointmentTimeSlots] PRIMARY KEY CLUSTERED ([AppointmentTimeSlotId] ASC),
    CONSTRAINT [R_176] FOREIGN KEY ([TimeSlotId]) REFERENCES [FAC].[TimeSlot] ([TimeSlotId]),
    CONSTRAINT [R_321] FOREIGN KEY ([AppointmentId]) REFERENCES [SCH].[Appointment] ([AppointmentId]),
    CONSTRAINT [R_854] FOREIGN KEY ([EmployeeId]) REFERENCES [FAC].[Employee] ([EmployeeId])
);

