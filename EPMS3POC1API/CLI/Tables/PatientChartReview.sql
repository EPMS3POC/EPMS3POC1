CREATE TABLE [CLI].[PatientChartReview] (
    [PatientChartReviewId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [AppointmentNumber]    BIGINT       NULL,
    [StartTimeStamp]       DATETIME     NULL,
    [EndTimeStamp]         DATETIME     NULL,
    [CreatedDateTime]      DATETIME     NOT NULL,
    [ModifiedDateTime]     DATETIME     NOT NULL,
    [CreatedByUser]        VARCHAR (80) NOT NULL,
    [ModifiedByUser]       VARCHAR (80) NULL,
    [CreatedByProgram]     VARCHAR (80) NOT NULL,
    [ModifiedByProgram]    VARCHAR (80) NULL,
    [RecordStatus]         INT          NOT NULL,
    [PatientId]            BIGINT       NULL,
    CONSTRAINT [PK_PatientChartReview] PRIMARY KEY CLUSTERED ([PatientChartReviewId] ASC),
    CONSTRAINT [R_896] FOREIGN KEY ([PatientId]) REFERENCES [PER].[Patient] ([PatientId])
);

