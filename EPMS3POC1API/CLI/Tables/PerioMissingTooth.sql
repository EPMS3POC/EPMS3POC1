CREATE TABLE [CLI].[PerioMissingTooth] (
    [PerioMissingToothId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [ToothNumber]         INT          NULL,
    [IsPerioMissingTooth] SMALLINT     NULL,
    [CreatedDateTime]     DATETIME     NOT NULL,
    [ModifiedDateTime]    DATETIME     NOT NULL,
    [CreatedByUser]       VARCHAR (80) NOT NULL,
    [ModifiedByUser]      VARCHAR (80) NULL,
    [CreatedByProgram]    VARCHAR (80) NOT NULL,
    [ModifiedByProgram]   VARCHAR (80) NULL,
    [RecordStatus]        INT          NOT NULL,
    [PerioChartId]        BIGINT       NULL,
    [PatientToothId]      BIGINT       NULL,
    CONSTRAINT [PK_PerioMissingTooth] PRIMARY KEY CLUSTERED ([PerioMissingToothId] ASC),
    CONSTRAINT [R_760] FOREIGN KEY ([PerioChartId]) REFERENCES [CLI].[PerioChart] ([PerioChartId]),
    CONSTRAINT [R_831] FOREIGN KEY ([PatientToothId]) REFERENCES [CLI].[PatientTooth] ([PatientToothId])
);

