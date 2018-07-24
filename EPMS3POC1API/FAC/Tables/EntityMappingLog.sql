CREATE TABLE [FAC].[EntityMappingLog] (
    [EntityMappingLogId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [MappedDateTime]     DATETIME     NULL,
    [CreatedDateTime]    DATETIME     NOT NULL,
    [ModifiedDateTime]   DATETIME     NOT NULL,
    [CreatedByUser]      VARCHAR (80) NOT NULL,
    [ModifiedByUser]     VARCHAR (80) NULL,
    [CreatedByProgram]   VARCHAR (80) NOT NULL,
    [ModifiedByProgram]  VARCHAR (80) NULL,
    [RecordStatus]       INT          NOT NULL,
    [PreviousMappingId]  BIGINT       NULL,
    [EntityId]           BIGINT       NULL,
    CONSTRAINT [XPKEntityMappingLog] PRIMARY KEY CLUSTERED ([EntityMappingLogId] ASC),
    CONSTRAINT [R_654] FOREIGN KEY ([EntityId]) REFERENCES [FAC].[Entity] ([EntityId])
);

