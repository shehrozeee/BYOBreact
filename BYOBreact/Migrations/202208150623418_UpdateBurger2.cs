namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBurger2 : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            AddColumn("dbo.Burgers", "BurgerBunId", c => c.Int(nullable: false));
            CreateIndex("dbo.Burgers", "BurgerBunId");
            AddForeignKey("dbo.Burgers", "BurgerBunId", "dbo.Buns", "Id", cascadeDelete: true);
        }
    }
}
