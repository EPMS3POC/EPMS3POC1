CREATE TABLE [FAC].[MasterSchedule] (
    [MasterScheduleId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [MasterScheduleDescription] VARCHAR (1024) NULL,
    [MasterScheduleCode]        CHAR (5)       NULL,
    [MasterScheduleName]        VARCHAR (40)   NULL,
    [CreatedDateTime]           DATETIME       NOT NULL,
    [ModifiedDateTime]          DATETIME       NOT NULL,
    [CreatedByUser]             VARCHAR (80)   NOT NULL,
    [ModifiedByUser]            VARCHAR (80)   NULL,
    [CreatedByProgram]          VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]         VARCHAR (80)   NULL,
    [RecordStatus]              INT            NOT NULL,
    [FacilityId]                BIGINT         NOT NULL,
    CONSTRAINT [XPKMasterSchedule] PRIMARY KEY CLUSTERED ([MasterScheduleId] ASC),
    CONSTRAINT [R_842] FOREIGN KEY ([FacilityId]) REFERENCES [FAC].[Facility] ([FacilityId])
);

