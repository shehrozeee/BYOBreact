namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBread : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Breads",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Burgers", "BreadId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Burgers", "BreadId");
            AddForeignKey("dbo.Burgers", "BreadId", "dbo.Breads", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Burgers", "BreadId", "dbo.Breads");
            DropIndex("dbo.Burgers", new[] { "BreadId" });
            DropColumn("dbo.Burgers", "BreadId");
            DropTable("dbo.Breads");
        }
    }
}
