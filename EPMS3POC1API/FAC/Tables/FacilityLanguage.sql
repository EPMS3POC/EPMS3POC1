CREATE TABLE [FAC].[FacilityLanguage] (
    [FacilityLanguageId] BIGINT NOT NULL,
    [FacilityId]         BIGINT NULL,
    [LanguageId]         BIGINT NULL,
    CONSTRAINT [XPKFacilityLanguage] PRIMARY KEY CLUSTERED ([FacilityLanguageId] ASC),
    CONSTRAINT [R_912] FOREIGN KEY ([FacilityId]) REFERENCES [FAC].[Facility] ([FacilityId]),
    CONSTRAINT [R_913] FOREIGN KEY ([LanguageId]) REFERENCES [PER].[Language] ([LanguageId])
);

