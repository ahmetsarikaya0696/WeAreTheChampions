namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        ColorId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Red = c.Int(nullable: false),
                        Green = c.Int(nullable: false),
                        Blue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ColorId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TeamId);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        MatchId = c.Int(nullable: false, identity: true),
                        MatchTime = c.DateTime(nullable: false),
                        HomeTeamId = c.Int(nullable: false),
                        GuestTeamId = c.Int(nullable: false),
                        Score1 = c.Int(),
                        Score2 = c.Int(),
                        Result = c.Int(),
                    })
                .PrimaryKey(t => t.MatchId)
                .ForeignKey("dbo.Teams", t => t.GuestTeamId)
                .ForeignKey("dbo.Teams", t => t.HomeTeamId)
                .Index(t => t.HomeTeamId)
                .Index(t => t.GuestTeamId);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.TeamColors",
                c => new
                    {
                        Team_TeamId = c.Int(nullable: false),
                        Color_ColorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Team_TeamId, t.Color_ColorId })
                .ForeignKey("dbo.Teams", t => t.Team_TeamId, cascadeDelete: true)
                .ForeignKey("dbo.Colors", t => t.Color_ColorId, cascadeDelete: true)
                .Index(t => t.Team_TeamId)
                .Index(t => t.Color_ColorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.TeamColors", "Color_ColorId", "dbo.Colors");
            DropForeignKey("dbo.TeamColors", "Team_TeamId", "dbo.Teams");
            DropForeignKey("dbo.Matches", "HomeTeamId", "dbo.Teams");
            DropForeignKey("dbo.Matches", "GuestTeamId", "dbo.Teams");
            DropIndex("dbo.TeamColors", new[] { "Color_ColorId" });
            DropIndex("dbo.TeamColors", new[] { "Team_TeamId" });
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropIndex("dbo.Matches", new[] { "GuestTeamId" });
            DropIndex("dbo.Matches", new[] { "HomeTeamId" });
            DropTable("dbo.TeamColors");
            DropTable("dbo.Players");
            DropTable("dbo.Matches");
            DropTable("dbo.Teams");
            DropTable("dbo.Colors");
        }
    }
}
