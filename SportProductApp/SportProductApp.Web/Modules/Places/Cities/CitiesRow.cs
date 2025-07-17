
namespace SportProductApp.Places.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Places"), TableName("[dbo].[Cities]")]
    [DisplayName("Cities"), InstanceName("Cities")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Places.CitiesRow")]
    public sealed class CitiesRow : Row, IIdRow, INameRow
    {
        [DisplayName("City Id"), Identity]
        public Int32? CityId
        {
            get { return Fields.CityId[this]; }
            set { Fields.CityId[this] = value; }
        }

        [DisplayName("Province"), NotNull, ForeignKey("[dbo].[Provinces]", "ProvinceId"), LeftJoin("jProvince"), TextualField("ProvinceName")]
        [LookupInclude]
        public Int32? ProvinceId
        {
            get { return Fields.ProvinceId[this]; }
            set { Fields.ProvinceId[this] = value; }
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Province Name"), Expression("jProvince.[Name]")]
        public String ProvinceName
        {
            get { return Fields.ProvinceName[this]; }
            set { Fields.ProvinceName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CityId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CitiesRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CityId;
            public Int32Field ProvinceId;
            public StringField Name;

            public StringField ProvinceName;
        }
    }
}