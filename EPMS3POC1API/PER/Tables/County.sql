CREATE TABLE [PER].[County] (
    [StateId]           BIGINT         NULL,
    [CountyId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CountyName]        VARCHAR (32)   NULL,
    [CountyDescription] VARCHAR (1024) NULL,
    [CountyCode]        VARCHAR (5)    NULL,
    [CreatedDateTime]   DATETIME       NOT NULL,
    [ModifiedDateTime]  DATETIME       NOT NULL,
    [CreatedByUser]     VARCHAR (80)   NOT NULL,
    [ModifiedByUser]    VARCHAR (80)   NULL,
    [CreatedByProgram]  VARCHAR (80)   NOT NULL,
    [ModifiedByProgram] VARCHAR (80)   NULL,
    [RecordStatus]      INT            NOT NULL,
    [TaxRate]           INT            NULL,
    CONSTRAINT [PK_County] PRIMARY KEY CLUSTERED ([CountyId] ASC),
    CONSTRAINT [R_685] FOREIGN KEY ([StateId]) REFERENCES [PER].[State] ([StateId])
);

