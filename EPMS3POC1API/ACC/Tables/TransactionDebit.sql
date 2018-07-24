CREATE TABLE [ACC].[TransactionDebit] (
    [TransactionDebitId]    BIGINT       IDENTITY (1, 1) NOT NULL,
    [PatientProcedureId]    BIGINT       NULL,
    [PatientProcedureLogId] BIGINT       NULL,
    [TransactionId]         BIGINT       NOT NULL,
    [CreatedDateTime]       DATETIME     NOT NULL,
    [ModifiedDateTime]      DATETIME     NOT NULL,
    [CreatedByUser]         VARCHAR (80) NOT NULL,
    [ModifiedByUser]        VARCHAR (80) NULL,
    [CreatedByProgram]      VARCHAR (80) NOT NULL,
    [ModifiedByProgram]     VARCHAR (80) NULL,
    [RecordStatus]          INT          NOT NULL,
    CONSTRAINT [XPKTransactionDebit] PRIMARY KEY CLUSTERED ([TransactionDebitId] ASC),
    CONSTRAINT [R_628] FOREIGN KEY ([PatientProcedureId]) REFERENCES [TRE].[PatientProcedure] ([PatientProcedureId]),
    CONSTRAINT [R_825] FOREIGN KEY ([PatientProcedureLogId]) REFERENCES [TRE].[PatientProcedureLog] ([PatientProcedureLogId]),
    CONSTRAINT [R_858] FOREIGN KEY ([TransactionId]) REFERENCES [ACC].[Transaction] ([TransactionId])
);

