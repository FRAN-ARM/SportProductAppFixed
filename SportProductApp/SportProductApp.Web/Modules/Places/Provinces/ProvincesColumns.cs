
namespace SportProductApp.Places.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Places.Provinces")]
    [BasedOnRow(typeof(Entities.ProvincesRow), CheckNames = true)]
    public class ProvincesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ProvinceId { get; set; }
        [EditLink]
        public String Name { get; set; }
    }
}