
namespace SportProductApp.Places.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using SportProductApp.Places.Entities;

    [FormScript("Places.CitiesForm")]
    [BasedOnRow(typeof(CitiesRow), CheckNames = true)]
    public class CitiesForm
    {
        public Int32 ProvinceId { get; set; }
        public String Name { get; set; }
    }
}