using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitTestingDemo.Data;
using UnitTestingDemo.Models;

namespace UnitTestingDemo.Controllers
{
    public class ProductController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Index(CustomerProduct custProd)
        {
            BillModel model = new BillModel();

            //ViewData["TotalPrice"] = model.TotalAmount;
            //ViewBag.totalAmount = model;
            model.TotalAmount = GetResult(custProd);
            return View(model);
            //return View();
        }

        //public IActionResult ProductDiscount(CustomerProduct custProd)
        //{
        //    BillModel model = new BillModel();

        //    //ViewData["TotalPrice"] = model.TotalAmount;
        //    //ViewBag.totalAmount = model;
        //    model.TotalAmount = GetResult(custProd);
        //    return View(model);
        //    //return View();
        //}
        public double  GetResult(CustomerProduct custProd)
        {

            ProductData prodData = new ProductData();
            var products = prodData.GetProducts();
            double totalAmount = 0;
            foreach (ProductModel prod in products)
            {
                if (prod.ProductId == custProd.ProductID)
                {
                    if (custProd.CustomerType == "Regular")
                    {
                        totalAmount = prod.ProductPrice - prod.ProductPrice * 0.1;
                    }
                    else
                    {
                        totalAmount = prod.ProductPrice - prod.ProductPrice * 0.2;
                    }
                }

            }
            return totalAmount;
        }
    }
}