using FluentMigrator;
using System;

namespace FluentMigration.Migrations
{
    [Migration(202204241920)]
    public class M202204241930AddAdminUser : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Users")
                  .Row(new { Name = "Admin", Surname = "Admin", BirthDate = new DateTime(2000, 01, 01) });
        }

        public override void Down()
        {
            Delete.FromTable("Users")
                  .Row(new { Name = "Admin" });
        }

    }
}
