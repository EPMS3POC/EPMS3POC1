CREATE TABLE [ACC].[AdjustmentType] (
    [AdjustmentTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [AdjustmentTypeDescription] VARCHAR (1024) NULL,
    [AdjustmentTypeCode]        CHAR (5)       NULL,
    [AdjustmentTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]           DATETIME       NOT NULL,
    [ModifiedDateTime]          DATETIME       NOT NULL,
    [CreatedByUser]             VARCHAR (80)   NOT NULL,
    [ModifiedByUser]            VARCHAR (80)   NULL,
    [CreatedByProgram]          VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]         VARCHAR (80)   NULL,
    [RecordStatus]              INT            NOT NULL,
    CONSTRAINT [XPKAdjustmentType] PRIMARY KEY CLUSTERED ([AdjustmentTypeId] ASC)
);

