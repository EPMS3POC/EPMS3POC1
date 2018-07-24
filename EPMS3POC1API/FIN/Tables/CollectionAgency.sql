CREATE TABLE [FIN].[CollectionAgency] (
    [CollectionAgencyId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [FinanceId]                   BIGINT         NULL,
    [CollectionAgencyName]        VARCHAR (40)   NULL,
    [CollectionAgencyDescription] VARCHAR (1024) NULL,
    [CollectionAgencyCode]        CHAR (5)       NULL,
    [CreatedDateTime]             DATETIME       NOT NULL,
    [ModifiedDateTime]            DATETIME       NOT NULL,
    [CreatedByUser]               VARCHAR (80)   NOT NULL,
    [ModifiedByUser]              VARCHAR (80)   NULL,
    [CreatedByProgram]            VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]           VARCHAR (80)   NULL,
    [RecordStatus]                INT            NOT NULL,
    CONSTRAINT [XPKCollectionAgency] PRIMARY KEY CLUSTERED ([CollectionAgencyId] ASC),
    CONSTRAINT [R_722] FOREIGN KEY ([FinanceId]) REFERENCES [FIN].[Finance] ([FinanceId])
);

