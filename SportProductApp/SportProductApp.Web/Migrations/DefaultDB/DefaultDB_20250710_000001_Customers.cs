using FluentMigrator;
using System;
namespace SportProductApp.Migrations.DefaultDB
{
    [Migration(20250710000001)]
    public class DefaultDB_20250710_000001_Customers : Migration
    {
        public override void Up()
        {
            //Down();
            Create.Table("Customers")
                .WithColumn("CustomerId").AsInt32().PrimaryKey().Identity()
                .WithColumn("PublicId").AsString(64).NotNullable().Unique()
                .WithColumn("UserId").AsInt32().NotNullable()
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("CreditCard").AsString(64).Nullable().Unique()
                .WithColumn("DateCreated").AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentUTCDateTime);

            // Relationship Customer - User
            Create.ForeignKey("FK_Customer_UserId")
                .FromTable("Customers").ForeignColumn("UserId")
                .ToTable("Users").PrimaryColumn("UserId");
        }
        public override void Down()
        {
            Delete.ForeignKey("FK_Customer_UserId").OnTable("Customers");
            Delete.Table("Customers");
        }
    }
}
