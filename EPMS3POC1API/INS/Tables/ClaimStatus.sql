CREATE TABLE [INS].[ClaimStatus] (
    [ClaimStatusId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [ClaimStatusDescription] VARCHAR (1024) NULL,
    [ClaimStatusCode]        CHAR (5)       NULL,
    [ClaimStatusName]        VARCHAR (40)   NULL,
    [CreatedDateTime]        DATETIME       NOT NULL,
    [ModifiedDateTime]       DATETIME       NOT NULL,
    [CreatedByUser]          VARCHAR (80)   NOT NULL,
    [ModifiedByUser]         VARCHAR (80)   NULL,
    [CreatedByProgram]       VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]      VARCHAR (80)   NULL,
    [RecordStatus]           INT            NOT NULL,
    CONSTRAINT [XPKClaimStatus] PRIMARY KEY CLUSTERED ([ClaimStatusId] ASC)
);

