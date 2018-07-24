CREATE TABLE [INS].[ProviderInsurance] (
    [ProviderId]              BIGINT       NULL,
    [ProviderInsuranceId]     BIGINT       IDENTITY (1, 1) NOT NULL,
    [CreatedDateTime]         DATETIME     NOT NULL,
    [ModifiedDateTime]        DATETIME     NOT NULL,
    [CreatedByUser]           VARCHAR (80) NOT NULL,
    [ModifiedByUser]          VARCHAR (80) NULL,
    [CreatedByProgram]        VARCHAR (80) NOT NULL,
    [ModifiedByProgram]       VARCHAR (80) NULL,
    [RecordStatus]            INT          NOT NULL,
    [LicenseNumber]           VARCHAR (20) NULL,
    [ProviderSpecialtyCodeId] BIGINT       NULL,
    [InsurancePayerId]        BIGINT       NULL,
    [PayeeIdentification]     VARCHAR (20) NULL,
    CONSTRAINT [XPKProviderInsurance] PRIMARY KEY CLUSTERED ([ProviderInsuranceId] ASC),
    CONSTRAINT [R_497] FOREIGN KEY ([ProviderId]) REFERENCES [FAC].[Provider] ([ProviderId]),
    CONSTRAINT [R_733] FOREIGN KEY ([InsurancePayerId]) REFERENCES [INS].[InsurancePayer] ([InsurancePayerId])
);

