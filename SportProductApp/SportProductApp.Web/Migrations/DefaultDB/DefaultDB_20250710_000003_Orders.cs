using FluentMigrator;
using System;
namespace SportProductApp.Migrations.DefaultDB
{
    [Migration(20250710000003)]
    public class DefaultDB_20250710_000003_Orders : Migration
    {
        public override void Up()
        {
            //Down();
            Create.Table("Orders")
                .WithColumn("OrderId").AsInt32().PrimaryKey().Identity()
                .WithColumn("PublicId").AsString(64).NotNullable().Unique()
                .WithColumn("CustomerId").AsInt32().NotNullable()
                .WithColumn("Status").AsString(50).NotNullable().WithDefaultValue("Pending")
                .WithColumn("Address").AsString(248).NotNullable().WithDefaultValue("")
                .WithColumn("DateCreated").AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentUTCDateTime);

            Create.ForeignKey("FK_Order_CustomerId")
                .FromTable("Orders").ForeignColumn("CustomerId")
                .ToTable("Customers").PrimaryColumn("CustomerId");
        }
        public override void Down()
        {
            Delete.ForeignKey("FK_Order_CustomerId").OnTable("Orders");
            Delete.Table("Orders");
        }
    }
}
