using FluentMigrator;
using System;
namespace SportProductApp.Migrations.DefaultDB
{
    [Migration(20250710000004)]
    public class DefaultDB_20250710_000004_OrderDetails : Migration
    {
        public override void Up()
        {
            //Down();
            Create.Table("OrderDetails")
                .WithColumn("OrderDetailId").AsInt32().PrimaryKey().Identity()
                .WithColumn("OrderId").AsInt32().NotNullable()
                .WithColumn("ProductId").AsInt32().NotNullable()
                .WithColumn("Quantity").AsInt32().NotNullable()
                .WithColumn("PriceSnapshot").AsDecimal(10, 2).NotNullable();

            Create.ForeignKey("FK_OrderDetail_OrderId")
                .FromTable("OrderDetails").ForeignColumn("OrderId")
                .ToTable("Orders").PrimaryColumn("OrderId");

            Create.ForeignKey("FK_OrderDetail_ProductId")
                .FromTable("OrderDetails").ForeignColumn("ProductId")
                .ToTable("Products").PrimaryColumn("ProductId");
        }
        public override void Down()
        {
            Delete.ForeignKey("FK_OrderDetail_OrderId").OnTable("OrderDetails");
            Delete.ForeignKey("FK_OrderDetail_ProductId").OnTable("OrderDetails");
            Delete.Table("OrderDetails");
        }
    }
}
