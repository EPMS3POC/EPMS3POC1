CREATE TABLE [ACC].[TransactionCredit] (
    [TransactionCreditId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [RemittanceId]        BIGINT       NULL,
    [CheckId]             BIGINT       NULL,
    [PaymentId]           BIGINT       NULL,
    [TransactionId]       BIGINT       NOT NULL,
    [CreatedDateTime]     DATETIME     NOT NULL,
    [ModifiedDateTime]    DATETIME     NOT NULL,
    [CreatedByUser]       VARCHAR (80) NOT NULL,
    [ModifiedByUser]      VARCHAR (80) NULL,
    [CreatedByProgram]    VARCHAR (80) NOT NULL,
    [ModifiedByProgram]   VARCHAR (80) NULL,
    [RecordStatus]        INT          NOT NULL,
    CONSTRAINT [XPKTransactionCredit] PRIMARY KEY CLUSTERED ([TransactionCreditId] ASC),
    CONSTRAINT [R_531] FOREIGN KEY ([RemittanceId]) REFERENCES [ACC].[Remittance] ([RemittanceId]),
    CONSTRAINT [R_763] FOREIGN KEY ([CheckId]) REFERENCES [ACC].[Check] ([CheckId]),
    CONSTRAINT [R_764] FOREIGN KEY ([PaymentId]) REFERENCES [ACC].[Payment] ([PaymentId]),
    CONSTRAINT [R_857] FOREIGN KEY ([TransactionId]) REFERENCES [ACC].[Transaction] ([TransactionId])
);

