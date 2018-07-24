CREATE TABLE [INS].[InsurancePayer] (
    [InsurancePayerId]     BIGINT       IDENTITY (1, 1) NOT NULL,
    [CompanyNumber]        VARCHAR (80) NULL,
    [InsurancePayerName]   VARCHAR (80) NULL,
    [InsuranceCompanyName] VARCHAR (20) NULL,
    [AllowElectronicClaim] SMALLINT     NULL,
    [InsurancePayerCode]   VARCHAR (20) NULL,
    [CreatedDateTime]      DATETIME     NOT NULL,
    [ModifiedDateTime]     DATETIME     NOT NULL,
    [CreatedByUser]        VARCHAR (80) NOT NULL,
    [ModifiedByUser]       VARCHAR (80) NULL,
    [CreatedByProgram]     VARCHAR (80) NOT NULL,
    [ModifiedByProgram]    VARCHAR (80) NULL,
    [RecordStatus]         INT          NOT NULL,
    [InsurancePayerTypeFK] INT          NULL,
    [MedicaidClaimTypeFK]  INT          NULL,
    [Email]                NVARCHAR (1) NULL,
    [Website]              NVARCHAR (1) NULL,
    CONSTRAINT [XPKInsurancePayer] PRIMARY KEY CLUSTERED ([InsurancePayerId] ASC)
);

