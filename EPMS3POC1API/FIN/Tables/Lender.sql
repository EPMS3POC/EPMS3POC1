CREATE TABLE [FIN].[Lender] (
    [FinanceId]         BIGINT       NULL,
    [LenderId]          BIGINT       IDENTITY (1, 1) NOT NULL,
    [LenderTypeId]      BIGINT       NOT NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKLender] PRIMARY KEY CLUSTERED ([LenderId] ASC),
    CONSTRAINT [R_362] FOREIGN KEY ([LenderTypeId]) REFERENCES [FIN].[LenderType] ([LenderTypeId]),
    CONSTRAINT [R_364] FOREIGN KEY ([FinanceId]) REFERENCES [FIN].[Finance] ([FinanceId])
);

