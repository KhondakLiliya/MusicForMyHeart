CREATE TABLE [dbo].[Belongings] (
    [ID_P]  INT NOT NULL,
    [ID_PL] INT NOT NULL,
    [ID_S]  INT NOT NULL,
    CONSTRAINT [FK_Belongings_Person] FOREIGN KEY ([ID_P]) REFERENCES [dbo].[Person] ([ID_person]),
    CONSTRAINT [FK_Belongings_Playlist] FOREIGN KEY ([ID_PL]) REFERENCES [dbo].[Playlist] ([ID_playlist]),
    CONSTRAINT [FK_Belongings_Songs] FOREIGN KEY ([ID_S]) REFERENCES [dbo].[Songs] ([ID_song])
);

