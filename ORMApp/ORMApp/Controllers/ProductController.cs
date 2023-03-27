using ORMApp.Data;
using ORMApp.Data.Models;

namespace ORMApp.Controllers
{
    public class ProductController
    {
        private ShopContext context;

        public ProductController(ShopContext cont)
        {
            this.context = cont;
        }

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public Product Get(int id)
        {
            var product = this.context.Products.FirstOrDefault(x => x.Id == id);

            return product;
        }

        public void Add(Product product)
        {
            this.context.Products.Add(product);
            this.context.SaveChanges();
        }

        public void Delete(int id)
        {
            var productItem = this.Get(id);

            this.context.Products.Remove(productItem);
            this.context.SaveChanges();

        }

        public void Update(Product product)
        {
            var productItem = this.Get(product.Id);

            if (productItem != null)
            {
                this.context.Entry(productItem).CurrentValues.SetValues(product);
                this.context.SaveChanges();
            }
        }
    }
}
