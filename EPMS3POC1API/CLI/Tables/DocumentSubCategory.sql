CREATE TABLE [CLI].[DocumentSubCategory] (
    [DocumentSubCategoryId] BIGINT        IDENTITY (1, 1) NOT NULL,
    [DocumentCategoryId]    BIGINT        NOT NULL,
    [SubcategoryName]       VARCHAR (250) NULL,
    [DisplayName]           VARCHAR (250) NULL,
    [SubCatgoryFileName]    VARCHAR (5)   NULL,
    [CreatedDateTime]       DATETIME      NOT NULL,
    [ModifiedDateTime]      DATETIME      NOT NULL,
    [CreatedByUser]         VARCHAR (80)  NOT NULL,
    [ModifiedByUser]        VARCHAR (80)  NULL,
    [CreatedByProgram]      VARCHAR (80)  NOT NULL,
    [ModifiedByProgram]     VARCHAR (80)  NULL,
    [RecordStatus]          INT           NOT NULL,
    CONSTRAINT [PK_DocumentSubCategory] PRIMARY KEY CLUSTERED ([DocumentSubCategoryId] ASC),
    CONSTRAINT [R_391] FOREIGN KEY ([DocumentCategoryId]) REFERENCES [CLI].[DocumentCategory] ([DocumentCategoryId])
);

