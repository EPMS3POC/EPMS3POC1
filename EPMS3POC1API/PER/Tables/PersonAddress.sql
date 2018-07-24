CREATE TABLE [PER].[PersonAddress] (
    [PersonId]             BIGINT       NOT NULL,
    [PersonAddressId]      BIGINT       IDENTITY (1, 1) NOT NULL,
    [AddressId]            BIGINT       NOT NULL,
    [AddressTypeId]        BIGINT       NOT NULL,
    [PersonAddressComment] VARCHAR (20) NULL,
    [CreatedDateTime]      DATETIME     NOT NULL,
    [ModifiedDateTime]     DATETIME     NOT NULL,
    [CreatedByUser]        VARCHAR (80) NOT NULL,
    [ModifiedByUser]       VARCHAR (80) NULL,
    [CreatedByProgram]     VARCHAR (80) NOT NULL,
    [ModifiedByProgram]    VARCHAR (80) NULL,
    [RecordStatus]         INT          NOT NULL,
    CONSTRAINT [XPKPersonAddress] PRIMARY KEY CLUSTERED ([PersonAddressId] ASC),
    CONSTRAINT [R_241] FOREIGN KEY ([AddressId]) REFERENCES [PER].[Address] ([AddressId]),
    CONSTRAINT [R_242] FOREIGN KEY ([PersonId]) REFERENCES [PER].[Person] ([PersonId]),
    CONSTRAINT [R_328] FOREIGN KEY ([AddressTypeId]) REFERENCES [PER].[AddressType] ([AddressTypeId])
);

