
namespace SportProductApp.SportFlow.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("SportFlow.ProductsForm")]
    [BasedOnRow(typeof(Entities.ProductsRow), CheckNames = true)]
    public class ProductsForm
    {
        [Hidden]
        public String PublicId { get; set; }
        [StringEditor]
        public String Name { get; set; }
        [DecimalEditor]
        public Decimal Price { get; set; }
        [Hidden/*, DateEditor, ReadOnly(true)*/]
        public DateTime DateCreated { get; set; }
    }
}