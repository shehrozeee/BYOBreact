namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateBun : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Buns ON");
            Sql("INSERT INTO Buns (Id,Name) VALUES(1,'Plain')");
            Sql("INSERT INTO Buns (Id,Name) VALUES(2,'Sesame')");
            Sql("INSERT INTO Buns (Id,Name) VALUES(3,'Potato')");
            Sql("SET IDENTITY_INSERT Buns OFF");
        }

        public override void Down()
        {
        }
    }
}
