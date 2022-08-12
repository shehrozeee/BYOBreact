namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMeat : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Meats (Id,Name) VALUES(1,'Chicken')");
            Sql("INSERT INTO Meats (Id,Name) VALUES(2,'Beef')");
            Sql("INSERT INTO Meats (Id,Name) VALUES(3,'Mutton')");
        }
        
        public override void Down()
        {
        }
    }
}
