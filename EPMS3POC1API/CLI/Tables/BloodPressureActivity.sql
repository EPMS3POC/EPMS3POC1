CREATE TABLE [CLI].[BloodPressureActivity] (
    [BloodPressureActivityId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [BloodPressureActivityDescription] VARCHAR (1024) NULL,
    [BloodPressureActivityCode]        CHAR (5)       NULL,
    [BloodPressureActivityName]        VARCHAR (50)   NULL,
    [CreatedDateTime]                  DATETIME       NOT NULL,
    [ModifiedDateTime]                 DATETIME       NOT NULL,
    [CreatedByUser]                    VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                   VARCHAR (80)   NULL,
    [CreatedByProgram]                 VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]                VARCHAR (80)   NULL,
    [RecordStatus]                     INT            NOT NULL,
    CONSTRAINT [XPKBloodPressureActivity] PRIMARY KEY CLUSTERED ([BloodPressureActivityId] ASC)
);

