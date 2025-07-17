
namespace SportProductApp.SportFlow.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("SportFlow.CustomersForm")]
    public class CustomersForm
    {
        /*[StaticTextBlock(HideLabel = true, IsHtml = true, Text = "<h4 class='text-blue'>Welcome to Order Wizard!</h4>"]
        public string WelcomeMessage { get; set; }*/

        [Required, MaxLength(100)]
        [DisplayName("Username"), Width(200)]
        public String UserUsername { get; set; }

        [Required, MaxLength(100)]
        [DisplayName("Full Name (Real Name)"), Width(200)]
        public String UserDisplayName { get; set; }

        [Required, EmailEditor, MaxLength(100)]
        public String UserEmail { get; set; }

        [Required, DisplayName("Credit Card"), MaxLength(64)]
        public String CreditCard { get; set; }

        [DisplayName("Creation Date"), ReadOnly(true), Width(200)]
        public DateTime DateCreated { get; set; }
    }
}