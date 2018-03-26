namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Type) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Type) VALUES ('Romance')");
            Sql("INSERT INTO Genres (Type) VALUES ('Action')");
            Sql("INSERT INTO Genres (Type) VALUES ('Family')");

        }

        public override void Down()
        {
        }
    }
}
