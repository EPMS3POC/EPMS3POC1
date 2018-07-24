CREATE TABLE [SCH].[AppointmentType] (
    [AppointmentTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CPTCode]                    VARCHAR (6)    NULL,
    [TimeslotDurationInMinutes]  INT            NULL,
    [AppointmentTypeDescription] VARCHAR (1024) NULL,
    [AppointmentTypeCode]        CHAR (5)       NULL,
    [AppointmentTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]            DATETIME       NOT NULL,
    [ModifiedDateTime]           DATETIME       NOT NULL,
    [CreatedByUser]              VARCHAR (80)   NOT NULL,
    [ModifiedByUser]             VARCHAR (80)   NULL,
    [CreatedByProgram]           VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]          VARCHAR (80)   NULL,
    [RecordStatus]               INT            NOT NULL,
    CONSTRAINT [PK_AppointmentTypes] PRIMARY KEY CLUSTERED ([AppointmentTypeId] ASC)
);

