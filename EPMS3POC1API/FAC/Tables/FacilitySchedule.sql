CREATE TABLE [FAC].[FacilitySchedule] (
    [FacilityScheduleId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [FacilityId]         BIGINT       NOT NULL,
    [TimeZoneId]         BIGINT       NULL,
    [CreatedDateTime]    DATETIME     NOT NULL,
    [ModifiedDateTime]   DATETIME     NOT NULL,
    [CreatedByUser]      VARCHAR (80) NOT NULL,
    [ModifiedByUser]     VARCHAR (80) NULL,
    [CreatedByProgram]   VARCHAR (80) NOT NULL,
    [ModifiedByProgram]  VARCHAR (80) NULL,
    [RecordStatus]       INT          NOT NULL,
    [MasterCalendarId]   BIGINT       NULL,
    CONSTRAINT [XPKFacilitySchedule] PRIMARY KEY CLUSTERED ([FacilityScheduleId] ASC)
);

