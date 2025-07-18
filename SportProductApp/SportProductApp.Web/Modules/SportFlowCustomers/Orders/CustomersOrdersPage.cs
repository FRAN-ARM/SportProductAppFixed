
namespace SportProductApp.SportFlowCustomers.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("SportFlowCustomers/Orders"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CustomersOrdersRow))]
    public class CustomersOrdersController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/SportFlowCustomers/Orders/CustomersOrdersIndex.cshtml");
        }
    }
}