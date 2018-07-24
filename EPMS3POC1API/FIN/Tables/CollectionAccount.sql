CREATE TABLE [FIN].[CollectionAccount] (
    [CollectionAccountId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [CollectionAgencyId]  BIGINT       NULL,
    [AccountId]           BIGINT       NULL,
    [AmountPastDue]       MONEY        NULL,
    [CollectedBalance]    MONEY        NULL,
    [CreatedDateTime]     DATETIME     NOT NULL,
    [ModifiedDateTime]    DATETIME     NOT NULL,
    [CreatedByUser]       VARCHAR (80) NOT NULL,
    [ModifiedByUser]      VARCHAR (80) NULL,
    [CreatedByProgram]    VARCHAR (80) NOT NULL,
    [ModifiedByProgram]   VARCHAR (80) NULL,
    [RecordStatus]        INT          NOT NULL,
    CONSTRAINT [XPKCollectionAccount] PRIMARY KEY CLUSTERED ([CollectionAccountId] ASC),
    CONSTRAINT [R_720] FOREIGN KEY ([CollectionAgencyId]) REFERENCES [FIN].[CollectionAgency] ([CollectionAgencyId]),
    CONSTRAINT [R_721] FOREIGN KEY ([AccountId]) REFERENCES [ACC].[Account] ([AccountId])
);

