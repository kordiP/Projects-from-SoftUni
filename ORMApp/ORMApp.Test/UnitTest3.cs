using Microsoft.EntityFrameworkCore;
using Moq;
using ORMApp.Controllers;
using ORMApp.Data.Models;
using ORMApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMApp.Test
{
    public class UnitTest3
    {
        [Test]
        public void GetAllReturnsAllProductsFromDatabase()
        {
            var data = new List<Product>()
            {
                new Product("Test", 15, 5){ Id = 1},
                new Product("Test2", 12, 2) {Id = 2},
                new Product("Juice", 4, 6) {Id = 3},
                new Product("tes", 7, 8) {Id = 4}
            }.AsQueryable(); //

            var context = new ShopContext();
            var controller = new ProductController(context);
            var product = new Product("12", 44.04m, 1);

            var mockSet = new Mock<DbSet<Product>>();
            mockSet.As<IQueryable<Product>>().Setup(m => m.Provider).Returns(data.Provider); //
            mockSet.As<IQueryable<Product>>().Setup(m => m.Expression).Returns(data.Expression);//
            mockSet.As<IQueryable<Product>>().Setup(m => m.ElementType).Returns(data.ElementType);//
            mockSet.As<IQueryable<Product>>().Setup(m => m.GetEnumerator()).Returns(() => data.GetEnumerator());//

            var mockContext = new Mock<ShopContext>();//
            mockContext.Setup(m => m.Products).Returns(mockSet.Object); // setup means when you get products, return that

            var service = new ProductController(mockContext.Object);

            data.ToList().ForEach(p => service.Add(p));

            var expected = 4;
            var result = service.GetAll();

            Assert.That(result.Count, Is.EqualTo(expected));
        }
    }
}
