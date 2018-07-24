CREATE TABLE [INS].[ClaimType] (
    [ClaimTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [ClaimTypeDescription] VARCHAR (1024) NULL,
    [ClaimTypeCode]        CHAR (5)       NULL,
    [ClaimTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]      DATETIME       NOT NULL,
    [ModifiedDateTime]     DATETIME       NOT NULL,
    [CreatedByUser]        VARCHAR (80)   NOT NULL,
    [ModifiedByUser]       VARCHAR (80)   NULL,
    [CreatedByProgram]     VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]    VARCHAR (80)   NULL,
    [RecordStatus]         INT            NOT NULL,
    CONSTRAINT [XPKClaimType] PRIMARY KEY CLUSTERED ([ClaimTypeId] ASC)
);

