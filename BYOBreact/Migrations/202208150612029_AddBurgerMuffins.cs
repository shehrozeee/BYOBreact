namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBurgerMuffins : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BurgerMuffins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            
            AddColumn("dbo.Burgers", "BurgerMuffinsId", c => c.Int(nullable: false));
            
            CreateIndex("dbo.Burgers", "BurgerMuffinsId");
            AddForeignKey("dbo.Burgers", "BurgerMuffinsId", "dbo.BurgerMuffins", "Id", cascadeDelete: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Burgers", "MuffinsId", "dbo.Buns");
            DropForeignKey("dbo.Burgers", "BurgerMuffinsId", "dbo.BurgerMuffins");
            DropForeignKey("dbo.Burgers", "BurgerBunId", "dbo.Buns");
            DropIndex("dbo.Burgers", new[] { "BurgerMuffinsId" });
            DropIndex("dbo.Burgers", new[] { "MuffinsId" });
            DropIndex("dbo.Burgers", new[] { "BurgerBunId" });
            DropColumn("dbo.Burgers", "BurgerMuffinsId");
            DropColumn("dbo.Burgers", "MuffinsId");
            DropColumn("dbo.Burgers", "BurgerBunId");
            DropTable("dbo.BurgerMuffins");
        }
    }
}
