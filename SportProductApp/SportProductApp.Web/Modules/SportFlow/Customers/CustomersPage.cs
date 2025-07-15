
namespace SportProductApp.SportFlow.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("SportFlow/Customers"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CustomersRow))]
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/SportFlow/Customers/CustomersIndex.cshtml");
        }
    }
}