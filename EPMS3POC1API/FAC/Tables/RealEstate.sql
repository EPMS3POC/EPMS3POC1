CREATE TABLE [FAC].[RealEstate] (
    [RealEstateId]                         BIGINT       IDENTITY (1, 1) NOT NULL,
    [OpenDate]                             DATETIME     NULL,
    [TaxIdIdentity]                        VARCHAR (20) NULL,
    [RealEstateRegionIdentity]             VARCHAR (20) NULL,
    [RealEstateSchedulingProviderIdentity] VARCHAR (20) NULL,
    [CountyIdentity]                       CHAR (2)     NULL,
    [FeeSchedule]                          VARCHAR (20) NULL,
    [FacilityId]                           BIGINT       NOT NULL,
    [RegionIdentity]                       CHAR (4)     NULL,
    [Territory]                            VARCHAR (20) NULL,
    [CreatedDateTime]                      DATETIME     NOT NULL,
    [ModifiedDateTime]                     DATETIME     NOT NULL,
    [CreatedByUser]                        VARCHAR (80) NOT NULL,
    [ModifiedByUser]                       VARCHAR (80) NULL,
    [CreatedByProgram]                     VARCHAR (80) NOT NULL,
    [ModifiedByProgram]                    VARCHAR (80) NULL,
    [RecordStatus]                         INT          NOT NULL,
    CONSTRAINT [XPKRealEstate] PRIMARY KEY CLUSTERED ([RealEstateId] ASC),
    CONSTRAINT [R_333] FOREIGN KEY ([FacilityId]) REFERENCES [FAC].[Facility] ([FacilityId])
);

