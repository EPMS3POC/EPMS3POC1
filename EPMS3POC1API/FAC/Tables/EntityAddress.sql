CREATE TABLE [FAC].[EntityAddress] (
    [EntityAddressId]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [AddressId]         BIGINT       NOT NULL,
    [EntityId]          BIGINT       NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKEntityAddress] PRIMARY KEY CLUSTERED ([EntityAddressId] ASC),
    CONSTRAINT [R_575] FOREIGN KEY ([AddressId]) REFERENCES [PER].[Address] ([AddressId]),
    CONSTRAINT [R_576] FOREIGN KEY ([EntityId]) REFERENCES [FAC].[Entity] ([EntityId])
);

