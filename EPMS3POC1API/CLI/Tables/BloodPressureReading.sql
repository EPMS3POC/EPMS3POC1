CREATE TABLE [CLI].[BloodPressureReading] (
    [BloodPressureReadingId]  BIGINT       IDENTITY (1, 1) NOT NULL,
    [BloodPressureActivityId] BIGINT       NULL,
    [VitalStateId]            BIGINT       NULL,
    [SystolicPressure]        INT          NULL,
    [DiastolicPressure]       INT          NULL,
    [CreatedDateTime]         DATETIME     NOT NULL,
    [ModifiedDateTime]        DATETIME     NOT NULL,
    [CreatedByUser]           VARCHAR (80) NOT NULL,
    [ModifiedByUser]          VARCHAR (80) NULL,
    [CreatedByProgram]        VARCHAR (80) NOT NULL,
    [ModifiedByProgram]       VARCHAR (80) NULL,
    [RecordStatus]            INT          NOT NULL,
    CONSTRAINT [XPKBloodPressureReading] PRIMARY KEY CLUSTERED ([BloodPressureReadingId] ASC),
    CONSTRAINT [R_777] FOREIGN KEY ([BloodPressureActivityId]) REFERENCES [CLI].[BloodPressureActivity] ([BloodPressureActivityId]),
    CONSTRAINT [R_778] FOREIGN KEY ([VitalStateId]) REFERENCES [CLI].[VitalState] ([VitalStateId])
);

