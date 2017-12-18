namespace MusicForMyHeart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Playlists",
                c => new
                    {
                        PlaylistID = c.Int(nullable: false, identity: true),
                        PlaylistName = c.String(),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlaylistID);
            
            CreateTable(
                "dbo.SongDatas",
                c => new
                    {
                        SongID = c.Int(nullable: false, identity: true),
                        SongName = c.String(),
                        SongArtist = c.String(),
                        SongGenre = c.String(),
                        SongLength = c.Int(nullable: false),
                        Playlist_PlaylistID = c.Int(),
                    })
                .PrimaryKey(t => t.SongID)
                .ForeignKey("dbo.Playlists", t => t.Playlist_PlaylistID)
                .Index(t => t.Playlist_PlaylistID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SongDatas", "Playlist_PlaylistID", "dbo.Playlists");
            DropIndex("dbo.SongDatas", new[] { "Playlist_PlaylistID" });
            DropTable("dbo.Users");
            DropTable("dbo.SongDatas");
            DropTable("dbo.Playlists");
        }
    }
}
