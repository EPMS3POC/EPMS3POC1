CREATE TABLE [FAC].[DemographicField] (
    [DemographicFieldId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [DemographicFieldDescription] VARCHAR (1024) NULL,
    [DemographicFieldCode]        CHAR (5)       NULL,
    [DemographicFieldName]        VARCHAR (40)   NULL,
    [CreatedDateTime]             DATETIME       NOT NULL,
    [ModifiedDateTime]            DATETIME       NOT NULL,
    [CreatedByUser]               VARCHAR (80)   NOT NULL,
    [ModifiedByUser]              VARCHAR (80)   NULL,
    [CreatedByProgram]            VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]           VARCHAR (80)   NULL,
    [RecordStatus]                INT            NOT NULL,
    CONSTRAINT [XPKDemographicField] PRIMARY KEY CLUSTERED ([DemographicFieldId] ASC)
);

