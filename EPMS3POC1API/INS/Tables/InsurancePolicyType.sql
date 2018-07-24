CREATE TABLE [INS].[InsurancePolicyType] (
    [InsurancePolicyTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [InsurancePolicyTypeDescription] VARCHAR (1024) NULL,
    [InsurancePolicyTypeCode]        CHAR (5)       NULL,
    [InsurancePolicyTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]                DATETIME       NOT NULL,
    [ModifiedDateTime]               DATETIME       NOT NULL,
    [CreatedByUser]                  VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                 VARCHAR (80)   NULL,
    [CreatedByProgram]               VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]              VARCHAR (80)   NULL,
    [RecordStatus]                   INT            NOT NULL,
    CONSTRAINT [XPKInsurancePolicyType] PRIMARY KEY CLUSTERED ([InsurancePolicyTypeId] ASC)
);

