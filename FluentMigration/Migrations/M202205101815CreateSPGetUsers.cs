using FluentMigrator;

namespace FluentMigration.Migrations
{
    [Migration(202205101815)]
    public class M202205101815CreateSPGetUsers : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("Script.GetUsers_05102022_1820.sql");
        }

        public override void Down()
        {
            // I create a store procedure and I can delete it directly use this method
            Execute.Sql("DROP PROCEDURE [dbo].[GetUsers]");
        }

    }
}
