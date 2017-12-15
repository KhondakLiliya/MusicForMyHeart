CREATE TABLE [dbo].[Songs] (
    [ID_song]  INT           NOT NULL,
    [Artist]   NVARCHAR (50) NOT NULL,
    [Name]     NVARCHAR (50) NOT NULL,
    [Genre]    NVARCHAR (50) NOT NULL,
    [Duration] TIME (7)      NOT NULL,
    CONSTRAINT [PK_Songs] PRIMARY KEY CLUSTERED ([ID_song] ASC)
);

