using System;
using APIparcial.Controllers;
using APIparcial.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestParcial1
{
    [TestClass]
    public class UnitTestApi
    {
        [TestMethod]
        public void TestMethodGet()
        {
            Product producto = new Product();

            ProductsController control = new ProductsController();

            var resp = GetProduct(3);


        }
    }
}
