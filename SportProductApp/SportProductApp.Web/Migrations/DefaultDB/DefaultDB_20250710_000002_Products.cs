using FluentMigrator;
using System;
namespace SportProductApp.Migrations.DefaultDB
{
    [Migration(20250710000002)]
    public class DefaultDB_20250710_000002_Products : Migration
    {
        public override void Up()
        {
            //Down();
            Create.Table("Products").InSchema("mov")
                .WithColumn("ProductId").AsInt32().PrimaryKey().Identity()
                .WithColumn("PublicId").AsString(64).NotNullable().Unique()
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Price").AsDecimal(10, 2).NotNullable()
                .WithColumn("DateCreated").AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentUTCDateTime);
        }
        public override void Down()
        {
            Delete.Table("Products");
        }
    }
}
