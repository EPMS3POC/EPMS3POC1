CREATE TABLE [SCH].[AppointmentCancellationCode] (
    [AppointmentCancellationCodeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [IsNoShowCharge]                         SMALLINT       NULL,
    [DefaultCharge]                          MONEY          NULL,
    [AppointmentCancellationCodeDescription] VARCHAR (1024) NULL,
    [AppointmentCancellationCodeCode]        CHAR (5)       NULL,
    [AppointmentCancellationCodeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]                        DATETIME       NOT NULL,
    [ModifiedDateTime]                       DATETIME       NOT NULL,
    [CreatedByUser]                          VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                         VARCHAR (80)   NULL,
    [CreatedByProgram]                       VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]                      VARCHAR (80)   NULL,
    [RecordStatus]                           INT            NOT NULL,
    CONSTRAINT [PK_AppointmentCancellationCodes] PRIMARY KEY CLUSTERED ([AppointmentCancellationCodeId] ASC)
);

