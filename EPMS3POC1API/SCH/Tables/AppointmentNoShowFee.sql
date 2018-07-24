CREATE TABLE [SCH].[AppointmentNoShowFee] (
    [AppointmentNoShowFeeId]        INT          IDENTITY (1, 1) NOT NULL,
    [DefaultCharge]                 MONEY        NULL,
    [AppointmentCancellationCodeId] BIGINT       NULL,
    [AppointmentId]                 BIGINT       NULL,
    [InitiatedByWhom]               VARCHAR (80) NULL,
    [CreatedDateTime]               DATETIME     NOT NULL,
    [ModifiedDateTime]              DATETIME     NOT NULL,
    [CreatedByUser]                 VARCHAR (80) NOT NULL,
    [ModifiedByUser]                VARCHAR (80) NULL,
    [CreatedByProgram]              VARCHAR (80) NOT NULL,
    [ModifiedByProgram]             VARCHAR (80) NULL,
    [RecordStatus]                  INT          NOT NULL,
    CONSTRAINT [PK_AppointmentNoShowFees] PRIMARY KEY CLUSTERED ([AppointmentNoShowFeeId] ASC),
    CONSTRAINT [R_134] FOREIGN KEY ([AppointmentCancellationCodeId]) REFERENCES [SCH].[AppointmentCancellationCode] ([AppointmentCancellationCodeId]),
    CONSTRAINT [R_138] FOREIGN KEY ([AppointmentId]) REFERENCES [SCH].[Appointment] ([AppointmentId])
);

