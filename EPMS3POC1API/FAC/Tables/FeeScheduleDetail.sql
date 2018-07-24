CREATE TABLE [FAC].[FeeScheduleDetail] (
    [FeeScheduleDetailId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [FeeAmount]           MONEY        NULL,
    [FeeScheduleId]       BIGINT       NULL,
    [MasterProcedureId]   BIGINT       NULL,
    [CreatedDateTime]     DATETIME     NOT NULL,
    [ModifiedDateTime]    DATETIME     NOT NULL,
    [CreatedByUser]       VARCHAR (80) NOT NULL,
    [ModifiedByUser]      VARCHAR (80) NULL,
    [CreatedByProgram]    VARCHAR (80) NOT NULL,
    [ModifiedByProgram]   VARCHAR (80) NULL,
    [RecordStatus]        INT          NOT NULL,
    CONSTRAINT [XPKFeeScheduleDetail] PRIMARY KEY CLUSTERED ([FeeScheduleDetailId] ASC),
    CONSTRAINT [R_514] FOREIGN KEY ([FeeScheduleId]) REFERENCES [FAC].[FeeSchedule] ([FeeScheduleId]),
    CONSTRAINT [R_600] FOREIGN KEY ([MasterProcedureId]) REFERENCES [TRE].[MasterProcedure] ([MasterProcedureId])
);

