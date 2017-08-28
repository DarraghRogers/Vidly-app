namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies ( Name, ReleaseDate, DateAdded, Stock, Genre_Id) VALUES ('Hangover', 11/06/2009, 08/28/2017, 6, 5)");
            Sql("INSERT INTO Movies ( Name, ReleaseDate, DateAdded, Stock, Genre_Id) VALUES ('The Terminator', 10/05/1986, 08/28/2017, 10, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
