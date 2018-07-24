CREATE TABLE [FAC].[CouponOption] (
    [CouponOptionId]     BIGINT       IDENTITY (1, 1) NOT NULL,
    [CouponOptionlValue] VARCHAR (40) NULL,
    [CreatedDateTime]    DATETIME     NOT NULL,
    [ModifiedDateTime]   DATETIME     NOT NULL,
    [CreatedByUser]      VARCHAR (80) NOT NULL,
    [ModifiedByUser]     VARCHAR (80) NULL,
    [CreatedByProgram]   VARCHAR (80) NOT NULL,
    [ModifiedByProgram]  VARCHAR (80) NULL,
    [RecordStatus]       INT          NOT NULL,
    [CouponOptionTypeId] BIGINT       NULL,
    [CouponId]           BIGINT       NULL,
    CONSTRAINT [XPKCouponOption] PRIMARY KEY CLUSTERED ([CouponOptionId] ASC),
    CONSTRAINT [R_646] FOREIGN KEY ([CouponOptionTypeId]) REFERENCES [FAC].[CouponOptionType] ([CouponOptionTypeId]),
    CONSTRAINT [R_647] FOREIGN KEY ([CouponId]) REFERENCES [FAC].[Coupon] ([CouponId])
);

