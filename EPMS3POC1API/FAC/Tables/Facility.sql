﻿CREATE TABLE [FAC].[Facility] (
    [AncillaryStaffCount]  INT            NULL,
    [ContactName]          VARCHAR (80)   NULL,
    [IsPublishFacility]    SMALLINT       NULL,
    [IsWheelChairAccess]   SMALLINT       NULL,
    [ReportCategory]       CHAR (1)       NULL,
    [FacilityId]           BIGINT         IDENTITY (1, 1) NOT NULL,
    [EntityId]             BIGINT         NOT NULL,
    [ExamTime]             INT            NULL,
    [X_RayTime]            INT            NULL,
    [CCForceAppointmentAM] INT            NULL,
    [CCForceAppointmentPM] INT            NULL,
    [DoseSpotClinicKey]    VARCHAR (80)   NULL,
    [DoseSpotClinicId]     VARCHAR (80)   NULL,
    [ClinicProxyUser]      VARCHAR (80)   NULL,
    [LocationStatusId]     BIGINT         NULL,
    [IsHeadQuarter]        SMALLINT       NULL,
    [EmailIdentifier]      VARCHAR (80)   NULL,
    [WebsiteAddress]       VARCHAR (80)   NULL,
    [FacilityDescription]  VARCHAR (1024) NULL,
    [FacilityCode]         CHAR (5)       NULL,
    [FacilityName]         VARCHAR (40)   NULL,
    [CreatedDateTime]      DATETIME       NOT NULL,
    [ModifiedDateTime]     DATETIME       NOT NULL,
    [CreatedByUser]        VARCHAR (80)   NOT NULL,
    [ModifiedByUser]       VARCHAR (80)   NULL,
    [CreatedByProgram]     VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]    VARCHAR (80)   NULL,
    [RecordStatus]         INT            NOT NULL,
    CONSTRAINT [PK_Facility] PRIMARY KEY NONCLUSTERED ([FacilityId] ASC),
    CONSTRAINT [R_266] FOREIGN KEY ([EntityId]) REFERENCES [FAC].[Entity] ([EntityId]),
    CONSTRAINT [R_571] FOREIGN KEY ([LocationStatusId]) REFERENCES [FAC].[LocationStatus] ([LocationStatusId])
);

