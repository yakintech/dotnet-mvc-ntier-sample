using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SiemensECommerce.UI.Controllers
{
    [Authorize]
    public class AdminBaseController : Controller
    {
       
    }
}
