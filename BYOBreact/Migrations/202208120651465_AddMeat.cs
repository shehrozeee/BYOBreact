namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMeat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Meats",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Burgers", "MeatId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Burgers", "MeatId");
            AddForeignKey("dbo.Burgers", "MeatId", "dbo.Meats", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Burgers", "MeatId", "dbo.Meats");
            DropIndex("dbo.Burgers", new[] { "MeatId" });
            DropColumn("dbo.Burgers", "MeatId");
            DropTable("dbo.Meats");
        }
    }
}
