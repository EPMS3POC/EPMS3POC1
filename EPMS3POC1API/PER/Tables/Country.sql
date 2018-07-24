CREATE TABLE [PER].[Country] (
    [CountryId]            BIGINT         IDENTITY (1, 1) NOT NULL,
    [CountryName]          VARCHAR (32)   NULL,
    [CountryDescription]   VARCHAR (1024) NULL,
    [CountryCode]          VARCHAR (5)    NULL,
    [CreatedDateTime]      DATETIME       NOT NULL,
    [ModifiedDateTime]     DATETIME       NOT NULL,
    [CreatedByUser]        VARCHAR (80)   NOT NULL,
    [ModifiedByUser]       VARCHAR (80)   NULL,
    [CreatedByProgram]     VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]    VARCHAR (80)   NULL,
    [RecordStatus]         INT            NOT NULL,
    [TaxRate]              INT            NULL,
    [CountryCode3]         VARCHAR (5)    NULL,
    [CountryTelephoneCode] VARCHAR (5)    NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([CountryId] ASC)
);

