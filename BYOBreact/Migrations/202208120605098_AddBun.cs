namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBun : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Burgers", "BunId", c => c.Int(nullable: false));
            CreateIndex("dbo.Burgers", "BunId");
            AddForeignKey("dbo.Burgers", "BunId", "dbo.Buns", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Burgers", "BunId", "dbo.Buns");
            DropIndex("dbo.Burgers", new[] { "BunId" });
            DropColumn("dbo.Burgers", "BunId");
            DropTable("dbo.Buns");
        }
    }
}
