using Microsoft.AspNetCore.Mvc;

namespace Equinox.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        //This requiremet is to use attribute routing for actions defined in Admin area
        public IActionResult Index() => View();
    }
}
