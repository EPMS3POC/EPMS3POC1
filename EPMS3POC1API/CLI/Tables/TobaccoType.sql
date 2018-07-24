CREATE TABLE [CLI].[TobaccoType] (
    [TobaccoTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [TobaccoTypeDescription] VARCHAR (1024) NULL,
    [TobaccoTypeCode]        CHAR (5)       NULL,
    [TobaccoTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]        DATETIME       NOT NULL,
    [ModifiedDateTime]       DATETIME       NOT NULL,
    [CreatedByUser]          VARCHAR (80)   NOT NULL,
    [ModifiedByUser]         VARCHAR (80)   NULL,
    [CreatedByProgram]       VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]      VARCHAR (80)   NULL,
    [RecordStatus]           INT            NOT NULL,
    CONSTRAINT [PK_TobaccoType] PRIMARY KEY CLUSTERED ([TobaccoTypeId] ASC)
);

