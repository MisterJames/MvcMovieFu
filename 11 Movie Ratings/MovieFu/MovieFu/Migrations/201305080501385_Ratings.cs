namespace MovieFu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ratings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Stars = c.Double(nullable: false),
                        Comments = c.String(),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Ratings", new[] { "MovieId" });
            DropForeignKey("dbo.Ratings", "MovieId", "dbo.Movies");
            DropTable("dbo.Ratings");
        }
    }
}
