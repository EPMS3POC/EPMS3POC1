CREATE TABLE [PER].[City] (
    [CityId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CityName]        VARCHAR (32)   NOT NULL,
    [CityDescription] VARCHAR (1024) NULL,
    [CityCode]        VARCHAR (5)    NOT NULL,
    [TaxRate]         INT            NULL,
    [CountyId]        BIGINT         NULL,
    [ZipCodeId]       BIGINT         NULL,
    CONSTRAINT [XPKCity] PRIMARY KEY CLUSTERED ([CityId] ASC),
    CONSTRAINT [R_917] FOREIGN KEY ([CountyId]) REFERENCES [PER].[County] ([CountyId]),
    CONSTRAINT [R_919] FOREIGN KEY ([ZipCodeId]) REFERENCES [PER].[ZipCode] ([ZipCodeId])
);

