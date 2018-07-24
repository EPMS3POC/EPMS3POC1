CREATE TABLE [PER].[ZipCode] (
    [ZipCodeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CountryId]          BIGINT         NULL,
    [StateId]            BIGINT         NULL,
    [ZipCode]            CHAR (5)       NULL,
    [ZipExtension]       CHAR (4)       NULL,
    [ZipCodeName]        VARCHAR (40)   NULL,
    [ZipCodeDescription] VARCHAR (1024) NULL,
    [CreatedDateTime]    DATETIME       NOT NULL,
    [ModifiedDateTime]   DATETIME       NOT NULL,
    [CreatedByUser]      VARCHAR (80)   NOT NULL,
    [ModifiedByUser]     VARCHAR (80)   NULL,
    [CreatedByProgram]   VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]  VARCHAR (80)   NULL,
    [RecordStatus]       INT            NOT NULL,
    CONSTRAINT [XPKZipCode] PRIMARY KEY NONCLUSTERED ([ZipCodeId] ASC),
    CONSTRAINT [R_633] FOREIGN KEY ([CountryId]) REFERENCES [PER].[Country] ([CountryId]),
    CONSTRAINT [R_653] FOREIGN KEY ([StateId]) REFERENCES [PER].[State] ([StateId])
);

