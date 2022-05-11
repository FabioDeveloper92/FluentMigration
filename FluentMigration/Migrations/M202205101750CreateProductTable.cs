using FluentMigrator;
using FluentMigrator.SqlServer;

namespace FluentMigration.Migrations
{
    [Migration(02205101750)]
    public class M202205101750CreateProductTable : Migration
    {
        public override void Up()
        {
            Create.Table("Products")
                  .WithColumn("Id").AsInt32().Identity(1, 1)
                  .WithColumn("Name").AsString(100);
        }

        public override void Down()
        {
            Delete.PrimaryKey("PK_Products_Name");
            Delete.Table("Products");
        }

    }
}
