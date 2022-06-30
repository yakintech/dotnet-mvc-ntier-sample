using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SiemensECommerce.Business.Repository;
using SiemensECommerce.UI.Models.VM;
using System.Security.Claims;
using System.Text.Json;

namespace SiemensECommerce.UI.Controllers
{
    public class SiteBaseController : Controller
    {
        public UnitOfWork unitOfWork;
        public SiteBaseController()
        {
            unitOfWork = new UnitOfWork();
        }
        //Bu metot herhangi bir action çalışmadan önce ÇALIŞACAKTIR.
        public override void OnActionExecuting(ActionExecutingContext context)
        {
     
            UnitOfWork unitOfWork = new UnitOfWork();
            ViewBag.categories = unitOfWork.CategoryRepository.GetAll();


            string cart = HttpContext.Session.GetString("cart") ?? "";

            List<CartVM> model;

            if (cart == "")
            {
                model = new List<CartVM>();
            }
            else
            {
                model = JsonSerializer.Deserialize<List<CartVM>>(cart);

            }


            ViewBag.CartLength = model.Count;

        }
    }
}
