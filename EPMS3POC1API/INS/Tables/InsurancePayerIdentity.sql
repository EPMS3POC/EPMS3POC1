CREATE TABLE [INS].[InsurancePayerIdentity] (
    [ElectronicPayerIdentityId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [InsurancePayerId]          BIGINT       NULL,
    [ClearingHouseId]           BIGINT       NULL,
    [ElectronicPayerIdentity]   CHAR (18)    NULL,
    [CreatedDateTime]           DATETIME     NOT NULL,
    [ModifiedDateTime]          DATETIME     NOT NULL,
    [CreatedByUser]             VARCHAR (80) NOT NULL,
    [ModifiedByUser]            VARCHAR (80) NULL,
    [CreatedByProgram]          VARCHAR (80) NOT NULL,
    [ModifiedByProgram]         VARCHAR (80) NULL,
    [RecordStatus]              INT          NOT NULL,
    CONSTRAINT [XPKInsurancePayerIdentity] PRIMARY KEY CLUSTERED ([ElectronicPayerIdentityId] ASC),
    CONSTRAINT [R_707] FOREIGN KEY ([InsurancePayerId]) REFERENCES [INS].[InsurancePayer] ([InsurancePayerId]),
    CONSTRAINT [R_708] FOREIGN KEY ([ClearingHouseId]) REFERENCES [INS].[ClearingHouse] ([ClearingHouseId])
);

