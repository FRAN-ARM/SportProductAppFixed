
namespace SportProductApp.SportFlowCustomers.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("SportFlowCustomers.CustomersOrders")]
    [BasedOnRow(typeof(Entities.CustomersOrdersRow), CheckNames = true)]
    public class CustomersOrdersForm
    {
        public String PublicId { get; set; }
        public Int32 CustomerId { get; set; }
        public String Address { get; set; }
        public DateTime DateCreated { get; set; }
        public Int32 Status { get; set; }
    }
}