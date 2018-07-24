CREATE TABLE [INS].[InsuranceElectronicTransaction] (
    [InsuranceElectronicTransactionId]     BIGINT       IDENTITY (1, 1) NOT NULL,
    [IsSupported]                          SMALLINT     NULL,
    [InsuranceElectronicTransactionTypeId] BIGINT       NULL,
    [CreatedDateTime]                      DATETIME     NOT NULL,
    [ModifiedDateTime]                     DATETIME     NOT NULL,
    [CreatedByUser]                        VARCHAR (80) NOT NULL,
    [ModifiedByUser]                       VARCHAR (80) NULL,
    [CreatedByProgram]                     VARCHAR (80) NOT NULL,
    [ModifiedByProgram]                    VARCHAR (80) NULL,
    [RecordStatus]                         INT          NOT NULL,
    [InsurancePayerId]                     BIGINT       NULL,
    CONSTRAINT [XPKInsuranceElectronicTransaction] PRIMARY KEY CLUSTERED ([InsuranceElectronicTransactionId] ASC),
    CONSTRAINT [R_696] FOREIGN KEY ([InsuranceElectronicTransactionTypeId]) REFERENCES [INS].[InsuranceElectronicTransactionType] ([InsuranceElectronicTransactionTypeId]),
    CONSTRAINT [R_729] FOREIGN KEY ([InsurancePayerId]) REFERENCES [INS].[InsurancePayer] ([InsurancePayerId])
);

