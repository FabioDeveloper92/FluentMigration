using FluentMigrator;

namespace FluentMigration.Migrations
{
    [Migration(202204201855)]
    public class M202204201855CreateUserTable : Migration
    {
        public override void Up()
        {
            Create.Table("Users")
                  .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                  .WithColumn("Name").AsString().NotNullable()
                  .WithColumn("BirthDate").AsDateTime().Nullable();
        }

        public override void Down()
        {
            Delete.Table("Users");
        }

    }
}
