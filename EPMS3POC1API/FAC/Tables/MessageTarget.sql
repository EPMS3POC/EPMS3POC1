CREATE TABLE [FAC].[MessageTarget] (
    [MessageTargetId]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [RoleId]            INT          NULL,
    [MessageId]         BIGINT       NOT NULL,
    [MarketingId]       BIGINT       NOT NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [PK_MessageTarget] PRIMARY KEY CLUSTERED ([MessageTargetId] ASC),
    CONSTRAINT [R_304] FOREIGN KEY ([MessageId]) REFERENCES [FAC].[Message] ([MessageId]),
    CONSTRAINT [R_351] FOREIGN KEY ([MarketingId]) REFERENCES [FAC].[Marketing] ([MarketingId])
);

