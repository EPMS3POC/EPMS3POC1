CREATE TABLE [FIN].[CreditAccount] (
    [CreditAccountId]       BIGINT       IDENTITY (1, 1) NOT NULL,
    [LenderId]              BIGINT       NULL,
    [AccountId]             BIGINT       NULL,
    [CreditAccountStatusId] BIGINT       NULL,
    [CreditMaximum]         MONEY        NULL,
    [CreditBalanceDue]      MONEY        NULL,
    [CreatedDateTime]       DATETIME     NOT NULL,
    [ModifiedDateTime]      DATETIME     NOT NULL,
    [CreatedByUser]         VARCHAR (80) NOT NULL,
    [ModifiedByUser]        VARCHAR (80) NULL,
    [CreatedByProgram]      VARCHAR (80) NOT NULL,
    [ModifiedByProgram]     VARCHAR (80) NULL,
    [RecordStatus]          INT          NOT NULL,
    [AccountNumber]         VARCHAR (20) NULL,
    CONSTRAINT [XPKCreditAccount] PRIMARY KEY CLUSTERED ([CreditAccountId] ASC),
    CONSTRAINT [R_691] FOREIGN KEY ([LenderId]) REFERENCES [FIN].[Lender] ([LenderId]),
    CONSTRAINT [R_692] FOREIGN KEY ([AccountId]) REFERENCES [ACC].[Account] ([AccountId]),
    CONSTRAINT [R_719] FOREIGN KEY ([CreditAccountStatusId]) REFERENCES [FIN].[CreditAccountStatus] ([CreditAccountStatusId])
);

