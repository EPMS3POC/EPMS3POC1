CREATE TABLE [ACC].[Adjustment] (
    [AdjustmentId]        BIGINT         IDENTITY (1, 1) NOT NULL,
    [AdjustmentDate]      DATETIME       NULL,
    [AdjustmentCodeId]    BIGINT         NULL,
    [ProviderId]          BIGINT         NULL,
    [AdjustmentReference] VARCHAR (20)   NULL,
    [AdjustmentAmount]    MONEY          NULL,
    [AdjustmentComments]  VARCHAR (1024) NULL,
    [AdjustmentTypeId]    BIGINT         NULL,
    [CreatedDateTime]     DATETIME       NOT NULL,
    [ModifiedDateTime]    DATETIME       NOT NULL,
    [CreatedByUser]       VARCHAR (80)   NOT NULL,
    [ModifiedByUser]      VARCHAR (80)   NULL,
    [CreatedByProgram]    VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]   VARCHAR (80)   NULL,
    [RecordStatus]        INT            NOT NULL,
    [TransactionId]       BIGINT         NOT NULL,
    CONSTRAINT [XPKAdjustment] PRIMARY KEY CLUSTERED ([AdjustmentId] ASC),
    CONSTRAINT [R_681] FOREIGN KEY ([AdjustmentCodeId]) REFERENCES [ACC].[AdjustmentCode] ([AdjustmentCodeId]),
    CONSTRAINT [R_682] FOREIGN KEY ([ProviderId]) REFERENCES [FAC].[Provider] ([ProviderId]),
    CONSTRAINT [R_683] FOREIGN KEY ([AdjustmentTypeId]) REFERENCES [ACC].[AdjustmentType] ([AdjustmentTypeId]),
    CONSTRAINT [R_859] FOREIGN KEY ([TransactionId]) REFERENCES [ACC].[Transaction] ([TransactionId])
);

