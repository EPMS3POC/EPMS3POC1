CREATE TABLE [ACC].[Account] (
    [AccountId]         BIGINT       IDENTITY (1, 1) NOT NULL,
    [AccountNumber]     DECIMAL (9)  NULL,
    [AccountGroup]      BIGINT       NULL,
    [GuarantorId]       BIGINT       NULL,
    [SubscriberId]      BIGINT       NULL,
    [StatementId]       BIGINT       NULL,
    [AccountStatusId]   BIGINT       NULL,
    [FacilityId]        BIGINT       NOT NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([AccountId] ASC),
    CONSTRAINT [R_297] FOREIGN KEY ([GuarantorId]) REFERENCES [ACC].[Guarantor] ([GuarantorId]),
    CONSTRAINT [R_313] FOREIGN KEY ([SubscriberId]) REFERENCES [ACC].[Subscriber] ([SubscriberId]),
    CONSTRAINT [R_365] FOREIGN KEY ([StatementId]) REFERENCES [ACC].[Statement] ([StatementId]),
    CONSTRAINT [R_718] FOREIGN KEY ([AccountStatusId]) REFERENCES [ACC].[AccountStatus] ([AccountStatusId]),
    CONSTRAINT [R_826] FOREIGN KEY ([FacilityId]) REFERENCES [FAC].[Facility] ([FacilityId])
);

