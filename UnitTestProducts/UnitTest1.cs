using System;
using UnitTestingDemo.Controllers;
using UnitTestingDemo.Models;
using Xunit;

namespace UnitTestProducts
{
    public class ProductionTests
    {
        [Fact]
        public void ProductDiscount_BothIdIsSame_ChecksValue()
        {
            //Arrange
            var productController = new ProductController();

            //Act
            var result = productController.ProductDiscount(new CustomerProduct { ProductID = 1 });

            //Assert
            Assert
        }
    }
}
