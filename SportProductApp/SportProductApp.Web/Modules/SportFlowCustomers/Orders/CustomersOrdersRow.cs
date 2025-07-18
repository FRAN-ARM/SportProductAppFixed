namespace SportProductApp.SportFlowCustomers.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using SportProductApp.SportFlow.Entities;
    using SportProductApp.SportFlow.Order.Enums;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("SportFlowCustomers"), TableName("[dbo].[Orders]")]
    [DisplayName("Orders"), InstanceName("Orders")]
    [ReadPermission("Customers:General")]
    //[ModifyPermission("Customers:General")]
    public sealed class CustomersOrdersRow : Row, IIdRow, INameRow
    {
        [DisplayName("Order Id"), Identity]
        public Int32? OrderId
        {
            get { return Fields.OrderId[this]; }
            set { Fields.OrderId[this] = value; }
        }

        [DisplayName("Public Id"), Size(64), NotNull, QuickSearch]
        public String PublicId
        {
            get { return Fields.PublicId[this]; }
            set { Fields.PublicId[this] = value; }
        }

        [DisplayName("Customer"), NotNull, PrimaryKey, ForeignKey(typeof(CustomersRow)), LeftJoin("c")]
        public Int32? CustomerId
        {
            get { return Fields.CustomerId[this]; }
            set { Fields.CustomerId[this] = value; }
        }

        [DisplayName("Address"), Size(248), NotNull]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName("Date Created"), NotNull]
        public DateTime? DateCreated
        {
            get { return Fields.DateCreated[this]; }
            set { Fields.DateCreated[this] = value; }
        }

        [DisplayName("Status"), NotNull]
        public OrderStatusKind Status
        {
            get { return (OrderStatusKind)Fields.Status[this]; }
            set { Fields.Status[this] = value; }
        }

        [Origin("c"), DisplayName("Customer Public Id"), Expression("c.[PublicId]")]
        public String CustomerPublicId
        {
            get { return Fields.CustomerPublicId[this]; }
            set { Fields.CustomerPublicId[this] = value; }
        }

        [Origin("c"), DisplayName("Customer User Id"), Expression("c.[UserId]")]
        public Int32? CustomerUserId
        {
            get { return Fields.CustomerUserId[this]; }
            set { Fields.CustomerUserId[this] = value; }
        }

        [Origin("c"), DisplayName("Customer Name"), Expression("c.[Name]")]
        public String CustomerName
        {
            get { return Fields.CustomerName[this]; }
            set { Fields.CustomerName[this] = value; }
        }

        [Origin("c"), DisplayName("Customer Credit Card"), Expression("c.[CreditCard]")]
        public String CustomerCreditCard
        {
            get { return Fields.CustomerCreditCard[this]; }
            set { Fields.CustomerCreditCard[this] = value; }
        }

        [Origin("c"), DisplayName("Customer Date Created"), Expression("c.[DateCreated]")]
        public DateTime? CustomerDateCreated
        {
            get { return Fields.CustomerDateCreated[this]; }
            set { Fields.CustomerDateCreated[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.OrderId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.PublicId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CustomersOrdersRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field OrderId;
            public StringField PublicId;
            public Int32Field CustomerId;
            public StringField Address;
            public DateTimeField DateCreated;
            public EnumField<OrderStatusKind> Status;

            public StringField CustomerPublicId;
            public Int32Field CustomerUserId;
            public StringField CustomerName;
            public StringField CustomerCreditCard;
            public DateTimeField CustomerDateCreated;
        }
    }
}