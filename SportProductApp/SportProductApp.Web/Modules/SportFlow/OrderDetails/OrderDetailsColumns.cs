namespace SportProductApp.SportFlow.Columns
{
    using Serenity.ComponentModel;
    using System;

    [ColumnsScript("SportFlow.OrderDetailsColumns")]
    [BasedOnRow(typeof(Entities.OrderDetailsRow), CheckNames = true)]
    public class OrderDetailsColumns
    {
        [Width(200)]
        public string OrderPublicId { get; set; }

        [Width(200)]
        public string ProductPublicId { get; set; }

        [Width(200)]
        public string ProductName { get; set; }

        [Width(120)]
        public decimal ProductPrice { get; set; }

        [Width(150)]
        public DateTime ProductDateCreated { get; set; }

        [Width(100)]
        public int Quantity { get; set; }

        [Width(120)]
        public decimal PriceSnapshot { get; set; }

        [Width(100)]
        public decimal Total { get; set; }

        [Width(150)]
        public string OrderStatus { get; set; }
    }
}
