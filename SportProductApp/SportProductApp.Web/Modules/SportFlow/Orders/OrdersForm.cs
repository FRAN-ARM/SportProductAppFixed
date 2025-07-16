
namespace SportProductApp.SportFlow.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using SportProductApp.SportFlow.Entities;
    using SportProductApp.SportFlow.Order.Enums;
    using SportProductApp.Places.Entities;

    [FormScript("SportFlow.Orders")]
    /*[BasedOnRow(typeof(Entities.OrdersRow), CheckNames = true)]*/
    public class OrdersForm
    {
        [Hidden]
        public String PublicId { get; set; }

        [LookupEditor(typeof(CustomersRow), AutoComplete = true)]
        public Int32 CustomerId { get; set; }
        public OrderStatusKind Status { get; set; }
        [Hidden]
        public String Address { get; set; }
        [DisplayName("Provincia"), LookupEditor(typeof(ProvincesRow), InplaceAdd = false, AutoComplete = true)]
        public Int32? ProvinceId { get; set; }

        [DisplayName("Ciudad"), LookupEditor(typeof(CitiesRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId", InplaceAdd = false, AutoComplete = true)]
        public Int32? CityId { get; set; }

        [DisplayName("Items"), OrderDetailsEditor]
        public List<OrderDetailsRow> ItemList { get; set; }

        [DisplayName("Creation Date"), ReadOnly(true), Width(200)]

        public DateTime DateCreated { get; set; }
    }
}