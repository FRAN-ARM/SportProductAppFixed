
namespace SportProductApp.SportFlow.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("SportFlow/Products"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ProductsRow))]
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/SportFlow/Products/ProductsIndex.cshtml");
        }
    }
}