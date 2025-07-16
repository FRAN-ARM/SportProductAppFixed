
namespace SportProductApp.SportFlow.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("SportFlow.OrderDetails")]
    [BasedOnRow(typeof(Entities.OrderDetailsRow), CheckNames = true)]
    public class OrderDetailsForm
    {
        [LookupEditor("SportFlow.OrderDetailsFormId"), QuickFilter]
        public Int32 OrderId { get; set; }
        public Int32 ProductId { get; set; }
        [IntegerEditor]
        public Int32 Quantity { get; set; }
        [ReadOnly(true)]
        public Decimal PriceSnapshot { get; set; }
    }
}