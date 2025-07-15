
namespace SportProductApp.SportFlow.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("SportFlow"), TableName("[dbo].[Orders]")]
    [DisplayName("Orders"), InstanceName("Orders")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class OrdersRow : Row, IIdRow, INameRow
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

        [DisplayName("Customer"), NotNull, ForeignKey("[dbo].[Customers]", "CustomerId"), LeftJoin("jCustomer"), TextualField("CustomerPublicId")]
        public Int32? CustomerId
        {
            get { return Fields.CustomerId[this]; }
            set { Fields.CustomerId[this] = value; }
        }

        [DisplayName("Status"), Size(50), NotNull]
        public String Status
        {
            get { return Fields.Status[this]; }
            set { Fields.Status[this] = value; }
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

        [DisplayName("Customer Public Id"), Expression("jCustomer.[PublicId]")]
        public String CustomerPublicId
        {
            get { return Fields.CustomerPublicId[this]; }
            set { Fields.CustomerPublicId[this] = value; }
        }

        [DisplayName("Customer User Id"), Expression("jCustomer.[UserId]")]
        public Int32? CustomerUserId
        {
            get { return Fields.CustomerUserId[this]; }
            set { Fields.CustomerUserId[this] = value; }
        }

        [DisplayName("Customer Name"), Expression("jCustomer.[Name]")]
        public String CustomerName
        {
            get { return Fields.CustomerName[this]; }
            set { Fields.CustomerName[this] = value; }
        }

        [DisplayName("Customer Credit Card"), Expression("jCustomer.[CreditCard]")]
        public String CustomerCreditCard
        {
            get { return Fields.CustomerCreditCard[this]; }
            set { Fields.CustomerCreditCard[this] = value; }
        }

        [DisplayName("Customer Date Created"), Expression("jCustomer.[DateCreated]")]
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

        public OrdersRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field OrderId;
            public StringField PublicId;
            public Int32Field CustomerId;
            public StringField Status;
            public StringField Address;
            public DateTimeField DateCreated;

            public StringField CustomerPublicId;
            public Int32Field CustomerUserId;
            public StringField CustomerName;
            public StringField CustomerCreditCard;
            public DateTimeField CustomerDateCreated;
        }
    }
}
