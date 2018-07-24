CREATE TABLE [SCH].[ChartAudit] (
    [ChartAuditId]       BIGINT       IDENTITY (1, 1) NOT NULL,
    [AppointmentId]      BIGINT       NOT NULL,
    [ChartAuditStatusId] BIGINT       NULL,
    [ReviewReasonId]     BIGINT       NULL,
    [CreatedDateTime]    DATETIME     NOT NULL,
    [ModifiedDateTime]   DATETIME     NOT NULL,
    [CreatedByUser]      VARCHAR (80) NOT NULL,
    [ModifiedByUser]     VARCHAR (80) NULL,
    [CreatedByProgram]   VARCHAR (80) NOT NULL,
    [ModifiedByProgram]  VARCHAR (80) NULL,
    [RecordStatus]       INT          NOT NULL,
    CONSTRAINT [XPKChartAudit] PRIMARY KEY CLUSTERED ([ChartAuditId] ASC),
    CONSTRAINT [R_517] FOREIGN KEY ([AppointmentId]) REFERENCES [SCH].[Appointment] ([AppointmentId]),
    CONSTRAINT [R_586] FOREIGN KEY ([ChartAuditStatusId]) REFERENCES [SCH].[ChartAuditStatus] ([ChartAuditStatusId]),
    CONSTRAINT [R_587] FOREIGN KEY ([ReviewReasonId]) REFERENCES [SCH].[ReviewReason] ([ReviewReasonId])
);

