CREATE TABLE [PER].[Relationship] (
    [PatientId]          BIGINT       NOT NULL,
    [PersonId]           BIGINT       NOT NULL,
    [RelationshipId]     BIGINT       IDENTITY (1, 1) NOT NULL,
    [RelationshipTypeId] BIGINT       NOT NULL,
    [CreatedDateTime]    DATETIME     NOT NULL,
    [ModifiedDateTime]   DATETIME     NOT NULL,
    [CreatedByUser]      VARCHAR (80) NOT NULL,
    [ModifiedByUser]     VARCHAR (80) NULL,
    [CreatedByProgram]   VARCHAR (80) NOT NULL,
    [ModifiedByProgram]  VARCHAR (80) NULL,
    [RecordStatus]       INT          NOT NULL,
    CONSTRAINT [XPKRelationship] PRIMARY KEY CLUSTERED ([RelationshipId] ASC),
    CONSTRAINT [R_208] FOREIGN KEY ([PersonId]) REFERENCES [PER].[Person] ([PersonId]),
    CONSTRAINT [R_210] FOREIGN KEY ([RelationshipTypeId]) REFERENCES [PER].[RelationshipType] ([RelationshipTypeId])
);

