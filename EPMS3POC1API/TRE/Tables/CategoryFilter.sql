CREATE TABLE [TRE].[CategoryFilter] (
    [CategoryFilterId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CategoryFilterDescription] VARCHAR (1024) NULL,
    [CategoryFilterCode]        CHAR (5)       NULL,
    [CategoryFilterName]        VARCHAR (40)   NULL,
    [CreatedDateTime]           DATETIME       NOT NULL,
    [ModifiedDateTime]          DATETIME       NOT NULL,
    [CreatedByUser]             VARCHAR (80)   NOT NULL,
    [ModifiedByUser]            VARCHAR (80)   NULL,
    [CreatedByProgram]          VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]         VARCHAR (80)   NULL,
    [RecordStatus]              INT            NOT NULL,
    CONSTRAINT [XPKCategoryFilter] PRIMARY KEY CLUSTERED ([CategoryFilterId] ASC)
);

