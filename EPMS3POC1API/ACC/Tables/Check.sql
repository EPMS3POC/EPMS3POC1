CREATE TABLE [ACC].[Check] (
    [CheckId]            BIGINT       NOT NULL,
    [CheckNumber]        VARCHAR (20) NULL,
    [DateOfPayment]      VARCHAR (20) NULL,
    [MICRData]           VARCHAR (20) NULL,
    [AccountNumber]      VARCHAR (20) NULL,
    [BankRountingNumber] VARCHAR (20) NULL,
    [Amount]             VARCHAR (20) NULL,
    [CheckImage]         VARCHAR (20) NULL,
    [ICLReceivedDate]    VARCHAR (20) NULL,
    [MasterPayerId]      BIGINT       NULL,
    [MasterPayeeId]      BIGINT       NULL,
    [CheckFilieName]     VARCHAR (20) NULL,
    [CreatedDateTime]    DATETIME     NOT NULL,
    [ModifiedDateTime]   DATETIME     NOT NULL,
    [CreatedByUser]      VARCHAR (80) NOT NULL,
    [ModifiedByUser]     VARCHAR (80) NULL,
    [CreatedByProgram]   VARCHAR (80) NOT NULL,
    [ModifiedByProgram]  VARCHAR (80) NULL,
    [RecordStatus]       INT          NOT NULL,
    CONSTRAINT [XPKCheck] PRIMARY KEY CLUSTERED ([CheckId] ASC),
    CONSTRAINT [R_762] FOREIGN KEY ([MasterPayeeId]) REFERENCES [ACC].[MasterPayee] ([MasterPayeeId])
);

