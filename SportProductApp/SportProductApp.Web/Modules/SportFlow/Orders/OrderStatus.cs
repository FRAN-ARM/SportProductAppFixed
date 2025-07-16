
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SportProductApp.SportFlow.Order.Enums
{
    [EnumKey("SportFlow.OrderStatusKind")]
    public enum OrderStatusKind
    {
        [Description("Pending")]
        Pending = 0,
        [Description("Canceled")]
        Canceled = 1,
        [Description("Completed")]
        Completed = 2
    }
}
