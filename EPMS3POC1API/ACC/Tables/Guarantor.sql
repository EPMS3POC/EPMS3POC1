CREATE TABLE [ACC].[Guarantor] (
    [GuarantorId]       BIGINT       IDENTITY (1, 1) NOT NULL,
    [PersonId]          BIGINT       NOT NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKGuarantor] PRIMARY KEY CLUSTERED ([GuarantorId] ASC),
    CONSTRAINT [R_298] FOREIGN KEY ([PersonId]) REFERENCES [PER].[Person] ([PersonId])
);

