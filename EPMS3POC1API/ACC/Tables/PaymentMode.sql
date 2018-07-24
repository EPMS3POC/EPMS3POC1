CREATE TABLE [ACC].[PaymentMode] (
    [PaymentModeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [PaymentModeDescription] VARCHAR (1024) NULL,
    [PaymentModeCode]        CHAR (5)       NULL,
    [PaymentModeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]        DATETIME       NOT NULL,
    [ModifiedDateTime]       DATETIME       NOT NULL,
    [CreatedByUser]          VARCHAR (80)   NOT NULL,
    [ModifiedByUser]         VARCHAR (80)   NULL,
    [CreatedByProgram]       VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]      VARCHAR (80)   NULL,
    [RecordStatus]           INT            NOT NULL,
    CONSTRAINT [XPKPaymentMode] PRIMARY KEY CLUSTERED ([PaymentModeId] ASC)
);

