using Serenity.Extensibility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SportProductApp.Modules.SportFlow
{
    [NestedPermissionKeys]
    [DisplayName("Customers")]
    public class PermissionKeys
    {
        [Description("Customer can track online the order status")]
        public const string General = "Customers:General";
    }
}
