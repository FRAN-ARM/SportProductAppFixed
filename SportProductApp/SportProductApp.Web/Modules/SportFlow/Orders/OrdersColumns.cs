
namespace SportProductApp.SportFlow.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("SportFlow.OrdersColumns")]
    [BasedOnRow(typeof(Entities.OrdersRow), CheckNames = true)]
    public class OrdersColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 OrderId { get; set; }
        [EditLink]
        public String PublicId { get; set; }
        public String CustomerPublicId { get; set; }
        public Int32 Status { get; set; }
        public String Address { get; set; }
        public DateTime DateCreated { get; set; }
    }
}