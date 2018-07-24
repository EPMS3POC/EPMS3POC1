CREATE TABLE [FAC].[MessageSource] (
    [MessageSourceId]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [Module]            VARCHAR (50) NULL,
    [Object]            VARCHAR (50) NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    [ApplicationId]     BIGINT       NULL,
    CONSTRAINT [PK_MessageSource] PRIMARY KEY CLUSTERED ([MessageSourceId] ASC),
    CONSTRAINT [R_877] FOREIGN KEY ([ApplicationId]) REFERENCES [FAC].[Application] ([ApplicationId])
);

