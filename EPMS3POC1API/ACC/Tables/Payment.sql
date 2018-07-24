CREATE TABLE [ACC].[Payment] (
    [PaymentId]         BIGINT         IDENTITY (1, 1) NOT NULL,
    [PaymentDate]       DATETIME       NULL,
    [PaymentModeId]     BIGINT         NULL,
    [PaymentReference]  VARCHAR (20)   NULL,
    [PaymentAmount]     MONEY          NULL,
    [PaymentComments]   VARCHAR (1024) NULL,
    [PaymentStatusId]   BIGINT         NULL,
    [PostedAmount]      MONEY          NULL,
    [UnAppliedAmount]   MONEY          NULL,
    [PaymentSourceId]   BIGINT         NULL,
    [CreatedDateTime]   DATETIME       NOT NULL,
    [ModifiedDateTime]  DATETIME       NOT NULL,
    [CreatedByUser]     VARCHAR (80)   NOT NULL,
    [ModifiedByUser]    VARCHAR (80)   NULL,
    [CreatedByProgram]  VARCHAR (80)   NOT NULL,
    [ModifiedByProgram] VARCHAR (80)   NULL,
    [RecordStatus]      INT            NOT NULL,
    CONSTRAINT [XPKPayment] PRIMARY KEY CLUSTERED ([PaymentId] ASC),
    CONSTRAINT [R_675] FOREIGN KEY ([PaymentModeId]) REFERENCES [ACC].[PaymentMode] ([PaymentModeId]),
    CONSTRAINT [R_676] FOREIGN KEY ([PaymentStatusId]) REFERENCES [ACC].[PaymentStatus] ([PaymentStatusId]),
    CONSTRAINT [R_679] FOREIGN KEY ([PaymentSourceId]) REFERENCES [ACC].[PaymentSource] ([PaymentSourceId])
);

