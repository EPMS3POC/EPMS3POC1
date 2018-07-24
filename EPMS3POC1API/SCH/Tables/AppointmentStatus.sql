CREATE TABLE [SCH].[AppointmentStatus] (
    [AppointmentStatusId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [AppointmentStatusDescription] VARCHAR (1024) NULL,
    [AppointmentStatusCode]        CHAR (5)       NULL,
    [AppointmentStatusName]        VARCHAR (40)   NULL,
    [CreatedDateTime]              DATETIME       NOT NULL,
    [ModifiedDateTime]             DATETIME       NOT NULL,
    [CreatedByUser]                VARCHAR (80)   NOT NULL,
    [ModifiedByUser]               VARCHAR (80)   NULL,
    [CreatedByProgram]             VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]            VARCHAR (80)   NULL,
    [RecordStatus]                 INT            NOT NULL,
    CONSTRAINT [XPKAppointmentStatus] PRIMARY KEY CLUSTERED ([AppointmentStatusId] ASC)
);

