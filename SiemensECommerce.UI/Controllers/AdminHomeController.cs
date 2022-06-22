using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SiemensECommerce.UI.Controllers
{

    public class AdminHomeController : AdminBaseController
    {
     
        public IActionResult Index()
        {
            return View();
        }
    }
}
