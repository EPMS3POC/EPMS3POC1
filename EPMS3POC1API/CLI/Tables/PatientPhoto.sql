CREATE TABLE [CLI].[PatientPhoto] (
    [PatientPhotoId]    BIGINT       IDENTITY (1, 1) NOT NULL,
    [PatientId]         BIGINT       NOT NULL,
    [ImagePath]         VARCHAR (1)  NULL,
    [ImageDate]         DATETIME     NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [PatientPhoto_pk] PRIMARY KEY CLUSTERED ([PatientPhotoId] ASC),
    CONSTRAINT [R_380] FOREIGN KEY ([PatientId]) REFERENCES [PER].[Patient] ([PatientId])
);

