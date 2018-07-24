CREATE TABLE [FAC].[COTSVendor] (
    [COTSVendorId]      BIGINT       IDENTITY (1, 1) NOT NULL,
    [MerchantIdValue]   VARCHAR (20) NULL,
    [MerchantName]      VARCHAR (40) NULL,
    [FacilityId]        BIGINT       NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKCOTSVendor] PRIMARY KEY CLUSTERED ([COTSVendorId] ASC),
    CONSTRAINT [R_585] FOREIGN KEY ([FacilityId]) REFERENCES [FAC].[Facility] ([FacilityId])
);

