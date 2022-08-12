namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBun2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Burgers", "Bun_Id", "dbo.Buns");
            DropIndex("dbo.Burgers", new[] { "Bun_Id" });
            DropColumn("dbo.Burgers", "BunId");
            RenameColumn(table: "dbo.Burgers", name: "Bun_Id", newName: "BunId");
            AlterColumn("dbo.Burgers", "BunId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Burgers", "BunId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Burgers", "BunId");
            AddForeignKey("dbo.Burgers", "BunId", "dbo.Buns", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Burgers", "BunId", "dbo.Buns");
            DropIndex("dbo.Burgers", new[] { "BunId" });
            AlterColumn("dbo.Burgers", "BunId", c => c.Byte());
            AlterColumn("dbo.Burgers", "BunId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Burgers", name: "BunId", newName: "Bun_Id");
            AddColumn("dbo.Burgers", "BunId", c => c.Int(nullable: false));
            CreateIndex("dbo.Burgers", "Bun_Id");
            AddForeignKey("dbo.Burgers", "Bun_Id", "dbo.Buns", "Id");
        }
    }
}
