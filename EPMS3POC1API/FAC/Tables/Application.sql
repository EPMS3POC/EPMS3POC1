CREATE TABLE [FAC].[Application] (
    [ApplicationId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [ApplicationDescription] VARCHAR (1024) NULL,
    [ApplicationCode]        CHAR (5)       NULL,
    [ApplicationName]        VARCHAR (40)   NULL,
    [CreatedDateTime]        DATETIME       NOT NULL,
    [ModifiedDateTime]       DATETIME       NOT NULL,
    [CreatedByUser]          VARCHAR (80)   NOT NULL,
    [ModifiedByUser]         VARCHAR (80)   NULL,
    [CreatedByProgram]       VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]      VARCHAR (80)   NULL,
    [RecordStatus]           INT            NOT NULL,
    CONSTRAINT [PK_Application] PRIMARY KEY CLUSTERED ([ApplicationId] ASC)
);

