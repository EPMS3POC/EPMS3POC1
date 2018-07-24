CREATE TABLE [FAC].[Entity] (
    [EntityId]              BIGINT         IDENTITY (1, 1) NOT NULL,
    [OrganizationId]        BIGINT         NOT NULL,
    [LocationStatusId]      BIGINT         NULL,
    [ExternalMarketingName] VARCHAR (40)   NULL,
    [IsHeadQuarter]         SMALLINT       NULL,
    [WebsiteAddress]        VARCHAR (80)   NULL,
    [EmailIdentifier]       VARCHAR (80)   NULL,
    [EntityDescription]     VARCHAR (1024) NULL,
    [EntityCode]            CHAR (5)       NULL,
    [EntityName]            VARCHAR (40)   NULL,
    [CreatedDateTime]       DATETIME       NOT NULL,
    [ModifiedDateTime]      DATETIME       NOT NULL,
    [CreatedByUser]         VARCHAR (80)   NOT NULL,
    [ModifiedByUser]        VARCHAR (80)   NULL,
    [CreatedByProgram]      VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]     VARCHAR (80)   NULL,
    [RecordStatus]          INT            NOT NULL,
    CONSTRAINT [XPKEntity] PRIMARY KEY CLUSTERED ([EntityId] ASC),
    CONSTRAINT [R_265] FOREIGN KEY ([OrganizationId]) REFERENCES [FAC].[Organization] ([OrganizationId]),
    CONSTRAINT [R_572] FOREIGN KEY ([LocationStatusId]) REFERENCES [FAC].[LocationStatus] ([LocationStatusId])
);

