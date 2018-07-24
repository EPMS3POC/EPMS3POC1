CREATE TABLE [ACC].[AdjustmentCode] (
    [AdjustmentCodeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [AdjustmentCodeDescription] VARCHAR (1024) NULL,
    [AdjustmentCodeCode]        CHAR (5)       NULL,
    [AdjustmentCodeName]        VARCHAR (40)   NULL,
    [AdjustmentTypeId]          BIGINT         NULL,
    [CreatedDateTime]           DATETIME       NOT NULL,
    [ModifiedDateTime]          DATETIME       NOT NULL,
    [CreatedByUser]             VARCHAR (80)   NOT NULL,
    [ModifiedByUser]            VARCHAR (80)   NULL,
    [CreatedByProgram]          VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]         VARCHAR (80)   NULL,
    [RecordStatus]              INT            NOT NULL,
    CONSTRAINT [XPKAdjustmentCode] PRIMARY KEY CLUSTERED ([AdjustmentCodeId] ASC),
    CONSTRAINT [R_684] FOREIGN KEY ([AdjustmentTypeId]) REFERENCES [ACC].[AdjustmentType] ([AdjustmentTypeId])
);

