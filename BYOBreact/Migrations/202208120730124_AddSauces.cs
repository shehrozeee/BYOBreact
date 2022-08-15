namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSauces : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sauces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Burgers", "SaucesId", c => c.Int(nullable: false));
            CreateIndex("dbo.Burgers", "SaucesId");
            AddForeignKey("dbo.Burgers", "SaucesId", "dbo.Sauces", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Burgers", "SaucesId", "dbo.Sauces");
            DropIndex("dbo.Burgers", new[] { "SaucesId" });
            DropColumn("dbo.Burgers", "SaucesId");
            DropTable("dbo.Sauces");
        }
    }
}
