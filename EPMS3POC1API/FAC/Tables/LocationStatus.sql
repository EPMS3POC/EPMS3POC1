CREATE TABLE [FAC].[LocationStatus] (
    [LocationStatusId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [LocationStatusDescription] VARCHAR (1024) NULL,
    [LocationStatusCode]        CHAR (5)       NULL,
    [LocationStatusName]        VARCHAR (40)   NULL,
    [CreatedDateTime]           DATETIME       NOT NULL,
    [ModifiedDateTime]          DATETIME       NOT NULL,
    [CreatedByUser]             VARCHAR (80)   NOT NULL,
    [ModifiedByUser]            VARCHAR (80)   NULL,
    [CreatedByProgram]          VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]         VARCHAR (80)   NULL,
    [RecordStatus]              INT            NOT NULL,
    CONSTRAINT [XPKLocationStatus] PRIMARY KEY CLUSTERED ([LocationStatusId] ASC)
);

