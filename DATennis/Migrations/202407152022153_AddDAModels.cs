namespace DATennis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDAModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tournament_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tournaments", t => t.Tournament_Id)
                .Index(t => t.Tournament_Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                        Ranking = c.Int(nullable: false),
                        DobYear = c.Int(nullable: false),
                        DobMonth = c.Int(nullable: false),
                        DobDay = c.Int(nullable: false),
                        TurnedProYear = c.Int(nullable: false),
                        Weight = c.String(),
                        Height = c.String(),
                        Birthplace = c.String(),
                        Residence = c.String(),
                        Plays = c.String(),
                        Coach = c.String(),
                        Singlestitles = c.Int(nullable: false),
                        Group_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .Index(t => t.Group_Id);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Groups", "Tournament_Id", "dbo.Tournaments");
            DropForeignKey("dbo.Players", "Group_Id", "dbo.Groups");
            DropIndex("dbo.Players", new[] { "Group_Id" });
            DropIndex("dbo.Groups", new[] { "Tournament_Id" });
            DropTable("dbo.Tournaments");
            DropTable("dbo.Players");
            DropTable("dbo.Groups");
        }
    }
}
