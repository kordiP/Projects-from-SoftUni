using Microsoft.EntityFrameworkCore;
using Moq;
using ORMApp.Controllers;
using ORMApp.Data;
using ORMApp.Data.Models;
using System.Net.Sockets;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;

namespace ORMApp.Test
{
    public class Tests
    {
        [Test]
        public void AddProductInDatabase()
        {
            var data = new List<Product>() 
            { 
                new Product("Test", 15, 5){ Id = 1}, 
                new Product("Test2", 12, 2) {Id = 2}
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

            var products = service.Get(1);

            Assert.That(products.Id, Is.EqualTo(1));
        }
    }
}