CREATE TABLE [PER].[IdentityProofType] (
    [IdentityProofTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [IdentityProofTypeCode]        CHAR (5)       NULL,
    [IdentityProofTypeName]        VARCHAR (40)   NULL,
    [IdentityProofTypeDescription] VARCHAR (1024) NULL,
    [CreatedDateTime]              DATETIME       NOT NULL,
    [ModifiedDateTime]             DATETIME       NOT NULL,
    [CreatedByUser]                VARCHAR (80)   NOT NULL,
    [ModifiedByUser]               VARCHAR (80)   NULL,
    [CreatedByProgram]             VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]            VARCHAR (80)   NULL,
    [RecordStatus]                 INT            NOT NULL,
    CONSTRAINT [XPKIdentityProofType] PRIMARY KEY CLUSTERED ([IdentityProofTypeId] ASC)
);

