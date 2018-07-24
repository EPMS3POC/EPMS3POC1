CREATE TABLE [PER].[State] (
    [StateId]           BIGINT         IDENTITY (1, 1) NOT NULL,
    [StateName]         VARCHAR (32)   NULL,
    [StateDescription]  VARCHAR (1024) NULL,
    [StateCode]         VARCHAR (5)    NULL,
    [CreatedDateTime]   DATETIME       NOT NULL,
    [ModifiedDateTime]  DATETIME       NOT NULL,
    [CreatedByUser]     VARCHAR (80)   NOT NULL,
    [ModifiedByUser]    VARCHAR (80)   NULL,
    [CreatedByProgram]  VARCHAR (80)   NOT NULL,
    [ModifiedByProgram] VARCHAR (80)   NULL,
    [RecordStatus]      INT            NOT NULL,
    [CountryId]         BIGINT         NULL,
    [TaxRate]           INT            NULL,
    CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED ([StateId] ASC),
    CONSTRAINT [R_915] FOREIGN KEY ([CountryId]) REFERENCES [PER].[Country] ([CountryId])
);

