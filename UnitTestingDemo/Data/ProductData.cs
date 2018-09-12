using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestingDemo.Models;

namespace UnitTestingDemo.Data
{
    public class ProductData
    {
        public List<ProductModel> GetProducts()
        {
            return new List<ProductModel>
            {
                new ProductModel {ProductId=1,ProductName="Apple",ProductPrice=100 },
                new ProductModel {ProductId=2,ProductName="Mango",ProductPrice=120 },
                new ProductModel {ProductId=3,ProductName="Guava",ProductPrice=60 },
                new ProductModel {ProductId=4,ProductName="Banana",ProductPrice=30 },
                new ProductModel {ProductId=5,ProductName="Litchi",ProductPrice=90 },
                new ProductModel {ProductId=6,ProductName="Pomergranate",ProductPrice=120 }
            };
        }
        public List<ProductModel> GetFruitByName(string name)
        {
            List<ProductModel> fruitList = new List<ProductModel>();
            fruitList = (from s in GetProducts()
                           where s.ProductName.ToLower().Contains(name.ToLower())
                           select s).ToList();
            return fruitList;

        }
    }
}
