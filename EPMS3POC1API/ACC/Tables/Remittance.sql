CREATE TABLE [ACC].[Remittance] (
    [RemittanceId]      BIGINT       NOT NULL,
    [InsuranceId]       BIGINT       NULL,
    [EOBCheckNumber]    VARCHAR (20) NULL,
    [EOBCheckAmount]    MONEY        NULL,
    [EOBAccountNumber]  VARCHAR (20) NULL,
    [EOBReceivedDate]   DATETIME     NULL,
    [EOBPayer]          VARCHAR (20) NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKRemittance] PRIMARY KEY CLUSTERED ([RemittanceId] ASC),
    CONSTRAINT [R_530] FOREIGN KEY ([InsuranceId]) REFERENCES [INS].[Insurance] ([InsuranceId])
);

