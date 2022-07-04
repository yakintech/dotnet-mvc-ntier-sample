using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;
using System.Text.Json;

namespace SiemensECommerce.UI.Controllers
{
    public class CartController : SiteBaseController
    {

        public IActionResult Index()
        {
            string cart = HttpContext.Session.GetString("cart") ?? "";

            List<CartVM> model;

            if(cart == "")
            {
                model = new List<CartVM>();
            }
            else
            {
                model = JsonSerializer.Deserialize<List<CartVM>>(cart);

            }

            return View(model);
        }


        [HttpPost]
        public IActionResult AddToCart(CartVM model)
        {
            //Öncelikle sepete eklenecek ürünü db den buluyorum...
            Product product = unitOfWork.ProductRepository.GetEntityById(model.ProductId);

            //Eğer sonuç null gelirse boş bir string ata
            string cart = HttpContext.Session.GetString("cart") ?? "";

            //Session üzerinden aldığım sepet bilgileri string formatta olduğu için onu csharp modeline ceviriyorum.

            List<CartVM> cartModel;
            if (cart == "")
            {
                cartModel = new List<CartVM>();
            }
            else
            {

                cartModel = JsonSerializer.Deserialize<List<CartVM>>(cart);
            }

            //Ürün sepette varsa miktarını bir arttıracağım yoksa sepete yeni ürünü ekleyeceğim!!! Session üzerindne yapacağız!

            var cartProduct = cartModel.FirstOrDefault(q => q.ProductId == product.Id);
            //var cartQuantity = cartModel.FirstOrDefault(q => q.Quantity == model.Quantity);
      
            


            if (cartProduct != null)
            {
                cartProduct.Quantity = cartProduct.Quantity + 1;
                cartProduct.TotalPrice = cartProduct.TotalPrice * cartProduct.Quantity;
            }
            else
            {
                CartVM newCartProduct = new CartVM();
                newCartProduct.Quantity = 1;
                newCartProduct.ProductId = product.Id;
                newCartProduct.Img = product.MainImage;
                newCartProduct.Name = product.Name;
                newCartProduct.Description = product.Description;
                newCartProduct.TotalPrice = product.UnitPrice;
                cartModel.Add(newCartProduct);
            }

            var newCart = JsonSerializer.Serialize(cartModel);

            HttpContext.Session.SetString("cart", newCart);


            return Json(cartModel.Count);
        }

        [HttpPost]
        public IActionResult RemoveItem(CartVM model)
        {            
            Product product = unitOfWork.ProductRepository.GetEntityById(model.ProductId);

            string cart = HttpContext.Session.GetString("cart") ?? "";

            List<CartVM> cartModel;
            if (cart == "")
            {
                cartModel = new List<CartVM>();
            }
            else
            {

                cartModel = JsonSerializer.Deserialize<List<CartVM>>(cart);
            }

            var cartProduct = cartModel.FirstOrDefault(q => q.ProductId == product.Id);


            cartModel.Remove(cartProduct);



            var newCart = JsonSerializer.Serialize(cartModel);

            HttpContext.Session.SetString("cart", newCart );


            return Json(cartModel.Count);
        }

    [HttpPost]
        public IActionResult RemoveAll()
        {
            HttpContext.Session.SetString("cart", "");
            return Json("");
        }





    }
}
