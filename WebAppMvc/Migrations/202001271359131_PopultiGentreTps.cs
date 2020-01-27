namespace WebAppMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopultiGentreTps : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GenreTypes (  GenreName ) VALUES('ACTION') ");
            Sql("INSERT INTO GenreTypes(  GenreName ) VALUES('DRAMA') ");

            Sql("INSERT INTO GenreTypes (  GenreName ) VALUES('SCIFI') ");

            Sql("INSERT INTO GenreTypes (  GenreName ) VALUES('ANIMATION') ");
            Sql("INSERT INTO GenreTypes (  GenreName ) VALUES('ANIME') ");
            Sql("INSERT INTO GenreTypes (  GenreName ) VALUES('THRILLER') ");





        }

        public override void Down()
        {
        }
    }
}
