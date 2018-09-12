using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnitTestingDemo.Controllers;
using UnitTestingDemo.Data;
using UnitTestingDemo.Models;
using UnitTestingDemo;

namespace UnitTestDemoProducts
{
    public class TotalAmt
    {
        double totalAmount = 0;
    }
    [TestFixture]
    public class ProductionTests
    {
        TotalAmt totalAmt = new TotalAmt();   
        
        CustomerProduct custProd = new CustomerProduct();
        //[Test] //attribute indicates a method is a test method.
               //[TestCase("Regualar", 3)]
               //[TestCase("Regular", 1)]
               //[TestCase("Premium", 2)]

        [Test]
        public void ReturnProductDiscount(string CustomerType, int ProductID)
        {
            ProductController product = new ProductController();
            List<ProductModel> user = new List<ProductModel>
            {
                new ProductModel {ProductId=1,ProductName="Apple",ProductPrice=100 },
                new ProductModel {ProductId=2,ProductName="Mango",ProductPrice=120 },
                new ProductModel {ProductId=3,ProductName="Guava",ProductPrice=60 },
                new ProductModel {ProductId=4,ProductName="Banana",ProductPrice=30 },
                new ProductModel {ProductId=5,ProductName="Litchi",ProductPrice=90 },
                new ProductModel {ProductId=6,ProductName="Pomergranate",ProductPrice=120 }
            };
            //Act
           
            
            ProductData prodData = new ProductData();
            var products = prodData.GetProducts();
            ProductModel prod1 = new ProductModel();
            prod1.TotalAmount = 0;
            foreach (ProductModel prod in products)
            {
                if (CustomerType == "Premium")
                {
                    prod1.TotalAmount = prod.ProductPrice - prod.ProductPrice * 0.1;
                }
                if (CustomerType == "Regular")
                {
                    prod1.TotalAmount = prod.ProductPrice - prod.ProductPrice * 0.2;
                }
            }
           // var pro = product.GetResult(custProd);
            double checkProduct = 0.9 * prod1.ProductPrice;
            //CustomerProduct custProd1 = new CustomerProduct();
            //Assert.AreEqual((prod1.TotalAmount, product.GetResult(custProd)));
            Assert.IsTrue(prod1.TotalAmount == product.GetResult(custProd));
        }
    }
}

