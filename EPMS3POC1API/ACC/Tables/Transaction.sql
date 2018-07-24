CREATE TABLE [ACC].[Transaction] (
    [TransactionId]     BIGINT       IDENTITY (1, 1) NOT NULL,
    [LedgerId]          BIGINT       NOT NULL,
    [WriteOffAmount]    MONEY        NULL,
    [AdjustmentAmount]  MONEY        NULL,
    [TransactionAmount] MONEY        NULL,
    [PostedDate]        DATETIME     NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKTransaction] PRIMARY KEY CLUSTERED ([TransactionId] ASC),
    CONSTRAINT [R_523] FOREIGN KEY ([LedgerId]) REFERENCES [ACC].[Ledger] ([LedgerId])
);

