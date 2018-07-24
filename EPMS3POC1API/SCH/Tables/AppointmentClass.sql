CREATE TABLE [SCH].[AppointmentClass] (
    [AppointmentClassId]               BIGINT         IDENTITY (1, 1) NOT NULL,
    [ProviderTypeId]                   BIGINT         NULL,
    [OperatoryId]                      BIGINT         NULL,
    [AppointmentClassDescription]      VARCHAR (1024) NULL,
    [AppointmentClassCode]             CHAR (5)       NULL,
    [AppointmentClassName]             VARCHAR (40)   NULL,
    [IsExamDoctorRequired]             SMALLINT       NULL,
    [ShortestAppointmentOpeningToSave] INT            NULL,
    [LongestAppointmentOpeningToSave]  INT            NULL,
    [MinutesPerAppointmentUnit]        INT            NULL,
    [DaysToHoldSchedule]               INT            NULL,
    [CreatedDateTime]                  DATETIME       NOT NULL,
    [ModifiedDateTime]                 DATETIME       NOT NULL,
    [CreatedByUser]                    VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                   VARCHAR (80)   NULL,
    [CreatedByProgram]                 VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]                VARCHAR (80)   NULL,
    [RecordStatus]                     INT            NOT NULL,
    CONSTRAINT [XPKAppointmentClass] PRIMARY KEY CLUSTERED ([AppointmentClassId] ASC),
    CONSTRAINT [R_544] FOREIGN KEY ([ProviderTypeId]) REFERENCES [FAC].[ProviderType] ([ProviderTypeId]),
    CONSTRAINT [R_612] FOREIGN KEY ([OperatoryId]) REFERENCES [FAC].[Operatory] ([OperatoryId])
);

