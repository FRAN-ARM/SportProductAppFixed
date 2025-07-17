
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

    [FormScript("Places.ProvincesForm")]
    [BasedOnRow(typeof(ProvincesRow), CheckNames = true)]
    public class ProvincesForm
    {
        public String Name { get; set; }
    }
}