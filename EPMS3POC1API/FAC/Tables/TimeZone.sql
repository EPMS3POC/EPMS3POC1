CREATE TABLE [FAC].[TimeZone] (
    [TimeZoneId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [TimeZoneDescription] VARCHAR (1024) NULL,
    [TimeZoneCode]        CHAR (5)       NULL,
    [TimeZoneName]        VARCHAR (40)   NULL,
    [CreatedDateTime]     DATETIME       NOT NULL,
    [ModifiedDateTime]    DATETIME       NOT NULL,
    [CreatedByUser]       VARCHAR (80)   NOT NULL,
    [ModifiedByUser]      VARCHAR (80)   NULL,
    [CreatedByProgram]    VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]   VARCHAR (80)   NULL,
    [RecordStatus]        INT            NOT NULL,
    CONSTRAINT [XPKTimeZone] PRIMARY KEY CLUSTERED ([TimeZoneId] ASC)
);

