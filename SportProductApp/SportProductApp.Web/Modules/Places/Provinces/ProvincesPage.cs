
namespace SportProductApp.Places.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Places/Provinces"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ProvincesRow))]
    public class ProvincesController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Places/Provinces/ProvincesIndex.cshtml");
        }
    }
}