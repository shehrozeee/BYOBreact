namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateSauces : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Sauces ON");
            Sql("INSERT INTO Sauces (Id,Name) VALUES(1,'Barbeque')");
            Sql("INSERT INTO Sauces (Id,Name) VALUES(2,'Cheese')");
            Sql("INSERT INTO Sauces (Id,Name) VALUES(3,'Atomic')");
            Sql("INSERT INTO Sauces (Id,Name) VALUES(4,'Chipotele')");
            Sql("INSERT INTO Sauces (Id,Name) VALUES(5,'Greek')");
            Sql("SET IDENTITY_INSERT Sauces OFF");
        }
        
        public override void Down()
        {
        }
    }
}
