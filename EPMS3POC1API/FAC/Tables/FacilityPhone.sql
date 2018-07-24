CREATE TABLE [FAC].[FacilityPhone] (
    [PhoneId]           BIGINT       NOT NULL,
    [FacilityId]        BIGINT       NOT NULL,
    [FacilityPhoneId]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKFacilityPhone] PRIMARY KEY CLUSTERED ([FacilityPhoneId] ASC),
    CONSTRAINT [R_267] FOREIGN KEY ([FacilityId]) REFERENCES [FAC].[Facility] ([FacilityId]),
    CONSTRAINT [R_268] FOREIGN KEY ([PhoneId]) REFERENCES [PER].[Phone] ([PhoneId])
);

