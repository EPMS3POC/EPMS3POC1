CREATE TABLE [PER].[Address] (
    [AddressId]           BIGINT        IDENTITY (1, 1) NOT NULL,
    [ZipCodeId]           BIGINT        NULL,
    [SpecialInstructions] VARCHAR (200) NULL,
    [AddressLine1]        VARCHAR (30)  NULL,
    [AddressLine2]        VARCHAR (30)  NULL,
    [AddressLine3]        VARCHAR (30)  NULL,
    [CreatedDateTime]     DATETIME      NOT NULL,
    [ModifiedDateTime]    DATETIME      NOT NULL,
    [CreatedByUser]       VARCHAR (80)  NOT NULL,
    [ModifiedByUser]      VARCHAR (80)  NULL,
    [CreatedByProgram]    VARCHAR (80)  NOT NULL,
    [ModifiedByProgram]   VARCHAR (80)  NULL,
    [RecordStatus]        INT           NOT NULL,
    [CountyId]            BIGINT        NULL,
    [StateId]             BIGINT        NULL,
    [CityId]              BIGINT        NULL,
    CONSTRAINT [PK_PersonAddress] PRIMARY KEY CLUSTERED ([AddressId] ASC),
    CONSTRAINT [R_115] FOREIGN KEY ([ZipCodeId]) REFERENCES [PER].[ZipCode] ([ZipCodeId]),
    CONSTRAINT [R_686] FOREIGN KEY ([CountyId]) REFERENCES [PER].[County] ([CountyId]),
    CONSTRAINT [R_905] FOREIGN KEY ([StateId]) REFERENCES [PER].[State] ([StateId]),
    CONSTRAINT [R_918] FOREIGN KEY ([CityId]) REFERENCES [PER].[City] ([CityId])
);

