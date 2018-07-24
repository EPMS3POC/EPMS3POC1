CREATE TABLE [CLI].[HeightMeasurement] (
    [HeightMeasurementId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [HeightMeasurementDescription] VARCHAR (1024) NULL,
    [HeightMeasurementCode]        CHAR (5)       NULL,
    [HeightMeasurementName]        VARCHAR (50)   NULL,
    [CreatedDateTime]              DATETIME       NOT NULL,
    [ModifiedDateTime]             DATETIME       NOT NULL,
    [CreatedByUser]                VARCHAR (80)   NOT NULL,
    [ModifiedByUser]               VARCHAR (80)   NULL,
    [CreatedByProgram]             VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]            VARCHAR (80)   NULL,
    [RecordStatus]                 INT            NOT NULL,
    CONSTRAINT [PK_HeightMeasurement] PRIMARY KEY CLUSTERED ([HeightMeasurementId] ASC)
);

