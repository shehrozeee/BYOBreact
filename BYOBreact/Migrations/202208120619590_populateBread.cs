namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateBread : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Breads (Id,Name) VALUES(1,'Plain')");
            Sql("INSERT INTO Breads (Id,Name) VALUES(2,'Sesame')");
            Sql("INSERT INTO Breads (Id,Name) VALUES(3,'Potato')");
        }

        public override void Down()
        {
        }
    }
}
