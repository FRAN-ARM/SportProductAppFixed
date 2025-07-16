using FluentMigrator;
using System;

namespace SportProductApp.Migrations.DefaultDB
{
    // Cambia el tipo de dato de Status a Int32 para el uso del enum disponible en Modules/SportFlow/Orders/OrderStatus.
    [Migration(20250710000008)]
    public class DefaultDB_20250710_000008_OrdersChangeTypeStatus : Migration
    {
        public override void Up()
        {
            Delete.DefaultConstraint().OnTable("Orders").OnColumn("Status");
            Delete.Column("Status").FromTable("Orders");
            Alter.Table("Orders")
                .AddColumn("Status").AsInt32().NotNullable().WithDefaultValue(0);
        }

        public override void Down()
        {
            Delete.Column("Status").FromTable("Orders");
            Alter.Table("Orders")
                .AddColumn("Status").AsString(50).NotNullable().WithDefaultValue("Pending");
        }
    }
}
