CREATE TABLE [CLI].[DiagnosticCenter] (
    [DiagnosticCenterId]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [DiagnosticCenterName] VARCHAR (50) NULL,
    [FacilityId]           BIGINT       NULL,
    [CreatedDateTime]      DATETIME     NOT NULL,
    [ModifiedDateTime]     DATETIME     NOT NULL,
    [CreatedByUser]        VARCHAR (80) NOT NULL,
    [ModifiedByUser]       VARCHAR (80) NULL,
    [CreatedByProgram]     VARCHAR (80) NOT NULL,
    [ModifiedByProgram]    VARCHAR (80) NULL,
    [RecordStatus]         INT          NOT NULL,
    CONSTRAINT [PK_DiagnosticCenters] PRIMARY KEY CLUSTERED ([DiagnosticCenterId] ASC),
    CONSTRAINT [R_629] FOREIGN KEY ([FacilityId]) REFERENCES [FAC].[Facility] ([FacilityId])
);

