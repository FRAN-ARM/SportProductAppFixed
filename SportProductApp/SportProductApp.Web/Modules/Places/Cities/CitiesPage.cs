
namespace SportProductApp.Places.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Places/Cities"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CitiesRow))]
    public class CitiesController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Places/Cities/CitiesIndex.cshtml");
        }
    }
}