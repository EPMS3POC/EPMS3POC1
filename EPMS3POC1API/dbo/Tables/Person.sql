CREATE TABLE [dbo].[Person] (
    [PersonId]             FLOAT (53)     NULL,
    [FirstName]            NVARCHAR (255) NULL,
    [MiddleName]           NVARCHAR (255) NULL,
    [LastName]             NVARCHAR (255) NULL,
    [BirthDate]            NVARCHAR (255) NULL,
    [UserId]               FLOAT (53)     NULL,
    [SocialSecurityNumber] FLOAT (53)     NULL,
    [PrefixId]             FLOAT (53)     NULL,
    [IdentityProofNumber]  NVARCHAR (255) NULL,
    [IdentityProofTypeId]  FLOAT (53)     NULL,
    [IdentityExpiryDate]   DATETIME       NULL,
    [CreatedDateTime]      DATETIME       NULL,
    [ModifiedDateTime]     DATETIME       NULL,
    [CreatedByUser]        NVARCHAR (255) NULL,
    [ModifiedByUser]       NVARCHAR (255) NULL,
    [CreatedByProgram]     NVARCHAR (255) NULL,
    [ModifiedByProgram]    NVARCHAR (255) NULL,
    [RecordStatus]         FLOAT (53)     NULL,
    [SuffixId]             FLOAT (53)     NULL,
    [GenderId]             FLOAT (53)     NULL
);

