CREATE TABLE [FAC].[PromotionType] (
    [PromotionTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [PromotionTypeDescription] VARCHAR (1024) NULL,
    [PromotionTypeCode]        CHAR (5)       NULL,
    [PromotionTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]          DATETIME       NOT NULL,
    [ModifiedDateTime]         DATETIME       NOT NULL,
    [CreatedByUser]            VARCHAR (80)   NOT NULL,
    [ModifiedByUser]           VARCHAR (80)   NULL,
    [CreatedByProgram]         VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]        VARCHAR (80)   NULL,
    [RecordStatus]             INT            NOT NULL,
    CONSTRAINT [XPKPromotionType] PRIMARY KEY CLUSTERED ([PromotionTypeId] ASC)
);

