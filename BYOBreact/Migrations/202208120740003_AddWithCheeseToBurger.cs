namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWithCheeseToBurger : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Burgers", "WithCheese", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BurgerBuns",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Burgers", "BurgerBunId", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Burgers", "BunId", "dbo.Buns");
            DropIndex("dbo.Burgers", new[] { "BunId" });
            DropPrimaryKey("dbo.Buns");
            AlterColumn("dbo.Buns", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Burgers", "BunId", c => c.Byte(nullable: false));
            DropColumn("dbo.Burgers", "WithCheese");
            AddPrimaryKey("dbo.Buns", "Id");
            RenameColumn(table: "dbo.Burgers", name: "BunId", newName: "BreadId");
            CreateIndex("dbo.Burgers", "BreadId");
            CreateIndex("dbo.Burgers", "BurgerBunId");
            AddForeignKey("dbo.Burgers", "BreadId", "dbo.Breads", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Burgers", "BurgerBunId", "dbo.BurgerBuns", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.Buns", newName: "Breads");
        }
    }
}
