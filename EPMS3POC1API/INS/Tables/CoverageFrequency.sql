CREATE TABLE [INS].[CoverageFrequency] (
    [CoverageFrequencyId] BIGINT         IDENTITY (1, 1) NOT NULL,
    [CoverageCategory]    NVARCHAR (100) NULL,
    [CoverageSubCategory] NVARCHAR (100) NULL,
    [TwoQuadrantsPerDay]  SMALLINT       CONSTRAINT [DF__CoverageF__TwoQu__666B225D] DEFAULT ((0)) NULL,
    [FourQuadrantsPerDay] SMALLINT       CONSTRAINT [DF__CoverageF__FourQ__675F4696] DEFAULT ((0)) NULL,
    [TwiceAYear]          SMALLINT       CONSTRAINT [DF__CoverageF__Twice__68536ACF] DEFAULT ((0)) NULL,
    [TwoPerTwelveMonth]   SMALLINT       CONSTRAINT [DF__CoverageF__TwoPe__69478F08] DEFAULT ((0)) NULL,
    [CycleEveryMonth]     INT            NULL,
    [AgeLimit]            INT            NULL,
    [LastDate]            DATETIME       NULL,
    [NextDate]            DATETIME       NULL,
    [CoverageBookId]      BIGINT         NULL,
    [CreatedDateTime]     DATETIME       NOT NULL,
    [ModifiedDateTime]    DATETIME       NOT NULL,
    [CreatedByUser]       VARCHAR (80)   NOT NULL,
    [ModifiedByUser]      VARCHAR (80)   NULL,
    [CreatedByProgram]    VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]   VARCHAR (80)   NULL,
    [RecordStatus]        INT            NOT NULL,
    CONSTRAINT [XPKCoverageFrequency] PRIMARY KEY CLUSTERED ([CoverageFrequencyId] ASC),
    CONSTRAINT [R_743] FOREIGN KEY ([CoverageBookId]) REFERENCES [INS].[CoverageBook] ([CoverageBookId])
);

