using FluentMigrator;

namespace FluentMigration.Migrations
{
    [Migration(202205101810)]
    public class M202205101810CreateIndexUserTable : Migration
    {
        public override void Up()
        {
            Create.Index("IX_Users_CLSName").OnTable("Users").OnColumn("Name").Ascending()
                                                             .OnColumn("Surname").Ascending()
                                                             .WithOptions()
                                                             .NonClustered();
        }

        public override void Down()
        {
            Delete.Index("IX_Users_CLSName");
        }

    }
}
