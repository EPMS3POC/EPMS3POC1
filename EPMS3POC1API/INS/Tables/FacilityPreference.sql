CREATE TABLE [INS].[FacilityPreference] (
    [FacilityPreferenceId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [FacilityId]           BIGINT       NULL,
    [ClearingHouseId]      BIGINT       NULL,
    [CreatedDateTime]      DATETIME     NOT NULL,
    [ModifiedDateTime]     DATETIME     NOT NULL,
    [CreatedByUser]        VARCHAR (80) NOT NULL,
    [ModifiedByUser]       VARCHAR (80) NULL,
    [CreatedByProgram]     VARCHAR (80) NOT NULL,
    [ModifiedByProgram]    VARCHAR (80) NULL,
    [RecordStatus]         INT          NOT NULL,
    CONSTRAINT [XPKFacilityPreference] PRIMARY KEY CLUSTERED ([FacilityPreferenceId] ASC),
    CONSTRAINT [R_705] FOREIGN KEY ([FacilityId]) REFERENCES [FAC].[Facility] ([FacilityId]),
    CONSTRAINT [R_706] FOREIGN KEY ([ClearingHouseId]) REFERENCES [INS].[ClearingHouse] ([ClearingHouseId])
);

