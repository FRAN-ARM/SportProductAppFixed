
namespace SportProductApp.SportFlow.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("SportFlow/OrderDetails"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.OrderDetailsRow))]
    public class OrderDetailsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/SportFlow/OrderDetails/OrderDetailsIndex.cshtml");
        }
    }
}