using FluentMigrator;

namespace FluentMigration.Migrations
{
    [Migration(202204241920)]
    public class M202204241930UpdateAdminUser : Migration
    {
        public override void Up()
        {
            Update.Table("Users")
                  .Set(new { Name = "Admin" })
                  .Where(new { Name = "SuperAdmin" });
        }

        public override void Down()
        {
            Update.Table("Users")
                  .Set(new { Name = "SuperAdmin" })
                  .Where(new { Name = "Admin" });
        }

    }
}
