CREATE TABLE [SCH].[ExcuseNote] (
    [ExcuseNoteId]         BIGINT       IDENTITY (1, 1) NOT NULL,
    [ExcuseDateTime]       DATETIME     NULL,
    [AppointmentStartTime] DATETIME     NULL,
    [AppointmentEndTime]   DATETIME     NULL,
    [ExcuseInHours]        BIT          NULL,
    [ExcuseInDays]         BIT          NULL,
    [NumberOfHoursOrDays]  INT          NULL,
    [ReturnDate]           DATETIME     NULL,
    [ProviderId]           BIGINT       NULL,
    [AppointmentId]        BIGINT       NULL,
    [CreatedDateTime]      DATETIME     NOT NULL,
    [ModifiedDateTime]     DATETIME     NOT NULL,
    [CreatedByUser]        VARCHAR (80) NOT NULL,
    [ModifiedByUser]       VARCHAR (80) NULL,
    [CreatedByProgram]     VARCHAR (80) NOT NULL,
    [ModifiedByProgram]    VARCHAR (80) NULL,
    [RecordStatus]         INT          NOT NULL,
    CONSTRAINT [PK_ExcuseNotes] PRIMARY KEY CLUSTERED ([ExcuseNoteId] ASC),
    CONSTRAINT [R_386] FOREIGN KEY ([AppointmentId]) REFERENCES [SCH].[Appointment] ([AppointmentId]),
    CONSTRAINT [R_853] FOREIGN KEY ([ProviderId]) REFERENCES [FAC].[Provider] ([ProviderId])
);

