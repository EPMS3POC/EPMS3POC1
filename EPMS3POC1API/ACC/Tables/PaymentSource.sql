CREATE TABLE [ACC].[PaymentSource] (
    [PaymentSourceId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [PaymentSourceDescription] VARCHAR (1024) NULL,
    [PaymentSourceCode]        CHAR (5)       NULL,
    [PaymentSourceName]        VARCHAR (40)   NULL,
    [CreatedDateTime]          DATETIME       NOT NULL,
    [ModifiedDateTime]         DATETIME       NOT NULL,
    [CreatedByUser]            VARCHAR (80)   NOT NULL,
    [ModifiedByUser]           VARCHAR (80)   NULL,
    [CreatedByProgram]         VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]        VARCHAR (80)   NULL,
    [RecordStatus]             INT            NOT NULL,
    CONSTRAINT [XPKPaymentSource] PRIMARY KEY CLUSTERED ([PaymentSourceId] ASC)
);

