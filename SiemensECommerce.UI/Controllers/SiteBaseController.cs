using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SiemensECommerce.Business.Repository;
using System.Security.Claims;

namespace SiemensECommerce.UI.Controllers
{
    public class SiteBaseController : Controller
    {
        //Bu metot herhangi bir action çalışmadan önce ÇALIŞACAKTIR.
        public override void OnActionExecuting(ActionExecutingContext context)
        {
     
            UnitOfWork unitOfWork = new UnitOfWork();
            ViewBag.categories = unitOfWork.CategoryRepository.GetAll();
        }
    }
}
