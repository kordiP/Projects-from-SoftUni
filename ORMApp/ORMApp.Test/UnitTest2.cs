using Microsoft.EntityFrameworkCore;
using Moq;
using ORMApp.Controllers;
using ORMApp.Data;
using ORMApp.Data.Models;

namespace ORMApp.Test
{
    public class UnitTest2
    {
        [Test]
        public void CreateProduct_SavesProduct_ViaContext()
        {
            var mockSet = new Mock<DbSet<Product>>();

            var mockContext = new Mock<ShopContext>();
            mockContext.Setup(m => m.Products).Returns(mockSet.Object);

            var service = new ProductController(mockContext.Object);
            service.Add(new Product("testProd", 12, 6));

            mockSet.Verify(m => m.Add(It.IsAny<Product>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}
