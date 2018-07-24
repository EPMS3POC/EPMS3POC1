CREATE TABLE [INS].[InsuranceAddress] (
    [InsuranceAddressId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [AddressId]          BIGINT       NULL,
    [AddressTypeId]      BIGINT       NOT NULL,
    [CreatedDateTime]    DATETIME     NOT NULL,
    [ModifiedDateTime]   DATETIME     NOT NULL,
    [CreatedByUser]      VARCHAR (80) NOT NULL,
    [ModifiedByUser]     VARCHAR (80) NULL,
    [CreatedByProgram]   VARCHAR (80) NOT NULL,
    [ModifiedByProgram]  VARCHAR (80) NULL,
    [RecordStatus]       INT          NOT NULL,
    [InsurancePayerId]   BIGINT       NULL,
    CONSTRAINT [XPKInsuranceAddress] PRIMARY KEY CLUSTERED ([InsuranceAddressId] ASC),
    CONSTRAINT [R_435] FOREIGN KEY ([AddressId]) REFERENCES [PER].[Address] ([AddressId]),
    CONSTRAINT [R_436] FOREIGN KEY ([AddressTypeId]) REFERENCES [PER].[AddressType] ([AddressTypeId]),
    CONSTRAINT [R_728] FOREIGN KEY ([InsurancePayerId]) REFERENCES [INS].[InsurancePayer] ([InsurancePayerId])
);

