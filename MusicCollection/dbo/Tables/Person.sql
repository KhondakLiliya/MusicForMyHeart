CREATE TABLE [dbo].[Person] (
    [ID_person] INT           NOT NULL,
    [login]     NVARCHAR (50) NOT NULL,
    [password]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([ID_person] ASC)
);

