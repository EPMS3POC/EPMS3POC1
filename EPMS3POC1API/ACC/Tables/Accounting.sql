CREATE TABLE [ACC].[Accounting] (
    [AccountingId] BIGINT NOT NULL,
    [FacilityId]   BIGINT NOT NULL,
    CONSTRAINT [XPKAccounting] PRIMARY KEY CLUSTERED ([AccountingId] ASC),
    CONSTRAINT [R_345] FOREIGN KEY ([FacilityId]) REFERENCES [FAC].[Facility] ([FacilityId])
);

