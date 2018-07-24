CREATE TABLE [FIN].[CreditAccountStatus] (
    [CreditAccountStatusId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CreditAccountStatusName]        VARCHAR (40)   NULL,
    [CreditAccountStatusDescription] VARCHAR (1024) NULL,
    [CreditAccountStatusCode]        CHAR (5)       NULL,
    [CreatedDateTime]                DATETIME       NOT NULL,
    [ModifiedDateTime]               DATETIME       NOT NULL,
    [CreatedByUser]                  VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                 VARCHAR (80)   NULL,
    [CreatedByProgram]               VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]              VARCHAR (80)   NULL,
    [RecordStatus]                   INT            NOT NULL,
    CONSTRAINT [XPKCreditAccountStatus] PRIMARY KEY CLUSTERED ([CreditAccountStatusId] ASC)
);

