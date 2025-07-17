
namespace SportProductApp.SportFlow.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("SportFlow.ProductsColumns")]
    [BasedOnRow(typeof(Entities.ProductsRow), CheckNames = true)]
    public class ProductsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ProductId { get; set; }
        [EditLink, Width(334)]
        public String PublicId { get; set; }
        [Width(218)]
        public String Name { get; set; }
        [Width(128)]
        public Decimal Price { get; set; }
        [Width(128)]
        public DateTime DateCreated { get; set; }
    }
}