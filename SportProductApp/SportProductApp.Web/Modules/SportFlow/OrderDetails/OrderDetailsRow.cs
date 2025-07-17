
namespace SportProductApp.SportFlow.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
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

        [DisplayName("Order"), NotNull, ForeignKey("[dbo].[Orders]", "OrderId"), LeftJoin("jOrder"), TextualField("OrderPublicId")]
        public Int32? OrderId
        {
            get { return Fields.OrderId[this]; }
            set { Fields.OrderId[this] = value; }
        }

        [DisplayName("Product"), NotNull, ForeignKey("[dbo].[Products]", "ProductId"), LeftJoin("jProduct"), TextualField("ProductPublicId")]
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

        [DisplayName("Price Snapshot"), Size(10), Scale(2), NotNull]
        public Decimal? PriceSnapshot
        {
            get { return Fields.PriceSnapshot[this]; }
            set { Fields.PriceSnapshot[this] = value; }
        }

        [DisplayName("Order Public Id"), Expression("jOrder.[PublicId]")]
        public String OrderPublicId
        {
            get { return Fields.OrderPublicId[this]; }
            set { Fields.OrderPublicId[this] = value; }
        }

        [DisplayName("Order Customer Id"), Expression("jOrder.[CustomerId]")]
        public Int32? OrderCustomerId
        {
            get { return Fields.OrderCustomerId[this]; }
            set { Fields.OrderCustomerId[this] = value; }
        }

        [DisplayName("Order Status"), Expression("jOrder.[Status]")]
        public String OrderStatus
        {
            get { return Fields.OrderStatus[this]; }
            set { Fields.OrderStatus[this] = value; }
        }

        [DisplayName("Order Address"), Expression("jOrder.[Address]")]
        public String OrderAddress
        {
            get { return Fields.OrderAddress[this]; }
            set { Fields.OrderAddress[this] = value; }
        }

        [DisplayName("Order Date Created"), Expression("jOrder.[DateCreated]")]
        public DateTime? OrderDateCreated
        {
            get { return Fields.OrderDateCreated[this]; }
            set { Fields.OrderDateCreated[this] = value; }
        }

        [DisplayName("Product Public Id"), Expression("jProduct.[PublicId]")]
        public String ProductPublicId
        {
            get { return Fields.ProductPublicId[this]; }
            set { Fields.ProductPublicId[this] = value; }
        }

        [DisplayName("Product Name"), Expression("jProduct.[Name]")]
        public String ProductName
        {
            get { return Fields.ProductName[this]; }
            set { Fields.ProductName[this] = value; }
        }

        [DisplayName("Product Price"), Expression("jProduct.[Price]")]
        public Decimal? ProductPrice
        {
            get { return Fields.ProductPrice[this]; }
            set { Fields.ProductPrice[this] = value; }
        }

        [DisplayName("Product Date Created"), Expression("jProduct.[DateCreated]")]
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

            public StringField OrderPublicId;
            public Int32Field OrderCustomerId;
            public StringField OrderStatus;
            public StringField OrderAddress;
            public DateTimeField OrderDateCreated;

            public StringField ProductPublicId;
            public StringField ProductName;
            public DecimalField ProductPrice;
            public DateTimeField ProductDateCreated;
        }
    }
}
