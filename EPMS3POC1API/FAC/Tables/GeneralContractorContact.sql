CREATE TABLE [FAC].[GeneralContractorContact] (
    [GeneralContractorContactId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [PersonId]                   BIGINT       NOT NULL,
    [RealEstateId]               BIGINT       NOT NULL,
    [CreatedDateTime]            DATETIME     NOT NULL,
    [ModifiedDateTime]           DATETIME     NOT NULL,
    [CreatedByUser]              VARCHAR (80) NOT NULL,
    [ModifiedByUser]             VARCHAR (80) NULL,
    [CreatedByProgram]           VARCHAR (80) NOT NULL,
    [ModifiedByProgram]          VARCHAR (80) NULL,
    [RecordStatus]               INT          NOT NULL,
    CONSTRAINT [XPKGeneralContractorContact] PRIMARY KEY CLUSTERED ([GeneralContractorContactId] ASC),
    CONSTRAINT [R_716] FOREIGN KEY ([PersonId]) REFERENCES [PER].[Person] ([PersonId]),
    CONSTRAINT [R_717] FOREIGN KEY ([RealEstateId]) REFERENCES [FAC].[RealEstate] ([RealEstateId])
);

