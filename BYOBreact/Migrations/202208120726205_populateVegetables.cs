namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateVegetables : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Vegetables ON");
            Sql("INSERT INTO Vegetables (Id,Name) VALUES(1,'Tomatos')");
            Sql("INSERT INTO Vegetables (Id,Name) VALUES(2,'Lettuce')");
            Sql("INSERT INTO Vegetables (Id,Name) VALUES(3,'Onions')");
            Sql("SET IDENTITY_INSERT Vegetables OFF");
        }
        
        public override void Down()
        {
        }
    }
}
