
namespace SportProductApp.SportFlow.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using SportProductApp.SportFlow.Order.Enums;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("SportFlow"), TableName("[dbo].[OrderDetails]")]
    [DisplayName("Order Details"), InstanceName("Order Details")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class OrderDetailsRow : Row, IIdRow
    {
        [DisplayName("Order Detail Id"), Identity]
        public Int32? OrderDetailId
        {
            get { return Fields.OrderDetailId[this]; }
            set { Fields.OrderDetailId[this] = value; }
        }

        [DisplayName("Order"), NotNull, PrimaryKey, ForeignKey(typeof(OrdersRow)), LeftJoin("o"), TextualField("OrderPublicId"),
        LookupEditor(typeof(OrdersRow), InplaceAdd = false)]
        public Int32? OrderId
        {
            get { return Fields.OrderId[this]; }
            set { Fields.OrderId[this] = value; }
        }

        [DisplayName("Product"), NotNull, PrimaryKey, ForeignKey(typeof(ProductsRow)), LeftJoin("p"), TextualField("ProductPublicId")]
        public Int32? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("Quantity"), NotNull]
        public Int32? Quantity
        {
            get { return Fields.Quantity[this]; }
            set { Fields.Quantity[this] = value; }
        }

        [DisplayName("Total"), Expression("(T0.[PriceSnapshot] * T0.[Quantity])"), DisplayFormat("#,##0.00")]
        public Decimal? Total
        {
            get { return Fields.Total[this]; }
            set { Fields.Total[this] = value; }
        }

        [DisplayName("Price Snapshot"), Size(10), Scale(2), NotNull, DisplayFormat("#,##0.00")]
        public Decimal? PriceSnapshot
        {
            get { return Fields.PriceSnapshot[this]; }
            set { Fields.PriceSnapshot[this] = value; }
        }

        [Origin("o"), DisplayName("Order Public Id"), Expression("o.[PublicId]")]
        public String OrderPublicId
        {
            get { return Fields.OrderPublicId[this]; }
            set { Fields.OrderPublicId[this] = value; }
        }

        [Origin("o"), DisplayName("Order Customer Id"), Expression("o.[CustomerId]")]
        public Int32? OrderCustomerId
        {
            get { return Fields.OrderCustomerId[this]; }
            set { Fields.OrderCustomerId[this] = value; }
        }

        [Origin("o"), DisplayName("Order Status"), Expression("o.[Status]")]
        public OrderStatusKind OrderStatus
        {
            get { return (OrderStatusKind)(OrderStatusKind?)Fields.OrderStatus[this]; }
            set { Fields.OrderStatus[this] = (Int32?)value; }
        }

        [Origin("o"), DisplayName("Order Address"), Expression("o.[Address]")]
        public String OrderAddress
        {
            get { return Fields.OrderAddress[this]; }
            set { Fields.OrderAddress[this] = value; }
        }

        [Origin("o"), DisplayName("Order Date Created"), Expression("o.[DateCreated]")]
        public DateTime? OrderDateCreated
        {
            get { return Fields.OrderDateCreated[this]; }
            set { Fields.OrderDateCreated[this] = value; }
        }

        [Origin("p"), DisplayName("Product Public Id"), Expression("p.[PublicId]")]
        public String ProductPublicId
        {
            get { return Fields.ProductPublicId[this]; }
            set { Fields.ProductPublicId[this] = value; }
        }

        [Origin("p"), DisplayName("Product Name"), Expression("p.[Name]")]
        public String ProductName
        {
            get { return Fields.ProductName[this]; }
            set { Fields.ProductName[this] = value; }
        }

        [Origin("p"), DisplayName("Product Price"), Expression("p.[Price]")]
        public Decimal? ProductPrice
        {
            get { return Fields.ProductPrice[this]; }
            set { Fields.ProductPrice[this] = value; }
        }

        [Origin("p"), DisplayName("Product Date Created"), Expression("p.[DateCreated]")]
        public DateTime? ProductDateCreated
        {
            get { return Fields.ProductDateCreated[this]; }
            set { Fields.ProductDateCreated[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.OrderDetailId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public OrderDetailsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field OrderDetailId;
            public Int32Field OrderId;
            public Int32Field ProductId;
            public Int32Field Quantity;
            public DecimalField PriceSnapshot;
            public DecimalField Total;

            public StringField OrderPublicId;
            public Int32Field OrderCustomerId;
            public Int32Field OrderStatus;
            public StringField OrderAddress;
            public DateTimeField OrderDateCreated;

            public StringField ProductPublicId;
            public StringField ProductName;
            public DecimalField ProductPrice;
            public DateTimeField ProductDateCreated;
        }
    }
}
