CREATE TABLE [ACC].[Statement] (
    [AccountingId]         BIGINT         NOT NULL,
    [StatementId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [StatementName]        VARCHAR (40)   NULL,
    [StatementDescription] VARCHAR (1024) NULL,
    [StatementCode]        CHAR (5)       NULL,
    [CreatedDateTime]      DATETIME       NOT NULL,
    [ModifiedDateTime]     DATETIME       NOT NULL,
    [CreatedByUser]        VARCHAR (80)   NOT NULL,
    [ModifiedByUser]       VARCHAR (80)   NULL,
    [CreatedByProgram]     VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]    VARCHAR (80)   NULL,
    [RecordStatus]         INT            NOT NULL,
    CONSTRAINT [XPKStatement] PRIMARY KEY CLUSTERED ([StatementId] ASC),
    CONSTRAINT [R_363] FOREIGN KEY ([AccountingId]) REFERENCES [ACC].[Accounting] ([AccountingId])
);

