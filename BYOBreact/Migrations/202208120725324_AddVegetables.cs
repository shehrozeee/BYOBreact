namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVegetables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vegetables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Burgers", "VegetablesId", c => c.Int(nullable: false));
            CreateIndex("dbo.Burgers", "VegetablesId");
            AddForeignKey("dbo.Burgers", "VegetablesId", "dbo.Vegetables", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Burgers", "VegetablesId", "dbo.Vegetables");
            DropIndex("dbo.Burgers", new[] { "VegetablesId" });
            DropColumn("dbo.Burgers", "VegetablesId");
            DropTable("dbo.Vegetables");
        }
    }
}
