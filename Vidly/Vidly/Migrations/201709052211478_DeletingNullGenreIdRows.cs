namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletingNullGenreIdRows : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Movies WHERE Id=1 ");
            Sql("DELETE FROM Movies WHERE Id=2 ");
        }
        
        public override void Down()
        {
        }
    }
}
