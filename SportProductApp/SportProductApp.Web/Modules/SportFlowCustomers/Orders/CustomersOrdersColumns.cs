
namespace SportProductApp.SportFlowCustomers.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using SportProductApp.SportFlow.Order.Enums;

    [ColumnsScript("SportFlowCustomers.CustomersOrdersColumns")]
    [BasedOnRow(typeof(Entities.CustomersOrdersRow), CheckNames = true)]
    public class CustomerOrdersColumns
    {
        [Width(240)]
        public String PublicId { get; set; }
        [Width(240)]
        public String CustomerPublicId { get; set; }
        [Width(180), EnumEditor, QuickFilter]
        public OrderStatusKind Status { get; set; }
        [Width(240)]
        public String Address { get; set; }
        [Width(240), QuickFilter]
        public DateTime DateCreated { get; set; }
    }
}