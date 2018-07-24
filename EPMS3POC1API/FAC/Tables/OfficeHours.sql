CREATE TABLE [FAC].[OfficeHours] (
    [StartTime]              DATETIME       NULL,
    [EndTime]                DATETIME       NULL,
    [OfficeHoursId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [FacilityScheduleId]     BIGINT         NOT NULL,
    [OfficeHoursDescription] VARCHAR (1024) NULL,
    [OfficeHoursCode]        CHAR (5)       NULL,
    [OfficeHoursName]        VARCHAR (40)   NULL,
    [CreatedDateTime]        DATETIME       NOT NULL,
    [ModifiedDateTime]       DATETIME       NOT NULL,
    [CreatedByUser]          VARCHAR (80)   NOT NULL,
    [ModifiedByUser]         VARCHAR (80)   NULL,
    [CreatedByProgram]       VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]      VARCHAR (80)   NULL,
    [RecordStatus]           INT            NOT NULL,
    [OfficeHoursDate]        DATETIME       NULL,
    CONSTRAINT [XPKOfficeHours] PRIMARY KEY CLUSTERED ([OfficeHoursId] ASC),
    CONSTRAINT [R_581] FOREIGN KEY ([FacilityScheduleId]) REFERENCES [FAC].[FacilitySchedule] ([FacilityScheduleId])
);

