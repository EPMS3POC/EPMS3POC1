CREATE TABLE [ACC].[AccountStatus] (
    [AccountStatusId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [AccountStatusName]        VARCHAR (40)   NULL,
    [AccountStatusDescription] VARCHAR (1024) NULL,
    [AccountStatusCode]        CHAR (5)       NULL,
    [CreatedDateTime]          DATETIME       NOT NULL,
    [ModifiedDateTime]         DATETIME       NOT NULL,
    [CreatedByUser]            VARCHAR (80)   NOT NULL,
    [ModifiedByUser]           VARCHAR (80)   NULL,
    [CreatedByProgram]         VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]        VARCHAR (80)   NULL,
    [RecordStatus]             INT            NOT NULL,
    CONSTRAINT [XPKAccountStatus] PRIMARY KEY CLUSTERED ([AccountStatusId] ASC)
);

