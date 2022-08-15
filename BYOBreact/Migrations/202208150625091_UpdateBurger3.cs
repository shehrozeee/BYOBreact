namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBurger3 : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Burgers", "MuffinsId", "dbo.Buns");
            //DropIndex("dbo.Burgers", new[] { "MuffinsId" });
            //DropColumn("dbo.Burgers", "MuffinsId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Burgers", "MuffinsId", c => c.Int(nullable: false));
            CreateIndex("dbo.Burgers", "MuffinsId");
            AddForeignKey("dbo.Burgers", "MuffinsId", "dbo.Buns", "Id", cascadeDelete: true);
        }
    }
}
