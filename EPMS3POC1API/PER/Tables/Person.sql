CREATE TABLE [PER].[Person] (
    [PersonId]             BIGINT       IDENTITY (1, 1) NOT NULL,
    [FirstName]            VARCHAR (35) NULL,
    [MiddleName]           VARCHAR (35) NULL,
    [LastName]             VARCHAR (35) NULL,
    [BirthDate]            DATE         NULL,
    [UserId]               BIGINT       NULL,
    [SocialSecurityNumber] VARCHAR (11) NULL,
    [PrefixId]             BIGINT       NULL,
    [IdentityProofNumber]  VARCHAR (20) NULL,
    [IdentityProofTypeId]  BIGINT       NULL,
    [IdentityExpiryDate]   DATETIME     NULL,
    [CreatedDateTime]      DATETIME     NOT NULL,
    [ModifiedDateTime]     DATETIME     NOT NULL,
    [CreatedByUser]        VARCHAR (80) NOT NULL,
    [ModifiedByUser]       VARCHAR (80) NULL,
    [CreatedByProgram]     VARCHAR (80) NOT NULL,
    [ModifiedByProgram]    VARCHAR (80) NULL,
    [RecordStatus]         INT          NOT NULL,
    [SuffixId]             BIGINT       NULL,
    [GenderId]             BIGINT       NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY NONCLUSTERED ([PersonId] ASC),
    CONSTRAINT [R_292] FOREIGN KEY ([UserId]) REFERENCES [USR].[User] ([UserId]),
    CONSTRAINT [R_570] FOREIGN KEY ([PrefixId]) REFERENCES [PER].[Prefix] ([PrefixId]),
    CONSTRAINT [R_580] FOREIGN KEY ([IdentityProofTypeId]) REFERENCES [PER].[IdentityProofType] ([IdentityProofTypeId]),
    CONSTRAINT [R_909] FOREIGN KEY ([SuffixId]) REFERENCES [PER].[Suffix] ([SuffixId]),
    CONSTRAINT [R_910] FOREIGN KEY ([GenderId]) REFERENCES [PER].[Gender] ([GenderId])
);


GO
ALTER TABLE [PER].[Person] NOCHECK CONSTRAINT [R_292];


GO
ALTER TABLE [PER].[Person] NOCHECK CONSTRAINT [R_570];


GO
ALTER TABLE [PER].[Person] NOCHECK CONSTRAINT [R_580];


GO
ALTER TABLE [PER].[Person] NOCHECK CONSTRAINT [R_909];


GO
ALTER TABLE [PER].[Person] NOCHECK CONSTRAINT [R_910];

