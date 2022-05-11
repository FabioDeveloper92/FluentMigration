using FluentMigrator;
using FluentMigrator.SqlServer;

namespace FluentMigration.Migrations
{
    [Migration(202205101800)]
    public class M202205101800CreatePKProductTable : Migration
    {
        public override void Up()
        {
            Create.PrimaryKey("PK_Products_Name").OnTable("Products").Column("Name").NonClustered();
        }

        public override void Down()
        {
            Delete.PrimaryKey("PK_Products_Name");
        }

    }
}
