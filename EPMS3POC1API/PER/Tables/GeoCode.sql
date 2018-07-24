CREATE TABLE [PER].[GeoCode] (
    [GeoCodeId]         BIGINT       IDENTITY (1, 1) NOT NULL,
    [AddressId]         BIGINT       NOT NULL,
    [Latitude]          FLOAT (53)   NULL,
    [Longitude]         FLOAT (53)   NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKGeoCode] PRIMARY KEY CLUSTERED ([GeoCodeId] ASC),
    CONSTRAINT [R_591] FOREIGN KEY ([AddressId]) REFERENCES [PER].[Address] ([AddressId])
);

