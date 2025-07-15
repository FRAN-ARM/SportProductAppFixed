
namespace SportProductApp.SportFlow.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("SportFlow.Orders")]
    [BasedOnRow(typeof(Entities.OrdersRow), CheckNames = true)]
    public class OrdersForm
    {
        public String PublicId { get; set; }
        public Int32 CustomerId { get; set; }
        public String Status { get; set; }
        public String Address { get; set; }
        public DateTime DateCreated { get; set; }
    }
}