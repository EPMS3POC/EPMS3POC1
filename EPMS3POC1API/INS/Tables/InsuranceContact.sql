CREATE TABLE [INS].[InsuranceContact] (
    [InsuranceContactId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [PersonId]           BIGINT       NOT NULL,
    [CreatedDateTime]    DATETIME     NOT NULL,
    [ModifiedDateTime]   DATETIME     NOT NULL,
    [CreatedByUser]      VARCHAR (80) NOT NULL,
    [ModifiedByUser]     VARCHAR (80) NULL,
    [CreatedByProgram]   VARCHAR (80) NOT NULL,
    [ModifiedByProgram]  VARCHAR (80) NULL,
    [RecordStatus]       INT          NOT NULL,
    [InsurancePayerId]   BIGINT       NULL,
    CONSTRAINT [XPKInsuranceContact] PRIMARY KEY CLUSTERED ([InsuranceContactId] ASC),
    CONSTRAINT [R_694] FOREIGN KEY ([PersonId]) REFERENCES [PER].[Person] ([PersonId]),
    CONSTRAINT [R_727] FOREIGN KEY ([InsurancePayerId]) REFERENCES [INS].[InsurancePayer] ([InsurancePayerId])
);

