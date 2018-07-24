CREATE TABLE [SCH].[Confirmation] (
    [ConfirmationId]    BIGINT       IDENTITY (1, 1) NOT NULL,
    [IsConfirmed]       SMALLINT     NULL,
    [AppointmentId]     BIGINT       NULL,
    [ConfirmationDate]  DATETIME     NULL,
    [ConfirmationCode]  VARCHAR (20) NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKConfirmation] PRIMARY KEY CLUSTERED ([ConfirmationId] ASC),
    CONSTRAINT [R_588] FOREIGN KEY ([AppointmentId]) REFERENCES [SCH].[Appointment] ([AppointmentId])
);

