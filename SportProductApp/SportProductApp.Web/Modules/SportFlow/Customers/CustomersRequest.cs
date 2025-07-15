
namespace SportProductApp.SportFlow.Customers
{
    using Serenity.Services;
    using SportProductApp.SportFlow.Forms;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    public class CustomersRequest : ServiceRequest
    {
        public CustomersForm Form { get; set; }
    }
}