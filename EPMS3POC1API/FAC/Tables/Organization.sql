CREATE TABLE [FAC].[Organization] (
    [OrganizationId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [LocationStatusId]        BIGINT         NULL,
    [OrganizationDescription] VARCHAR (1024) NULL,
    [OrganizationCode]        CHAR (5)       NULL,
    [OrganizationName]        VARCHAR (40)   NULL,
    [CreatedDateTime]         DATETIME       NOT NULL,
    [ModifiedDateTime]        DATETIME       NOT NULL,
    [CreatedByUser]           VARCHAR (80)   NOT NULL,
    [ModifiedByUser]          VARCHAR (80)   NULL,
    [CreatedByProgram]        VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]       VARCHAR (80)   NULL,
    [RecordStatus]            INT            NOT NULL,
    CONSTRAINT [XPKOrganization] PRIMARY KEY CLUSTERED ([OrganizationId] ASC),
    CONSTRAINT [R_573] FOREIGN KEY ([LocationStatusId]) REFERENCES [FAC].[LocationStatus] ([LocationStatusId])
);

