namespace BYOBreact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateBurgerMuffins : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT BurgerMuffins ON");
            Sql("INSERT INTO BurgerMuffins (Id,Name) VALUES(1,'Plain')");
            Sql("INSERT INTO BurgerMuffins (Id,Name) VALUES(2,'Sesame')");
            Sql("INSERT INTO BurgerMuffins (Id,Name) VALUES(3,'Potato')");
            Sql("SET IDENTITY_INSERT BurgerMuffins ON");
        }
        
        public override void Down()
        {
        }
    }
}
