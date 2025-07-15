
namespace SportProductApp.SportFlow.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("SportFlow/Orders"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.OrdersRow))]
    public class OrdersController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/SportFlow/Orders/OrdersIndex.cshtml");
        }
    }
}