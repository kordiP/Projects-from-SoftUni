using ORMApp.Controllers;
using ORMApp.Data.Models;

namespace ORMApp.Views
{
    public class Display
    {
        public Display()
        {
            productController = new ProductController(new Data.ShopContext());
            Input();
        }

        private int closeOperationId = 6;

        private ProductController productController;

        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all");
            Console.WriteLine("2. Add");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Fetch by id");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Exit");
        }

        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        List();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Fetch();
                        break;
                    case 5:
                        Delete();
                        break;
                }
            } while (operation != closeOperationId);
        }

        private void Fetch()
        {
            Console.WriteLine("Enter id to fetch: ");
            int id = int.Parse(Console.ReadLine());
            var prod = this.productController.Get(id);

            if (prod != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine($"Product Id: {prod.Id}");
                Console.WriteLine($"Product Name: {prod.Name}");
                Console.WriteLine($"Product Price: {prod.Price}");
                Console.WriteLine($"Product Stock: {prod.Stock}");
                Console.WriteLine(new string('-', 40));
            }
        }

        private void Delete()
        {
            Console.WriteLine("Enter Id to delete: ");
            int id = int.Parse(Console.ReadLine());
            productController.Delete(id);
            Console.WriteLine("Done.");
        }

        private void Update()
        {
            Console.WriteLine("Enter Id to update: ");
            int id = int.Parse(Console.ReadLine());
            var prod = this.productController.Get(id);

            if (prod != null)
            {
                Console.WriteLine("Enter name: ");
                prod.Name = Console.ReadLine();

                Console.WriteLine("Enter price: ");
                prod.Price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter stock: ");
                prod.Stock = int.Parse(Console.ReadLine());

                this.productController.Update(prod);
            }
        }

        private void Add()
        {
            Product product = new Product();

            Console.WriteLine("Enter product name:");
            product.Name = Console.ReadLine();

            Console.WriteLine("Enter product price:");
            product.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter product stock:");
            product.Stock = int.Parse(Console.ReadLine());

            productController.Add(product);

        }

        private void List()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "PRODUCTS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));

            var products = this.productController.GetAll();

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Price} {item.Stock}");
            }
        }
    }
}
