CREATE TABLE [FAC].[LandLordContact] (
    [PersonId]          BIGINT       NOT NULL,
    [LandLordContactId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [RealEstateId]      BIGINT       NOT NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKLandLordContact] PRIMARY KEY CLUSTERED ([LandLordContactId] ASC),
    CONSTRAINT [R_714] FOREIGN KEY ([PersonId]) REFERENCES [PER].[Person] ([PersonId]),
    CONSTRAINT [R_715] FOREIGN KEY ([RealEstateId]) REFERENCES [FAC].[RealEstate] ([RealEstateId])
);

