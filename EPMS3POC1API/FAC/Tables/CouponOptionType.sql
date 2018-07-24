CREATE TABLE [FAC].[CouponOptionType] (
    [CouponOptionTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CouponOptionTypeDescription] VARCHAR (1024) NULL,
    [CouponOptionTypeCode]        CHAR (5)       NULL,
    [CouponOptionTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]             DATETIME       NOT NULL,
    [ModifiedDateTime]            DATETIME       NOT NULL,
    [CreatedByUser]               VARCHAR (80)   NOT NULL,
    [ModifiedByUser]              VARCHAR (80)   NULL,
    [CreatedByProgram]            VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]           VARCHAR (80)   NULL,
    [RecordStatus]                INT            NOT NULL,
    CONSTRAINT [XPKCouponOptionType] PRIMARY KEY CLUSTERED ([CouponOptionTypeId] ASC)
);

