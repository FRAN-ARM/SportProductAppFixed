
namespace SportProductApp.SportFlow.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("SportFlow.CustomersColumns")]
    [BasedOnRow(typeof(Entities.CustomersRow), CheckNames = true)]
    public class CustomersColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 CustomerId { get; set; }
        [EditLink, Width(334)]
        public String PublicId { get; set; }
        [Width(218)]
        public String UserPublicId { get; set; }
        [Width(218)]
        public String Name { get; set; }
        [Width(128)]
        public String CreditCard { get; set; }
        [Width(128)]
        public DateTime DateCreated { get; set; }
    }
}