CREATE TABLE [FAC].[FacilityAddress] (
    [AddressId]         BIGINT       NOT NULL,
    [FacilityId]        BIGINT       NOT NULL,
    [FacilityAddressId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKFacilityAddress] PRIMARY KEY CLUSTERED ([FacilityAddressId] ASC),
    CONSTRAINT [R_269] FOREIGN KEY ([FacilityId]) REFERENCES [FAC].[Facility] ([FacilityId]),
    CONSTRAINT [R_270] FOREIGN KEY ([AddressId]) REFERENCES [PER].[Address] ([AddressId])
);

