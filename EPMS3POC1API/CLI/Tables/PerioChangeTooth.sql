CREATE TABLE [CLI].[PerioChangeTooth] (
    [PerioChangeToothId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [ToothNumber]        INT          NULL,
    [CreatedDateTime]    DATETIME     NOT NULL,
    [ModifiedDateTime]   DATETIME     NOT NULL,
    [CreatedByUser]      VARCHAR (80) NOT NULL,
    [ModifiedByUser]     VARCHAR (80) NULL,
    [CreatedByProgram]   VARCHAR (80) NOT NULL,
    [ModifiedByProgram]  VARCHAR (80) NULL,
    [RecordStatus]       INT          NOT NULL,
    CONSTRAINT [PK_PerioChangeTooth] PRIMARY KEY CLUSTERED ([PerioChangeToothId] ASC)
);

