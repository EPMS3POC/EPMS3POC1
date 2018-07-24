CREATE TABLE [INS].[InsuranceElectronicTransactionType] (
    [InsuranceElectronicTransactionTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [InsuranceElectronicTransactionTypeDescription] VARCHAR (1024) NULL,
    [InsuranceElectronicTransactionTypeCode]        CHAR (5)       NULL,
    [InsuranceElectronicTransactionTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]                               DATETIME       NOT NULL,
    [ModifiedDateTime]                              DATETIME       NOT NULL,
    [CreatedByUser]                                 VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                                VARCHAR (80)   NULL,
    [CreatedByProgram]                              VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]                             VARCHAR (80)   NULL,
    [RecordStatus]                                  INT            NOT NULL,
    CONSTRAINT [XPKInsuranceElectronicTransactionType] PRIMARY KEY CLUSTERED ([InsuranceElectronicTransactionTypeId] ASC)
);

