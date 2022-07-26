using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Test.ControllersTest
{
    public class HomeControllerTests
    {
        [Test]
        public void Index()
        {
            HomeController homeController = new HomeController();

            var result = homeController.Index() as ViewResult;

            Assert.IsNotNull(result);

            var data = result.ViewData.Model as List<Product>;

            Assert.IsTrue(data.Count > 0);


        }

        [Test]
        public void ProductDetail()
        {
            HomeController homeController = new HomeController();

            var result = homeController.ProductDetail(-1) as ViewResult;

            Assert.IsNotNull(result);
        }




    }
}
