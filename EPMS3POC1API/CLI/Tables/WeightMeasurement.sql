CREATE TABLE [CLI].[WeightMeasurement] (
    [WeightMeasurementId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [WeightMeasurementDescription] VARCHAR (1024) NULL,
    [WeightMeasurementCode]        CHAR (5)       NULL,
    [WeightMeasurementName]        VARCHAR (50)   NULL,
    [CreatedDateTime]              DATETIME       NOT NULL,
    [ModifiedDateTime]             DATETIME       NOT NULL,
    [CreatedByUser]                VARCHAR (80)   NOT NULL,
    [ModifiedByUser]               VARCHAR (80)   NULL,
    [CreatedByProgram]             VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]            VARCHAR (80)   NULL,
    [RecordStatus]                 INT            NOT NULL,
    CONSTRAINT [PK_WeightMeasurement] PRIMARY KEY CLUSTERED ([WeightMeasurementId] ASC)
);

