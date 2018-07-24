CREATE TABLE [ACC].[PaymentStatus] (
    [PaymentStatusId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [PaymentStatusDescription] VARCHAR (1024) NULL,
    [PaymentStatusCode]        CHAR (5)       NULL,
    [PaymentStatusName]        VARCHAR (40)   NULL,
    [CreatedDateTime]          DATETIME       NOT NULL,
    [ModifiedDateTime]         DATETIME       NOT NULL,
    [CreatedByUser]            VARCHAR (80)   NOT NULL,
    [ModifiedByUser]           VARCHAR (80)   NULL,
    [CreatedByProgram]         VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]        VARCHAR (80)   NULL,
    [RecordStatus]             INT            NOT NULL,
    CONSTRAINT [XPKPaymentStatus] PRIMARY KEY CLUSTERED ([PaymentStatusId] ASC)
);

