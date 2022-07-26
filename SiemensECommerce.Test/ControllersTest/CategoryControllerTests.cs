using NUnit.Framework;
using SiemensECommerce.UI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Test.ControllersTest
{
    public class CategoryControllerTests
    {
        [Test]
        public void Index()
        {
            CategoryController categoryController = new CategoryController();
            var result = categoryController.Index();


            Assert.IsNotNull(result);

           

        }


        [Test]
        public void Detail()
        {
            CategoryController categoryController = new CategoryController();

            var result = categoryController.Detail("Çağatay", 5);

            Assert.IsNotNull(result);
        }
    }
}
