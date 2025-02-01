using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Areas.Users.Controllers
{
    public class User : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
