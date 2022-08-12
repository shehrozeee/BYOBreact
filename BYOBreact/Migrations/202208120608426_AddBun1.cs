namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBun1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Burgers", "BunId", "dbo.Buns");
            DropIndex("dbo.Burgers", new[] { "BunId" });
            DropPrimaryKey("dbo.Buns");
            AddColumn("dbo.Burgers", "Bun_Id", c => c.Byte());
            AlterColumn("dbo.Buns", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Buns", "Id");
            CreateIndex("dbo.Burgers", "Bun_Id");
            AddForeignKey("dbo.Burgers", "Bun_Id", "dbo.Buns", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Burgers", "Bun_Id", "dbo.Buns");
            DropIndex("dbo.Burgers", new[] { "Bun_Id" });
            DropPrimaryKey("dbo.Buns");
            AlterColumn("dbo.Buns", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Burgers", "Bun_Id");
            AddPrimaryKey("dbo.Buns", "Id");
            CreateIndex("dbo.Burgers", "BunId");
            AddForeignKey("dbo.Burgers", "BunId", "dbo.Buns", "Id", cascadeDelete: true);
        }
    }
}
