using FluentMigrator;

namespace FluentMigration.Migrations
{
    [Migration(202204241920)]
    public class M202204241920AlterColumnNameUserTable : Migration
    {
        public override void Up()
        {
            Alter.Table("Users")
                 .AddColumn("Surname")
                 .AsString()
                 .NotNullable()
                 .WithDefaultValue("");
        }

        public override void Down()
        {
            Delete.Column("Surname")
                  .FromTable("Users");
        }

    }
}
